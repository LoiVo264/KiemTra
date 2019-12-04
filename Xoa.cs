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
    public partial class Xoa : Form
    {
        public Xoa()
        {
            InitializeComponent();
        }

        private void Xoa_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Ketnoi.str;
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select *from SinhViens", con);
            DataTable tb = new DataTable();
            da.Fill(tb);
            listViewSinhVien.Items.Clear();
            listViewSinhVien.View = View.Details;

            listViewSinhVien.Columns.Add("Msv");
            listViewSinhVien.Columns.Add("Name");
            listViewSinhVien.Columns.Add("DateOfBirth");
            listViewSinhVien.Columns.Add("Gender");
            listViewSinhVien.Columns.Add("MaLop");
            listViewSinhVien.GridLines = true;
            listViewSinhVien.FullRowSelect = true;

            for (int i = 0; i < tb.Rows.Count; i++)

            {
                ListViewItem item = new ListViewItem(tb.Rows[i][0].ToString());

                item.SubItems.Add(tb.Rows[i][1].ToString());
                item.SubItems.Add(tb.Rows[i][2].ToString());
                if (Convert.ToInt16(tb.Rows[i][3]) == 1)
                {
                    item.SubItems.Add("Nam");
                }
                else
                {
                    item.SubItems.Add("Nữ");
                }

                item.SubItems.Add(tb.Rows[i][4].ToString());

                listViewSinhVien.Items.Add(item);
            }
            con.Close();
        }
    }
}
