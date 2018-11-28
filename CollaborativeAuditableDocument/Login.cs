﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollaborativeAuditableDocument
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text;
            if (Core.Instance.Login(userName))
            {
                Core.Instance.User = userName;
                Form main = new Form1();
                main.Show();
                
            }
        }
    }
}