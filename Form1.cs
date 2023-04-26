using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop_For_em_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            //ListBox.Items.Add(1);
            //ListBox.Items.Add(2);
            //ListBox.Items.Add(3);
            //ListBox.Items.Add(50);

            //For
            for (int valor = 0; valor <= 50; valor++) //++ incremento
            {
                ListBox.Items.Add(valor);
            }

            ////For para apresentar números ímpares
            //for (int valor = 1; valor <= 30; valor += 2) //++ incremento
            //{
            //    ListBox.Items.Add(valor);
            //}

            ////For para apresentar números decrescentes
            //for (int valor = 200; valor >= 100; valor--) //-- incremento
            //{
            //    ListBox.Items.Add(valor);
            //}

            //Se escrever for e der tab + tab cria automaticamente essa estrutura:
            //for (int i = 0; i < length; i++)
            //{

            //}
        }
    }
}
