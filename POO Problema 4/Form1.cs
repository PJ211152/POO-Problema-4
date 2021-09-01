using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Problema_4
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

        private void txt_arreglo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_arreglo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                lst_lista.Items.Add(txt_arreglo.Text);
                txt_arreglo.Clear();
                txt_arreglo.Focus();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int mayorneg = -1000;
            double cantidadnumeros = lst_lista.Items.Count;
            double cantidadceros = 0;
            double porcentaje = 0;
            double prom;
            double cantidadimpares = 0;
            double suma = 0;

            try
            {
                if (txt_ParesNeg.Text.Length != 0)
                {
                    for (int i = 0; i < lst_lista.Items.Count; i++)
                    {
                        string valor = lst_lista.Items[i].ToString();
                        int numero = int.Parse(valor);
                        if (numero < 0 && numero % 2 == 0)
                        {
                            if (numero > mayorneg)
                            {
                                mayorneg = numero;
                                txt_ParesNeg.Text = mayorneg.ToString();
                            }
                        }
                        else
                        {
                            txt_ParesNeg.Text = "No hay números negativos pares";
                        }
                    }

                }

                if (txt_PorcentajeCeros.Text.Length != 0)
                {
                    for (int i = 0; i < lst_lista.Items.Count; i++)
                    {
                        string valor = lst_lista.Items[i].ToString();
                        int numero = int.Parse(valor);
                        if (numero == 0)
                        {
                            cantidadceros = cantidadceros + 1;
                        }
                    }
                    porcentaje = (cantidadceros / cantidadnumeros) * 100;
                    txt_PorcentajeCeros.Text = porcentaje.ToString() + "%";

                }

                if (txt_ImparesPositivos.Text.Length != 0)
                {
                    for (int i = 0; i < lst_lista.Items.Count; i++)
                    {
                        string valor = lst_lista.Items[i].ToString();
                        int numero = int.Parse(valor);
                        if (numero > 0 && numero % 2 != 0)
                        {
                            suma = suma + numero;
                            cantidadimpares = cantidadimpares + 1;
                        }
                    }
                    prom = suma / cantidadimpares;
                    txt_ImparesPositivos.Text = prom.ToString();
                }

                if (txt_MayorParPos.Text.Length != 0)
                {
                    int mayor = 0;
                    for (int i = 0; i < lst_lista.Items.Count; i++)
                    {
                        string valor = lst_lista.Items[i].ToString();
                        int numero = int.Parse(valor);
                        if (numero > 0 && numero % 2 == 0)
                        {
                            if (numero > mayor)
                                mayor = numero;
                        }
                    }
                    txt_MayorParPos.Text = mayor.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese caracteres validos");
            }
        }
    }
}
