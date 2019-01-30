namespace Induvidual_Task
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.labelPattern = new System.Windows.Forms.Label();
            this.buttonLoadPattern = new System.Windows.Forms.Button();
            this.buttonClearPattern = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelStatus = new System.Windows.Forms.Label();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnHeaderNameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPathFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBoxFile = new System.Windows.Forms.RichTextBox();
            this.labelReport = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.labelStatusL = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.FolderToolStripMenuItem,
            this.выйтиToolStripMenuItem,
            this.ExitToolStripMenuItem1});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Enabled = false;
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.StartToolStripMenuItem.Text = "Пуск";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить отчёт";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // FolderToolStripMenuItem
            // 
            this.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem";
            this.FolderToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.FolderToolStripMenuItem.Text = "Выбрать каталог";
            this.FolderToolStripMenuItem.Click += new System.EventHandler(this.FolderToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(163, 6);
            // 
            // ExitToolStripMenuItem1
            // 
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.ExitToolStripMenuItem1.Text = "Выйти";
            this.ExitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramToolStripMenuItem1});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.AboutToolStripMenuItem.Text = "Справка";
            // 
            // AboutProgramToolStripMenuItem1
            // 
            this.AboutProgramToolStripMenuItem1.Name = "AboutProgramToolStripMenuItem1";
            this.AboutProgramToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.AboutProgramToolStripMenuItem1.Text = "О програме Searcher";
            this.AboutProgramToolStripMenuItem1.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem1_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonPause,
            this.toolStripButtonStop,
            this.toolStripSeparator2,
            this.toolStripButtonFolder,
            this.toolStripButtonSave,
            this.toolStripButtonClear});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Location = new System.Drawing.Point(12, 122);
            this.textBoxPattern.Multiline = true;
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(245, 229);
            this.textBoxPattern.TabIndex = 2;
            // 
            // labelPattern
            // 
            this.labelPattern.AutoSize = true;
            this.labelPattern.Location = new System.Drawing.Point(87, 106);
            this.labelPattern.Name = "labelPattern";
            this.labelPattern.Size = new System.Drawing.Size(97, 13);
            this.labelPattern.TabIndex = 3;
            this.labelPattern.Text = "Текст для поиска";
            // 
            // buttonLoadPattern
            // 
            this.buttonLoadPattern.Location = new System.Drawing.Point(31, 357);
            this.buttonLoadPattern.Name = "buttonLoadPattern";
            this.buttonLoadPattern.Size = new System.Drawing.Size(120, 23);
            this.buttonLoadPattern.TabIndex = 5;
            this.buttonLoadPattern.Text = "Загрузить с файла";
            this.buttonLoadPattern.UseVisualStyleBackColor = true;
            this.buttonLoadPattern.Click += new System.EventHandler(this.ButtonLoadPattern_Click);
            // 
            // buttonClearPattern
            // 
            this.buttonClearPattern.Enabled = false;
            this.buttonClearPattern.Location = new System.Drawing.Point(175, 357);
            this.buttonClearPattern.Name = "buttonClearPattern";
            this.buttonClearPattern.Size = new System.Drawing.Size(65, 23);
            this.buttonClearPattern.TabIndex = 6;
            this.buttonClearPattern.Text = "Очистить";
            this.buttonClearPattern.UseVisualStyleBackColor = true;
            this.buttonClearPattern.Click += new System.EventHandler(this.ButtonClearPattern_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(728, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Location = new System.Drawing.Point(732, 24);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(68, 13);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Не запущен";
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNameFile,
            this.columnHeaderPathFile,
            this.columnHeaderSize});
            this.listViewFiles.Location = new System.Drawing.Point(263, 122);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(280, 257);
            this.listViewFiles.TabIndex = 9;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNameFile
            // 
            this.columnHeaderNameFile.Text = "Имя файла";
            this.columnHeaderNameFile.Width = 80;
            // 
            // columnHeaderPathFile
            // 
            this.columnHeaderPathFile.Text = "Путь к файлу";
            this.columnHeaderPathFile.Width = 136;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Размер файла";
            // 
            // richTextBoxFile
            // 
            this.richTextBoxFile.Location = new System.Drawing.Point(549, 122);
            this.richTextBoxFile.Name = "richTextBoxFile";
            this.richTextBoxFile.ReadOnly = true;
            this.richTextBoxFile.Size = new System.Drawing.Size(239, 257);
            this.richTextBoxFile.TabIndex = 10;
            this.richTextBoxFile.Text = "";
            // 
            // labelReport
            // 
            this.labelReport.AutoSize = true;
            this.labelReport.Location = new System.Drawing.Point(379, 106);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(36, 13);
            this.labelReport.TabIndex = 11;
            this.labelReport.Text = "Отчёт";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(624, 106);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(107, 13);
            this.labelFile.TabIndex = 12;
            this.labelFile.Text = "Содержимое файла";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(69, 78);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(719, 20);
            this.textBoxFolder.TabIndex = 13;
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(12, 81);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(51, 13);
            this.labelFolder.TabIndex = 14;
            this.labelFolder.Text = "Каталог:";
            // 
            // labelStatusL
            // 
            this.labelStatusL.AutoSize = true;
            this.labelStatusL.BackColor = System.Drawing.Color.Transparent;
            this.labelStatusL.Location = new System.Drawing.Point(687, 24);
            this.labelStatusL.Name = "labelStatusL";
            this.labelStatusL.Size = new System.Drawing.Size(44, 13);
            this.labelStatusL.TabIndex = 15;
            this.labelStatusL.Text = "Статус:";
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(746, 49);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(30, 13);
            this.labelPercent.TabIndex = 16;
            this.labelPercent.Text = "0.0%";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStart.Enabled = false;
            this.toolStripButtonStart.Image = global::Induvidual_Task.Properties.Resources.play;
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStart.Text = "Пуск";
            this.toolStripButtonStart.Click += new System.EventHandler(this.ToolStripButtonStart_Click);
            // 
            // toolStripButtonPause
            // 
            this.toolStripButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPause.Enabled = false;
            this.toolStripButtonPause.Image = global::Induvidual_Task.Properties.Resources.pause;
            this.toolStripButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPause.Name = "toolStripButtonPause";
            this.toolStripButtonPause.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPause.Text = "Пауза";
            this.toolStripButtonPause.Click += new System.EventHandler(this.ToolStripButtonPause_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Enabled = false;
            this.toolStripButtonStop.Image = global::Induvidual_Task.Properties.Resources.stop;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStop.Text = "Остановить";
            this.toolStripButtonStop.Click += new System.EventHandler(this.ToolStripButtonStop_Click);
            // 
            // toolStripButtonFolder
            // 
            this.toolStripButtonFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFolder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripButtonFolder.Image = global::Induvidual_Task.Properties.Resources.browse_folder;
            this.toolStripButtonFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFolder.Name = "toolStripButtonFolder";
            this.toolStripButtonFolder.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFolder.Text = "Выбрать каталог";
            this.toolStripButtonFolder.Click += new System.EventHandler(this.ToolStripButtonFolder_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = global::Induvidual_Task.Properties.Resources.save;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Сохранить отчёт";
            this.toolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSave_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClear.Enabled = false;
            this.toolStripButtonClear.Image = global::Induvidual_Task.Properties.Resources.clear;
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClear.Text = "Очистить";
            this.toolStripButtonClear.Click += new System.EventHandler(this.ToolStripButtonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.labelStatusL);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.richTextBoxFile);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonClearPattern);
            this.Controls.Add(this.buttonLoadPattern);
            this.Controls.Add(this.labelPattern);
            this.Controls.Add(this.textBoxPattern);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поисковик";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonPause;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonFolder;
        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.Label labelPattern;
        private System.Windows.Forms.Button buttonLoadPattern;
        private System.Windows.Forms.Button buttonClearPattern;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.RichTextBox richTextBoxFile;
        private System.Windows.Forms.Label labelReport;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.ColumnHeader columnHeaderNameFile;
        private System.Windows.Forms.ColumnHeader columnHeaderPathFile;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.Label labelStatusL;
        private System.Windows.Forms.Label labelPercent;
    }
}

