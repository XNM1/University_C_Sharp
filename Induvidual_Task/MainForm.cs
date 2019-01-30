using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Induvidual_Task
{
    public partial class MainForm : Form
    {
        Searcher searcher;
        public MainForm()
        {
            InitializeComponent();
            textBoxFolder.TextChanged += TextBoxFolder_TextChanged;
            textBoxPattern.TextChanged += TextBoxPattern_TextChanged;
            listViewFiles.ItemSelectionChanged += ListViewFiles_ItemSelectionChanged;
            Load += MainForm_Load;
            FormClosing += MainForm_FormClosing;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            LoadForm loadForm = new LoadForm();
            loadForm.Show();
            loadForm.Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Visible = true;
            ShowInTaskbar = true;
            Show();
        }

        private void ListViewFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewFiles.SelectedItems.Count > 0 && listViewFiles.SelectedItems[0] != null)
            {
                richTextBoxFile.Text = File.ReadAllText(listViewFiles.SelectedItems[0].SubItems[1].Text);
                HighlightPhrase(richTextBoxFile, textBoxPattern.Text, Color.Red);
            }
        }

        private void HighlightPhrase(RichTextBox box, string phrase, Color color)
        {
            int pos = box.SelectionStart;
            string s = box.Text;
            for (int ix = 0; ;)
            {
                int jx = s.IndexOf(phrase, ix, StringComparison.CurrentCultureIgnoreCase);
                if (jx < 0) break;
                box.SelectionStart = jx;
                box.SelectionLength = phrase.Length;
                box.SelectionColor = color;
                ix = jx + 1;
            }
            box.SelectionStart = pos;
            box.SelectionLength = 0;
        }

        private void TextCheck()
        {
            if (!string.IsNullOrWhiteSpace(textBoxPattern.Text)
                && Directory.Exists(textBoxFolder.Text))
            {
                StartToolStripMenuItem.Enabled = true;
                toolStripButtonStart.Enabled = true;
            }
            else
            {
                StartToolStripMenuItem.Enabled = false;
                toolStripButtonStart.Enabled = false;
            }
        }

        private void TextBoxPattern_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxPattern.Text))
            {
                buttonClearPattern.Enabled = true;
            }
            else
            {
                buttonClearPattern.Enabled = false;
            }
            TextCheck();
        }

        private void TextBoxFolder_TextChanged(object sender, EventArgs e)
        {
            TextCheck();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripButtonStart_Click(object sender, EventArgs e)
        {
            StartToolStripMenuItem_Click(sender, e);
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searcher == null || searcher.Status != Status.Working
                && searcher.Status != Status.Paused)
            {
                searcher = new Searcher(textBoxPattern.Text, textBoxFolder.Text);
                searcher.Completed += Searcher_Completed;
                searcher.SearchProgress += Searcher_Progress;
                searcher.FileFound += Searcher_FileFound;

                listViewFiles.Items.Clear();

                searcher.DirectoryPath = textBoxFolder.Text;
                searcher.Pattern = textBoxPattern.Text;
                searcher.Start();
            }
            else if (searcher.Status == Status.Paused)
            {
                searcher.Resume();
            }

            labelStatus.ForeColor = Color.DarkGreen;
            labelStatus.Text = "Работает";

            SaveToolStripMenuItem.Enabled = false;
            toolStripButtonSave.Enabled = false;
            toolStripButtonClear.Enabled = false;

            toolStripButtonPause.Enabled = true;
            toolStripButtonStop.Enabled = true;

            StartToolStripMenuItem.Enabled = false;
            toolStripButtonStart.Enabled = false;
            toolStripButtonFolder.Enabled = false;
            FolderToolStripMenuItem.Enabled = false;

            buttonClearPattern.Enabled = false;
            buttonLoadPattern.Enabled = false;
            textBoxFolder.ReadOnly = true;
            textBoxPattern.ReadOnly = true;
        }

        private void Searcher_FileFound(object sender, FileFoundEventArgs e)
        {
            ListViewItem item = new ListViewItem(e.File.Name);
            item.SubItems.Add(e.File.FullName);
            item.SubItems.Add(MemoryConverter.MemoryToString(e.File.Length));

            Action action = new Action(() =>
           {
               listViewFiles.Items.Add(item);
           });
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Searcher_Progress(object sender, SearchProgressEventArgs e)
        {
            Action action = new Action(() => 
            {
                progressBar1.Value = (int)e.Progress;
                labelPercent.ForeColor = Color.FromArgb(0, (int)((e.Progress / 100) * 255), 0);
                labelPercent.Text = e.Progress.ToString("0.0") + '%';
            });
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Searcher_Completed(object sender, CompletedEventArgs e)
        {
            Action action = new Action(() =>
            {
                labelStatus.ForeColor = Color.Green;
                labelStatus.Text = "Завершён";
                Complete();
                MessageBox.Show("Сканирование завершено");
            });
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void FolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ToolStripButtonFolder_Click(object sender, EventArgs e)
        {
            FolderToolStripMenuItem_Click(sender, e);
        }

        private void ButtonClearPattern_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите очистить текст для поиска?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                textBoxPattern.Clear();
        }

        private void ButtonLoadPattern_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPattern.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveToolStripMenuItem_Click(sender, e);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Saver.SaveReport(saveFileDialog.FileName, searcher);
            }
        }

        private void ToolStripButtonClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите всё очистить?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBoxFolder.Clear();
                textBoxPattern.Clear();
                richTextBoxFile.Clear();
                listViewFiles.Items.Clear();
                progressBar1.Value = 0;
                labelPercent.ForeColor = Color.Black;
                labelPercent.Text = "0.0%";
                labelStatus.ForeColor = Color.Black;
                labelStatus.Text = "Не запущен";
                SaveToolStripMenuItem.Enabled = false;
                toolStripButtonSave.Enabled = false;
                toolStripButtonClear.Enabled = false;
                StartToolStripMenuItem.Enabled = false;
                toolStripButtonStart.Enabled = false;
                buttonClearPattern.Enabled = false;
            }
        }

        private void ToolStripButtonPause_Click(object sender, EventArgs e)
        {
            if (searcher.Status == Status.Working)
            {
                searcher.Pause();

                labelStatus.ForeColor = Color.Black;
                labelStatus.Text = "На паузе";

                toolStripButtonPause.Enabled = false;
                toolStripButtonStop.Enabled = false;

                StartToolStripMenuItem.Enabled = true;
                toolStripButtonStart.Enabled = true;
            }
        }

        private void ToolStripButtonStop_Click(object sender, EventArgs e)
        {
            if (searcher.Status == Status.Working)
            {
                searcher.Stop();

                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "Остановлен";

                Complete();
            }
        }

        private void Complete()
        {
            SaveToolStripMenuItem.Enabled = true;
            toolStripButtonSave.Enabled = true;
            toolStripButtonClear.Enabled = true;

            toolStripButtonPause.Enabled = false;
            toolStripButtonStop.Enabled = false;

            StartToolStripMenuItem.Enabled = true;
            toolStripButtonStart.Enabled = true;
            toolStripButtonFolder.Enabled = true;
            FolderToolStripMenuItem.Enabled = true;

            buttonClearPattern.Enabled = true;
            buttonLoadPattern.Enabled = true;
            textBoxFolder.ReadOnly = false;
            textBoxPattern.ReadOnly = false;
        }

        private void AboutProgramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
