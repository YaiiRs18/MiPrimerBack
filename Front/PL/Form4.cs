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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();
            this.Hide();

            Form3 form3 = new Form3();
            this.Hide();

            Form2 form2 = new Form2();
            this.Hide();

            Form1 form = new Form1();


            form.ShowDialog();
            this.Close();
            this.Hide();



        }

        private void button1_Click(object sender, EventArgs e)
        {


            button3.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Nip = Convert.ToInt32(textBox1.Text);
            TarjetasReference.Tarjetas tarjetas1 = new TarjetasReference.Tarjetas();
            TarjetasReference.TarjetasClient tarjetas = new TarjetasReference.TarjetasClient();
            tarjetas1.Nip = Nip;
            tarjetas1.NoTarjeta = Convert.ToInt32(label2.Text);
            var request = tarjetas.GetNip(tarjetas1);

            if (request.Code == 100)
            {

                int saldo = 0;
                foreach (var obj in request.TarjetasList)
                {
                    ClientesReference.Tarjetas saldoTarjeta = new ClientesReference.Tarjetas();
                    saldoTarjeta.Saldo = obj.Saldo;

                    saldo = saldoTarjeta.Saldo;

                }
                Form4 form4 = new Form4();
                this.Hide();




                Form2 form2 = new Form2();
                form2.label1f2.Text = "Tu saldo es: " + saldo;
                form2.label2.Text = label2.Text;
                form2.ShowDialog();

                this.Show();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
