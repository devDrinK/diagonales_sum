using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagonales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random x = new Random();
        int anchoCelda = 30;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum.Multiline = false;
            txtMatriz.Multiline = true;
            txtMatriz.WordWrap = false;
            txtMatriz.ReadOnly = true;
            txtMatriz.Font = new Font("Courier New", 12);
        }

        float factorAncho = 1.7f; // Puedes ajustar este factor
        float factorAlto = 1.2f;
        private async void txtNum_Click(object sender, EventArgs e)
        {
            txtMatriz.Clear();

            if (int.TryParse(txtNum.Text, out int def) && def > 0)
            {
                string[,] diagonales = new string[def,def];
                int[,] matriz = new int[def, def];
                int altoCelda = 30;
                int margen = 20;

                txtMatriz.Width = (int)((def * anchoCelda + margen) * factorAncho);
                txtMatriz.Height = (int)((def * altoCelda + margen) * factorAlto);

                

                // Generar la matriz con valores aleatorios
                for (int i = 0; i < def; i++)
                {
                    for (int j = 0; j < def; j++)
                    {
                        matriz[i, j] = x.Next(50);
                    }
                }
                CenterTextBox();
                int sumaDiagonalPrincipal = 0;
                int sumaDiagonalSecundaria = 0;
                int p = matriz.GetLength(0);
                // Imprimir la matriz original
                for (int i = 0; i < def; i++)
                {
                    string row = "| ";
                    sumaDiagonalPrincipal += matriz[i, i];
                    sumaDiagonalSecundaria += matriz[i, p - i - 1];
                    for (int j = 0; j < def; j++)
                    {
                        row += matriz[i, j].ToString("D2") + " | ";
                    }
                    txtMatriz.AppendText(row + Environment.NewLine);

                    if (i < def - 1)
                    {
                        string separator = "|";
                        for (int j = 0; j < def; j++)
                        {
                            separator += new string('_', 4) + "|";
                        }
                        txtMatriz.AppendText(separator + Environment.NewLine);
                    }

                    await Task.Delay(500);
                }

                await Task.Delay(1000);
                
                txtMatriz.Clear();
                // Imprimir solo las diagonales con el formato deseado
                for (int i = 0; i < def; i++)
                {
                    string row = "| ";
                    for (int j = 0; j < def; j++)
                    {
                        if (i == j || j == def - i - 1) // Verificar si es parte de alguna de las diagonales
                        {
                            row += matriz[i, j].ToString("D2").PadLeft(2).PadRight(2) + " | ";
                        }
                        else
                        {
                            row += "   | "; // Espacio en blanco para alinear correctamente
                        }
                    }
                    txtMatriz.AppendText(row + Environment.NewLine);

                    if (i < def - 1)
                    {
                        string separator = "|";
                        for (int j = 0; j < def; j++)
                        {
                            separator += new string('_', 4) + "|";
                        }
                        txtMatriz.AppendText(separator + Environment.NewLine);
                    }

                    await Task.Delay(500); // Simular un retraso para efectos visuales
                }

                lblDprincipal.Text = $"La suma de la principal es: {sumaDiagonalPrincipal}";
                lblDopuesta.Text = $"La suma de la opuesta es: {sumaDiagonalSecundaria}";
            }
            else if (txtNum.Text == "")
            { }
            else
            {
                MessageBox.Show("Ingresa solo números enteros positivos.");
            }
        }

        private void CenterTextBox()
        {
            txtMatriz.Left = (this.ClientSize.Width - txtMatriz.Width) / 2;
            txtMatriz.Top = (this.ClientSize.Height - txtMatriz.Height) / 2;
        }

        private void txtMatriz_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDprincipal_Click(object sender, EventArgs e)
        {

        }

        private void lblDopuesta_Click(object sender, EventArgs e)
        {

        }
    }
}
