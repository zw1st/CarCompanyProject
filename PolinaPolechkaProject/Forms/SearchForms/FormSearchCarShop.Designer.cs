namespace PolinaPolechkaProject.Forms.SearchForms
{
    partial class FormSearchCarShop
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
            numericUpDownGuaranteeFrom = new NumericUpDown();
            numericUpDownRatingFrom = new NumericUpDown();
            label2 = new Label();
            textBoxCarShopName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numericUpDownGuaranteeTo = new NumericUpDown();
            numericUpDownRatingTo = new NumericUpDown();
            buttonCancel = new Button();
            buttonSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGuaranteeFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRatingFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGuaranteeTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRatingTo).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownGuaranteeFrom
            // 
            numericUpDownGuaranteeFrom.Location = new Point(199, 84);
            numericUpDownGuaranteeFrom.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDownGuaranteeFrom.Name = "numericUpDownGuaranteeFrom";
            numericUpDownGuaranteeFrom.Size = new Size(76, 27);
            numericUpDownGuaranteeFrom.TabIndex = 57;
            // 
            // numericUpDownRatingFrom
            // 
            numericUpDownRatingFrom.Location = new Point(199, 46);
            numericUpDownRatingFrom.Name = "numericUpDownRatingFrom";
            numericUpDownRatingFrom.Size = new Size(76, 27);
            numericUpDownRatingFrom.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 46);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 55;
            label2.Text = "Рейтинг";
            // 
            // textBoxCarShopName
            // 
            textBoxCarShopName.Location = new Point(199, 6);
            textBoxCarShopName.Name = "textBoxCarShopName";
            textBoxCarShopName.Size = new Size(192, 27);
            textBoxCarShopName.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 86);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 53;
            label4.Text = "Гарантия (месяцев)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 52;
            label1.Text = "Название салона";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 46);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 59;
            label3.Text = "От";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 86);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 58;
            label5.Text = "От";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 48);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 61;
            label6.Text = "До";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 88);
            label7.Name = "label7";
            label7.Size = new Size(28, 20);
            label7.TabIndex = 60;
            label7.Text = "До";
            // 
            // numericUpDownGuaranteeTo
            // 
            numericUpDownGuaranteeTo.Location = new Point(315, 86);
            numericUpDownGuaranteeTo.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDownGuaranteeTo.Name = "numericUpDownGuaranteeTo";
            numericUpDownGuaranteeTo.Size = new Size(76, 27);
            numericUpDownGuaranteeTo.TabIndex = 63;
            numericUpDownGuaranteeTo.Value = new decimal(new int[] { 24, 0, 0, 0 });
            // 
            // numericUpDownRatingTo
            // 
            numericUpDownRatingTo.Location = new Point(315, 48);
            numericUpDownRatingTo.Name = "numericUpDownRatingTo";
            numericUpDownRatingTo.Size = new Size(76, 27);
            numericUpDownRatingTo.TabIndex = 62;
            numericUpDownRatingTo.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(110, 119);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(135, 51);
            buttonCancel.TabIndex = 65;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.LimeGreen;
            buttonSearch.Location = new Point(256, 119);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(135, 51);
            buttonSearch.TabIndex = 64;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // FormSearchCarShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 185);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSearch);
            Controls.Add(numericUpDownGuaranteeTo);
            Controls.Add(numericUpDownRatingTo);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(numericUpDownGuaranteeFrom);
            Controls.Add(numericUpDownRatingFrom);
            Controls.Add(label2);
            Controls.Add(textBoxCarShopName);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "FormSearchCarShop";
            Text = "Поиск автосалона";
            ((System.ComponentModel.ISupportInitialize)numericUpDownGuaranteeFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRatingFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGuaranteeTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRatingTo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownGuaranteeFrom;
        private NumericUpDown numericUpDownRatingFrom;
        private Label label2;
        private TextBox textBoxCarShopName;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDownGuaranteeTo;
        private NumericUpDown numericUpDownRatingTo;
        private Button buttonCancel;
        private Button buttonSearch;
    }
}