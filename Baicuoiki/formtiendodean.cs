using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baicuoiki.Bang;
using System.Data.SqlClient;

namespace Baicuoiki
{
    public partial class formtiendodean : Form
    {
        TabControl c = null;
        
        public formtiendodean()
        {
            InitializeComponent();
        }
        BindingManagerBase btiendodean;
        phancongdean pcdean = new phancongdean();
        duan duan = new duan();
        Phongban tbphong = new Phongban();
        Bangnhanvien tbnhanvien = new Bangnhanvien();
        tiendodean tiendodean = new tiendodean();
        DataSet ds = new DataSet();
        public formtiendodean(TabControl t)
        {
            c = t;
            InitializeComponent();
        }
        private void addcot1()
        {

            ds.Tables.AddRange(new DataTable[] { pcdean, duan });
            DataRelation qh = new DataRelation("FRK_PHANCONG_DEAN", duan.Columns["MADA"], pcdean.Columns["MADEAN"]);
            ds.Relations.Add(qh);
            DataColumn cottenda = new DataColumn("TENDA", Type.GetType("System.String"), "Parent(FRK_PHANCONG_DEAN).TENDA");
            DataColumn cotdiadiem = new DataColumn("DIADIEM", Type.GetType("System.String"), "Parent(FRK_PHANCONG_DEAN).DDIEM_DA");
            DataColumn cottiemloinhuan = new DataColumn("TIENLOINHUAN", Type.GetType("System.Int32"), "Parent(FRK_PHANCONG_DEAN).TIENLOINHUAN");
            pcdean.Columns.Add(cottenda);
            pcdean.Columns.Add(cotdiadiem);
            pcdean.Columns.Add(cottiemloinhuan);
        }
        private void addcot2()
        {

            ds.Tables.AddRange(new DataTable[] { tbphong, tbnhanvien });
            DataRelation qh = new DataRelation("FRK_PHONG_NHANVIEN", tbnhanvien.Columns["MANV"], tbphong.Columns["TRPHG"]);
            ds.Relations.Add(qh);
            DataColumn cottentp = new DataColumn("TENTRUONGPHONG", Type.GetType("System.String"), "Parent(FRK_PHONG_NHANVIEN).HOTENNV");
            tbphong.Columns.Add(cottentp);

        }
        private void addcot3()
        {


            DataRelation qh = new DataRelation("FRK_PHONG_PCDEAN", tbphong.Columns["MAPHG"], pcdean.Columns["MAPHONG"]);
            ds.Relations.Add(qh);
            DataColumn cottenphong = new DataColumn("TENPHONG", Type.GetType("System.String"), "Parent(FRK_PHONG_PCDEAN).TENPHG");
            DataColumn cottentrp = new DataColumn("TENTRUONGPHONG", Type.GetType("System.String"), "Parent(FRK_PHONG_PCDEAN).TENTRUONGPHONG");
            DataColumn cotmatrp = new DataColumn("MATRP", Type.GetType("System.String"), "Parent(FRK_PHONG_PCDEAN).TRPHG");
            pcdean.Columns.Add(cottenphong);
            pcdean.Columns.Add(cottentrp);
            pcdean.Columns.Add(cotmatrp);

        }
        private void addcot4()
        {

            ds.Tables.Add(tiendodean);
            DataRelation qh = new DataRelation("FRK_TIENDODEAN_PCDEAN", pcdean.Columns["MADEAN"], tiendodean.Columns["MADUAN"]);
            ds.Relations.Add(qh);
            DataColumn cottenda = new DataColumn("TENDA", Type.GetType("System.String"), "Parent(FRK_TIENDODEAN_PCDEAN).TENDA");
            DataColumn cottentrp = new DataColumn("TENTRUONGPHONG", Type.GetType("System.String"), "Parent(FRK_TIENDODEAN_PCDEAN).TENTRUONGPHONG");
            DataColumn cottenphong = new DataColumn("TENPHONG", Type.GetType("System.String"), "Parent(FRK_TIENDODEAN_PCDEAN).TENPHONG");
            DataColumn thoigianbatdau = new DataColumn("THOIGIANBATDAU", Type.GetType("System.DateTime"), "Parent(FRK_TIENDODEAN_PCDEAN).THOIGIANBATDAU");
            DataColumn thoigianKETTHUC = new DataColumn("THOIGIANKETTHUC", Type.GetType("System.DateTime"), "Parent(FRK_TIENDODEAN_PCDEAN).THOIGIANKETTHUC");
            tiendodean.Columns.Add(cottenda);
            tiendodean.Columns.Add(cottentrp);
            tiendodean.Columns.Add(cottenphong);
            tiendodean.Columns.Add(thoigianbatdau);
            tiendodean.Columns.Add(thoigianKETTHUC);

        }
        private void tiendodean_Load(object sender, EventArgs e)
        {
            addcot1();
            addcot2();
            addcot3();
            addcot4();
            dateTimePicker1.Value = DateTime.Now;
            dataGridViewtiendodean.AutoGenerateColumns = false;
            dataGridViewtiendodean.DataSource = tiendodean;
            loadcbchedoloc();
            btiendodean = this.BindingContext[tiendodean];
            tbxlochitiet2.Enabled = false;
        }


        private void dataGridViewtiendodean_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                btiendodean.EndCurrentEdit();
                try
                { if(tiendodean.ghi())
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                 }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
               

            }
            if (e.RowIndex >= 0 && (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6))
            {
                if (Convert.ToDateTime(tiendodean.Rows[e.RowIndex]["THOIGIANKETTHUC"]) < dateTimePicker1.Value)
                {
                    btiendodean.CancelCurrentEdit();
                    MessageBox.Show("Quá ngày cập nhật tiến độ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }



        }
        private void loadcbchedoloc()
        {
            cbxchedocloc2.Items.Add("Chế độ lọc");
            cbxchedocloc2.Items.Add("Mã dự án");
            cbxchedocloc2.Items.Add("Tên dự án");
            cbxchedocloc2.Items.Add("Tên phòng");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            c.TabPages.RemoveByKey("pagetiendodean");
        }

        private void tbxlochitiet2_TextChanged(object sender, EventArgs e)
        {
            if (cbxchedocloc2.Text == "Mã dự án")
            {

                tiendodean.locdulieu("MADUAN like'" + tbxlochitiet2.Text + "*'");

            }
            if (cbxchedocloc2.Text == "Tên phòng")
            {

                tiendodean.locdulieu("TENPHONG like'" + tbxlochitiet2.Text + "*'");

            }
            if (cbxchedocloc2.Text == "Tên dự án")
            {

                tiendodean.locdulieu("TENDA like'" + tbxlochitiet2.Text + "*'");

            }
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Lưu.Visible = true;
        }

        private void cbxchedocloc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxchedocloc2.SelectedIndex;
            if(index>=0)
            {
                tbxlochitiet2.Enabled = true;
            }
        }
    } 
}
