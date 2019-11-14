using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public int numerror;
        Lista TokenActual;
        List<Lista> listatokens;
        List<Parser> ListaC = new List<Parser>();

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
                //MessageBox.Show("Produccion <INICIO>.", "Información");                
                Console.WriteLine("Produccion <INICIO>.", "Información");
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
                //MessageBox.Show("Produccion <ESTRUCTURA>", "Información");
                Console.WriteLine("Produccion <ESTRUCTURA>", "Información");
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
                Instruccion();
                Parea(10);//}
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la produccion <ESTRUCTURA>", "Advertencia");
                Parea(0);
            }
        }

        public void Instruccion()
        {
            try
            {
                //MessageBox.Show("Produccion <INTRODUCCION>", "Informacion.");
                Console.WriteLine("Produccion <INTRODUCCION>");
                if (TokenActual.Idtkn.Equals(11) || TokenActual.Idtkn.Equals(12) || TokenActual.Idtkn.Equals(13) || TokenActual.Idtkn.Equals(14) || TokenActual.Idtkn.Equals(15))
                {
                    Declaracion(); Instruccion();
                }
                else if (TokenActual.Idtkn.Equals(47) || TokenActual.Idtkn.Equals(28))
                {
                    Imprimir(); Instruccion();
                }
                else if (TokenActual.Idtkn.Equals(35))
                {
                    Switch(); Instruccion();
                }
                else if (TokenActual.Idtkn.Equals(33))
                {
                    IF(); Instruccion();
                }
                else if (TokenActual.Idtkn.Equals(40))
                {
                    FOR(); Instruccion();
                }
                else if (TokenActual.Idtkn.Equals(43))
                {
                    WHILE(); Instruccion();
                }
                else
                {
                    // sale de la producción.
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
                else if (TokenActual.Idtkn.Equals(30) || TokenActual.Idtkn.Equals(46))
                {
                    ListaVar();
                }
            }
            catch (Exception)
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
                    Parea(11);//int
                }
                else if (TokenActual.Idtkn.Equals(12))
                {
                    Parea(12);//float
                }
                else if (TokenActual.Idtkn.Equals(13))
                {
                    Parea(13);//bool
                }
                else if (TokenActual.Idtkn.Equals(14))
                {
                    Parea(14);//char
                }
                else if (TokenActual.Idtkn.Equals(15))
                {
                    Parea(15);//string
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
                MessageBox.Show("Producción <LISTA_VAR>", "Información.");
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
                    J();
                    ListaVar();
                }
                else
                {
                    //Termina la produccion lista_var
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error producción <LISTA_VAR>", "Advertencia.");
                Parea(0);
            }
        }

        public void J()
        {
            try
            {
                MessageBox.Show("Producción <J>", "Información.");
                if (TokenActual.Idtkn.Equals(16) || TokenActual.Idtkn.Equals(20) || TokenActual.Idtkn.Equals(18))
                {
                    ValorAsignacion();
                }
                else if (TokenActual.Idtkn.Equals(19) || TokenActual.Idtkn.Equals(27) || TokenActual.Idtkn.Equals(25) || TokenActual.Idtkn.Equals(26))
                {
                    Expresion();
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la producción <J>", "Advertencia.");
            }
        }

        public void ValorArreglo()
        {
            try
            {
                MessageBox.Show("Producción <VALOR_ARREGLO>", "Información.");
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
                MessageBox.Show("Error en la producción <VALOR_ARREGLO>", "Advertencia.");
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
                    Expresion();
                    J();
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
                MessageBox.Show("Error producción <VALOR_ASIGNACION>", "Advertencia.");
                Parea(0);
            }
        }

        public void Otros()
        {
            try
            {
                MessageBox.Show("Producción <OTROS>", "Información.");
                if (TokenActual.Idtkn.Equals(11) || TokenActual.Idtkn.Equals(12) || TokenActual.Idtkn.Equals(13) || TokenActual.Idtkn.Equals(14) || TokenActual.Idtkn.Equals(15))
                {
                    Tipo();
                    Parea(46);//cadena
                }
                else if (TokenActual.Idtkn.Equals(2) || TokenActual.Idtkn.Equals(46) || TokenActual.Idtkn.Equals(48) || TokenActual.Idtkn.Equals(44) || TokenActual.Idtkn.Equals(45))
                {
                    TipoVar();
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error producción <OTROS>", "Advertencia.");
            }
        }

        public void TipoVar()
        {
            try
            {
                MessageBox.Show("Producción <TIPO_VAR>", "Información.");
                if (TokenActual.Idtkn.Equals(2))
                {
                    Parea(2);//numero
                }
                else if (TokenActual.Idtkn.Equals(46))
                {
                    Parea(46);//cadena
                }
                else if (TokenActual.Idtkn.Equals(48))
                {
                    Parea(48);//decimal
                }
                else if (TokenActual.Idtkn.Equals(44))
                {
                    Parea(44);//true
                }
                else if (TokenActual.Idtkn.Equals(45))
                {
                    Parea(45);//false
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la producción <TIPO_VAR>", "Advertencia.");
            }
        }

        public void Argumento()
        {
            try
            {
                MessageBox.Show("Producción <ARGUMENTO>", "Información");
                if (TokenActual.Idtkn.Equals(16))
                {
                    Parea(16);//,
                    TipoVar();
                    Argumento();
                }
                else
                {
                    //sale de la producción.
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la producción <ARGUMENTO>", "Advertencia.");
            }
        }

        public void Imprimir()
        {
            try
            {
                MessageBox.Show("Producción <IMPRIMIR>", "Información.");
                if (TokenActual.Idtkn.Equals(47))
                {
                    GraficarV();
                }
                else if (TokenActual.Idtkn.Equals(28))
                {
                    Parea(28);//Console
                    Parea(17);//.
                    Parea(29);//WriteLine
                    Parea(6);//(
                    ListadoImprimir();
                    Parea(8);//)
                    Parea(18);//;
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la producción <IMPRIMIR>", "Advertencia.");
            }
        }

        public void GraficarV()
        {
            try
            {
                MessageBox.Show("Producción <GRAFICAR_V>", "Información.");
                Parea(47);//graficarVector
                Parea(6);//(
                Parea(46);//cadena
                Parea(16);//,
                Parea(46);//cadena
                Parea(8);//)
                Parea(18);//;
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la producción <GRAFICAR_V>", "Advertencia.");
            }
        }

        public void ListadoImprimir()
        {
            try
            {
                MessageBox.Show("Producción <LISTADO_IMPRIMIR>", "Información");
                if (TokenActual.Idtkn.Equals(2) || TokenActual.Idtkn.Equals(46) || TokenActual.Idtkn.Equals(48) || TokenActual.Idtkn.Equals(44) || TokenActual.Idtkn.Equals(45))
                {
                    TipoVar();
                    Listado();
                }
                else
                {
                    //sale de la produccion.
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la producción <LISTADO_IMPRIMIR>", "Advertencia.");
            }
        }

        public void Listado()
        {
            try
            {
                MessageBox.Show("Producción <LISTADO>", "Informacion.");
                if (TokenActual.Idtkn.Equals(25))
                {
                    Parea(25);//+
                    TipoVar();
                    Listado();
                }
                else
                {
                    //sale de la produccion.
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <LISTADO>", "Advertencia.");
            }
        }

        public void Switch()
        {
            try
            {
                MessageBox.Show("Producción <SWITCH>", "Información.");
                Parea(35);//switch
                Parea(6);//(
                Parea(46);//cadena
                Parea(8);//)
                Parea(9);//{
                EstructuraSwitch();
                Parea(10);//}
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la producción <SWITCH>", "Advertencia.");
            }
        }

        public void EstructuraSwitch()
        {
            try
            {
                MessageBox.Show("Producción <ESTRUCTURA_SWITCH>", "Informacion.");
                Parea(36);//case
                TipoVar();
                Parea(39);//:
                Instruccion();
                Parea(37);//break
                Parea(18);//;
                EstSwitp();
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la producción <ESTRUTURA_SWITCH>", "Advertencia.");
            }
        }

        public void EstSwitp()
        {
            try
            {
                MessageBox.Show("Producción <EST_SWITP>", "Información.");
                if (TokenActual.Idtkn.Equals(36))
                {
                    EstructuraSwitch();
                }
                else
                {
                    Parea(38);//default
                    Parea(39);//:
                    Instruccion();
                    Parea(37);//break
                    Parea(18);//;
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la producción <EST_SWITP>", "Advertencia.");
            }
        }

        public void Expresion()
        {
            try
            {
                MessageBox.Show("Producción <EXPRESION>", "Información.");
                if (TokenActual.Idtkn.Equals(19) || TokenActual.Idtkn.Equals(27) || TokenActual.Idtkn.Equals(25) || TokenActual.Idtkn.Equals(26))
                {
                    ListaArit();
                    M();
                }
                else if (TokenActual.Idtkn.Equals(2) || TokenActual.Idtkn.Equals(6) || TokenActual.Idtkn.Equals(46) || TokenActual.Idtkn.Equals(48))
                {
                    M();
                }
                else
                {
                    //sale de la produccion
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la producción <EXPRESION>", "Advertencia.");
            }
        }

        public void M()
        {
            try
            {
                MessageBox.Show("producción <M>.", "Información.");
                if (TokenActual.Idtkn.Equals(2) || TokenActual.Idtkn.Equals(46) || TokenActual.Idtkn.Equals(48))
                {
                    Valor1();
                }
                else if (TokenActual.Idtkn.Equals(6))
                {
                    Parea(6);//(
                    ListaVar();
                    Parea(8);//)
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la producción <M>", "Advertencia.");
            }
        }

        public void Valor1()
        {
            try
            {
                MessageBox.Show("Producción <VALOR1>", "Información");
                if (TokenActual.Idtkn.Equals(2))
                {
                    Parea(2);//numero
                }
                else if (TokenActual.Idtkn.Equals(46))
                {
                    Parea(46);//cadena
                }
                else if (TokenActual.Idtkn.Equals(48))
                {
                    Parea(48);//decimal
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error de en la producción <VALOR1>", "Advertencia.");
            }
        }

        public void ListaArit()
        {
            try
            {
                MessageBox.Show("Producción <LISTA_ARIT>", "Información");
                if (TokenActual.Idtkn.Equals(19))
                {
                    Parea(19);// signo division
                }
                else if (TokenActual.Idtkn.Equals(27))
                {
                    Parea(27);//*
                }
                else if (TokenActual.Idtkn.Equals(26))
                {
                    Parea(26);//-
                }
                else if (TokenActual.Idtkn.Equals(25))
                {
                    Parea(25);//+
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <LISTA_ARIT>", "Advertencia.");
            }
        }

        public void IF()
        {
            try
            {
                MessageBox.Show("Produccion <IF>.", "Informacion");
                Parea(33);//if
                Parea(6);//(
                Sentencia();
                Parea(8);//)
                Parea(9);//{
                ArgumentoIf();
                Parea(10);//}
                IFP();
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <IF>", "Advertencia.");
            }
        }

        public void Sentencia()
        {
            try
            {
                MessageBox.Show("Produccion <SENTENCIA>", "Informacion.");
                Valor1();
                ListaOp();
                Valor1();
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <SENTENCIA>.", "Advertencia.");
            }
        }

        public void IFP()
        {
            try
            {
                MessageBox.Show("Produccion <IFP>", "Información.");
                if (TokenActual.Idtkn.Equals(34))
                {
                    Parea(34);//else
                    InstIf();
                }
                else
                {
                    //sale de la produccion
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <IFP>", "Advertencia.");
            }
        }

        public void InstIf()
        {
            try
            {
                MessageBox.Show("Produccion <INST_IF>", "Información.");
                if (TokenActual.Idtkn.Equals(9))
                {
                    Parea(9);//{
                    ArgumentoIf();
                    Parea(10);//}
                }
                else
                {
                    IF();
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <INST_IFP>", "Advertencia.");
            }
        }

        public void ArgumentoIf()
        {
            try
            {
                MessageBox.Show("Produccion <ARGUMENTO_IF>", "Información.");
                Instruccion();
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <ARGUMENTO_IF>", "Advertencia.");
            }
        }

        public void ListaOp()
        {
            try
            {
                MessageBox.Show("Produccion <LISTA_OP>", "Informacion.");
                if (TokenActual.Idtkn.Equals(20))
                {
                    Parea(20);//=
                    Parea(20);//=
                }
                else if (TokenActual.Idtkn.Equals(22))
                {
                    Parea(22);//>
                }
                else if (TokenActual.Idtkn.Equals(23))
                {
                    Parea(23);//<
                    N();
                }
                else if (TokenActual.Idtkn.Equals(46))
                {
                    Parea(46);//!
                    Parea(20);//=
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <LISTA_OP>.", "Advertencia.");
            }
        }

        public void N()
        {
            try
            {
                MessageBox.Show("Produccion <N>.", "Informacion");
                if (TokenActual.Idtkn.Equals(20))
                {
                    Parea(20);//=
                }
                else
                {
                    // sale de la produccion
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <N>.", "Advertencia.");
            }
        }

        public void FOR()
        {
            try
            {
                MessageBox.Show("Produccion <FOR>.", "Informacion");
                Parea(40);//for
                Parea(6);//(
                OP();
                Parea(18);//;
                OP1();
                Parea(18);//;
                Incremento();
                Parea(8);//)
                Parea(9);//{
                Instruccion();
                Parea(10);//}
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <FOR>.", "Advertencia.");
            }
        }

        public void OP()
        {
            try
            {
                MessageBox.Show("Produccion <OP>.", "Informacion");
                Tipo();
                Parea(46);//cadena
                Parea(20);//=
                Valor1();
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <OP>.", "Advertencia.");
            }
        }

        public void OP1()
        {
            try
            {
                MessageBox.Show("Produccion <OP1>.", "Informacion");
                Parea(46);//cadena
                ListaOp();
                Valor1();
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <OP1>.", "Advertencia.");
            }
        }

        public void Incremento()
        {
            try
            {
                MessageBox.Show("Produccion <INCREMENTO>.", "Informacion");                
                Parea(46);//cadena
                Inp();
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <INCREMENTO>.", "Advertencia.");
            }
        }

        public void Inp()
        {
            try
            {
                MessageBox.Show("Produccion <INP>.", "Informacion");
                if (TokenActual.Idtkn.Equals(25))
                {
                    Parea(25);//+
                    Parea(25);//+
                }
                else
                {
                    Parea(26);//-
                    Parea(26);//-
                    
                }
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <INP>.", "Advertencia.");
            }
        }

        public void WHILE()
        {
            try
            {
                MessageBox.Show("Produccion <WHILE>.", "Informacion");
                Parea(43);//while
                Parea(6);//(
                Sentencia();
                Parea(8);//)
                Parea(9);//{
                Instruccion();
                Parea(10);//}
            }
            catch (Exception)
            {
                Parea(0);
                MessageBox.Show("Error en la produccion <WHILE>.", "Advertencia.");
            }
        }

        //Varibles para crear reporte sintactico
        int num, fila;
        string tkn, lex, obtuvo;

        public void Parea(int valor)
        {
            if (!valor.Equals(TokenActual.Idtkn)) //Verifica que los valores coincidan
            {
                MessageBox.Show("Error se esperaba '" + TokenActual.Lexema + "' y se obtuvo token: '" + TokenActual.Lexema + "'" + "en la fila: " + TokenActual.Fila,"Error");

                numerror = 1;

                num = TokenActual.Numero;       fila = TokenActual.Fila;            tkn = TokenActual.Tkn;
                lex = TokenActual.Lexema;       obtuvo = TokenActual.Lexema;
                Parser aux = new Parser();
                aux.num = num;
                aux.fila = fila;
                aux.tkn = tkn;
                aux.lex = lex;
                aux.obtuvo = obtuvo;
                ListaC.Add(aux);
            }
            if (!TokenActual.Idtkn.Equals(0)) // Verifica si ya llego al tope de la lista.
            {                
                numpre += 1;
                TokenActual = listatokens.ElementAt(numpre);                
            }
            numerror = 0;
        }

        public void Reporte4()
        {
            try
            {
                if (ListaC.Count != 0)
                {
                    MessageBox.Show("Espere en un momento se abrira el reporte de errores sintacticos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reporte item = new Reporte();
                    item.ReporterSin(ListaC);
                    Process.Start(@"C:\Users\libni\OneDrive\Escritorio\ReporteSintactico.html");
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir el reporte de errores sintacticos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Ejecutar()
        {
            if (numerror == 0)
            {
                MessageBox.Show("Espere mientras se realiza la traduccion.","Informacion");
            }
            else
            {
                MessageBox.Show("Hay errores sintacticos, no se puede realizar la traduccion.", "Advertencia");
            }
        }
    }
}