using BUS.service;
using DAL.DomainClass;

namespace PRL
{
    public partial class Form1 : Form
    {
        private NhanVienService service;
        string idWhenClick;
        public Form1()
        {
            InitializeComponent();
            service = new NhanVienService();
            loadGrid();
            settingCombox();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.HoTen = txt_hoten.Text;
            nv.MaNv = txt_manv.Text;
            nv.NgaySinh = DateOnly.Parse(txt_ngaysinh.Text);
            nv.Diachi = cbx_diachi.Text;
            if (rbtn_nam.Checked)
            {
                nv.GioiTinh = "Nam";
            }
            else nv.GioiTinh = "Nu";
            MessageBox.Show(service.ThemNV(nv));
            loadGrid();
        }

        private void dtgView_danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= service.GetNhanViens(txt_timkiem.Text).Count())
            {
                return;
            }
            //////B2: l?y d? li?u c?a cell ch?a id ??i t??ng t? dòng ?ó
            idWhenClick = dtgView_danhsach.Rows[rowIndex].Cells[0].Value.ToString();
            FillData();
        }

        public void FillData()
        {
            var nv = service.GetNhanViens(txt_timkiem.Text).Find(x => x.MaNv == idWhenClick);
            txt_hoten.Text = nv.HoTen;
            txt_manv.Text = nv.MaNv;
            txt_ngaysinh.Text = nv.NgaySinh.ToString();
            cbx_diachi.Text = nv.Diachi;
            if (rbtn_nam.Checked == true)
            {
                rbtn_nam.Checked = true;
            }
            else
            {
                rbtn_nu.Checked = true;
            }
        }

        public void loadGrid()
        {
            dtgView_danhsach.ColumnCount = 5;
            dtgView_danhsach.Columns[0].Name = "Ma NV";
            dtgView_danhsach.Columns[1].Name = "Ho ten";
            dtgView_danhsach.Columns[2].Name = "Ngay sinh";
            dtgView_danhsach.Columns[3].Name = "Gioi tinh";
            dtgView_danhsach.Columns[4].Name = "Dia chi";
            dtgView_danhsach.Rows.Clear();
            foreach (var nv in service.GetNhanViens(txt_timkiem.Text))
            {
                dtgView_danhsach.Rows.Add(nv.MaNv, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.Diachi);
            }
        }
        private void dtgView_danhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        public void settingCombox()
        {
            cbx_diachi.Items.Add("ND");
            cbx_diachi.Items.Add("HN");
            cbx_diachi.Items.Add("HP");
        }
        private void cbx_diachi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //vì t?t c? ??i t??ng v? track=> không th? t?o nhân viên
            //mói trùng mã r?i update ???c
            //=> ??i gì thì ??i,không ??i mã
            var clone = service.GetNhanViens(txt_timkiem.Text).Find(x => x.MaNv == idWhenClick);
            clone.HoTen = txt_hoten.Text;
            clone.MaNv = txt_manv.Text;
            clone.NgaySinh = DateOnly.Parse(txt_ngaysinh.Text);
            clone.Diachi = cbx_diachi.Text;
            if (rbtn_nam.Checked)
            {
                clone.GioiTinh = "Nam";
            }
            else clone.GioiTinh = "Nu";
            MessageBox.Show(service.update_NV(clone));
            loadGrid();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string ma = txt_manv.Text;
            var luaChon = MessageBox.Show("Ban co chac chan xoa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (luaChon == DialogResult.Yes)
            {
                MessageBox.Show(service.XoaNV(ma));
            }

            loadGrid();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_manv.Clear();
            txt_hoten.Clear();
            txt_ngaysinh.Clear();
            rbtn_nam.Checked = false;
            rbtn_nu.Checked = false;
            cbx_diachi.Text = "";

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void rbtn_nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtn_nam.Checked = true;
        
        }
    }
}
