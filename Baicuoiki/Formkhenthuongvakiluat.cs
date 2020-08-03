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

namespace Baicuoiki
{
    public partial class Formkhenthuongvakiluat : Form
    {
        Bangnhanvien tbnhanvien =new Bangnhanvien();
        khenthuongvakiluat dskvakluat = new khenthuongvakiluat();
        Phongban tbphongban = new Phongban();
        DataSet ds = new DataSet();
        public Formkhenthuongvakiluat()
        {
            InitializeComponent();
        }

        private void Formkhenthuongvakiluat_Load(object sender, EventArgs e)
        {
            addcot2();
            addcot();
            
            cbhoten();
            cbhinhthuc();

            //tbxmanvthuongkiluat.DataBindings.Add("text", dskvakluat, "MANV", true);
            //tbxtenphong.DataBindings.Add("text", dskvakluat, "HOTENNV", true);
            //cbxtenphongthuong.DataBindings.Add("SelectedValue", dskvakluat, "PHG", true);
            //tbxlido.DataBindings.Add("text", dskvakluat, "LIDO", true);
            //tbxhinhphat.DataBindings.Add("text", dskvakluat, "HINHPHAT", true);
            //tbxphanthuong.DataBindings.Add("text", dskvakluat, "PHANTHUONG", true);
            //tbxchucvuthuongkiluat.DataBindings.Add("text", dskvakluat, "CHUCVU", true);
            tbxmanvthuongkiluat.Text = "";
            tbxchucvuthuongkiluat.Text = "";
            tbxtenphong.Text = "";
            tbxphanthuong.Enabled = false;
            tbxhinhphat.Enabled = false;
         
        }
        private void addcot()
        {
            

          
            ds.Tables.AddRange(new DataTable[] { dskvakluat});
            DataRelation qh = new DataRelation("FRK_DSKHENVAKILUAT_NHANVIEN",tbnhanvien.Columns["MANV"], dskvakluat.Columns["MANV"]);
            ds.Relations.Add(qh);
            DataColumn cotHOTEN = new DataColumn("HOTENNV", Type.GetType("System.String"), "Parent(FRK_DSKHENVAKILUAT_NHANVIEN).HOTENNV");
            DataColumn cotCHUCVU = new DataColumn("CHUCVU", Type.GetType("System.String"), "Parent(FRK_DSKHENVAKILUAT_NHANVIEN).CHUCVU");
            DataColumn cotPHG = new DataColumn("TENPHG", Type.GetType("System.String"), "Parent(FRK_DSKHENVAKILUAT_NHANVIEN).TENPHG");
            dskvakluat.Columns.Add(cotHOTEN);
            dskvakluat.Columns.Add(cotCHUCVU);
            dskvakluat.Columns.Add(cotPHG);
        }
        private void addcot2()
        {



            ds.Tables.AddRange(new DataTable[] { tbphongban, tbnhanvien});
            DataRelation qh = new DataRelation("FRK_NHANVIEN_PHONGBAN", tbphongban.Columns["MAPHG"], tbnhanvien.Columns["PHG"]);
            ds.Relations.Add(qh);

            DataColumn cotPHG = new DataColumn("TENPHG", Type.GetType("System.String"), "Parent(FRK_NHANVIEN_PHONGBAN).TENPHG");

           tbnhanvien.Columns.Add(cotPHG);
        }

        //private void loadtenphong()
        //{
        //    cbxtenphongthuong.DataSource = tbphongban;
        //    cbxtenphongthuong.DisplayMember = "TENPHG";
        //    cbxtenphongthuong.ValueMember = "MAPHG";
        //    cbxtenphongthuong.SelectedIndex = -1;
        //}
        private void cbhoten()
        {
            comboBoxhoten.DataSource = tbnhanvien;
            comboBoxhoten.DisplayMember = "HOTENNV";
            comboBoxhoten.ValueMember = "MANV";
            comboBoxhoten.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxhoten.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxhoten.SelectedIndex = -1;
        }
        private void cbhinhthuc()
        {
            cbxhinhthuc.Items.Add("Khen thưởng");
            cbxhinhthuc.Items.Add("Kỉ luật");
        
        }

        private void cbxhinhthuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        private void tbxphanthuong_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxhinhthuc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            object kt = "Khen thưởng";
            object hp = "Kỉ luật";
            if (cbxhinhthuc.SelectedItem == kt)
            {
                tbxphanthuong.Enabled = true;
                tbxhinhphat.Enabled = false;
            }
            else
            if (cbxhinhthuc.SelectedItem == hp)
            {
                tbxhinhphat.Enabled = true;
                tbxphanthuong.Enabled = false;
            }
        }

        private void btin_Click(object sender, EventArgs e)
        {
            Formindanhsachkhenthuongvakiuat f = new Formindanhsachkhenthuongvakiuat();
            f.hinhthuc = cbxhinhthuc.Text;
            f.manv = tbxmanvthuongkiluat.Text;
            f.ShowDialog();
        }

        private void btxemdanhsach_Click(object sender, EventArgs e)
        {
            Danhsachthuongvakiluat f = new Danhsachthuongvakiluat();
            f.ShowDialog();
        }

        private void comboBoxhoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxhoten.SelectedIndex;
            if(index>=0)
            {
                tbxmanvthuongkiluat.Text = tbnhanvien.Rows[index]["MANV"].ToString();
                tbxchucvuthuongkiluat.Text = tbnhanvien.Rows[index]["CHUCVU"].ToString();
                tbxtenphong.Text = tbnhanvien.Rows[index]["TENPHG"].ToString();
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            int t = 0;
            check(t);
            if (t == 1)
                return;
            if (t == 0)
            {
                DataRow r = dskvakluat.NewRow();
                r["MANV"] = tbxmanvthuongkiluat.Text;
                r["LIDO"] = tbxlido.Text;
                if (tbxphanthuong.Text != "")
                    r["PHANTHUONG"] = tbxphanthuong.Text;
                else
                    r["PHANTHUONG"] = DBNull.Value;
                if (tbxhinhphat.Text != "")
                    r["HINHPHAT"] = tbxhinhphat.Text;
                else
                    r["HINHPHAT"] = DBNull.Value;
                dskvakluat.Rows.Add(r);
                dskvakluat.ghi();
                if(dskvakluat.ghi()==true)
                {
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void check(int t)
        {   
            if(tbxlido.Text=="" || cbxhinhthuc.SelectedIndex==-1 || tbxmanvthuongkiluat.Text=="" || comboBoxhoten.SelectedIndex==-1|| tbxchucvuthuongkiluat.Text==""||tbxtenphong.Text==""||(tbxhinhphat.Text == "" && tbxphanthuong.Text == ""))
            
                {
                t = 1;
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
