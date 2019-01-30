namespace Lab10
{
    partial class CarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(12, 21);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(49, 13);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "Модель:";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.carBindingSource, "Model", true));
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(115, 18);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModel.TabIndex = 1;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(Lab06.Car);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(27, 188);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(149, 188);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 78);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 5;
            this.labelNumber.Text = "Номер:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Number", true));
            this.textBoxNumber.Location = new System.Drawing.Point(115, 75);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.carBindingSource, "Country", true));
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(115, 45);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountry.TabIndex = 2;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(12, 48);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(44, 13);
            this.labelCountry.TabIndex = 7;
            this.labelCountry.Text = "Країна:";
            // 
            // textBoxColor
            // 
            this.textBoxColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Color", true));
            this.textBoxColor.Location = new System.Drawing.Point(115, 101);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(121, 20);
            this.textBoxColor.TabIndex = 4;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(12, 104);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(37, 13);
            this.labelColor.TabIndex = 9;
            this.labelColor.Text = "Колір:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(12, 130);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(166, 13);
            this.labelMaxSpeed.TabIndex = 11;
            this.labelMaxSpeed.Text = "Максимальна швидкість(km\\h):";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(12, 156);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(55, 13);
            this.labelWeight.TabIndex = 13;
            this.labelWeight.Text = "Вага (kg):";
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carBindingSource, "MaxSpeed", true));
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(181, 127);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownMaxSpeed.TabIndex = 5;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carBindingSource, "Weight", true));
            this.numericUpDownWeight.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownWeight.Location = new System.Drawing.Point(181, 154);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownWeight.TabIndex = 6;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 223);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.numericUpDownMaxSpeed);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelMaxSpeed);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.labelModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CarForm";
            this.Text = "Автомобіль";
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.BindingSource carBindingSource;
    }
}