namespace Lab09
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
            this.labelX1min = new System.Windows.Forms.Label();
            this.textBoxX1min = new System.Windows.Forms.TextBox();
            this.textBoxX2min = new System.Windows.Forms.TextBox();
            this.labelX2min = new System.Windows.Forms.Label();
            this.textBoxX2max = new System.Windows.Forms.TextBox();
            this.labelX2max = new System.Windows.Forms.Label();
            this.textBoxX1max = new System.Windows.Forms.TextBox();
            this.labelX1max = new System.Windows.Forms.Label();
            this.textBoxdX2 = new System.Windows.Forms.TextBox();
            this.labeldX2 = new System.Windows.Forms.Label();
            this.textBoxdX1 = new System.Windows.Forms.TextBox();
            this.labeldX1 = new System.Windows.Forms.Label();
            this.dataGridViewFunct = new System.Windows.Forms.DataGridView();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunct)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1min
            // 
            this.labelX1min.AutoSize = true;
            this.labelX1min.Location = new System.Drawing.Point(26, 24);
            this.labelX1min.Name = "labelX1min";
            this.labelX1min.Size = new System.Drawing.Size(39, 13);
            this.labelX1min.TabIndex = 0;
            this.labelX1min.Text = "X1min:";
            // 
            // textBoxX1min
            // 
            this.textBoxX1min.Location = new System.Drawing.Point(67, 21);
            this.textBoxX1min.Name = "textBoxX1min";
            this.textBoxX1min.Size = new System.Drawing.Size(77, 20);
            this.textBoxX1min.TabIndex = 1;
            // 
            // textBoxX2min
            // 
            this.textBoxX2min.Location = new System.Drawing.Point(67, 47);
            this.textBoxX2min.Name = "textBoxX2min";
            this.textBoxX2min.Size = new System.Drawing.Size(77, 20);
            this.textBoxX2min.TabIndex = 3;
            // 
            // labelX2min
            // 
            this.labelX2min.AutoSize = true;
            this.labelX2min.Location = new System.Drawing.Point(26, 50);
            this.labelX2min.Name = "labelX2min";
            this.labelX2min.Size = new System.Drawing.Size(39, 13);
            this.labelX2min.TabIndex = 2;
            this.labelX2min.Text = "X2min:";
            // 
            // textBoxX2max
            // 
            this.textBoxX2max.Location = new System.Drawing.Point(283, 47);
            this.textBoxX2max.Name = "textBoxX2max";
            this.textBoxX2max.Size = new System.Drawing.Size(77, 20);
            this.textBoxX2max.TabIndex = 7;
            // 
            // labelX2max
            // 
            this.labelX2max.AutoSize = true;
            this.labelX2max.Location = new System.Drawing.Point(242, 50);
            this.labelX2max.Name = "labelX2max";
            this.labelX2max.Size = new System.Drawing.Size(39, 13);
            this.labelX2max.TabIndex = 6;
            this.labelX2max.Text = "X2max";
            // 
            // textBoxX1max
            // 
            this.textBoxX1max.Location = new System.Drawing.Point(283, 21);
            this.textBoxX1max.Name = "textBoxX1max";
            this.textBoxX1max.Size = new System.Drawing.Size(77, 20);
            this.textBoxX1max.TabIndex = 5;
            // 
            // labelX1max
            // 
            this.labelX1max.AutoSize = true;
            this.labelX1max.Location = new System.Drawing.Point(242, 24);
            this.labelX1max.Name = "labelX1max";
            this.labelX1max.Size = new System.Drawing.Size(42, 13);
            this.labelX1max.TabIndex = 4;
            this.labelX1max.Text = "X1max:";
            // 
            // textBoxdX2
            // 
            this.textBoxdX2.Location = new System.Drawing.Point(512, 47);
            this.textBoxdX2.Name = "textBoxdX2";
            this.textBoxdX2.Size = new System.Drawing.Size(77, 20);
            this.textBoxdX2.TabIndex = 11;
            // 
            // labeldX2
            // 
            this.labeldX2.AutoSize = true;
            this.labeldX2.Location = new System.Drawing.Point(471, 50);
            this.labeldX2.Name = "labeldX2";
            this.labeldX2.Size = new System.Drawing.Size(29, 13);
            this.labeldX2.TabIndex = 10;
            this.labeldX2.Text = "dX2:";
            // 
            // textBoxdX1
            // 
            this.textBoxdX1.Location = new System.Drawing.Point(512, 21);
            this.textBoxdX1.Name = "textBoxdX1";
            this.textBoxdX1.Size = new System.Drawing.Size(77, 20);
            this.textBoxdX1.TabIndex = 9;
            // 
            // labeldX1
            // 
            this.labeldX1.AutoSize = true;
            this.labeldX1.Location = new System.Drawing.Point(471, 24);
            this.labeldX1.Name = "labeldX1";
            this.labeldX1.Size = new System.Drawing.Size(29, 13);
            this.labeldX1.TabIndex = 8;
            this.labeldX1.Text = "dX1:";
            // 
            // dataGridViewFunct
            // 
            this.dataGridViewFunct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunct.Location = new System.Drawing.Point(29, 73);
            this.dataGridViewFunct.Name = "dataGridViewFunct";
            this.dataGridViewFunct.Size = new System.Drawing.Size(560, 365);
            this.dataGridViewFunct.TabIndex = 12;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(608, 73);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Розахувати";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(608, 102);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(608, 415);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Вийти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(641, 21);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(59, 20);
            this.textBoxSum.TabIndex = 17;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(606, 24);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(31, 13);
            this.labelSum.TabIndex = 16;
            this.labelSum.Text = "Sum:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.dataGridViewFunct);
            this.Controls.Add(this.textBoxdX2);
            this.Controls.Add(this.labeldX2);
            this.Controls.Add(this.textBoxdX1);
            this.Controls.Add(this.labeldX1);
            this.Controls.Add(this.textBoxX2max);
            this.Controls.Add(this.labelX2max);
            this.Controls.Add(this.textBoxX1max);
            this.Controls.Add(this.labelX1max);
            this.Controls.Add(this.textBoxX2min);
            this.Controls.Add(this.labelX2min);
            this.Controls.Add(this.textBoxX1min);
            this.Controls.Add(this.labelX1min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Вираз з двома змінними";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX1min;
        private System.Windows.Forms.TextBox textBoxX1min;
        private System.Windows.Forms.TextBox textBoxX2min;
        private System.Windows.Forms.Label labelX2min;
        private System.Windows.Forms.TextBox textBoxX2max;
        private System.Windows.Forms.Label labelX2max;
        private System.Windows.Forms.TextBox textBoxX1max;
        private System.Windows.Forms.Label labelX1max;
        private System.Windows.Forms.TextBox textBoxdX2;
        private System.Windows.Forms.Label labeldX2;
        private System.Windows.Forms.TextBox textBoxdX1;
        private System.Windows.Forms.Label labeldX1;
        private System.Windows.Forms.DataGridView dataGridViewFunct;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelSum;
    }
}

