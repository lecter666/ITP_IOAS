﻿using System;
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
    public partial class Excavation : MaterialForm
    {
        public Excavation()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.BlueGrey500, Accent.Yellow400, TextShade.WHITE);

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void Excavation_Load(object sender, EventArgs e)
        {
            tabPage1.Text = " Add Excavation Site";
            tabPage2.Text = "Add Excavation Info ";

            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}
