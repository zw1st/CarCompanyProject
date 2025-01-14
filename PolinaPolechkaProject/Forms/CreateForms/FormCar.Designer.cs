namespace PolinaPolechkaProject.Forms
{
    partial class FormCar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBoxBrand = new ComboBox();
            comboBoxOwner = new ComboBox();
            comboBoxFactory = new ComboBox();
            comboBoxCarShop = new ComboBox();
            dateTimePickerReleaseYear = new DateTimePicker();
            numericUpDownPrice = new NumericUpDown();
            comboBoxDrive = new ComboBox();
            checkBoxAuto = new CheckBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Марка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Стоимость";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 3;
            label3.Text = "Привод";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 86);
            label4.Name = "label4";
            label4.Size = new Size(246, 20);
            label4.TabIndex = 2;
            label4.Text = "Автоматическая коробка передач";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 175);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 4;
            label5.Text = "Год выпуска";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 300);
            label7.Name = "label7";
            label7.Size = new Size(163, 20);
            label7.TabIndex = 7;
            label7.Text = "Завод-производитель";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 259);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 6;
            label8.Text = "Владелец";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 219);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 5;
            label9.Text = "Автосалон";
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(283, 6);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(194, 28);
            comboBoxBrand.TabIndex = 8;
            // 
            // comboBoxOwner
            // 
            comboBoxOwner.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOwner.FormattingEnabled = true;
            comboBoxOwner.Location = new Point(283, 251);
            comboBoxOwner.Name = "comboBoxOwner";
            comboBoxOwner.Size = new Size(194, 28);
            comboBoxOwner.TabIndex = 9;
            // 
            // comboBoxFactory
            // 
            comboBoxFactory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFactory.FormattingEnabled = true;
            comboBoxFactory.Location = new Point(283, 297);
            comboBoxFactory.Name = "comboBoxFactory";
            comboBoxFactory.Size = new Size(194, 28);
            comboBoxFactory.TabIndex = 10;
            // 
            // comboBoxCarShop
            // 
            comboBoxCarShop.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCarShop.FormattingEnabled = true;
            comboBoxCarShop.Location = new Point(283, 211);
            comboBoxCarShop.Name = "comboBoxCarShop";
            comboBoxCarShop.Size = new Size(194, 28);
            comboBoxCarShop.TabIndex = 11;
            // 
            // dateTimePickerReleaseYear
            // 
            dateTimePickerReleaseYear.Location = new Point(283, 170);
            dateTimePickerReleaseYear.Name = "dateTimePickerReleaseYear";
            dateTimePickerReleaseYear.Size = new Size(194, 27);
            dateTimePickerReleaseYear.TabIndex = 12;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(283, 46);
            numericUpDownPrice.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(194, 27);
            numericUpDownPrice.TabIndex = 13;
            numericUpDownPrice.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // comboBoxDrive
            // 
            comboBoxDrive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDrive.FormattingEnabled = true;
            comboBoxDrive.Location = new Point(283, 127);
            comboBoxDrive.Name = "comboBoxDrive";
            comboBoxDrive.Size = new Size(194, 28);
            comboBoxDrive.TabIndex = 14;
            // 
            // checkBoxAuto
            // 
            checkBoxAuto.AutoSize = true;
            checkBoxAuto.Location = new Point(283, 86);
            checkBoxAuto.Name = "checkBoxAuto";
            checkBoxAuto.Size = new Size(18, 17);
            checkBoxAuto.TabIndex = 15;
            checkBoxAuto.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(196, 352);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(135, 51);
            buttonCancel.TabIndex = 35;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LimeGreen;
            buttonSave.Location = new Point(342, 352);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 51);
            buttonSave.TabIndex = 34;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 424);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(checkBoxAuto);
            Controls.Add(comboBoxDrive);
            Controls.Add(numericUpDownPrice);
            Controls.Add(dateTimePickerReleaseYear);
            Controls.Add(comboBoxCarShop);
            Controls.Add(comboBoxFactory);
            Controls.Add(comboBoxOwner);
            Controls.Add(comboBoxBrand);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Автомобиль";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBoxBrand;
        private ComboBox comboBoxOwner;
        private ComboBox comboBoxFactory;
        private ComboBox comboBoxCarShop;
        private DateTimePicker dateTimePickerReleaseYear;
        private NumericUpDown numericUpDownPrice;
        private ComboBox comboBoxDrive;
        private CheckBox checkBoxAuto;
        private Button buttonCancel;
        private Button buttonSave;
    }
}