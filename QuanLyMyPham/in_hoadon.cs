﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleTables;
namespace QuanLyMyPham
{   
    
    public partial class in_hoadon : Form
    {
        private int id_hoadon;
        private int tongtien;
        private DateTime date;
        public in_hoadon()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public in_hoadon(int id_hoadon , int tongtien,DateTime date)
        {
            InitializeComponent();
            this.id_hoadon = id_hoadon;
            this.tongtien = tongtien;
            this.date = date;
        }

        void get_data()
        {
            label_iD.Text = "" + id_hoadon;
            label_tongtien.Text =  tongtien + "VND";
            label_ngaythang.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void in_hoadon_Load(object sender, EventArgs e)
        {
            get_data();
            getdanhsach();
        }

        void getdanhsach()
        {
            try
            {
                string query = string.Format("SELECT cthd.ID_hoadon , cthd.ID_SanPham , sp.TenSanPham , " +
                                            "sp.GiaBan,sp.GiamGia,cthd.SoLuong , " +
                                            "SUM((sp.GiaBan - (sp.GiaBan *(sp.GiamGia / 100))) * cthd.SoLuong) AS TongTien " +
                                            "FROM chitiethoadon cthd, SanPham sp " +
                                            "where cthd.ID_SanPham = sp.ID_SanPham and ID_HoaDon = '{0}' " +
                                            "GROUP BY cthd.ID_HoaDon, cthd.ID_SanPham,sp.TenSanPham , sp.GiaBan,sp.GiamGia,cthd.SoLuong", id_hoadon);
                DataSet ds = kn.selectData(query);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    txt_chitietsanpham.Text += string.Format(
                        "\nSản phẩm: {0,-25} | Gia: {1,-10} | Giảm giá: {2,-10}% | Số lượng: {3,-10} | Tổng: {4,-10} VND\n",
                        row["TenSanPham"].ToString(),
                        row["GiaBan"].ToString(),
                        row["GiamGia"].ToString(),
                        row["SoLuong"].ToString(),
                        row["TongTien"].ToString()
                    );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi" + ex.Message);
            }
        }

        private void label_ngaythang_Click(object sender, EventArgs e)
        {

        }

        private void label_iD_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_tongtien_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_chitietsanpham_Click(object sender, EventArgs e)
        {

        }
    }
}
