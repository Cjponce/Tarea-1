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
            // asignando valor del texbox a variable
            Decimal num1 = Convert.ToDecimal(numero1textBox1.Text);
            // llamamos la funcion positivo y negativo y le asignamos
            // el valor del numero para que nos retorne el resultado a la variable
            string resultado = pos_nega(num1);
            // llamamos la funcion par impar y le asignamos el valor
            // del numero para que nos retorne el resultado a la variable
            string par_imp = par_impar(num1);
            //para mostrar los mensajes 
            MessageBox.Show("el numero es " + resultado + " y es " + par_imp);
        }

        //funcion par impar recibira un valor y retornara si el valor es impar o par
        private string par_impar(decimal num)
        {
            decimal parimpar = 0;// almacenar 0 o 1 de la primer condicion
            string res2 = " "; // para almacenar el resultado
            decimal mayor = 0;

            // if para saber si el numero es positivo o negativo
            if (num > 0) //si el numero es mayor que 0 entonces asignamos
                         //ese valor ala variable mayor y sabemos que es positivo 
            {
                mayor = num;
            }
            else { mayor = num * -1; }//aqui seria en caso contrario si es menor que 0
                                      //entonces el numero lo multiplicamos por -1 para 
                                      //que nos de un numero positivo y hacer la operacion siguiente
            parimpar = mayor % 2; // operacion para saber si es un numero par o impar
                                  // % lo que hace es darnos como resultado un 0 o 1 oh el
                                  // residio de una divicion si es 0 es par si es 1 es impar

            // si para saber si es par o impar 
            if (parimpar > 0) // si variable es mayor que cero sera impar y la retornara 
            {
                res2 = "impar";
            }
            else { res2 = "par"; } // caso contrario si es 0 almacenara la respuesta par y lo retornara
            return res2;
        }
        // funcion para retornar valor positivo o negativo
        private string pos_nega(decimal num)
        {
            string res = " "; // para almacenar el valor 
            //si para saber si es positivo o negativo
            if (num == 0)  // si variable es igual a 0 sera un valor neutro
            {
                res = "Neutro";
            }
            else if (num > 0)// si el valor es mayor que 0 es un valor positivo 
            {
                res = "positivo";
            }
            else { res = "negativo"; }// caso contrario si la variable es
                                      // un valor menor a cero sera negativo
            return res;
        }




    }
}
