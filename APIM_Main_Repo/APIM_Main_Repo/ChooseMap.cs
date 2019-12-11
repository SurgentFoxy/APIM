using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APIM_Main_Repo
{
    public partial class ChooseMap : Form
    {
        public ChooseMap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            map1 m1 = new map1();
            m1.Show();
            this.Hide();
        }
    }
}
