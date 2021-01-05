using phunz.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phunz
{
    public partial class frmBanAn : Form
    {
        BindingSource bindingSouceBanAn = new BindingSource();
        public frmBanAn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvBanAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBanAn_Load(object sender, EventArgs e)
        {
            BanAnDAO phunz = new BanAnDAO();
            dgvBanAn.DataSource = bindingSouceBanAn;
            bindingSouceBanAn.DataSource=  phunz.LayDanhSachBanAn();
            AddBindingSourceBanAn();
        }
        private void AddBindingSourceBanAn()
        {
            txtID.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "ID"));
            nmCapacity.DataBindings.Add(new Binding("Value", dgvBanAn.DataSource, "Capacity"));
            txtName.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "Name"));
            cbbStatus.DataBindings.Add(new Binding("SelectedIndex", dgvBanAn.DataSource, "Status"));
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int status =1;
            if (cbbStatus.Text == "Trống") status = 0;
            int capacity = (int)nmCapacity.Value;

            BanAnDAO phunz = new BanAnDAO();
           bool biu =  phunz.ThemBanMoi(name, status, capacity);

            if (biu == false)
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo lỗi");
                return;
            }
            MessageBox.Show("Thêm thành công", "Thông báo");
            dgvBanAn.DataSource = bindingSouceBanAn;
            bindingSouceBanAn.DataSource= phunz.LayDanhSachBanAn();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int status = 1;
            if (cbbStatus.Text == "Trống") status = 0;
            int capacity = (int)nmCapacity.Value;
            int id = Convert.ToInt32(txtID.Text);
            BanAnDAO phunz = new BanAnDAO();
          bool biu =   phunz.SuaBanAn(id, name, status, capacity);
            if (biu == false)
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo lỗi"); 
                return;
            }
            MessageBox.Show("Sửa thành công", "Thông báo");
            dgvBanAn.DataSource = bindingSouceBanAn;
            bindingSouceBanAn.DataSource= phunz.LayDanhSachBanAn();
           
        }
    }
}
