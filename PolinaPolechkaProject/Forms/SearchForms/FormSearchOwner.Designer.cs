namespace PolinaPolechkaProject.Forms.SearchForms
{
    partial class FormSearchOwner
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
            buttonSearch = new Button();
            textBoxSubAdress = new TextBox();
            textBoxSubEmail = new TextBox();
            textBoxSubPhone = new TextBox();
            textBoxSubName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(99, 222);
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
            buttonSearch.Location = new Point(245, 222);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(135, 51);
            buttonSearch.TabIndex = 42;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSubAdress
            // 
            textBoxSubAdress.Location = new Point(176, 155);
            textBoxSubAdress.Name = "textBoxSubAdress";
            textBoxSubAdress.Size = new Size(125, 27);
            textBoxSubAdress.TabIndex = 41;
            // 
            // textBoxSubEmail
            // 
            textBoxSubEmail.Location = new Point(176, 108);
            textBoxSubEmail.Name = "textBoxSubEmail";
            textBoxSubEmail.Size = new Size(125, 27);
            textBoxSubEmail.TabIndex = 40;
            // 
            // textBoxSubPhone
            // 
            textBoxSubPhone.Location = new Point(176, 59);
            textBoxSubPhone.Name = "textBoxSubPhone";
            textBoxSubPhone.Size = new Size(125, 27);
            textBoxSubPhone.TabIndex = 39;
            // 
            // textBoxSubName
            // 
            textBoxSubName.Location = new Point(176, 12);
            textBoxSubName.Name = "textBoxSubName";
            textBoxSubName.Size = new Size(125, 27);
            textBoxSubName.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 158);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 37;
            label3.Text = "Адрес проживания";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 111);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 36;
            label4.Text = "Почтовый адрес";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 62);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 35;
            label2.Text = "Телефон";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 34;
            label1.Text = "Полное имя";
            // 
            // FormSearchOwner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 288);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSubAdress);
            Controls.Add(textBoxSubEmail);
            Controls.Add(textBoxSubPhone);
            Controls.Add(textBoxSubName);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSearchOwner";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Поиск владельца";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonSearch;
        private TextBox textBoxSubAdress;
        private TextBox textBoxSubEmail;
        private TextBox textBoxSubPhone;
        private TextBox textBoxSubName;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}