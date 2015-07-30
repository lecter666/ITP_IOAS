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
    public partial class Planing : MaterialForm
    {
        public Planing()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.BlueGrey500, Accent.Red200, TextShade.WHITE);

        }

        private void Planing_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Add New Plan";
            tabPage2.Text = "View plan Progress";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}
