using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Baicuoiki.Bang;


namespace Baicuoiki
{
    public partial class formindanhsach : Form
    {
        public formindanhsach()
        {
            InitializeComponent();
        }

        private void formindanhsach_Load(object sender, EventArgs e)
        {
            var query = "SELECT NHANVIEN.MANV, NHANVIEN.HOTENNV, NHANVIEN.NGSINH, NHANVIEN.PHAI,NHANVIEN.DCHI, PHONGBAN.TENPHG, NHANVIEN.LUONG, NHANVIEN.CHUCVU, NHANVIEN.THOIHANHOPDONG "+
                        "FROM NHANVIEN INNER JOIN "+
                        " PHONGBAN ON NHANVIEN.PHG = PHONGBAN.MAPHG";
            SqlDataAdapter DA = new SqlDataAdapter(query,Bang.Bang.cnn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(DA);
            try
            {
                DataTable tb = new DataTable();
                DA.Fill(tb);
                rpindanhsachnhanvien rp = new rpindanhsachnhanvien();
                rp.SetDataSource(tb);
                crystalReportViewerdanhsach.ReportSource = rp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    }
}


