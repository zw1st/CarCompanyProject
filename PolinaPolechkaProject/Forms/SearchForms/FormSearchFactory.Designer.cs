namespace PolinaPolechkaProject.Forms.SearchForms
{
    partial class FormSearchFactory
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
            textBoxAdress = new TextBox();
            textBoxFactoryName = new TextBox();
            dateTimePickerFrom = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCancel = new Button();
            buttonSearch = new Button();
            label3 = new Label();
            label5 = new Label();
            dateTimePickerTo = new DateTimePicker();
            SuspendLayout();
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(180, 43);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(194, 27);
            textBoxAdress.TabIndex = 49;
            // 
            // textBoxFactoryName
            // 
            textBoxFactoryName.Location = new Point(180, 6);
            textBoxFactoryName.Name = "textBoxFactoryName";
            textBoxFactoryName.Size = new Size(194, 27);
            textBoxFactoryName.TabIndex = 48;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(180, 86);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(194, 27);
            dateTimePickerFrom.TabIndex = 47;
            dateTimePickerFrom.Value = new DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 86);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 46;
            label4.Text = "Год основания";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 45;
            label2.Text = "Адрес";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 44;
            label1.Text = "Название завода";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(93, 159);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(135, 51);
            buttonCancel.TabIndex = 43;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.LimeGreen;
            buttonSearch.Location = new Point(239, 159);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(135, 51);
            buttonSearch.TabIndex = 42;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 131);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 50;
            label3.Text = "До";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 86);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 51;
            label5.Text = "От";
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(180, 126);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(194, 27);
            dateTimePickerTo.TabIndex = 52;
            // 
            // FormSearchFactory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 220);
            Controls.Add(dateTimePickerTo);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBoxAdress);
            Controls.Add(textBoxFactoryName);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSearch);
            Name = "FormSearchFactory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Поиск заводов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAdress;
        private TextBox textBoxFactoryName;
        private DateTimePicker dateTimePickerFrom;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button buttonCancel;
        private Button buttonSearch;
        private Label label3;
        private Label label5;
        private DateTimePicker dateTimePickerTo;
    }
}