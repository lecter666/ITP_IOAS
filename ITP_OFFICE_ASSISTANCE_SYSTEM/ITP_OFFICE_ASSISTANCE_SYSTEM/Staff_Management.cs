using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ITP_OFFICE_ASSISTANCE_SYSTEM
{
    public partial class Staff_Management : MaterialForm
    {
        public Staff_Management()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.BlueGrey500, Accent.Red200, TextShade.WHITE);

        }

        private void Staff_Management_Load(object sender, EventArgs e)
        {

            tabPage1.Text = "Search Employee";
            tabPage2.Text = "Add Employee";
            tabPage3.Text = "Manage Access Levels";
            tabPage4.Text = "Manage Employee Info";
            tabPage5.Text = "Salary Management";
            tabPage6.Text = "Leave Management";
            tabPage7.Text = "Reports";

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialSingleLineTextField7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}
