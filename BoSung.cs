using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra
{
    public partial class BoSung : Form
    {
        string flag;
        public BoSung()
        {
            InitializeComponent();
        }

        private void BoSung_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
            quanLySinhVien.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (checkData())
            {
                QuanLySinhVien sv = new QuanLySinhVien();
                

               
               
                DialogResult result;
                result = MessageBox.Show("THÊM DỮ LIỆU THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    this.Close();
                    QuanLySinhVien frm = new QuanLySinhVien();
                    frm.Show();
                }
            }
        
        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbName.Focus();
                return false;

            }
            if (string.IsNullOrWhiteSpace(tbNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNgaySinh.Focus();
                return false;
            }
            return true;
        }
    }
}
