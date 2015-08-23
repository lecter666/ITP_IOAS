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
    public partial class Finanacial : MaterialForm
    {
        public Finanacial()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.BlueGrey500, Accent.Red200, TextShade.WHITE);
        }

        private void Finanacial_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Annual Budget";
            tabPage2.Text = "Budget Allocation";
            tabPage3.Text = "Miscellaneous Expenditure";

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.MaximizeBox = false;
            //this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
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
