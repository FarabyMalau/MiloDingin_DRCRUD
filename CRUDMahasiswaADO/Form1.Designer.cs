namespace CRUDMahasiswaADO
{
    partial class FormMahasiswa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbkJK = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKodeProdi = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(145, 39);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(247, 22);
            this.txtNIM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(145, 77);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(247, 22);
            this.txtNama.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jenis Kelamin";
            // 
            // cmbkJK
            // 
            this.cmbkJK.FormattingEnabled = true;
            this.cmbkJK.Location = new System.Drawing.Point(145, 115);
            this.cmbkJK.Name = "cmbkJK";
            this.cmbkJK.Size = new System.Drawing.Size(121, 24);
            this.cmbkJK.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tanggal Lahir";
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(145, 156);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(247, 22);
            this.dtpTanggalLahir.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(145, 201);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(247, 22);
            this.txtAlamat.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kode Prodi";
            // 
            // txtKodeProdi
            // 
            this.txtKodeProdi.Location = new System.Drawing.Point(145, 247);
            this.txtKodeProdi.Name = "txtKodeProdi";
            this.txtKodeProdi.Size = new System.Drawing.Size(121, 22);
            this.txtKodeProdi.TabIndex = 12;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(538, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(160, 36);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Membuka Koneksi";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(538, 78);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(160, 34);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Menampilkan Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(537, 118);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(161, 31);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Menambah Data";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(537, 155);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 43);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Mengubah Data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(537, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 36);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Menghapus Data";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 161);
            this.dataGridView1.TabIndex = 17;
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 477);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtKodeProdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbkJK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label1);
            this.Name = "FormMahasiswa";
            this.Text = "Form Data Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKodeProdi;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbkJK;
    }
}