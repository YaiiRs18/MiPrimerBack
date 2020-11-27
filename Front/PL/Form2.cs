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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

       

            int Saldo = Convert.ToInt32(textBox1.Text);
            TarjetasReference.Tarjetas tarjetas1 = new TarjetasReference.Tarjetas();
            TarjetasReference.TarjetasClient tarjetas = new TarjetasReference.TarjetasClient();

          
            tarjetas1.Saldo = Saldo;
            tarjetas1.NoTarjeta = Convert.ToInt32(label2.Text);
            var request = tarjetas.UpdateRe(tarjetas1);

            if (request.Code == 100)
            {

                Form2 form2 = new Form2();
                this.Hide();

                Form3 form3 = new Form3();
                form3.label1.Text = "Operacion Exitosa";
                form3.label4.Text = label2.Text;
                form3.ShowDialog();

                this.Show();


            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();


            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
            this.Hide();
        }
    } 
}
