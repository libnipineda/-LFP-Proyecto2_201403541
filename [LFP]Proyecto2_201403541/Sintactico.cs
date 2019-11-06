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
         * 
         */

        // variables                
        Lista preanalisis;
        List<Lista> listatokens;
        List<Parser> parser = new List<Parser>();
        int numpre, num, idtkn, fila, columna;
        string lexe, token;

        public void Parsear(List<Lista> lista)
        {
            listatokens = lista;
            num = 0 - 1; idtkn = 0; fila = 0; columna = 0; lexe = "---"; token = "Ultimo Token";
            AgregarListaA(num, lexe, idtkn, token, fila, columna);

            preanalisis = lista.ElementAt(0); // primer elemento de la lista.
            numpre = 0; // siguiente elemento.
            Inicio(); // primera produccion.
        }

        public void AgregarListaA(int num, string lexema, int idtkn, string tkn, int fila, int columna)
        {
            Lista aux = new Lista(num, lexema, idtkn, tkn, fila, columna);
            aux.Numero = num;
            aux.Lexema = lexema.Trim();
            aux.Idtkn = idtkn;
            aux.Tkn = tkn;
            aux.Fila = fila;
            aux.Columna = columna;
            listatokens.Add(aux);
        }

        public void Inicio()
        {

        }

        public void Parea(String valor)
        {
            if (!valor.Equals(preanalisis.Idtkn))// lo  que viene no es lo que se esperaba
            {
                MessageBox.Show("Error sintactico");
            }
            if (!preanalisis.Idtkn.Equals(0)) // saber si ya llego al tope de la lista
            {
                numpre++; // incrementa el valor del numero de preanalisis.
                preanalisis = listatokens.ElementAt(numpre); // ya esta en la siguiente posicion de la lista.
            }
        }
    }
}