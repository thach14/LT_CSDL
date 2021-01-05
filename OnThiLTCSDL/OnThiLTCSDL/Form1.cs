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
            dgvBanAn.DataSource = banAnDAO.LayDSBanAn();
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
            { MessageBox.Show("Thêm bàn ăn thành công!", "Thông báo"); dgvBanAn.DataSource = banAnDAO.LayDSBanAn(); return; }
            else MessageBox.Show("Thêm bàn ăn thất bại!", "Thông báo lỗi");
           
        }
    }
}
