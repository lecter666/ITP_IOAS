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
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.BlueGrey500, Accent.Red200, TextShade.WHITE);

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            if (materialSingleLineTextField1.Text.Equals("1"))
            {
                Staff_Management f = new Staff_Management();
                f.Show();
                this.Hide();
            }
            else if (materialSingleLineTextField1.Text.Equals("2"))
            {
                Admin_OverWatch f = new Admin_OverWatch();
                f.Show();
                this.Hide();
            }
            else if (materialSingleLineTextField1.Text.Equals("3"))
            {
                Conservation f = new Conservation();
                f.Show();
                this.Hide();
            }
            else if (materialSingleLineTextField1.Text.Equals("4"))
            {
                Excavation f = new Excavation();
                f.Show();
                this.Hide();
            }
            else if (materialSingleLineTextField1.Text.Equals("5"))
            {
                Exploration f = new Exploration();
                f.Show();
                this.Hide();
            }
            else if (materialSingleLineTextField1.Text.Equals("6"))
            {
                Planing f = new Planing();
                f.Show();
                this.Hide();
            }
            else if (materialSingleLineTextField1.Text.Equals("7"))
            {
                Finanacial f = new Finanacial();
                f.Show();
                this.Hide();
            }
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Welcome c = new Welcome();
            c.Show();
            this.Close();
        }
    }

}
