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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();

            FormAgua formAgua = new FormAgua();
            formAgua.Titulo.Text = "Pago de Agua";
            formAgua.Imagen.Visible = true;
            formAgua.label3.Text = label6.Text;
            formAgua.labelsaldoag.Text = label7.Text;
            formAgua.ShowDialog();

            this.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();

            FormAgua formAgua = new FormAgua();
            formAgua.Titulo.Text = "Pago de Luz";
            formAgua.ImagenLuz.Visible = true;
            formAgua.label3.Text = label6.Text;
            formAgua.ShowDialog();

            this.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5();
            this.Hide();

            FormAgua formAgua = new FormAgua();
            formAgua.Titulo.Text = "Pago de Telefono";
            formAgua.Telefono.Visible = true;
            formAgua.label3.Text = label6.Text;
            formAgua.ShowDialog();

            this.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();

            FormAgua formAgua = new FormAgua();
            formAgua.Titulo.Text = "Pago de Cable";
            formAgua.Cable.Visible = true;
            formAgua.label3.Text = label6.Text;
            formAgua.ShowDialog();

            this.Show();
        }
    }
}
