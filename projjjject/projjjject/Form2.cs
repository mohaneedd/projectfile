﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projjjject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            //  next.Parent = BackgroundImage;
            next2.BackColor = Color.Transparent;

        }

        private void back_Click(object sender, EventArgs e)
        {
            //  back.Parent = BackgroundImage;
            back2.BackColor = Color.Transparent;
            Vanity form = new Vanity();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void cart_Click(object sender, EventArgs e)
        {
            
        }

        private void label18_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
