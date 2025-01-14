namespace PolinaPolechkaProject.Forms.SearchForms
{
    partial class FormSearchCar
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
            checkBoxAuto = new CheckBox();
            comboBoxDrive = new ComboBox();
            numericUpDownPriceFrom = new NumericUpDown();
            dateTimePickerReleaseYearFrom = new DateTimePicker();
            comboBoxCarShop = new ComboBox();
            comboBoxFactory = new ComboBox();
            comboBoxOwner = new ComboBox();
            comboBoxBrand = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownPriceTo = new NumericUpDown();
            dateTimePickerReleaseYearTo = new DateTimePicker();
            buttonCancel = new Button();
            buttonSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceTo).BeginInit();
            SuspendLayout();
            // 
            // checkBoxAuto
            // 
            checkBoxAuto.AutoSize = true;
            checkBoxAuto.Location = new Point(283, 86);
            checkBoxAuto.Name = "checkBoxAuto";
            checkBoxAuto.Size = new Size(18, 17);
            checkBoxAuto.TabIndex = 51;
            checkBoxAuto.UseVisualStyleBackColor = true;
            // 
            // comboBoxDrive
            // 
            comboBoxDrive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDrive.FormattingEnabled = true;
            comboBoxDrive.Location = new Point(283, 127);
            comboBoxDrive.Name = "comboBoxDrive";
            comboBoxDrive.Size = new Size(274, 28);
            comboBoxDrive.TabIndex = 50;
            // 
            // numericUpDownPriceFrom
            // 
            numericUpDownPriceFrom.Location = new Point(283, 46);
            numericUpDownPriceFrom.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDownPriceFrom.Minimum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPriceFrom.Name = "numericUpDownPriceFrom";
            numericUpDownPriceFrom.Size = new Size(125, 27);
            numericUpDownPriceFrom.TabIndex = 49;
            numericUpDownPriceFrom.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // dateTimePickerReleaseYearFrom
            // 
            dateTimePickerReleaseYearFrom.Location = new Point(283, 170);
            dateTimePickerReleaseYearFrom.Name = "dateTimePickerReleaseYearFrom";
            dateTimePickerReleaseYearFrom.Size = new Size(125, 27);
            dateTimePickerReleaseYearFrom.TabIndex = 48;
            dateTimePickerReleaseYearFrom.Value = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // comboBoxCarShop
            // 
            comboBoxCarShop.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCarShop.FormattingEnabled = true;
            comboBoxCarShop.Location = new Point(283, 211);
            comboBoxCarShop.Name = "comboBoxCarShop";
            comboBoxCarShop.Size = new Size(274, 28);
            comboBoxCarShop.TabIndex = 47;
            // 
            // comboBoxFactory
            // 
            comboBoxFactory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFactory.FormattingEnabled = true;
            comboBoxFactory.Location = new Point(283, 297);
            comboBoxFactory.Name = "comboBoxFactory";
            comboBoxFactory.Size = new Size(274, 28);
            comboBoxFactory.TabIndex = 46;
            // 
            // comboBoxOwner
            // 
            comboBoxOwner.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOwner.FormattingEnabled = true;
            comboBoxOwner.Location = new Point(283, 251);
            comboBoxOwner.Name = "comboBoxOwner";
            comboBoxOwner.Size = new Size(274, 28);
            comboBoxOwner.TabIndex = 45;
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(283, 6);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(274, 28);
            comboBoxBrand.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 300);
            label7.Name = "label7";
            label7.Size = new Size(163, 20);
            label7.TabIndex = 43;
            label7.Text = "Завод-производитель";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 259);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 42;
            label8.Text = "Владелец";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 219);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 41;
            label9.Text = "Автосалон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 175);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 40;
            label5.Text = "Год выпуска";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 39;
            label3.Text = "Привод";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 86);
            label4.Name = "label4";
            label4.Size = new Size(246, 20);
            label4.TabIndex = 38;
            label4.Text = "Автоматическая коробка передач";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 37;
            label2.Text = "Стоимость";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 36;
            label1.Text = "Марка";
            // 
            // numericUpDownPriceTo
            // 
            numericUpDownPriceTo.Location = new Point(414, 46);
            numericUpDownPriceTo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPriceTo.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownPriceTo.Name = "numericUpDownPriceTo";
            numericUpDownPriceTo.Size = new Size(143, 27);
            numericUpDownPriceTo.TabIndex = 52;
            numericUpDownPriceTo.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // dateTimePickerReleaseYearTo
            // 
            dateTimePickerReleaseYearTo.Location = new Point(414, 170);
            dateTimePickerReleaseYearTo.Name = "dateTimePickerReleaseYearTo";
            dateTimePickerReleaseYearTo.Size = new Size(143, 27);
            dateTimePickerReleaseYearTo.TabIndex = 53;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(276, 331);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(135, 51);
            buttonCancel.TabIndex = 55;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.LimeGreen;
            buttonSearch.Location = new Point(422, 331);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(135, 51);
            buttonSearch.TabIndex = 54;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // FormSearchCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 391);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSearch);
            Controls.Add(dateTimePickerReleaseYearTo);
            Controls.Add(numericUpDownPriceTo);
            Controls.Add(checkBoxAuto);
            Controls.Add(comboBoxDrive);
            Controls.Add(numericUpDownPriceFrom);
            Controls.Add(dateTimePickerReleaseYearFrom);
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
            Name = "FormSearchCar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Поиск автомобиля";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceTo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxAuto;
        private ComboBox comboBoxDrive;
        private NumericUpDown numericUpDownPriceFrom;
        private DateTimePicker dateTimePickerReleaseYearFrom;
        private ComboBox comboBoxCarShop;
        private ComboBox comboBoxFactory;
        private ComboBox comboBoxOwner;
        private ComboBox comboBoxBrand;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownPriceTo;
        private DateTimePicker dateTimePickerReleaseYearTo;
        private Button buttonCancel;
        private Button buttonSearch;
    }
}