using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Proyecto2_201403541
{
    class Lista
    {
        private int numero = 0;
        private string lexema = "";
        private int idtkn = 0;
        private string tkn = "";
        private int fila = 0;
        private int columna = 0;

        public Lista(int numero, string lexema, int idtkn, string tkn, int fila, int columna )
        {
            this.Numero = numero;
            this.Lexema = lexema;
            this.Idtkn = idtkn;
            this.Tkn = tkn;
            this.Fila = fila;
            this.Columna = columna;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Lexema { get => lexema; set => lexema = value; }
        public int Idtkn { get => idtkn; set => idtkn = value; }
        public string Tkn { get => tkn; set => tkn = value; }
        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
    }

    class Elista
    {
        public int Enum = 0;
        public string Elex = "";
        public int Eid = 0;
        public string Etkn = "";
        public int Efila = 0;
        public int Ecolumna = 0;
    }

    class Parser
    {
        public int num = 0;
        public int fila = 0;
        public string tkn = "";
        public string lex = "";
        public string obtuvo = "";
    }

    class Traducir
    {
        public string valor = "";
    }
}