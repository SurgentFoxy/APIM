﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APIM_Main_Repo//The main Program(Don't Apply Changes until it's 100 working n checked)
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {            
            ChooseMap c = new ChooseMap();
            c.Activate();
            c.Show();
            this.Hide();
        }
    }
}
