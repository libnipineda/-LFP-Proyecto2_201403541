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
         * 1  -> class, 2  -> numero, 3  -> static, 4  -> void, 5  -> Main, 6  -> (, 7  ->  args, 8  -> ), 9 -> {, 10 -> }, 11 -> int, 12 -> float
           13 -> bool, 14 -> char, 15 -> string o String, 16 -> ,, 17 -> -, 18 -> ;, 19 -> /, 20 -> =, 21 -> ==, 22 -> >, 23 -> <, 24 -> !=, 25 -> +, 26 -> -
           27 -> *, 28 -> Console, 29 -> Write , 30 -> [, 31 -> ], 32 -> new, 33 -> if, 34 -> else, 35 -> switch, 36 -> case, 37 -> break, 38 -> default
           39 -> :, 40 -> for, 41 -> <=, 42 -> >=, 43 -> while, 44 -> true, 45 -> false, 46 -> cadena
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
                Parea(46);
                Parea(9);
                Estructura();
                Parea(10);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la produccion <INICIO>", "Advertencia");
            }
        }

        public void Estructura()
        {
            try
            {
                MessageBox.Show("Produccion <ESTRUCTURA>", "Información");
                Parea(3);
                Parea(4);
                Parea(5);
                Parea(6);
                Parea(15);
                Parea(30);
                Parea(31);
                Parea(7);
                Parea(8);
                Parea(9);
                Instruccion();
                Parea(10);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la produccion <ESTRUCTURA>", "Advertencia");
            }            
        }

        public void Instruccion()
        {
            try
            {
                MessageBox.Show("Produccion <INSTRUCCION>", "Información");
                Variable(); Instruccion();
                Arreglo(); Instruccion();
                Graficar_V(); Instruccion();
                Expresion_A(); Instruccion();

            }
            catch (Exception)
            {
                MessageBox.Show("Error en la produccion <INSTRUCCION>", "Advertencia");
            }
        }

        public void Variable()
        {

        }

        public void Arreglo()
        {

        }

        public void Graficar_V()
        {

        }

        public void Expresion_A()
        {

        }

        public void Operadores_R()
        {

        }

        public void Imprimir()
        {

        }

        public void If()
        {

        }

        public void For()
        {

        }

        public void Switch()
        {

        }

        public void While()
        {

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