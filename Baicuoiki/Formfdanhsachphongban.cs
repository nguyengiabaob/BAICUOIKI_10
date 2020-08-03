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

namespace Baicuoiki
{
    public partial class Formfdanhsachphongban : Form
    {
        public Formfdanhsachphongban()
        {
            InitializeComponent();
        }

        private void Formfdanhsachphongban_Load(object sender, EventArgs e)
        {
            var query = "SELECT PHONGBAN.MAPHG, PHONGBAN.TENPHG, NHANVIEN.HOTENNV, PHONGBAN.NG_NHANCHUCTRP " +
"FROM NHANVIEN INNER JOIN " +
                 "PHONGBAN ON NHANVIEN.PHG = PHONGBAN.MAPHG AND NHANVIEN.MANV = PHONGBAN.TRPHG";
            SqlDataAdapter da = new SqlDataAdapter(query, Bang.Bang.cnn);
            SqlCommandBuilder cmm = new SqlCommandBuilder(da);
            try
            {
                DataTable b = new DataTable();
                da.Fill(b);
                CrystalReport1indanhsachphongban rpt = new CrystalReport1indanhsachphongban();
                rpt.SetDataSource(b);
                crystalReportViewer1.ReportSource = rpt;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
   
}
