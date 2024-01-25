namespace Form1
{
    partial class Form2
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
            this.lblBirth = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gvGiaoVien = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBirth.Location = new System.Drawing.Point(235, 274);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(163, 20);
            this.lblBirth.TabIndex = 23;
            this.lblBirth.Text = "Ngay thang nam sinh";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(453, 192);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(250, 27);
            this.txtCMND.TabIndex = 22;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCMND.Location = new System.Drawing.Point(235, 192);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(55, 20);
            this.lblCMND.TabIndex = 21;
            this.lblCMND.Text = "CMND";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(453, 116);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 27);
            this.txtDiaChi.TabIndex = 20;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDiaChi.Location = new System.Drawing.Point(235, 116);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(61, 22);
            this.lblDiaChi.TabIndex = 19;
            this.lblDiaChi.Text = "Dia chi";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(609, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Sua";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(441, 393);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gvGiaoVien
            // 
            this.gvGiaoVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGiaoVien.Location = new System.Drawing.Point(813, 28);
            this.gvGiaoVien.Name = "gvGiaoVien";
            this.gvGiaoVien.RowHeadersWidth = 51;
            this.gvGiaoVien.RowTemplate.Height = 29;
            this.gvGiaoVien.Size = new System.Drawing.Size(517, 394);
            this.gvGiaoVien.TabIndex = 16;
            this.gvGiaoVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvGiaoVien_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(290, 393);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Location = new System.Drawing.Point(453, 274);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(250, 27);
            this.dtNgaysinh.TabIndex = 14;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(453, 46);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(250, 27);
            this.txtHoVaTen.TabIndex = 13;
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHoVaTen.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHoVaTen.Location = new System.Drawing.Point(235, 46);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(82, 22);
            this.lblHoVaTen.TabIndex = 12;
            this.lblHoVaTen.Text = "Ho va Ten";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 450);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gvGiaoVien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtNgaysinh);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.lblHoVaTen);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBirth;
        private TextBox txtCMND;
        private Label lblCMND;
        private TextBox txtDiaChi;
        private Label lblDiaChi;
        private Button btnUpdate;
        private Button btnXoa;
        private DataGridView gvGiaoVien;
        private Button btnThem;
        private DateTimePicker dtNgaysinh;
        private TextBox txtHoVaTen;
        private Label lblHoVaTen;
    }
}