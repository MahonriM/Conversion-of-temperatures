using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        private TextBox varTemp = null;
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                if (varTemp == Temperatura1)
                {
                    grados = Convert.ToDouble(Temperatura1.Text) * 1.8 + 32;
                    //Mostrar resultaod
                    btnfarenhit.Text = string.Format("{0:F}", grados);

                }
                //si se escribio en caja de grados Farenhit
                if (varTemp == btnfarenhit)
                {
                    grados = ((Convert.ToDouble(btnfarenhit.Text)) - 32) / 1.8;
                    //Mostrar resultaod
                    Temperatura1.Text = string.Format("{0:F}", grados);//en string.Format se decide e
                }

            }
            catch (FormatException)
            {
                Temperatura1.Text = "0.00";
                btnfarenhit.Text = "32.00";
                            
                

            }
           
        }             
        private void Temperatura1_KeyPress(object sender, KeyPressEventArgs e)//Key Press para ver la caja 
        {//handled_propiedad de tipo bool
            if (e.KeyChar < '0' || e.KeyChar > '9')//Para que no deje escribir letras solo numeros
            {
                e.Handled = true;

            }
            varTemp = (TextBox)sender;//sender objeto que genero el evento

        }

        private void btnfarenhit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<'0'||e.KeyChar>'9')//Para que no deje escribir letras solo numeros
            {
                e.Handled = true;
                
            }
            varTemp = (TextBox)sender;
        }
    }
}
