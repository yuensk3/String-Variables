﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStrings_Click(object sender, EventArgs e)
        {
            string firstName;
            string messageText;

            messageText = "Your name is: ";

            firstName = textBox1.Text;

            //MessageBox.Show("Your name is: " + firstName);

            TextMessage.Text = messageText + firstName;
            textBox2.Text = messageText + firstName;

        }


    }
}
