﻿
namespace LKSProvFullSoft
{
    partial class frmAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.pnlUser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbInput = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namauser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telepon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundedPanel3 = new LKSProvFullSoft.RoundedPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.roundedPanel2 = new LKSProvFullSoft.RoundedPanel();
            this.btnUser = new System.Windows.Forms.Button();
            this.roundedPanel1 = new LKSProvFullSoft.RoundedPanel();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlCancel = new LKSProvFullSoft.RoundedPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSave = new LKSProvFullSoft.RoundedPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlPassword = new LKSProvFullSoft.RoundedPanel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pnlTelp = new LKSProvFullSoft.RoundedPanel();
            this.tbTelepon = new System.Windows.Forms.TextBox();
            this.pnlUsername = new LKSProvFullSoft.RoundedPanel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.pnlNama = new LKSProvFullSoft.RoundedPanel();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.pnlAlamat = new LKSProvFullSoft.RoundedPanel();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.pnlTipeUser = new LKSProvFullSoft.RoundedPanel();
            this.cbTipeUser = new System.Windows.Forms.ComboBox();
            this.pnlTelepon = new LKSProvFullSoft.RoundedPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnlDelete = new LKSProvFullSoft.RoundedPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlEdit = new LKSProvFullSoft.RoundedPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlInsert = new LKSProvFullSoft.RoundedPanel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.gbInput.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlTelp.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            this.pnlNama.SuspendLayout();
            this.pnlAlamat.SuspendLayout();
            this.pnlTipeUser.SuspendLayout();
            this.pnlTelepon.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.pnlInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.White;
            this.pnlUser.Controls.Add(this.pnlCancel);
            this.pnlUser.Controls.Add(this.pnlSave);
            this.pnlUser.Controls.Add(this.gbInput);
            this.pnlUser.Controls.Add(this.dgvUser);
            this.pnlUser.Controls.Add(this.pnlTelepon);
            this.pnlUser.Controls.Add(this.pnlDelete);
            this.pnlUser.Controls.Add(this.label2);
            this.pnlUser.Controls.Add(this.pnlEdit);
            this.pnlUser.Controls.Add(this.pnlInsert);
            this.pnlUser.Location = new System.Drawing.Point(374, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(894, 687);
            this.pnlUser.TabIndex = 0;
            this.pnlUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUser_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeColumns = false;
            this.dgvUser.AllowUserToResizeRows = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipeuser,
            this.namauser,
            this.alamat,
            this.telepon});
            this.dgvUser.GridColor = System.Drawing.Color.Black;
            this.dgvUser.Location = new System.Drawing.Point(32, 516);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(814, 134);
            this.dgvUser.TabIndex = 1;
            this.dgvUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvUser_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kelola User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipe User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telepon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(693, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(664, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(671, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "Password";
            // 
            // gbInput
            // 
            this.gbInput.BackColor = System.Drawing.Color.Transparent;
            this.gbInput.Controls.Add(this.pnlPassword);
            this.gbInput.Controls.Add(this.label8);
            this.gbInput.Controls.Add(this.label7);
            this.gbInput.Controls.Add(this.label6);
            this.gbInput.Controls.Add(this.label5);
            this.gbInput.Controls.Add(this.label4);
            this.gbInput.Controls.Add(this.label3);
            this.gbInput.Controls.Add(this.pnlTelp);
            this.gbInput.Controls.Add(this.pnlUsername);
            this.gbInput.Controls.Add(this.pnlNama);
            this.gbInput.Controls.Add(this.pnlAlamat);
            this.gbInput.Controls.Add(this.pnlTipeUser);
            this.gbInput.Location = new System.Drawing.Point(32, 41);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(814, 332);
            this.gbInput.TabIndex = 3;
            // 
            // id
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.DefaultCellStyle = dataGridViewCellStyle8;
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // tipeuser
            // 
            this.tipeuser.HeaderText = "Tipe User";
            this.tipeuser.MinimumWidth = 6;
            this.tipeuser.Name = "tipeuser";
            this.tipeuser.ReadOnly = true;
            // 
            // namauser
            // 
            this.namauser.HeaderText = "Nama User";
            this.namauser.MinimumWidth = 6;
            this.namauser.Name = "namauser";
            this.namauser.ReadOnly = true;
            // 
            // alamat
            // 
            this.alamat.HeaderText = "Alamat";
            this.alamat.MinimumWidth = 6;
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            // 
            // telepon
            // 
            this.telepon.HeaderText = "Telepon";
            this.telepon.MinimumWidth = 6;
            this.telepon.Name = "telepon";
            this.telepon.ReadOnly = true;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.SkyBlue;
            this.roundedPanel3.Controls.Add(this.btnLogout);
            this.roundedPanel3.CornerRadius = 10;
            this.roundedPanel3.Location = new System.Drawing.Point(69, 525);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(237, 47);
            this.roundedPanel3.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(237, 47);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.SkyBlue;
            this.roundedPanel2.Controls.Add(this.btnUser);
            this.roundedPanel2.CornerRadius = 10;
            this.roundedPanel2.Location = new System.Drawing.Point(69, 394);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(237, 47);
            this.roundedPanel2.TabIndex = 4;
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(237, 47);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Kelola User";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.roundedPanel1.Controls.Add(this.btnReport);
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.Location = new System.Drawing.Point(69, 458);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(237, 47);
            this.roundedPanel1.TabIndex = 4;
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(0, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(237, 47);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Kelola Laporan";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // pnlCancel
            // 
            this.pnlCancel.BackColor = System.Drawing.Color.Crimson;
            this.pnlCancel.Controls.Add(this.btnCancel);
            this.pnlCancel.CornerRadius = 10;
            this.pnlCancel.Location = new System.Drawing.Point(260, 380);
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Size = new System.Drawing.Size(154, 43);
            this.pnlCancel.TabIndex = 2;
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
            this.pnlSave.BackColor = System.Drawing.Color.SpringGreen;
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.CornerRadius = 10;
            this.pnlSave.Location = new System.Drawing.Point(68, 379);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(153, 44);
            this.pnlSave.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPassword.Controls.Add(this.tbPassword);
            this.pnlPassword.CornerRadius = 10;
            this.pnlPassword.Location = new System.Drawing.Point(497, 267);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(297, 49);
            this.pnlPassword.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(3, 12);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(292, 26);
            this.tbPassword.TabIndex = 0;
            // 
            // pnlTelp
            // 
            this.pnlTelp.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTelp.Controls.Add(this.tbTelepon);
            this.pnlTelp.CornerRadius = 10;
            this.pnlTelp.Location = new System.Drawing.Point(33, 267);
            this.pnlTelp.Name = "pnlTelp";
            this.pnlTelp.Size = new System.Drawing.Size(297, 49);
            this.pnlTelp.TabIndex = 0;
            // 
            // tbTelepon
            // 
            this.tbTelepon.BackColor = System.Drawing.SystemColors.Control;
            this.tbTelepon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTelepon.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelepon.Location = new System.Drawing.Point(4, 12);
            this.tbTelepon.Name = "tbTelepon";
            this.tbTelepon.Size = new System.Drawing.Size(290, 26);
            this.tbTelepon.TabIndex = 2;
            this.tbTelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelepon_KeyPress);
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUsername.Controls.Add(this.tbUsername);
            this.pnlUsername.CornerRadius = 10;
            this.pnlUsername.Location = new System.Drawing.Point(497, 154);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(297, 49);
            this.pnlUsername.TabIndex = 0;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(3, 12);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(292, 26);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsername_KeyPress);
            // 
            // pnlNama
            // 
            this.pnlNama.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNama.Controls.Add(this.tbNama);
            this.pnlNama.CornerRadius = 10;
            this.pnlNama.Location = new System.Drawing.Point(33, 154);
            this.pnlNama.Name = "pnlNama";
            this.pnlNama.Size = new System.Drawing.Size(297, 49);
            this.pnlNama.TabIndex = 0;
            // 
            // tbNama
            // 
            this.tbNama.BackColor = System.Drawing.SystemColors.Control;
            this.tbNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNama.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(4, 11);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(291, 26);
            this.tbNama.TabIndex = 0;
            this.tbNama.Text = "Nama";
            this.tbNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNama_KeyPress);
            // 
            // pnlAlamat
            // 
            this.pnlAlamat.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAlamat.Controls.Add(this.tbAlamat);
            this.pnlAlamat.CornerRadius = 10;
            this.pnlAlamat.Location = new System.Drawing.Point(497, 47);
            this.pnlAlamat.Name = "pnlAlamat";
            this.pnlAlamat.Size = new System.Drawing.Size(297, 49);
            this.pnlAlamat.TabIndex = 0;
            // 
            // tbAlamat
            // 
            this.tbAlamat.BackColor = System.Drawing.SystemColors.Control;
            this.tbAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAlamat.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlamat.Location = new System.Drawing.Point(3, 11);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(291, 26);
            this.tbAlamat.TabIndex = 0;
            // 
            // pnlTipeUser
            // 
            this.pnlTipeUser.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTipeUser.Controls.Add(this.cbTipeUser);
            this.pnlTipeUser.CornerRadius = 10;
            this.pnlTipeUser.Location = new System.Drawing.Point(33, 47);
            this.pnlTipeUser.Name = "pnlTipeUser";
            this.pnlTipeUser.Size = new System.Drawing.Size(297, 49);
            this.pnlTipeUser.TabIndex = 0;
            // 
            // cbTipeUser
            // 
            this.cbTipeUser.BackColor = System.Drawing.SystemColors.Control;
            this.cbTipeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipeUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipeUser.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbTipeUser.FormattingEnabled = true;
            this.cbTipeUser.IntegralHeight = false;
            this.cbTipeUser.Items.AddRange(new object[] {
            "Gudang",
            "Kasir"});
            this.cbTipeUser.Location = new System.Drawing.Point(3, 8);
            this.cbTipeUser.Name = "cbTipeUser";
            this.cbTipeUser.Size = new System.Drawing.Size(288, 35);
            this.cbTipeUser.TabIndex = 0;
            // 
            // pnlTelepon
            // 
            this.pnlTelepon.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTelepon.Controls.Add(this.button1);
            this.pnlTelepon.Controls.Add(this.tbSearch);
            this.pnlTelepon.CornerRadius = 10;
            this.pnlTelepon.Location = new System.Drawing.Point(66, 440);
            this.pnlTelepon.Name = "pnlTelepon";
            this.pnlTelepon.Size = new System.Drawing.Size(297, 49);
            this.pnlTelepon.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(249, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 34);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(10, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(236, 26);
            this.tbSearch.TabIndex = 0;
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlDelete.Controls.Add(this.btnDelete);
            this.pnlDelete.CornerRadius = 10;
            this.pnlDelete.Location = new System.Drawing.Point(420, 379);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(154, 44);
            this.pnlDelete.TabIndex = 0;
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
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.CornerRadius = 10;
            this.pnlEdit.Location = new System.Drawing.Point(238, 379);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(154, 44);
            this.pnlEdit.TabIndex = 0;
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
            this.pnlInsert.Location = new System.Drawing.Point(55, 379);
            this.pnlInsert.Name = "pnlInsert";
            this.pnlInsert.Size = new System.Drawing.Size(154, 44);
            this.pnlInsert.TabIndex = 0;
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
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlUser);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.pnlCancel.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlTelp.ResumeLayout(false);
            this.pnlTelp.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlNama.ResumeLayout(false);
            this.pnlNama.PerformLayout();
            this.pnlAlamat.ResumeLayout(false);
            this.pnlAlamat.PerformLayout();
            this.pnlTipeUser.ResumeLayout(false);
            this.pnlTelepon.ResumeLayout(false);
            this.pnlTelepon.PerformLayout();
            this.pnlDelete.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlInsert.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel3;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnLogout;
        private RoundedPanel pnlTelepon;
        private RoundedPanel pnlPassword;
        private RoundedPanel pnlDelete;
        private RoundedPanel pnlEdit;
        private RoundedPanel pnlInsert;
        private RoundedPanel pnlTelp;
        private RoundedPanel pnlUsername;
        private RoundedPanel pnlNama;
        private RoundedPanel pnlAlamat;
        private RoundedPanel pnlTipeUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.ComboBox cbTipeUser;
        private System.Windows.Forms.Panel gbInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn namauser;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn telepon;
        private System.Windows.Forms.TextBox tbTelepon;
        private System.Windows.Forms.Button button1;
        private RoundedPanel pnlCancel;
        private System.Windows.Forms.Button btnCancel;
        private RoundedPanel pnlSave;
        private System.Windows.Forms.Button btnSave;
    }
}