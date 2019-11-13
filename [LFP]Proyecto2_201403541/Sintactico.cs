﻿using System;
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
           39 -> :, 40 -> for, 41 -> <=, 42 -> >=, 43 -> while, 44 -> true, 45 -> false, 46 -> cadena, 0 -> Ultimo token, 47 -> graficarVector, 48 -> decimal
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
                MessageBox.Show("Produccion <INICIO>.", "Información");
                Parea(1);//class
                Parea(46);//cadena
                Parea(9);//{
                Estructura();
                Parea(10);//}
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la produccion <INICIO>", "Advertencia");
                Parea(0);
            }
        }

        public void Estructura()
        {
            try
            {
                MessageBox.Show("Produccion <ESTRUCTURA>", "Información");
                Parea(3);//static
                Parea(4);//void
                Parea(5);//Main
                Parea(6);//(
                Parea(15);//string
                Parea(30);//[
                Parea(31);//]
                Parea(7);//args
                Parea(8);//)
                Parea(9);//{
                //Instruccion();
                Parea(10);//}
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la produccion <ESTRUCTURA>", "Advertencia");
                Parea(0);
            }
        }

        public void Introduccion()
        {
            try
            {
                MessageBox.Show("Produccion <INTRODUCCION>", "Informacion.");
                if (TokenActual.Idtkn.Equals(11) || TokenActual.Idtkn.Equals(12) || TokenActual.Idtkn.Equals(13) || TokenActual.Idtkn.Equals(14) || TokenActual.Idtkn.Equals(15))
                {
                    Declaracion(); Introduccion();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la produccion <INTRODUCCION>", "Advertencia.");
                Parea(0);
            }
        }

        public void Declaracion()
        {
            try
            {
                MessageBox.Show("Produccion <DECLARACION>", "Informacion.");
                if (TokenActual.Idtkn.Equals(11) || TokenActual.Idtkn.Equals(12) || TokenActual.Idtkn.Equals(13) || TokenActual.Idtkn.Equals(14) || TokenActual.Idtkn.Equals(15))
                {
                    Tipo(); ListaVar();                    
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error en la produccion <DECLARACION>", "Advertencia.");
                Parea(0);
            }
        }

        public void Tipo()
        {
            try
            {
                MessageBox.Show("Produccion <TIPO>.", "Información.");
                if (TokenActual.Idtkn.Equals(11))
                {
                    Parea(11);
                }
                else if (TokenActual.Idtkn.Equals(12))
                {
                    Parea(12);
                }
                else if (TokenActual.Idtkn.Equals(13))
                {
                    Parea(13);
                }
                else if (TokenActual.Idtkn.Equals(14))
                {
                    Parea(14);
                }
                else if (TokenActual.Idtkn.Equals(15))
                {
                    Parea(15);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la produccion <TIPO>.", "Advertencia.");
                Parea(0);
            }
        }

        public void ListaVar()
        {
            try
            {
                MessageBox.Show("Producción <LISTA_VAR>","Información.");
                if (TokenActual.Idtkn.Equals(30))
                {
                    Parea(30);//[
                    Parea(31);//]
                    Parea(46);//cadena
                    Parea(20);//=
                    ValorArreglo();
                    ListaVar();
                }
                else if (TokenActual.Idtkn.Equals(46))
                {
                    Parea(46);//cadena
                    ValorAsignacion();
                    ListaVar();
                }
                else
                {
                    //Termina la produccion lista_var
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error producción <LISTA_VAR>","Advertencia.");
                Parea(0);
            }
        }

        public void ValorArreglo()
        {
            try
            {
                MessageBox.Show("Producción <VALOR_ARREGLO>","Información.");
                if (TokenActual.Idtkn.Equals(32))
                {
                    Parea(32);//new
                    Tipo();
                    Parea(30);//[
                    Parea(31);//]
                    Parea(18);//;
                }
                else if (TokenActual.Idtkn.Equals(9))
                {
                    Parea(9);//{
                    TipoVar();
                    Argumento();
                    Parea(10);//}
                    Parea(18);//;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la producción <VALOR_ARREGLO>","Advertencia.");
                Parea(0);
            }
        }

        public void ValorAsignacion()
        {
            try
            {
                MessageBox.Show("Producción <VALOR_ASIGNACION>", "Informacion.");
                if (TokenActual.Idtkn.Equals(16))
                {
                    Parea(16);//,
                    Otros();
                    ValorAsignacion();
                }
                else if (TokenActual.Idtkn.Equals(20))
                {
                    Parea(20);//=
                    TipoVar();
                    ValorAsignacion();
                }
                else if (TokenActual.Idtkn.Equals(18))
                {
                    Parea(18);//;
                    ValorAsignacion();
                }
                else
                {
                    // sale de la produccion.
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error producción <VALOR_ASIGNACION>","Advertencia.");
                Parea(0);
            }
        }

        public void Otros()
        {
            try
            {
                MessageBox.Show("Producción <OTROS>","Información.");

            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error producción <OTROS>","Advertencia.");
            }
        }

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