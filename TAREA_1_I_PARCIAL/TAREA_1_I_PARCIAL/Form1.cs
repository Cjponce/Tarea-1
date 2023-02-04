using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA_1_I_PARCIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal num1 = Convert.ToDecimal(numero1textBox1.Text);
            string resultado = pos_nega(num1);
            string par_imp = par_impar(num1);
            MessageBox.Show("el numero es " + resultado + " y es " + par_imp);
        }
        private string par_impar(decimal num)
        {
            decimal parimpar = 0;
            string res2 = " ";
            decimal mayor = 0;

            if (num > 0)
            {
                mayor = num;
            }
            else { mayor = num * -1; }
            parimpar = mayor % 2;
            if (parimpar > 0)
            {
                res2 = "impar";
            }
            else { res2 = "par"; }
            return res2;
        }
        private string pos_nega(decimal num)
        {
            string res = " ";
            if (num == 0)
            {
                res = "Neutro";
            }
            else if (num > 0)
            {
                res = "positivo";
            }
            else { res = "negativo"; }
            return res;
        }




    }
}
