using OnThiLTCSDL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnThiLTCSDL
{
   
    public partial class frmMain : Form
    {
        BindingSource bindingSourceBanAn = new BindingSource();
        public frmMain()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BanAnDAO banAnDAO = new BanAnDAO();
            dgvBanAn.DataSource = bindingSourceBanAn;
            bindingSourceBanAn.DataSource = banAnDAO.LayDSBanAn();
            BingdingsourceBanAn();
        }
        private void BingdingsourceBanAn()
        {
            txtIDBanAn.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "ID"));
            txtName.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "Name"));
            nmCapacity.DataBindings.Add(new Binding("Value", dgvBanAn.DataSource, "Capacity"));
            cbbStatus.DataBindings.Add(new Binding("SelectedIndex", dgvBanAn.DataSource, "Status"));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int status = 0;
            if (cbbStatus.Text == "Có người") status = 1;
            int capacity = (int)nmCapacity.Value;
            BanAnDAO banAnDAO = new BanAnDAO();
            bool kq = banAnDAO.ThemBanAn(name, status, capacity);
            if (kq)
            { MessageBox.Show("Thêm bàn ăn thành công!", "Thông báo");
                dgvBanAn.DataSource = bindingSourceBanAn;
                bindingSourceBanAn.DataSource= banAnDAO.LayDSBanAn(); return; }
            else MessageBox.Show("Thêm bàn ăn thất bại!", "Thông báo lỗi");
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32 (txtIDBanAn.Text);
            string name = txtName.Text;
            int capacity = Convert.ToInt32(nmCapacity.Text);
            int status = 0;
            if (cbbStatus.Text == "Có người")
                status = 1;
            BanAnDAO banAnDAO = new BanAnDAO();
            bool kQ = banAnDAO.SuaBanAn(id, name, status, capacity);
            if (kQ)
            {
                MessageBox.Show("Sửa bàn ăn thành công", "Thông báo");
                dgvBanAn.DataSource = bindingSourceBanAn;
                    bindingSourceBanAn.DataSource = banAnDAO.LayDSBanAn();
                return;
            }
            else MessageBox.Show("Sửa thất bại", "Thông báo lỗi");
        }
    }
}
