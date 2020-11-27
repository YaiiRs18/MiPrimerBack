using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();

            Form4 form4 = new Form4();
            form4.label1.Text = "¿Deseas Realizar Otra Operacion?";
            form4.label2.Text = label4.Text;
            form4.ShowDialog();

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
