using System;
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
    public partial class Vanity : Form
    {
        public Vanity()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label18.BackColor = Color.Transparent;
            cart.BackColor = Color.Transparent;
            next.BackColor = Color.Transparent;
            Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();
            this.Close();
            back.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             
        }

        private void next_Click(object sender, EventArgs e)
        {
          
        }

        private void back_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
