namespace PolinaPolechkaProject.Forms.SearchForms
{
    partial class FormSearchBrand
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
            textBoxCountry = new TextBox();
            textBoxBrandName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            buttonCancel = new Button();
            buttonSearch = new Button();
            SuspendLayout();
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(198, 43);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(194, 27);
            textBoxCountry.TabIndex = 54;
            // 
            // textBoxBrandName
            // 
            textBoxBrandName.Location = new Point(198, 6);
            textBoxBrandName.Name = "textBoxBrandName";
            textBoxBrandName.Size = new Size(194, 27);
            textBoxBrandName.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 50);
            label4.Name = "label4";
            label4.Size = new Size(169, 20);
            label4.TabIndex = 52;
            label4.Text = "Страна производитель";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 51;
            label1.Text = "Название марки";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(111, 76);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(135, 51);
            buttonCancel.TabIndex = 56;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.LimeGreen;
            buttonSearch.Location = new Point(257, 76);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(135, 51);
            buttonSearch.TabIndex = 55;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // FormSearchBrand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 139);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxBrandName);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "FormSearchBrand";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Поиск марки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCountry;
        private TextBox textBoxBrandName;
        private Label label4;
        private Label label1;
        private Button buttonCancel;
        private Button buttonSearch;
    }
}