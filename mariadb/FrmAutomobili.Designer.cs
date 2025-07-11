namespace mariadb
{
    partial class FrmAutomobili
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
            dgvAutomobili = new DataGridView();
            dgIdAutomobila = new DataGridViewTextBoxColumn();
            dgRegistracija = new DataGridViewTextBoxColumn();
            dgIdProizvodjac = new DataGridViewTextBoxColumn();
            dgModel = new DataGridViewTextBoxColumn();
            dgIdGoriva = new DataGridViewTextBoxColumn();
            dgCcm = new DataGridViewTextBoxColumn();
            dgkW = new DataGridViewTextBoxColumn();
            dgPotrosnja = new DataGridViewTextBoxColumn();
            dgGodinaProizvodnje = new DataGridViewTextBoxColumn();
            dgDatumRegistracije = new DataGridViewTextBoxColumn();
            dgKilometriNaRegistraciji = new DataGridViewTextBoxColumn();
            dgDostupan = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtRegistracija = new TextBox();
            label2 = new Label();
            txtIdProizvodjac = new TextBox();
            label3 = new Label();
            txtModel = new TextBox();
            lblGorivo = new Label();
            txtIdGoriva = new TextBox();
            label5 = new Label();
            txtCcm = new TextBox();
            label6 = new Label();
            txtKw = new TextBox();
            label7 = new Label();
            txtPotrosnja = new TextBox();
            label8 = new Label();
            txtKilometriNaRegistraciji = new TextBox();
            label9 = new Label();
            label10 = new Label();
            dtpDatumRegistracije = new DateTimePicker();
            dtpGodinaProizvodnje = new DateTimePicker();
            cbDostupan = new CheckBox();
            btnCancel = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvAutomobili).BeginInit();
            SuspendLayout();
            // 
            // dgvAutomobili
            // 
            dgvAutomobili.AllowUserToDeleteRows = false;
            dgvAutomobili.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutomobili.Columns.AddRange(new DataGridViewColumn[] { dgIdAutomobila, dgRegistracija, dgIdProizvodjac, dgModel, dgIdGoriva, dgCcm, dgkW, dgPotrosnja, dgGodinaProizvodnje, dgDatumRegistracije, dgKilometriNaRegistraciji, dgDostupan });
            dgvAutomobili.Location = new Point(12, 12);
            dgvAutomobili.Name = "dgvAutomobili";
            dgvAutomobili.ReadOnly = true;
            dgvAutomobili.Size = new Size(760, 271);
            dgvAutomobili.TabIndex = 14;
            dgvAutomobili.DoubleClick += dgvAutomobili_DoubleClick;
            // 
            // dgIdAutomobila
            // 
            dgIdAutomobila.DataPropertyName = "IdAutomobila";
            dgIdAutomobila.HeaderText = "Id Automobila";
            dgIdAutomobila.Name = "dgIdAutomobila";
            dgIdAutomobila.ReadOnly = true;
            dgIdAutomobila.Visible = false;
            // 
            // dgRegistracija
            // 
            dgRegistracija.DataPropertyName = "Registracija";
            dgRegistracija.HeaderText = "Registracija";
            dgRegistracija.Name = "dgRegistracija";
            dgRegistracija.ReadOnly = true;
            // 
            // dgIdProizvodjac
            // 
            dgIdProizvodjac.DataPropertyName = "IdProizvodjac";
            dgIdProizvodjac.HeaderText = "Proizvođač";
            dgIdProizvodjac.Name = "dgIdProizvodjac";
            dgIdProizvodjac.ReadOnly = true;
            // 
            // dgModel
            // 
            dgModel.DataPropertyName = "Model";
            dgModel.HeaderText = "Model";
            dgModel.Name = "dgModel";
            dgModel.ReadOnly = true;
            // 
            // dgIdGoriva
            // 
            dgIdGoriva.DataPropertyName = "IdGoriva";
            dgIdGoriva.HeaderText = "Gorivo";
            dgIdGoriva.Name = "dgIdGoriva";
            dgIdGoriva.ReadOnly = true;
            // 
            // dgCcm
            // 
            dgCcm.DataPropertyName = "Ccm";
            dgCcm.HeaderText = "cm3";
            dgCcm.Name = "dgCcm";
            dgCcm.ReadOnly = true;
            // 
            // dgkW
            // 
            dgkW.DataPropertyName = "kW";
            dgkW.HeaderText = "kW";
            dgkW.Name = "dgkW";
            dgkW.ReadOnly = true;
            // 
            // dgPotrosnja
            // 
            dgPotrosnja.DataPropertyName = "Potrosnja";
            dgPotrosnja.HeaderText = "Potrošnja";
            dgPotrosnja.Name = "dgPotrosnja";
            dgPotrosnja.ReadOnly = true;
            // 
            // dgGodinaProizvodnje
            // 
            dgGodinaProizvodnje.DataPropertyName = "GodinaProizvodnje";
            dgGodinaProizvodnje.HeaderText = "Proizveden";
            dgGodinaProizvodnje.Name = "dgGodinaProizvodnje";
            dgGodinaProizvodnje.ReadOnly = true;
            // 
            // dgDatumRegistracije
            // 
            dgDatumRegistracije.DataPropertyName = "DatumRegistracije";
            dgDatumRegistracije.HeaderText = "Registriran";
            dgDatumRegistracije.Name = "dgDatumRegistracije";
            dgDatumRegistracije.ReadOnly = true;
            // 
            // dgKilometriNaRegistraciji
            // 
            dgKilometriNaRegistraciji.DataPropertyName = "KilometriNaRegistraciji";
            dgKilometriNaRegistraciji.HeaderText = "Kilometara";
            dgKilometriNaRegistraciji.Name = "dgKilometriNaRegistraciji";
            dgKilometriNaRegistraciji.ReadOnly = true;
            // 
            // dgDostupan
            // 
            dgDostupan.DataPropertyName = "Dostupan";
            dgDostupan.HeaderText = "Dostupan";
            dgDostupan.Name = "dgDostupan";
            dgDostupan.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 320);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 15;
            label1.Text = "Registracija";
            // 
            // txtRegistracija
            // 
            txtRegistracija.Location = new Point(84, 316);
            txtRegistracija.Name = "txtRegistracija";
            txtRegistracija.Size = new Size(100, 23);
            txtRegistracija.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 349);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 16;
            label2.Text = "Proizvođač";
            // 
            // txtIdProizvodjac
            // 
            txtIdProizvodjac.Location = new Point(84, 345);
            txtIdProizvodjac.Name = "txtIdProizvodjac";
            txtIdProizvodjac.Size = new Size(100, 23);
            txtIdProizvodjac.TabIndex = 1;
            txtIdProizvodjac.Tag = "Proizvođač";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 378);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 17;
            label3.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(84, 374);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 2;
            // 
            // lblGorivo
            // 
            lblGorivo.AutoSize = true;
            lblGorivo.Location = new Point(38, 407);
            lblGorivo.Name = "lblGorivo";
            lblGorivo.Size = new Size(42, 15);
            lblGorivo.TabIndex = 18;
            lblGorivo.Text = "Gorivo";
            // 
            // txtIdGoriva
            // 
            txtIdGoriva.Location = new Point(84, 403);
            txtIdGoriva.Name = "txtIdGoriva";
            txtIdGoriva.Size = new Size(100, 23);
            txtIdGoriva.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 320);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 19;
            label5.Text = "cm3";
            // 
            // txtCcm
            // 
            txtCcm.Location = new Point(333, 316);
            txtCcm.Name = "txtCcm";
            txtCcm.Size = new Size(100, 23);
            txtCcm.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 349);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 20;
            label6.Text = "kW";
            // 
            // txtKw
            // 
            txtKw.Location = new Point(333, 345);
            txtKw.Name = "txtKw";
            txtKw.Size = new Size(100, 23);
            txtKw.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 378);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 21;
            label7.Text = "l/100 km";
            // 
            // txtPotrosnja
            // 
            txtPotrosnja.Location = new Point(333, 374);
            txtPotrosnja.Name = "txtPotrosnja";
            txtPotrosnja.Size = new Size(100, 23);
            txtPotrosnja.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 407);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 22;
            label8.Text = "km od servisa";
            // 
            // txtKilometriNaRegistraciji
            // 
            txtKilometriNaRegistraciji.Location = new Point(333, 403);
            txtKilometriNaRegistraciji.Name = "txtKilometriNaRegistraciji";
            txtKilometriNaRegistraciji.Size = new Size(100, 23);
            txtKilometriNaRegistraciji.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(499, 320);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 23;
            label9.Text = "Registriran";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(497, 349);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 24;
            label10.Text = "Proizveden";
            // 
            // dtpDatumRegistracije
            // 
            dtpDatumRegistracije.Format = DateTimePickerFormat.Short;
            dtpDatumRegistracije.Location = new Point(568, 316);
            dtpDatumRegistracije.Name = "dtpDatumRegistracije";
            dtpDatumRegistracije.Size = new Size(200, 23);
            dtpDatumRegistracije.TabIndex = 8;
            // 
            // dtpGodinaProizvodnje
            // 
            dtpGodinaProizvodnje.CustomFormat = "yyyy";
            dtpGodinaProizvodnje.Format = DateTimePickerFormat.Custom;
            dtpGodinaProizvodnje.Location = new Point(568, 345);
            dtpGodinaProizvodnje.Name = "dtpGodinaProizvodnje";
            dtpGodinaProizvodnje.ShowUpDown = true;
            dtpGodinaProizvodnje.Size = new Size(77, 23);
            dtpGodinaProizvodnje.TabIndex = 9;
            // 
            // cbDostupan
            // 
            cbDostupan.AutoSize = true;
            cbDostupan.Location = new Point(568, 378);
            cbDostupan.Name = "cbDostupan";
            cbDostupan.Size = new Size(77, 19);
            cbDostupan.TabIndex = 10;
            cbDostupan.Text = "Dostupan";
            cbDostupan.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(439, 504);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(358, 504);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(280, 504);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmAutomobili
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(cbDostupan);
            Controls.Add(dtpGodinaProizvodnje);
            Controls.Add(dtpDatumRegistracije);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtKilometriNaRegistraciji);
            Controls.Add(label8);
            Controls.Add(txtPotrosnja);
            Controls.Add(label7);
            Controls.Add(txtKw);
            Controls.Add(label6);
            Controls.Add(txtCcm);
            Controls.Add(label5);
            Controls.Add(txtIdGoriva);
            Controls.Add(lblGorivo);
            Controls.Add(txtModel);
            Controls.Add(label3);
            Controls.Add(txtIdProizvodjac);
            Controls.Add(label2);
            Controls.Add(txtRegistracija);
            Controls.Add(label1);
            Controls.Add(dgvAutomobili);
            Name = "FrmAutomobili";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Automobili";
            Load += FrmAutomobili_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAutomobili).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAutomobili;
        private Label label1;
        private TextBox txtRegistracija;
        private Label label2;
        private TextBox txtIdProizvodjac;
        private Label label3;
        private TextBox txtModel;
        private Label lblGorivo;
        private TextBox txtIdGoriva;
        private Label label5;
        private TextBox txtCcm;
        private Label label6;
        private TextBox txtKw;
        private Label label7;
        private TextBox txtPotrosnja;
        private Label label8;
        private TextBox txtKilometriNaRegistraciji;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpDatumRegistracije;
        private DateTimePicker dtpGodinaProizvodnje;
        private CheckBox cbDostupan;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn dgIdAutomobila;
        private DataGridViewTextBoxColumn dgRegistracija;
        private DataGridViewTextBoxColumn dgIdProizvodjac;
        private DataGridViewTextBoxColumn dgModel;
        private DataGridViewTextBoxColumn dgIdGoriva;
        private DataGridViewTextBoxColumn dgCcm;
        private DataGridViewTextBoxColumn dgkW;
        private DataGridViewTextBoxColumn dgPotrosnja;
        private DataGridViewTextBoxColumn dgGodinaProizvodnje;
        private DataGridViewTextBoxColumn dgDatumRegistracije;
        private DataGridViewTextBoxColumn dgKilometriNaRegistraciji;
        private DataGridViewTextBoxColumn dgDostupan;
    }
}