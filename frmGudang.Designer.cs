
namespace LKSProvFullSoft
{
    partial class frmGudang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGudang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCancel = new LKSProvFullSoft.RoundedPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSave = new LKSProvFullSoft.RoundedPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbInput = new System.Windows.Forms.Panel();
            this.tbIdBarang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel6 = new LKSProvFullSoft.RoundedPanel();
            this.tbHargaSatuan = new System.Windows.Forms.TextBox();
            this.roundedPanel5 = new LKSProvFullSoft.RoundedPanel();
            this.dtpExpired = new System.Windows.Forms.DateTimePicker();
            this.roundedPanel4 = new LKSProvFullSoft.RoundedPanel();
            this.cbSatuan = new System.Windows.Forms.ComboBox();
            this.roundedPanel3 = new LKSProvFullSoft.RoundedPanel();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.roundedPanel2 = new LKSProvFullSoft.RoundedPanel();
            this.tbJumlahBarang = new System.Windows.Forms.TextBox();
            this.roundedPanel1 = new LKSProvFullSoft.RoundedPanel();
            this.tbKodeBarang = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.roundedPanel9 = new LKSProvFullSoft.RoundedPanel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlDelete = new LKSProvFullSoft.RoundedPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlEdit = new LKSProvFullSoft.RoundedPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlInsert = new LKSProvFullSoft.RoundedPanel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.roundedPanel7 = new LKSProvFullSoft.RoundedPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.gbInput.SuspendLayout();
            this.roundedPanel6.SuspendLayout();
            this.roundedPanel5.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.roundedPanel9.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.pnlInsert.SuspendLayout();
            this.roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlCancel);
            this.panel1.Controls.Add(this.pnlSave);
            this.panel1.Controls.Add(this.gbInput);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.roundedPanel9);
            this.panel1.Controls.Add(this.pnlDelete);
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Controls.Add(this.pnlInsert);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(441, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 839);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlCancel
            // 
            this.pnlCancel.BackColor = System.Drawing.Color.Crimson;
            this.pnlCancel.Controls.Add(this.btnCancel);
            this.pnlCancel.CornerRadius = 10;
            this.pnlCancel.Location = new System.Drawing.Point(317, 375);
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Size = new System.Drawing.Size(154, 43);
            this.pnlCancel.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 44);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlSave
            // 
            this.pnlSave.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.CornerRadius = 10;
            this.pnlSave.Location = new System.Drawing.Point(134, 375);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(154, 43);
            this.pnlSave.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.tbIdBarang);
            this.gbInput.Controls.Add(this.label7);
            this.gbInput.Controls.Add(this.label6);
            this.gbInput.Controls.Add(this.label5);
            this.gbInput.Controls.Add(this.label4);
            this.gbInput.Controls.Add(this.label3);
            this.gbInput.Controls.Add(this.label2);
            this.gbInput.Controls.Add(this.roundedPanel6);
            this.gbInput.Controls.Add(this.roundedPanel5);
            this.gbInput.Controls.Add(this.roundedPanel4);
            this.gbInput.Controls.Add(this.roundedPanel3);
            this.gbInput.Controls.Add(this.roundedPanel2);
            this.gbInput.Controls.Add(this.roundedPanel1);
            this.gbInput.Location = new System.Drawing.Point(20, 60);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(852, 302);
            this.gbInput.TabIndex = 15;
            // 
            // tbIdBarang
            // 
            this.tbIdBarang.Location = new System.Drawing.Point(357, 162);
            this.tbIdBarang.Name = "tbIdBarang";
            this.tbIdBarang.Size = new System.Drawing.Size(28, 25);
            this.tbIdBarang.TabIndex = 9;
            this.tbIdBarang.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(524, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = " Harga Per Satuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(524, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Satuan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jumlah Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Expired Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kode Barang";
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.BackColor = System.Drawing.SystemColors.Control;
            this.roundedPanel6.Controls.Add(this.tbHargaSatuan);
            this.roundedPanel6.CornerRadius = 10;
            this.roundedPanel6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedPanel6.Location = new System.Drawing.Point(518, 248);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(310, 36);
            this.roundedPanel6.TabIndex = 2;
            // 
            // tbHargaSatuan
            // 
            this.tbHargaSatuan.BackColor = System.Drawing.SystemColors.Control;
            this.tbHargaSatuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHargaSatuan.Location = new System.Drawing.Point(11, 10);
            this.tbHargaSatuan.Name = "tbHargaSatuan";
            this.tbHargaSatuan.Size = new System.Drawing.Size(290, 21);
            this.tbHargaSatuan.TabIndex = 3;
            this.tbHargaSatuan.Enter += new System.EventHandler(this.tbHargaSatuan_Enter);
            this.tbHargaSatuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHargaSatuan_KeyPress);
            this.tbHargaSatuan.Leave += new System.EventHandler(this.tbHargaSatuan_Leave);
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.SystemColors.Control;
            this.roundedPanel5.Controls.Add(this.dtpExpired);
            this.roundedPanel5.CornerRadius = 10;
            this.roundedPanel5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedPanel5.Location = new System.Drawing.Point(29, 248);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(310, 36);
            this.roundedPanel5.TabIndex = 2;
            // 
            // dtpExpired
            // 
            this.dtpExpired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpired.Location = new System.Drawing.Point(9, 6);
            this.dtpExpired.Name = "dtpExpired";
            this.dtpExpired.Size = new System.Drawing.Size(292, 28);
            this.dtpExpired.TabIndex = 0;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.roundedPanel4.Controls.Add(this.cbSatuan);
            this.roundedPanel4.CornerRadius = 10;
            this.roundedPanel4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedPanel4.Location = new System.Drawing.Point(518, 155);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(310, 36);
            this.roundedPanel4.TabIndex = 2;
            // 
            // cbSatuan
            // 
            this.cbSatuan.BackColor = System.Drawing.SystemColors.Control;
            this.cbSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSatuan.FormattingEnabled = true;
            this.cbSatuan.Items.AddRange(new object[] {
            "Botol",
            "Lusin"});
            this.cbSatuan.Location = new System.Drawing.Point(9, 6);
            this.cbSatuan.Name = "cbSatuan";
            this.cbSatuan.Size = new System.Drawing.Size(298, 30);
            this.cbSatuan.TabIndex = 0;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.roundedPanel3.Controls.Add(this.tbNamaBarang);
            this.roundedPanel3.CornerRadius = 10;
            this.roundedPanel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedPanel3.Location = new System.Drawing.Point(29, 155);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(310, 36);
            this.roundedPanel3.TabIndex = 2;
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.BackColor = System.Drawing.SystemColors.Control;
            this.tbNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNamaBarang.Location = new System.Drawing.Point(10, 10);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(290, 21);
            this.tbNamaBarang.TabIndex = 1;
            this.tbNamaBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNamaBarang_KeyPress);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.roundedPanel2.Controls.Add(this.tbJumlahBarang);
            this.roundedPanel2.CornerRadius = 10;
            this.roundedPanel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedPanel2.Location = new System.Drawing.Point(518, 50);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(310, 36);
            this.roundedPanel2.TabIndex = 2;
            // 
            // tbJumlahBarang
            // 
            this.tbJumlahBarang.BackColor = System.Drawing.SystemColors.Control;
            this.tbJumlahBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbJumlahBarang.Location = new System.Drawing.Point(10, 8);
            this.tbJumlahBarang.Name = "tbJumlahBarang";
            this.tbJumlahBarang.Size = new System.Drawing.Size(290, 21);
            this.tbJumlahBarang.TabIndex = 5;
            this.tbJumlahBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJumlahBarang_KeyPress);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundedPanel1.Controls.Add(this.tbKodeBarang);
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedPanel1.Location = new System.Drawing.Point(29, 50);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(310, 36);
            this.roundedPanel1.TabIndex = 1;
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.BackColor = System.Drawing.SystemColors.Control;
            this.tbKodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKodeBarang.Location = new System.Drawing.Point(10, 9);
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.Size = new System.Drawing.Size(290, 21);
            this.tbKodeBarang.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBarang);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(4, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 201);
            this.panel2.TabIndex = 14;
            // 
            // dgvBarang
            // 
            this.dgvBarang.AllowUserToAddRows = false;
            this.dgvBarang.AllowUserToDeleteRows = false;
            this.dgvBarang.AllowUserToResizeColumns = false;
            this.dgvBarang.AllowUserToResizeRows = false;
            this.dgvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarang.BackgroundColor = System.Drawing.Color.White;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.kode,
            this.nama,
            this.expired,
            this.jumlah,
            this.satuan,
            this.harga});
            this.dgvBarang.GridColor = System.Drawing.Color.White;
            this.dgvBarang.Location = new System.Drawing.Point(11, 9);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowHeadersWidth = 51;
            this.dgvBarang.Size = new System.Drawing.Size(894, 179);
            this.dgvBarang.TabIndex = 12;
            this.dgvBarang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBarang_MouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID Barang";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // kode
            // 
            this.kode.HeaderText = "Kode Barang";
            this.kode.MinimumWidth = 6;
            this.kode.Name = "kode";
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama Barang";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            // 
            // expired
            // 
            this.expired.HeaderText = "Expired Date";
            this.expired.MinimumWidth = 6;
            this.expired.Name = "expired";
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.MinimumWidth = 6;
            this.jumlah.Name = "jumlah";
            // 
            // satuan
            // 
            this.satuan.HeaderText = "Satuan";
            this.satuan.MinimumWidth = 6;
            this.satuan.Name = "satuan";
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga Satuan";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tabel Stock Barang";
            // 
            // roundedPanel9
            // 
            this.roundedPanel9.BackColor = System.Drawing.SystemColors.Control;
            this.roundedPanel9.Controls.Add(this.tbSearch);
            this.roundedPanel9.Controls.Add(this.btnSearch);
            this.roundedPanel9.CornerRadius = 10;
            this.roundedPanel9.Location = new System.Drawing.Point(585, 463);
            this.roundedPanel9.Name = "roundedPanel9";
            this.roundedPanel9.Size = new System.Drawing.Size(310, 36);
            this.roundedPanel9.TabIndex = 3;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.Gray;
            this.tbSearch.Location = new System.Drawing.Point(12, 9);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(256, 22);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(274, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 31);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlDelete.Controls.Add(this.btnDelete);
            this.pnlDelete.CornerRadius = 10;
            this.pnlDelete.Location = new System.Drawing.Point(389, 374);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(154, 44);
            this.pnlDelete.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 44);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.CornerRadius = 10;
            this.pnlEdit.Location = new System.Drawing.Point(220, 374);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(154, 44);
            this.pnlEdit.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 44);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlInsert
            // 
            this.pnlInsert.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlInsert.Controls.Add(this.btnInsert);
            this.pnlInsert.CornerRadius = 10;
            this.pnlInsert.Location = new System.Drawing.Point(49, 374);
            this.pnlInsert.Name = "pnlInsert";
            this.pnlInsert.Size = new System.Drawing.Size(154, 44);
            this.pnlInsert.TabIndex = 9;
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(154, 44);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Tambah";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelola Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 50);
            this.label9.TabIndex = 1;
            this.label9.Text = "Gudang";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(134, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 83);
            this.label10.TabIndex = 2;
            this.label10.Text = "Kelola Barang";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedPanel7
            // 
            this.roundedPanel7.BackColor = System.Drawing.Color.SkyBlue;
            this.roundedPanel7.Controls.Add(this.btnLogout);
            this.roundedPanel7.CornerRadius = 10;
            this.roundedPanel7.Location = new System.Drawing.Point(91, 605);
            this.roundedPanel7.Name = "roundedPanel7";
            this.roundedPanel7.Size = new System.Drawing.Size(234, 44);
            this.roundedPanel7.TabIndex = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(3, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(228, 44);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmGudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roundedPanel7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGudang";
            this.Text = "frmGudang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGudang_FormClosed);
            this.Load += new System.EventHandler(this.frmGudang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCancel.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.roundedPanel6.ResumeLayout(false);
            this.roundedPanel6.PerformLayout();
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.roundedPanel9.ResumeLayout(false);
            this.roundedPanel9.PerformLayout();
            this.pnlDelete.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlInsert.ResumeLayout(false);
            this.roundedPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RoundedPanel roundedPanel6;
        private RoundedPanel roundedPanel5;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvBarang;
        private RoundedPanel roundedPanel9;
        private RoundedPanel pnlDelete;
        private System.Windows.Forms.Button btnDelete;
        private RoundedPanel pnlEdit;
        private System.Windows.Forms.Button btnEdit;
        private RoundedPanel pnlInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbHargaSatuan;
        private System.Windows.Forms.ComboBox cbSatuan;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.TextBox tbJumlahBarang;
        private System.Windows.Forms.TextBox tbKodeBarang;
        private System.Windows.Forms.DateTimePicker dtpExpired;
        private System.Windows.Forms.Panel gbInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn expired;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private RoundedPanel pnlCancel;
        private System.Windows.Forms.Button btnCancel;
        private RoundedPanel pnlSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbIdBarang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private RoundedPanel roundedPanel7;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}