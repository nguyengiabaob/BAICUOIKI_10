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
    public partial class Formindanhsachkhenthuongvakiuat : Form
    {
        public string manv;
        public string hinhthuc;
        public Formindanhsachkhenthuongvakiuat()
        {
            InitializeComponent();
        }

        private void Formindanhsachkhenthuongvakiuat_Load(object sender, EventArgs e)
        {
            var query = "SELECT NHANVIEN.HOTENNV, NHANVIEN.NGSINH, NHANVIEN.PHAI, NHANVIEN.CHUCVU, DSKHENTHUONGVAKILUAT.LIDO, DSKHENTHUONGVAKILUAT.HINHPHAT, DSKHENTHUONGVAKILUAT.PHANTHUONG" +
" FROM DSKHENTHUONGVAKILUAT INNER JOIN " +
                  "NHANVIEN ON DSKHENTHUONGVAKILUAT.MANV = NHANVIEN.MANV " +
            "WHERE DSKHENTHUONGVAKILUAT.MANV='" + manv + "'";
            SqlDataAdapter da = new SqlDataAdapter(query,Bang.Bang.cnn);
            SqlCommandBuilder cmmd = new SqlCommandBuilder(da);
            try
            {
                DataTable tbl = new DataTable();
                da.Fill(tbl);
                reportkhenthuong rpt = new reportkhenthuong();
                reportkiluat rpt1 = new reportkiluat();
                if (hinhthuc == "Khen thưởng")
                {
                    rpt.SetDataSource(tbl);
                    crystalReportViewer1.ReportSource = rpt;
                }
                if(hinhthuc=="Kỉ luật")
                {
                    rpt1.SetDataSource(tbl);
                    crystalReportViewer1.ReportSource = rpt1;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
        
    
}
