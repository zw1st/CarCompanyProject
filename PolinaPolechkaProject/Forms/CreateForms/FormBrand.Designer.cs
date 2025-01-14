namespace PolinaPolechkaProject.Forms
{
    partial class FormBrand
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
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(198, 49);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(194, 27);
            textBoxCountry.TabIndex = 48;
            // 
            // textBoxBrandName
            // 
            textBoxBrandName.Location = new Point(198, 12);
            textBoxBrandName.Name = "textBoxBrandName";
            textBoxBrandName.Size = new Size(194, 27);
            textBoxBrandName.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 56);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 45;
            label4.Text = "страна производитель";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 44;
            label1.Text = "Название марки";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(111, 101);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(135, 51);
            buttonCancel.TabIndex = 43;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LimeGreen;
            buttonSave.Location = new Point(257, 101);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 51);
            buttonSave.TabIndex = 42;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormBrand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 176);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxBrandName);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Name = "FormBrand";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Марка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCountry;
        private TextBox textBoxBrandName;
        private Label label4;
        private Label label1;
        private Button buttonCancel;
        private Button buttonSave;
    }
}