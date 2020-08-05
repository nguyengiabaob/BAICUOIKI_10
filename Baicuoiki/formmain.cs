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
    public partial class formmain : Form
    {
       
        public formmain()
        {
            InitializeComponent();
        }
        public void enablebutton(int mapquyen)

        {  switch (mapquyen)
            {

                case 1:
                    {
                        phanhethong.Visible = true;
                        phanphongban.Visible = true;
                        phandean.Visible = true;
                        btdangxuat.Enabled = true;
                        btdoimatkhau.Enabled = true;

                        btdanhsachdean.Enabled = true;
                        btphancongdean.Enabled = false;
                        bttiendodean.Enabled = true;
                        btdanhsachphongban.Enabled = true;

                        phannhanvien.Visible = false;
                        phanluong.Visible = false;
                        break;
                    }
                case 0:
                    phannhanvien.Visible = true;
                    phanluong.Visible =true;
                    btdangxuat.Enabled = true;
                    btdoimatkhau.Enabled = true;
                    btcapnhatnhanvien.Enabled = true;
                    btxemdanhsachnhanvien.Enabled = true;
                    btkhenthuongvakiluat.Enabled = true;
                    btdanhsachdean.Enabled = true;
                    btphancongdean.Enabled = true;
                    bttiendodean.Enabled = true;
                    btdanhsachphongban.Enabled = true;
                    btluongtheothanhtich.Enabled = true;
                    bttinhluong.Enabled = true;
                    bttamung.Enabled = true;
                    break;
                default:
                    phannhanvien.Visible = false;
                    phanphongban.Visible = false;
                    phandean.Visible = false;
                    phanluong.Visible = false;
                    phanhethong.Visible = false;
                    break;
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlmain.TabPages.IndexOfKey("pagecapnhatnhanvien");
            if (index >= 0)
            {
                tabControlmain.SelectedIndex = index;
            }
            else
            {
                Formcapnhatnhanvien cnnhanvien = new Formcapnhatnhanvien(tabControlmain);
                TabPage p = new TabPage("Cập nhật danh sách nhân viên");
                p.Name = "pagecapnhatnhanvien";
                cnnhanvien.TopLevel = false;
                p.Controls.Add(cnnhanvien);
                cnnhanvien.FormBorderStyle = FormBorderStyle.None;
                cnnhanvien.Dock = DockStyle.Fill;
                tabControlmain.TabPages.Add(p);
                cnnhanvien.Show();
           
            }

        }

        private void formmain_Load(object sender, EventArgs e)
        {
           
             formdangnhap dangnhap = new formdangnhap(this);
            dangnhap.StartPosition = FormStartPosition.CenterScreen;
            dangnhap.WindowState = FormWindowState.Normal;
            dangnhap.ShowDialog();
           
        }

        private void btxemdanhsachnhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlmain.TabPages.IndexOfKey("pagedanhsachnhanvien");
            if(index>=0)
            {
                tabControlmain.SelectedIndex = index;
            }
            else
            {
                Formdanhsachsinhvien dsnhanvien = new Formdanhsachsinhvien(tabControlmain);
                TabPage p = new TabPage(dsnhanvien.Text);
                p.Name = "pagedanhsachnhanvien";
                dsnhanvien.TopLevel = false;
                p.Controls.Add(dsnhanvien);
                dsnhanvien.Dock = DockStyle.Fill;
                dsnhanvien.FormBorderStyle = FormBorderStyle.None;
                tabControlmain.TabPages.Add(p);
                dsnhanvien.Show();



            }


        }

        private void btkhenthuongvakiluat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlmain.TabPages.IndexOfKey("pagekhenthuongvakiluat");
            if (index >= 0)
            {
                tabControlmain.SelectedIndex = index;
            }
            else
            {
                Formkhenthuongvakiluat khenthuongkiluat = new Formkhenthuongvakiluat(tabControlmain);
                TabPage p = new TabPage(khenthuongkiluat.Text);
                p.Name = "pagekhenthuongvakiluat";
                khenthuongkiluat.TopLevel = false;
                p.Controls.Add(khenthuongkiluat);
                khenthuongkiluat.Dock = DockStyle.Fill;
                khenthuongkiluat.FormBorderStyle = FormBorderStyle.None;
                tabControlmain.TabPages.Add(p);
                khenthuongkiluat.Show();



            }

        }

        private void btdanhsachdean_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlmain.TabPages.IndexOfKey("pagedanhsachdean");
            if (index >= 0)
            {
                tabControlmain.SelectedIndex = index;
            }
            else
            {
                danhsachdean dsdean = new danhsachdean(tabControlmain);
                TabPage p = new TabPage(dsdean.Text);
                p.Name = "pagedanhsachdean";
                dsdean.TopLevel = false;
                p.Controls.Add(dsdean);
                dsdean.Dock = DockStyle.Fill;
                dsdean.FormBorderStyle = FormBorderStyle.None;
                tabControlmain.TabPages.Add(p);
                dsdean.Show();
            }
        }

        private void btphancongdean_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlmain.TabPages.IndexOfKey("pagephancongdean");
            if (index >= 0)
            {
                tabControlmain.SelectedIndex = index;
            }
            else
            {
                Formphancongdean phancongdean = new  Formphancongdean(tabControlmain);
                TabPage p = new TabPage(phancongdean.Text);
                p.Name = "pagephancongdean";
                phancongdean.TopLevel = false;
                p.Controls.Add(phancongdean);
                phancongdean.Dock = DockStyle.Fill;
                phancongdean.FormBorderStyle = FormBorderStyle.None;
                tabControlmain.TabPages.Add(p);
                phancongdean.Show();
            }
        }

        private void bttiendodean_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlmain.TabPages.IndexOfKey("pagetiendodean");
            if (index >= 0)
            {
                tabControlmain.SelectedIndex = index;
            }
            else
            {
                 formtiendodean tiendodean = new formtiendodean(tabControlmain) ;
                TabPage p = new TabPage(tiendodean.Text);
                p.Name = "pagetiendodean";
                tiendodean.TopLevel = false;
                p.Controls.Add(tiendodean);
                tiendodean.Dock = DockStyle.Fill;
                tiendodean.FormBorderStyle = FormBorderStyle.None;
                tabControlmain.TabPages.Add(p);
                tiendodean.Show();
            }
        }

        private void btdanhsachphongban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlmain.TabPages.IndexOfKey("pagedanhsachphongban");
            if (index >= 0)
            {
                tabControlmain.SelectedIndex = index;
            }
            else
            {
                danhsachphongban danhsachphongban = new danhsachphongban(tabControlmain);
                TabPage p = new TabPage(danhsachphongban.Text);
                p.Name = "pagedanhsachphongban";
                danhsachphongban.TopLevel = false;
                p.Controls.Add(danhsachphongban);
                danhsachphongban.Dock = DockStyle.Fill;
                danhsachphongban.FormBorderStyle = FormBorderStyle.None;
                tabControlmain.TabPages.Add(p);
                danhsachphongban.Show();
            }
        }

        private void bttamung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlmain.TabPages.IndexOfKey("pageluongtamung");
            if (index >= 0)
            {
                tabControlmain.SelectedIndex = index;
            }
            else
            {
               Formtamungtien tamungtien = new Formtamungtien(tabControlmain);
                TabPage p = new TabPage(tamungtien.Text);
                p.Name = "pageluongtamung";
                tamungtien.TopLevel = false;
                p.Controls.Add(tamungtien);
                tamungtien.Dock = DockStyle.Fill;
                tamungtien.FormBorderStyle = FormBorderStyle.None;
                tabControlmain.TabPages.Add(p);
                tamungtien.Show();
            }
        }

        private void bttinhluong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlmain.TabPages.IndexOfKey("pagetinhluong");
            if (index >= 0)
            {
                tabControlmain.SelectedIndex = index;
            }
            else
            {
                Formtinhluong tinhluong = new Formtinhluong(tabControlmain);
                TabPage p = new TabPage(tinhluong.Text);
                p.Name = "pagetinhluong";
                tinhluong.TopLevel = false;
                p.Controls.Add(tinhluong);
                tinhluong.Dock = DockStyle.Fill;
                tinhluong.FormBorderStyle = FormBorderStyle.None;
                tabControlmain.TabPages.Add(p);
                tinhluong.Show();
            }
        }

        private void btluongtheothanhtich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlmain.TabPages.IndexOfKey("pagetinhluongtheothanhtich");
            if (index >= 0)
            {
                tabControlmain.SelectedIndex = index;
            }
            else
            {Formluongtheothanhtich tinhluongtheothanhtich = new Formluongtheothanhtich(tabControlmain);
                TabPage p = new TabPage(tinhluongtheothanhtich.Text);
                p.Name = "pagetinhluongtheothanhtich";
                tinhluongtheothanhtich.TopLevel = false;
                p.Controls.Add(tinhluongtheothanhtich);
                tinhluongtheothanhtich.Dock = DockStyle.Fill;
                tinhluongtheothanhtich.FormBorderStyle = FormBorderStyle.None;
                tabControlmain.TabPages.Add(p);
                tinhluongtheothanhtich.Show();
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            tabControlmain.TabPages.Clear();
            this.Hide();
            formmain_Load(sender, e);
            shown();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formdoimatkhau f = new formdoimatkhau();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void formmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }
        private void  shown()
        {
            this.Show();
        }
    }
}
