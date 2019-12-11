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
    public partial class map1 : Form
    {
        public map1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            available.Hide();
            sold.Show();
        }
        private void Button2_Click(object sender, EventArgs e)
        {            
            available.Show();
            sold.Hide();
        }
    }
}
