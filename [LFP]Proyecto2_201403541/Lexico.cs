using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LFP_Proyecto2_201403541
{
    class Lexico
    {
        List<Lista> ListaA = new List<Lista>();
        List<Elista> ListaB = new List<Elista>();

        int idtkn, nutknen = 0, idtkns =0, fila = 1, columna = 1;
        string token = "";
        String concatenar = "", Etoken;

        public void Scanner(string cadena)
        {

        }

        public void AnalizarTkn(string tkn)
        {

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
            ListaA.Add(aux);
        }

        public void Reporte1()
        {
            try
            {
                MessageBox.Show("Espere en un momento se abrira el reporte de token´s", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reporte item = new Reporte();
                item.ReporteTkn(ListaA);
                Process.Start(@"C:\Users\libni\OneDrive\Escritorio\ReporteToken.html");                
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir el reporte de Token´s", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reporte2()
        {
            if (ListaB.Count != 0)
            {
                Reporte html = new Reporte();
                html.ReporteE(ListaB);
                Process.Start(@"C:\Users\libni\OneDrive\Escritorio\ReporteError.html");
            }
            else
            {
                MessageBox.Show("No se encontro errores.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
        }
    }