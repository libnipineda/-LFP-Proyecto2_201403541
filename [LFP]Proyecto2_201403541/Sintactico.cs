using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LFP_Proyecto2_201403541
{
    class Sintactico
    {
        /* correlativo y lexema:
         * 1  -> class, 2  -> numero, 3  -> static, 4  -> void, 5  -> Main, 6  -> (, 7  -> string[], 8  ->  args, 9  -> ), 10 -> {, 11 -> }, 12 -> int, 13 -> float
           14 -> bool, 15 -> char, 16 -> string o String, 17 -> ,, 18 -> -, 19 -> ;, 20 -> /, 21 -> =, 22 -> ==, 23 -> >, 24 -> <, 25 -> !=, 26 -> +, 27 -> -
           28 -> *, 29 -> Console, 30 -> Write , 31 -> [, 32 -> ], 33 -> new, 34 -> if, 35 -> else, 36 -> switch, 37 -> case, 38 -> break, 39 -> default
           40 -> :, 41 -> for, 42 -> <=, 43 -> >=, 44 -> while, 45 -> true, 46 -> false
         */

        // variables
        int numpre;
        Lista TokenActual;
        //LinkedList<Lista> listatokens;
        List<Lista> listatokens;

        //public void Parsear(LinkedList<Lista> tokens)
        //{
        //    this.listatokens = tokens;
        //    numpre = 0; // siguiente elemento.
        //    TokenActual = listatokens.ElementAt(numpre); // primer elemento de la lista.
        //    Console.WriteLine(tokens.Count());
        //    Inicio(); // primera producción.
        //}       

        public void Parsear(List<Lista> tokens)
        {
            listatokens = tokens;
            Lista aux = new Lista(0, "Ultimo", 0, "Ultimo Valor", 0, 0);
            listatokens.Add(aux);

            TokenActual = tokens.ElementAt(0);
            numpre = 0;
            Inicio();
        }

        public void Inicio()
        {
            MessageBox.Show("Inicio de la Gramatica", "Información");
            try
            {
                MessageBox.Show("Produccion <INICIO>.","Información");
                Parea(1);
                Parea(47);
                Parea(10);
                Estructura();
                Parea(11);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la produccion <INICIO>", "Advertencia");
            }
        }

        public void Estructura()
        {
            MessageBox.Show("Produccion <ESTRUCTURA>", "Información");
        }

        //public void Parea(int valor)
        //{
        //    if (TokenActual.Idtkn != valor)
        //    {
        //        MessageBox.Show("Error se esperaba " + valor.ToString() + "y se obtuvo token: " + TokenActual.Idtkn);
        //    }
        //    if (TokenActual.Idtkn.Equals(listatokens.Equals("0")))
        //    {
        //        numpre += 1;
        //        TokenActual = listatokens.ElementAt(numpre);
        //    }
        //}

        public void Parea(int valor)
        {
            if (!valor.Equals(TokenActual.Idtkn)) //Verifica que los valores coincidan
            {
                MessageBox.Show("Error se esperaba " + valor.ToString() + "y se obtuvo token: " + TokenActual.Idtkn + "->" + TokenActual.Lexema);
            }
            if (!TokenActual.Idtkn.Equals(0)) // Verifica si ya llego al tope de la lista.
            {
                numpre += 1;
                TokenActual = listatokens.ElementAt(numpre);
            }
        }
    }
}