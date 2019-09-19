using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.Application;

namespace DeskApp
{
    public partial class Form1 : Form
    {
        private codeHandler CODE;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CODE = new codeHandler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = CODE.Encrypt(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid format. " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = CODE.Decrypt(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid format. " + ex.Message);
            }
        }

    }
}
