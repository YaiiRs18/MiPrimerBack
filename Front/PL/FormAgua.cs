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
    public partial class FormAgua : Form
    {
        public FormAgua()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (label3.Text != "")
                {
                    int Saldo = Convert.ToInt32(textBox2.Text);
                    TarjetasReference.Tarjetas tarjetas1 = new TarjetasReference.Tarjetas();
                    TarjetasReference.TarjetasClient tarjetas = new TarjetasReference.TarjetasClient();


                    tarjetas1.Saldo = Saldo;
                    tarjetas1.NoTarjeta = Convert.ToInt32(label3.Text);
                    var request = tarjetas.UpdateRe(tarjetas1);

                    if (request.Code == 100)
                    {
                        PagosReference1.PagosClient pagoservicio = new PagosReference1.PagosClient();
                        PagosReference1.Pagos pagos = new PagosReference1.Pagos();
                        pagos.Monto = Convert.ToInt32(textBox2.Text);
                        pagos.Referencia = Convert.ToString(textBox1.Text);
                        pagos.Servicios = new PagosReference1.Servicios();
                        pagos.Servicios.IdServicios = 1;

                        var requestadd = pagoservicio.GetPagos(pagos);
                        if (requestadd.Code == 100)
                        {
                            MessageBox.Show("Operacion Exitosa");
                        }
                        else
                        {
                            MessageBox.Show(requestadd.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show(request.Message);
                    }



                }
                else
                {
                    PagosReference1.PagosClient pagoservicio = new PagosReference1.PagosClient();
                    PagosReference1.Pagos pagos = new PagosReference1.Pagos();
                    pagos.Monto = Convert.ToInt32(textBox2.Text);
                    pagos.Referencia = Convert.ToString(textBox1.Text);
                    pagos.Servicios = new PagosReference1.Servicios();
                    pagos.Servicios.IdServicios = 1;

                    var requestadd = pagoservicio.GetPagos(pagos);
                    if (requestadd.Code == 100)
                    {
                        MessageBox.Show("Operacion Exitosa");
                    }
                    else
                    {
                        MessageBox.Show(requestadd.Message);
                    }
                }



            }
            else
            {
                {

                    MessageBox.Show("Campos vacios");
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
