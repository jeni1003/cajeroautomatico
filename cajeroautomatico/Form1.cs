using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajeroautomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDinero_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            double cantidad = double.Parse(txtDinero.Text);
            sbyte n = 0;
            string respuesta = "Total: \n";
            foreach (double denominacion in denominaciones)
            {
                while (denominacion <= Math.Round(cantidad, 2))
                {
                    n++;
                    cantidad -= denominacion;
                }
                if (n > 0)
                {
                    respuesta += n + (denominacion > 1 ? " Billetes de " : " Monedas de ") + denominacion + "\n";
                }
                n = 0;
            }
            lblTotal.Text = respuesta;
            txtDinero.Text = "";
        }

        private void btnDinero1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtDinero1.Text), b = double.Parse(txtDinero2.Text), total;
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            sbyte n = 0;
            string respuesta = "Total: \n";
            foreach (double denominacion in denominaciones)
            {
                total = a - b;
                while (denominacion <= Math.Round(a, 2))
                {
                    a++;
                    //
                    a -= denominacion;
                }
                if (n > 0)
                {
                    respuesta += total + "\n" + a + (denominacion > 1 ? " Billetes de " : " Monedas de ") + denominacion;
                    n = 0;
                    lblTotal2.Text = respuesta;
                }
            }
        }

        private void btnFibocci_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtFibocci.Text), a = 0, b = 1, au, i;
            string respuesta = "";
            for (i = 0; i < n; i++)
            {
                au = a;
                a = b;
                b = au + a;
                respuesta += "la suma de " + a + " es " + b + "\n";
                lblFiboResp.Visible = true;
                lblFiboResp.Text = "" + respuesta;
                txtFibocci.Text = "";
            }
        }

        private void btnPrm_Click(object sender, EventArgs e)
        {
            int a = 0, i, n;
            n = int.Parse(txtPrm.Text);
            a = 0;
            for (i = 1; i < (n + 1); i++)

                if (n % i == 0)
                    a++;
            lblPrimoResp.Text = ((a != 2) ? n + " No es primo " : n + "  Es primo" + "\n");
            txtPrm.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
