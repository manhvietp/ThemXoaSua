namespace PRL
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
            dtgView_danhsach = new DataGridView();
            btn_xoa = new Button();
            btn_clear = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            rbtn_nu = new RadioButton();
            rbtn_nam = new RadioButton();
            cbx_diachi = new ComboBox();
            txt_timkiem = new TextBox();
            txt_ngaysinh = new TextBox();
            txt_hoten = new TextBox();
            txt_manv = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgView_danhsach).BeginInit();
            SuspendLayout();
            // 
            // dtgView_danhsach
            // 
            dtgView_danhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_danhsach.Location = new Point(55, 426);
            dtgView_danhsach.Name = "dtgView_danhsach";
            dtgView_danhsach.ReadOnly = true;
            dtgView_danhsach.RowHeadersWidth = 82;
            dtgView_danhsach.Size = new Size(1090, 300);
            dtgView_danhsach.TabIndex = 34;
            dtgView_danhsach.CellClick += dtgView_danhsach_CellClick;
            dtgView_danhsach.CellContentClick += dtgView_danhsach_CellContentClick;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(919, 242);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(226, 46);
            btn_xoa.TabIndex = 33;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(919, 312);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(226, 46);
            btn_clear.TabIndex = 32;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(919, 160);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(226, 46);
            btn_sua.TabIndex = 31;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(919, 72);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(226, 46);
            btn_them.TabIndex = 30;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // rbtn_nu
            // 
            rbtn_nu.AutoSize = true;
            rbtn_nu.Location = new Point(424, 236);
            rbtn_nu.Name = "rbtn_nu";
            rbtn_nu.Size = new Size(77, 36);
            rbtn_nu.TabIndex = 29;
            rbtn_nu.TabStop = true;
            rbtn_nu.Text = "Nữ";
            rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_nam
            // 
            rbtn_nam.AutoSize = true;
            rbtn_nam.Location = new Point(247, 236);
            rbtn_nam.Name = "rbtn_nam";
            rbtn_nam.Size = new Size(96, 36);
            rbtn_nam.TabIndex = 28;
            rbtn_nam.TabStop = true;
            rbtn_nam.Text = "Nam";
            rbtn_nam.UseVisualStyleBackColor = true;
            rbtn_nam.CheckedChanged += rbtn_nam_CheckedChanged;
            // 
            // cbx_diachi
            // 
            cbx_diachi.FormattingEnabled = true;
            cbx_diachi.Location = new Point(247, 278);
            cbx_diachi.Name = "cbx_diachi";
            cbx_diachi.Size = new Size(492, 40);
            cbx_diachi.TabIndex = 27;
            cbx_diachi.SelectedIndexChanged += cbx_diachi_SelectedIndexChanged;
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(247, 347);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(492, 39);
            txt_timkiem.TabIndex = 26;
            txt_timkiem.TextChanged += txt_timkiem_TextChanged;
            // 
            // txt_ngaysinh
            // 
            txt_ngaysinh.Location = new Point(247, 162);
            txt_ngaysinh.Name = "txt_ngaysinh";
            txt_ngaysinh.Size = new Size(492, 39);
            txt_ngaysinh.TabIndex = 25;
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(247, 102);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(492, 39);
            txt_hoten.TabIndex = 24;
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(247, 43);
            txt_manv.Name = "txt_manv";
            txt_manv.Size = new Size(492, 39);
            txt_manv.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 354);
            label6.Name = "label6";
            label6.Size = new Size(113, 32);
            label6.TabIndex = 22;
            label6.Text = "Tìm kiếm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 286);
            label5.Name = "label5";
            label5.Size = new Size(87, 32);
            label5.TabIndex = 21;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 229);
            label4.Name = "label4";
            label4.Size = new Size(105, 32);
            label4.TabIndex = 20;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 169);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 19;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 109);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 18;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 50);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 17;
            label1.Text = "Mã NV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 765);
            Controls.Add(dtgView_danhsach);
            Controls.Add(btn_xoa);
            Controls.Add(btn_clear);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(rbtn_nu);
            Controls.Add(rbtn_nam);
            Controls.Add(cbx_diachi);
            Controls.Add(txt_timkiem);
            Controls.Add(txt_ngaysinh);
            Controls.Add(txt_hoten);
            Controls.Add(txt_manv);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgView_danhsach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgView_danhsach;
        private Button btn_xoa;
        private Button btn_clear;
        private Button btn_sua;
        private Button btn_them;
        private RadioButton rbtn_nu;
        private RadioButton rbtn_nam;
        private ComboBox cbx_diachi;
        private TextBox txt_timkiem;
        private TextBox txt_ngaysinh;
        private TextBox txt_hoten;
        private TextBox txt_manv;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
