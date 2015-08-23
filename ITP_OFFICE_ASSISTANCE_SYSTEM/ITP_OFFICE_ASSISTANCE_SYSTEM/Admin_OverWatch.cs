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
    public partial class Admin_OverWatch : MaterialForm
    {
        public Admin_OverWatch()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.BlueGrey500, Accent.Red200, TextShade.WHITE);

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "WELCOME";
            tabPage2.Text = "Exploration";
            tabPage3.Text = "Excavation";
            tabPage4.Text = "Conservation";
            tabPage5.Text = "Maintenance";
            tabPage6.Text = "Planing";
            tabPage7.Text = "Finance";

            

            /* tabPage1.UseVisualStyleBackColor = false;
             tabPage2.UseVisualStyleBackColor = false;
             tabPage3.UseVisualStyleBackColor = false;
             tabPage4.UseVisualStyleBackColor = false;
             tabPage5.UseVisualStyleBackColor = false;
             tabPage6.UseVisualStyleBackColor = false;
             tabPage7.UseVisualStyleBackColor = false;
             */

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}
