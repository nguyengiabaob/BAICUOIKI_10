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
    public partial class Formphancongdean : Form
    {
        TabControl c = null;
        duan duan = new duan();
        Phongban tbphong = new Phongban();
        
        phancongdean pcdean = new phancongdean();
        Bangnhanvien tbnhanvien = new Bangnhanvien();
        DataSet ds = new DataSet();
        BindingManagerBase b;
        public Formphancongdean()
        {
            InitializeComponent();
        }
        public Formphancongdean(TabControl t)
        {
            c = t;
            InitializeComponent();
        }
        private void load()
        {
            cbxtendean.SelectedIndex = -1;
            cbtenphongphancong.SelectedIndex = -1;
            tbxdiadiem.Text = "";
            tbxmadean.Text = "";
            tbxmaphong.Text="";
            tbxmatrhp.Text = "";
            tbxtruongphong.Text = "";
            tbxttienloinhuan.Text="";
            
        }
        private void loadcbtendean()
        {
            cbxtendean.DataSource = duan;
            cbxtendean.DisplayMember = "TENDA";
            cbxtendean.ValueMember = "MADA";
            cbxtendean.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxtendean.AutoCompleteSource = AutoCompleteSource.ListItems;
          
        }
        private void LOADTHONGITNDEAN()
        {
            tbxmadean.DataBindings.Add("text", duan, "MADA", true);
            cbxtendean.DataBindings.Add("selectedvalue", duan, "MADA", true);
            tbxdiadiem.DataBindings.Add("text", duan, "DDIEM_DA", true);
            tbxttienloinhuan.DataBindings.Add("text", duan, "TIENLOINHUAN", true);

        }
        private void cbtenphong()
        {
            cbtenphongphancong.DataSource = tbphong;
            cbtenphongphancong.DisplayMember = "TENPHG";
            cbtenphongphancong.ValueMember = "MAPHG";

        }
        private void loadthongtinphancong()
        {
            tbxmaphong.DataBindings.Add("text", pcdean, "MAPHONG", true);
            tbxmatrhp.DataBindings.Add("text",pcdean, "MATRP", true);
            cbtenphongphancong.DataBindings.Add("selectedvalue", pcdean, "MAPHONG", true);
            tbxtruongphong.DataBindings.Add("text", pcdean, "TENTRUONGPHONG", true);


        }

        private void btxemdanhsach_Click(object sender, EventArgs e)
        {

            formdanhsachphancongdeancs f = new formdanhsachphancongdeancs();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
        private void addcot1()
        {
            
            ds.Tables.AddRange(new DataTable[] {pcdean , duan });
            DataRelation qh = new DataRelation("FRK_PHANCONG_DEAN",duan.Columns["MADA"], pcdean.Columns["MADEAN"]);
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
           
            
            DataRelation qh = new DataRelation("FRK_PHONG_PCDEAN", tbphong.Columns["MAPHG"],pcdean.Columns["MAPHONG"]);
            ds.Relations.Add(qh);
            DataColumn cottenphong = new DataColumn("TENPHONG", Type.GetType("System.String"), "Parent(FRK_PHONG_PCDEAN).TENPHG");
            DataColumn cottentrp =new DataColumn("TENTRUONGPHONG", Type.GetType("System.String"), "Parent(FRK_PHONG_PCDEAN).TENTRUONGPHONG");
            DataColumn cotmatrp = new DataColumn("MATRP", Type.GetType("System.String"), "Parent(FRK_PHONG_PCDEAN).TRPHG");
            pcdean.Columns.Add(cottenphong);
            pcdean.Columns.Add(cottentrp);
            pcdean.Columns.Add(cotmatrp);

        }

        private void Formphancongdean_Load(object sender, EventArgs e)
        {
            addcot1();
            addcot2();
            addcot3();
            loadcbtendean();
            cbtenphong();
            load();
            //loadthongtinphancong();
            //LOADTHONGITNDEAN();
          
        }

       

        private void cbxtendean_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxtendean.SelectedIndex;
            if(index>=0)
            {
                tbxmadean.Text = duan.Rows[index]["MADA"].ToString();
                tbxdiadiem.Text = duan.Rows[index]["DDIEM_DA"].ToString();
                tbxttienloinhuan.Text = duan.Rows[index]["TIENLOINHUAN"].ToString();
            }
            else
            {

            }
        }

        private void cbtenphongphancong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbtenphongphancong.SelectedIndex;
            if (index >= 0)
            {
                tbxmaphong.Text = tbphong.Rows[index]["MAPHG"].ToString();
                tbxmatrhp.Text = tbphong.Rows[index]["TRPHG"].ToString();
                tbxtruongphong.Text = tbphong.Rows[index]["TENTRUONGPHONG"].ToString();
            }
            else
            {
                tbxmaphong.Text = "";
                tbxmatrhp.Text = "";
                tbxtruongphong.Text = ""; 
            }
        }

        private void btluuphancong_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (tbxmadean.Text == "" || tbxttienloinhuan.Text == "" || tbxdiadiem.Text == "" || tbxmaphong.Text == "" || tbxtruongphong.Text == "" || tbxmatrhp.Text == "")
            {
                t = 1;
                MessageBox.Show("Thông tin chưa điền đầy đũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (t == 1)
            {
                int mn = pcdean.getcount;
                DataRow r = pcdean.NewRow();
                r["MADEAN"] = tbxmadean.Text;
                r["MAPHONG"] = tbxmaphong.Text;
                r["THOIGIANBATDAU"] = dateTimePickertgbatdau.Text;
                r["THOIGIANKETTHUC"] = dateTimePickerketthuc.Text;
                r["TENDA"] = cbtenphongphancong.Text;
                r["TENTRUONGPHONG"] = tbxtruongphong.Text;
                pcdean.Rows.Add(r);
                try
                {
                    pcdean.ghi();
                    if (pcdean.ghi() == true)
                    {
                        MessageBox.Show("Lưu thành công!!!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btxoaphancong_Click(object sender, EventArgs e)
        {
            tbxmadean.Text = "";
            tbxttienloinhuan.Text="";
            tbxdiadiem.Text = "";
            tbxmaphong.Text = "";
            tbxtruongphong.Text = "";
            tbxmatrhp.Text = "";

        }

        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            c.TabPages.RemoveByKey("pagephancongdean");
        }
    }
}
