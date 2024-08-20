using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMyPham
{
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();
        void getdata()
        {
            try
            {
                string query = "select * from chitiethoadon";
                DataSet ds = kn.selectData(query);
                dgv_chitiethoadon.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi " + ex.Message);
            }
        }

        void getdata_hoadon()
        {
            try
            {
                string query = "select * from hoadon";
                DataSet ds = kn.selectData(query);
                cbx_hoadon.DataSource = ds.Tables[0];
                cbx_hoadon.DisplayMember = "ID_hoadon";
                cbx_hoadon.ValueMember = "ID_hoadon";
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi " + ex.Message);
            }
        }
        void getdata_sanpham()
        {
            try
            {
                string query = "select * from sanpham";
                DataSet ds = kn.selectData(query);
                cbx_sanpham.DataSource = ds.Tables[0];
                cbx_sanpham.DisplayMember = "ID_sanpham";
                cbx_sanpham.ValueMember = "ID_sanpham";
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi " + ex.Message);
            }
        }

        void update_soluong()
        {
            try
            {
                string updateQuery = @"UPDATE SanPham SET Soluong = 
                                        COALESCE((
                                            SELECT COALESCE(SUM(soluong), 0)
                                            FROM ChiTietPhieuNhap 
                                            WHERE ChiTietPhieuNhap.ID_SanPham = SanPham.ID_SanPham), 0) - 
                                        COALESCE((
                                            SELECT COALESCE(SUM(soluong), 0)
                                            FROM ChiTietHoaDon 
                                            WHERE ChiTietHoaDon.ID_SanPham = SanPham.ID_SanPham), 0)";
                bool kt1 = kn.thucthi(updateQuery);
                if (kt1 == false)
                {
                    MessageBox.Show("Cập nhật số lượng lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi " + ex.Message);
            }
        }

        void update_hoadon()
        {
            try
            {
                string tongtien_hoadon = "UPDATE HoaDon SET TongTien = " +
                                           "(SELECT SUM(SoLuong* (GiaBan -GiaBan * (GiamGia / 100)))" +
                                           "FROM ChiTietHoaDon WHERE ChiTietHoaDon.ID_HoaDon = HoaDon.ID_HoaDon)";
                bool kt = kn.thucthi(tongtien_hoadon);
                if (kt == false)
                {
                    MessageBox.Show("Cập nhật tổng tiền lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.Message);
            }
        }

        void getclear()
        {
            cbx_hoadon.Text = "";
            cbx_sanpham.Text = "";
            txt_giaban.Text = "";
            txt_Giamgia.Text = "";
            txt_soluong.Text = "";
            txt_timkiem.Text = "";
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }
       
        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            getdata();
            getdata_hoadon();
            getdata_sanpham();
            getclear();
            txt_giaban.Enabled = false;
            txt_Giamgia.Enabled = false;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon frm = new HoaDon();
            frm.ShowDialog();
            this.Close();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietHoaDon frm = new ChiTietHoaDon();
            frm.ShowDialog();
            this.Close();
        }

        private void dgv_chitiethoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home frm = new Home();
            frm.ShowDialog();
            this.Close();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham frm = new SanPham();
            frm.ShowDialog();
            this.Close();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaiKhoan frm = new TaiKhoan();
            frm.ShowDialog();
            this.Close();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon frm = new HoaDon();
            frm.ShowDialog();
            this.Close();
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaCungCap frm = new NhaCungCap();
            frm.ShowDialog();
            this.Close();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe frm = new ThongKe();
            frm.ShowDialog();
            this.Close();
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuNhap frm = new PhieuNhap();
            frm.ShowDialog();
            this.Close();
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap frm = new DangNhap();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }
    }
}
