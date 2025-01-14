namespace PolinaPolechkaProject.Forms
{
    partial class FormFactory
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
            buttonCancel = new Button();
            buttonSave = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerFoundationYear = new DateTimePicker();
            textBoxAdress = new TextBox();
            textBoxFactoryName = new TextBox();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(80, 131);
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
            buttonSave.Location = new Point(226, 131);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 51);
            buttonSave.TabIndex = 34;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 86);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 38;
            label4.Text = "Год основания";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 37;
            label2.Text = "Адрес";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 36;
            label1.Text = "Название завода";
            // 
            // dateTimePickerFoundationYear
            // 
            dateTimePickerFoundationYear.Location = new Point(167, 86);
            dateTimePickerFoundationYear.Name = "dateTimePickerFoundationYear";
            dateTimePickerFoundationYear.Size = new Size(194, 27);
            dateTimePickerFoundationYear.TabIndex = 39;
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(167, 43);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(194, 27);
            textBoxAdress.TabIndex = 41;
            // 
            // textBoxFactoryName
            // 
            textBoxFactoryName.Location = new Point(167, 6);
            textBoxFactoryName.Name = "textBoxFactoryName";
            textBoxFactoryName.Size = new Size(194, 27);
            textBoxFactoryName.TabIndex = 40;
            // 
            // FormFactory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 204);
            Controls.Add(textBoxAdress);
            Controls.Add(textBoxFactoryName);
            Controls.Add(dateTimePickerFoundationYear);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Name = "FormFactory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Завод-производитель";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonSave;
        private Label label4;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerFoundationYear;
        private TextBox textBoxAdress;
        private TextBox textBoxFactoryName;
    }
}