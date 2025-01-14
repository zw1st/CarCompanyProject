namespace PolinaPolechkaProject
{
    partial class FormMain
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
            menuStrip1 = new MenuStrip();
            таблицыToolStripMenuItem = new ToolStripMenuItem();
            владельцыToolStripMenuItem = new ToolStripMenuItem();
            автомобилиToolStripMenuItem = new ToolStripMenuItem();
            заводыToolStripMenuItem = new ToolStripMenuItem();
            маркиToolStripMenuItem = new ToolStripMenuItem();
            автосалоныToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { таблицыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            таблицыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { владельцыToolStripMenuItem, автомобилиToolStripMenuItem, заводыToolStripMenuItem, маркиToolStripMenuItem, автосалоныToolStripMenuItem });
            таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            таблицыToolStripMenuItem.Size = new Size(85, 24);
            таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // владельцыToolStripMenuItem
            // 
            владельцыToolStripMenuItem.Name = "владельцыToolStripMenuItem";
            владельцыToolStripMenuItem.Size = new Size(224, 26);
            владельцыToolStripMenuItem.Text = "Владельцы";
            владельцыToolStripMenuItem.Click += владельцыToolStripMenuItem_Click;
            // 
            // автомобилиToolStripMenuItem
            // 
            автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            автомобилиToolStripMenuItem.Size = new Size(224, 26);
            автомобилиToolStripMenuItem.Text = "Автомобили";
            автомобилиToolStripMenuItem.Click += автомобилиToolStripMenuItem_Click;
            // 
            // заводыToolStripMenuItem
            // 
            заводыToolStripMenuItem.Name = "заводыToolStripMenuItem";
            заводыToolStripMenuItem.Size = new Size(224, 26);
            заводыToolStripMenuItem.Text = "Заводы";
            заводыToolStripMenuItem.Click += заводыToolStripMenuItem_Click;
            // 
            // маркиToolStripMenuItem
            // 
            маркиToolStripMenuItem.Name = "маркиToolStripMenuItem";
            маркиToolStripMenuItem.Size = new Size(224, 26);
            маркиToolStripMenuItem.Text = "Марки";
            маркиToolStripMenuItem.Click += маркиToolStripMenuItem_Click;
            // 
            // автосалоныToolStripMenuItem
            // 
            автосалоныToolStripMenuItem.Name = "автосалоныToolStripMenuItem";
            автосалоныToolStripMenuItem.Size = new Size(224, 26);
            автосалоныToolStripMenuItem.Text = "Автосалоны";
            автосалоныToolStripMenuItem.Click += автосалоныToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Главная";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem таблицыToolStripMenuItem;
        private ToolStripMenuItem владельцыToolStripMenuItem;
        private ToolStripMenuItem автомобилиToolStripMenuItem;
        private ToolStripMenuItem заводыToolStripMenuItem;
        private ToolStripMenuItem маркиToolStripMenuItem;
        private ToolStripMenuItem автосалоныToolStripMenuItem;
    }
}