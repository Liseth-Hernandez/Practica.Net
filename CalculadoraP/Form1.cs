using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, res;
            a = int.Parse(txtNum1.Text);
            b = int.Parse(txtNum2.Text); 
            res = a + b;
            txtRes.Text = res.ToString();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtRes.Text = "";
        }
          
    }
}
