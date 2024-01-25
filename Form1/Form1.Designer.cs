namespace Form1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.gvHsinh = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvHsinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHoVaTen.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHoVaTen.Location = new System.Drawing.Point(51, 54);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(82, 22);
            this.lblHoVaTen.TabIndex = 0;
            this.lblHoVaTen.Text = "Ho va Ten";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(269, 54);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(250, 27);
            this.txtHoVaTen.TabIndex = 1;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Location = new System.Drawing.Point(269, 153);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(250, 27);
            this.dtNgaysinh.TabIndex = 2;
            this.dtNgaysinh.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgaysinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(106, 401);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gvHsinh
            // 
            this.gvHsinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvHsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHsinh.Location = new System.Drawing.Point(629, 36);
            this.gvHsinh.Name = "gvHsinh";
            this.gvHsinh.RowHeadersWidth = 51;
            this.gvHsinh.RowTemplate.Height = 29;
            this.gvHsinh.Size = new System.Drawing.Size(517, 394);
            this.gvHsinh.TabIndex = 4;
            this.gvHsinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHsinh_CellContentClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(257, 401);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(425, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Sua";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(269, 87);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 27);
            this.txtDiaChi.TabIndex = 8;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDiaChi.Location = new System.Drawing.Point(51, 92);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(61, 22);
            this.lblDiaChi.TabIndex = 7;
            this.lblDiaChi.Text = "Dia chi";
            this.lblDiaChi.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(269, 120);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(250, 27);
            this.txtCMND.TabIndex = 10;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBirth.Location = new System.Drawing.Point(51, 158);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(163, 20);
            this.lblBirth.TabIndex = 11;
            this.lblBirth.Text = "Ngay thang nam sinh";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCMND.Location = new System.Drawing.Point(51, 127);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(55, 20);
            this.lblCMND.TabIndex = 9;
            this.lblCMND.Text = "CMND";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(348, 490);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(94, 29);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Giao vien";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(186, 493);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tim kiem";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(269, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 27);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(51, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 22);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(269, 243);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(250, 27);
            this.txtID.TabIndex = 17;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(51, 243);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 22);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(269, 281);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 27);
            this.txtPhone.TabIndex = 19;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(51, 281);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 22);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(50, 331);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 22);
            this.lblGender.TabIndex = 20;
            this.lblGender.Text = "Gender";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(269, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 43);
            this.panel1.TabIndex = 21;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(133, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1158, 685);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gvHsinh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtNgaysinh);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.lblHoVaTen);
            this.Name = "Form1";
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHsinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHoVaTen;
        private TextBox txtHoVaTen;
        private DateTimePicker dtNgaysinh;
        private Button btnThem;
        private DataGridView gvHsinh;
        private Button btnXoa;
        private Button btnUpdate;
        private TextBox txtDiaChi;
        private Label lblDiaChi;
        private TextBox txtCMND;
        private Label lblBirth;
        private Label lblCMND;
        private Button btnFind;
        private Button btnSearch;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtID;
        private Label lblID;
        private TextBox txtPhone;
        private Label lblPhone;
        private Label lblGender;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}