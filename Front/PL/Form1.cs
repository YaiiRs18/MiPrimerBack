using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.ClientesReference;
using PL.TarjetasReference;

namespace PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            int Tarjeta = Convert.ToInt32(textBox1.Text);
            ClientesReference.Service1Client service = new Service1Client();
            ClientesReference.Tarjetas tarjetas = new ClientesReference.Tarjetas();
            tarjetas.NoTarjeta = Tarjeta;
            var request = service.GetTarjeta(tarjetas);

            if (request.Code == 100)
            {

                foreach (var obj in request.ClientesList)
                {
                    label2.Text = "¿Eres " + obj.Nombre + " ?" ;
                    label2.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            button3.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            
        }

        public void button3_Click(object sender, EventArgs e)
        {

            int Nip = Convert.ToInt32(textBox2.Text);
            TarjetasReference.Tarjetas tarjetas1 = new TarjetasReference.Tarjetas();
            TarjetasReference.TarjetasClient tarjetas = new TarjetasReference.TarjetasClient();
            tarjetas1.Nip = Nip;
            tarjetas1.NoTarjeta = Convert.ToInt32(textBox1.Text);
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
                Form1 form1 = new Form1();
                this.Hide();

               


                Form2 form2 = new Form2();
                form2.label1f2.Text = "Tu saldo es: " + saldo;
                form2.labelsaldo.Text =Convert.ToString(saldo);
                form2.label2.Text = textBox1.Text;
                form2.ShowDialog();
                
                this.Show();

            }

            else if (request.Code == 50)
            {

                label4.Text = "Nip incorrecto";
                label4.Visible = true;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();


            Form5 form5 = new Form5();
            form5.ShowDialog();

            this.Show();



        }
    }
}
