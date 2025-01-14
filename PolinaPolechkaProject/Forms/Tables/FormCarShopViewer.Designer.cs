namespace PolinaPolechkaProject.Forms.Tables
{
    partial class FormCarShopViewer
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            buttonDelete = new Button();
            buttonSearch = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            panel1 = new Panel();
            buttonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(659, 450);
            dataGridView1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonReset);
            panel2.Controls.Add(buttonDelete);
            panel2.Controls.Add(buttonSearch);
            panel2.Controls.Add(buttonUpdate);
            panel2.Controls.Add(buttonAdd);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(659, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(141, 450);
            panel2.TabIndex = 5;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(14, 153);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDel_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(14, 103);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(14, 56);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Изменить";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpd_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(14, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(798, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(12, 8);
            panel1.TabIndex = 4;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(14, 409);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "Сбросить";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // FormCarShopViewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCarShopViewer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Автосалоны";
            Load += FormViewer_Load;
            Click += FormViewer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private Button buttonDelete;
        private Button buttonSearch;
        private Button buttonUpdate;
        private Button buttonAdd;
        private Panel panel1;
        private Button buttonReset;
    }
}