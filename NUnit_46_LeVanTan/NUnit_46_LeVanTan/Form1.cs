using System;
using System.Windows.Forms;

namespace NUnit_46_LeVanTan
{
    public partial class NUnit_46_Chuoi : Form
    {
        public NUnit_46_Chuoi()
        {
            InitializeComponent();
        }

        private void NUnit_46_Chuoi_Load(object sender, EventArgs e)
        {
        }

        private void txtString1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGhepChuoi_Click(object sender, EventArgs e)
        {
            string ketqua;
            string str1 = txtString1.Text;
            string str2 = txtString2.Text;
            NUnit46_Chuoi c = new NUnit46_Chuoi(str1, str2);
            ketqua = c.Execute_46_Tan("Ghep");
            txt_GhepChuoi_46_Tan.Text = ketqua.ToString();
        }

        //Cat so phan tu muon lay
        private void btnCatChuoi_Click(object sender, EventArgs e)
        {
            string ketqua;
            string str1 = txtString1.Text;
            string str2 = txtString2.Text;
            NUnit46_Chuoi c = new NUnit46_Chuoi(str1, str2);
            ketqua = c.Execute_46_Tan("Cat");
            txt_CatChuoi_46_Tan.Text = ketqua.ToString();
        }

        private void btnVietHoa_Click(object sender, EventArgs e)
        {
            string ketqua;
            string str1 = txtString1.Text;
            string str2 = txtString2.Text;
            NUnit46_Chuoi c = new NUnit46_Chuoi(str1, null);
            ketqua = c.Execute_46_Tan("Hoa");
            txt_VietHoa_46_Tan.Text = ketqua.ToString();
        }

        private void btnVietThuong_Click(object sender, EventArgs e)
        {
            string ketqua;
            string str1 = txtString1.Text;
            string str2 = txtString2.Text;
            NUnit46_Chuoi c = new NUnit46_Chuoi(str1, null);
            ketqua = c.Execute_46_Tan("Thuong");
            txt_VietThuong_46_Tan.Text = ketqua.ToString();
        }

        private void btnXoaKhoangTrang_Click(object sender, EventArgs e)
        {
            string ketqua;
            string str1 = txtString1.Text;
            NUnit46_Chuoi c = new NUnit46_Chuoi(str1, null);
            ketqua = c.Execute_46_Tan("KhoangTrang");
            txt_XoaKhoangTrang_46_Tan.Text = ketqua.ToString();
        }

        private void btnLaySo_Click(object sender, EventArgs e)
        {
            string ketqua;
            string str1 = txtString1.Text;
            NUnit46_Chuoi c = new NUnit46_Chuoi(str1, null);
            ketqua = c.Execute_46_Tan("LaySo");
            txt_LaySo_46_Tan.Text = ketqua.ToString();
        }

        private void btnDaoChuoi_Click(object sender, EventArgs e)
        {
            string ketqua;
            string str1 = txtString1.Text;
            NUnit46_Chuoi c = new NUnit46_Chuoi(str1, null);
            ketqua = c.Execute_46_Tan("DaoChuoi");
            txt_DaoChuoi_46_Tan.Text = ketqua.ToString();
        }

        private void KetQua_46_Tan_Click(object sender, EventArgs e)
        {
   
            string str1 = txtString1.Text;
            string str2 = txtString2.Text;
            NUnit46_Chuoi c = new NUnit46_Chuoi(str1, str2);

            //Ghep chuoi
            string ghepchuoi_46_Tan;
            ghepchuoi_46_Tan = c.Execute_46_Tan("Ghep");
            txt_GhepChuoi_46_Tan.Text = ghepchuoi_46_Tan.ToString();

            //Cat chuoi
            string catchuoi_46_Tan;
            catchuoi_46_Tan = c.Execute_46_Tan("Cat");
            txt_CatChuoi_46_Tan.Text = catchuoi_46_Tan.ToString();

            //Xoa khoang trang
            string xoakhoangtrang_46_Tan;
            xoakhoangtrang_46_Tan = c.Execute_46_Tan("KhoangTrang");
            txt_XoaKhoangTrang_46_Tan.Text = xoakhoangtrang_46_Tan.ToString();

            //Dao chuoi
            string daochuoi_46_Tan;
            daochuoi_46_Tan = c.Execute_46_Tan("DaoChuoi");
            txt_DaoChuoi_46_Tan.Text = daochuoi_46_Tan.ToString();

            //Viet thuong
            string vietthuong_46_Tan;
            vietthuong_46_Tan = c.Execute_46_Tan("Thuong");
            txt_VietThuong_46_Tan.Text = vietthuong_46_Tan.ToString();

            //Viet hoa
            string viethoa_46_Tan;
            viethoa_46_Tan = c.Execute_46_Tan("Hoa");
            txt_VietHoa_46_Tan.Text = viethoa_46_Tan.ToString();

            //Lay so
            string layso_46_Tan;
            layso_46_Tan = c.Execute_46_Tan("LaySo");
            txt_LaySo_46_Tan.Text = layso_46_Tan.ToString();
        }

        private void ketqua_Click(object sender, EventArgs e)
        {
        }
    }
}