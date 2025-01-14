namespace PolinaPolechkaProject.Forms
{
    partial class FormCarShop
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
            textBoxCarShopName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            label2 = new Label();
            numericUpDownRating = new NumericUpDown();
            numericUpDownGar = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGar).BeginInit();
            SuspendLayout();
            // 
            // textBoxCarShopName
            // 
            textBoxCarShopName.Location = new Point(166, 12);
            textBoxCarShopName.Name = "textBoxCarShopName";
            textBoxCarShopName.Size = new Size(194, 27);
            textBoxCarShopName.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 92);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 45;
            label4.Text = "Гарантия (месяцев)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 44;
            label1.Text = "Название салона";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(79, 137);
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
            buttonSave.Location = new Point(225, 137);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 51);
            buttonSave.TabIndex = 42;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 49;
            label2.Text = "Рейтинг";
            // 
            // numericUpDownRating
            // 
            numericUpDownRating.Location = new Point(166, 52);
            numericUpDownRating.Name = "numericUpDownRating";
            numericUpDownRating.Size = new Size(194, 27);
            numericUpDownRating.TabIndex = 50;
            numericUpDownRating.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // numericUpDownGar
            // 
            numericUpDownGar.Location = new Point(166, 90);
            numericUpDownGar.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDownGar.Name = "numericUpDownGar";
            numericUpDownGar.Size = new Size(194, 27);
            numericUpDownGar.TabIndex = 51;
            numericUpDownGar.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // FormCarShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 205);
            Controls.Add(numericUpDownGar);
            Controls.Add(numericUpDownRating);
            Controls.Add(label2);
            Controls.Add(textBoxCarShopName);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Name = "FormCarShop";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Автосалон";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCarShopName;
        private Label label4;
        private Label label1;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label2;
        private NumericUpDown numericUpDownRating;
        private NumericUpDown numericUpDownGar;
    }
}