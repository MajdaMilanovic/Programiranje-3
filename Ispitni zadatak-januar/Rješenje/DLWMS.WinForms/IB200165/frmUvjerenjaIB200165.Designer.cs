namespace DLWMS.WinForms.IB200165
{
    partial class frmUvjerenjaIB200165
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvUvjerenja = new System.Windows.Forms.DataGridView();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uplatnica = new System.Windows.Forms.DataGridViewImageColumn();
            this.Printano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Printaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodaj2 = new System.Windows.Forms.Button();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUvjerenja)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(668, 10);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(152, 28);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj uvjerenje";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvUvjerenja
            // 
            this.dgvUvjerenja.AllowUserToAddRows = false;
            this.dgvUvjerenja.AllowUserToDeleteRows = false;
            this.dgvUvjerenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUvjerenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vrsta,
            this.Svrha,
            this.Uplatnica,
            this.Printano,
            this.Datum,
            this.Brisi,
            this.Printaj});
            this.dgvUvjerenja.Location = new System.Drawing.Point(12, 44);
            this.dgvUvjerenja.Name = "dgvUvjerenja";
            this.dgvUvjerenja.ReadOnly = true;
            this.dgvUvjerenja.RowHeadersWidth = 51;
            this.dgvUvjerenja.RowTemplate.Height = 29;
            this.dgvUvjerenja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUvjerenja.Size = new System.Drawing.Size(808, 239);
            this.dgvUvjerenja.TabIndex = 1;
            this.dgvUvjerenja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUvjerenja_CellContentClick);
            // 
            // Vrsta
            // 
            this.Vrsta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta uvjerenja";
            this.Vrsta.MinimumWidth = 6;
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.ReadOnly = true;
            // 
            // Svrha
            // 
            this.Svrha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.HeaderText = "Svrha uvjerenja";
            this.Svrha.MinimumWidth = 6;
            this.Svrha.Name = "Svrha";
            this.Svrha.ReadOnly = true;
            // 
            // Uplatnica
            // 
            this.Uplatnica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Uplatnica.DataPropertyName = "Uplatnica";
            this.Uplatnica.HeaderText = "Uplatnica";
            this.Uplatnica.MinimumWidth = 6;
            this.Uplatnica.Name = "Uplatnica";
            this.Uplatnica.ReadOnly = true;
            // 
            // Printano
            // 
            this.Printano.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Printano.DataPropertyName = "Printano";
            this.Printano.HeaderText = "Printano";
            this.Printano.MinimumWidth = 6;
            this.Printano.Name = "Printano";
            this.Printano.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Brisi
            // 
            this.Brisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brisi.HeaderText = "";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Brisi";
            // 
            // Printaj
            // 
            this.Printaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Printaj.HeaderText = "";
            this.Printaj.MinimumWidth = 6;
            this.Printaj.Name = "Printaj";
            this.Printaj.ReadOnly = true;
            this.Printaj.Text = "Printaj";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodaj2);
            this.groupBox1.Controls.Add(this.cmbVrsta);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.txtBroj);
            this.groupBox1.Controls.Add(this.txtSvrha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 269);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje uvjerenja";
            // 
            // btnDodaj2
            // 
            this.btnDodaj2.Location = new System.Drawing.Point(636, 107);
            this.btnDodaj2.Name = "btnDodaj2";
            this.btnDodaj2.Size = new System.Drawing.Size(152, 28);
            this.btnDodaj2.TabIndex = 3;
            this.btnDodaj2.Text = "Dodaj =>";
            this.btnDodaj2.UseVisualStyleBackColor = true;
            this.btnDodaj2.Click += new System.EventHandler(this.btnDodaj2_Click);
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(6, 54);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(204, 28);
            this.cmbVrsta.TabIndex = 8;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(6, 108);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(604, 152);
            this.txtInfo.TabIndex = 7;
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(616, 54);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(186, 27);
            this.txtBroj.TabIndex = 6;
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(216, 55);
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(394, 27);
            this.txtSvrha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Info:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj uvjerenja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Svrha uvjerenja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta uvjerenja:";
            // 
            // frmUvjerenjaIB200165
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUvjerenja);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmUvjerenjaIB200165";
            this.Text = "frmUvjerenjaIB200165";
            this.Load += new System.EventHandler(this.frmUvjerenjaIB200165_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUvjerenja)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDodaj;
        private DataGridView dgvUvjerenja;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
        private GroupBox groupBox1;
        private Button btnDodaj2;
        private ComboBox cmbVrsta;
        private TextBox txtInfo;
        private TextBox txtBroj;
        private TextBox txtSvrha;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}