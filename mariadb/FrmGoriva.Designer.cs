namespace mariadb
{
    partial class FrmGoriva
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
            components = new System.ComponentModel.Container();
            dgvGoriva = new DataGridView();
            cmsVrijednost = new ContextMenuStrip(components);
            dohvatiToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            txtNazivGoriva = new TextBox();
            txtCijenaGoriva = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            dgIdGoriva = new DataGridViewTextBoxColumn();
            dgNazivGoriva = new DataGridViewTextBoxColumn();
            dgCijenaGoriva = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvGoriva).BeginInit();
            cmsVrijednost.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGoriva
            // 
            dgvGoriva.AllowUserToAddRows = false;
            dgvGoriva.AllowUserToDeleteRows = false;
            dgvGoriva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoriva.Columns.AddRange(new DataGridViewColumn[] { dgIdGoriva, dgNazivGoriva, dgCijenaGoriva });
            dgvGoriva.ContextMenuStrip = cmsVrijednost;
            dgvGoriva.Location = new Point(14, 12);
            dgvGoriva.Name = "dgvGoriva";
            dgvGoriva.ReadOnly = true;
            dgvGoriva.Size = new Size(266, 272);
            dgvGoriva.TabIndex = 0;
            dgvGoriva.DoubleClick += dgvGoriva_DoubleClick;
            // 
            // cmsVrijednost
            // 
            cmsVrijednost.Items.AddRange(new ToolStripItem[] { dohvatiToolStripMenuItem });
            cmsVrijednost.Name = "cmsVrijednost";
            cmsVrijednost.Size = new Size(116, 26);
            // 
            // dohvatiToolStripMenuItem
            // 
            dohvatiToolStripMenuItem.Name = "dohvatiToolStripMenuItem";
            dohvatiToolStripMenuItem.Size = new Size(115, 22);
            dohvatiToolStripMenuItem.Text = "Dohvati";
            dohvatiToolStripMenuItem.Click += dohvatiToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 302);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Naziv goriva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 337);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Cijena goriva";
            // 
            // txtNazivGoriva
            // 
            txtNazivGoriva.Location = new Point(92, 299);
            txtNazivGoriva.Name = "txtNazivGoriva";
            txtNazivGoriva.Size = new Size(188, 23);
            txtNazivGoriva.TabIndex = 2;
            // 
            // txtCijenaGoriva
            // 
            txtCijenaGoriva.Location = new Point(92, 334);
            txtCijenaGoriva.Name = "txtCijenaGoriva";
            txtCijenaGoriva.Size = new Size(188, 23);
            txtCijenaGoriva.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 376);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(108, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(189, 376);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgIdGoriva
            // 
            dgIdGoriva.DataPropertyName = "IdGoriva";
            dgIdGoriva.HeaderText = "Id Goriva";
            dgIdGoriva.MinimumWidth = 6;
            dgIdGoriva.Name = "dgIdGoriva";
            dgIdGoriva.ReadOnly = true;
            dgIdGoriva.Visible = false;
            dgIdGoriva.Width = 125;
            // 
            // dgNazivGoriva
            // 
            dgNazivGoriva.DataPropertyName = "NazivGoriva";
            dgNazivGoriva.HeaderText = "Naziv goriva";
            dgNazivGoriva.Name = "dgNazivGoriva";
            dgNazivGoriva.ReadOnly = true;
            dgNazivGoriva.Visible = false;
            // 
            // dgCijenaGoriva
            // 
            dgCijenaGoriva.DataPropertyName = "CijenaGoriva";
            dgCijenaGoriva.HeaderText = "Cijena Goriva";
            dgCijenaGoriva.Name = "dgCijenaGoriva";
            dgCijenaGoriva.ReadOnly = true;
            dgCijenaGoriva.Visible = false;
            // 
            // FrmGoriva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 411);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtCijenaGoriva);
            Controls.Add(txtNazivGoriva);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvGoriva);
            Name = "FrmGoriva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Goriva";
            Load += FrmGoriva_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGoriva).EndInit();
            cmsVrijednost.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGoriva;
        private Label label1;
        private Label label2;
        private TextBox txtNazivGoriva;
        private TextBox txtCijenaGoriva;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;
        private ContextMenuStrip cmsVrijednost;
        private ToolStripMenuItem dohvatiToolStripMenuItem;
        private DataGridViewTextBoxColumn dgIdGoriva;
        private DataGridViewTextBoxColumn dgNazivGoriva;
        private DataGridViewTextBoxColumn dgCijenaGoriva;
    }
}