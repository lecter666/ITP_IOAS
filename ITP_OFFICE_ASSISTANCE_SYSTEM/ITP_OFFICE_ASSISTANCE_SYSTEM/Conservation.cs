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
    public partial class Conservation : MaterialForm
    {
        public Conservation()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink800, Primary.Pink900, Primary.BlueGrey500, Accent.Purple200, TextShade.WHITE);

        }

        private void Conservation_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Add Artifact Info";
            tabPage2.Text = "Change Artifact Info";

            
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}
