using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Proyecto2_201403541
{
    class Reporte
    {
        string tabla = "";
        string Etabla = "";
        string sin = "";
        string fecha = "Fecha: " + DateTime.Now.ToString();

        public void ReporteTkn(List<Lista> datos)
        {
            string url = "Ruta de archivo Html" + @"C:\Users\libni\OneDrive\Escritorio\ReporteToken.html";

            if (datos.Count != 0)
            {
                for (int i =0; i < datos.Count; i++)
                {
                    tabla = tabla + "<tr>"
                      + "<td><strong>" + datos[i].Numero + "</strong></td>"
                      + "<td><strong>" + datos[i].Lexema + "</strong></td>"
                      + "<td><strong>" + datos[i].Idtkn + "</strong></td>"
                      + "<td><strong>" + datos[i].Tkn + "</strong></td>"
                      + "<td><strong>" + datos[i].Fila + "</strong></td>"
                      + "<td><strong>" + datos[i].Columna + "</strong></td>"
                      + "</tr>";
                }
            }

            string[] texto = { "<html>"
                    ,"<head>"
                ,"<title>TABLA DE TOKEN'S</title>"
                ,"</head>"
                ,"<body>"
                ,"<h1> LFP PROYECTO NO.1 Listado de Tokens</h1>"
                ,"<p>"
                ,fecha
                ,"</p>"
                ,"<p>"
                ,url
                ,"</p>"
                ,"<table border>"
                ,"<tr>"
                ,"<td><strong>No</strong></td>"
                ,"<td><strong>Lexema</strong></td>"
                ,"<td><strong>ID_Token</strong></td>"
                ,"<td><strong>Token</strong></td>"
                ,"<td><strong>Fila</strong></td>"
                ,"<td><strong>Coluna</strong></td>"
                ,"</tr>"
                ,tabla
                ,"</table>"
                ,"</body>"
                ,"</html> "
                };

            System.IO.File.WriteAllLines(@"C:\Users\libni\OneDrive\Escritorio\ReporteToken.html", texto);
        }

        public void ReporteE(List<Elista> valor)
        {
            string url = "Ruta de archivo html" + @"C:\Users\libni\OneDrive\Escritorio\ReporteError.html";

            if (valor.Count != 0)
            {
                for (int i = 0; i < valor.Count; i++)
                {
                    Etabla = Etabla + "<tr>"
                        + "<td><strong>" + valor[i].Enum + "</strong></td>"
                        + "<td><strong>" + valor[i].Efila + "</strong></td>"
                        + "<td><strong>" + valor[i].Ecolumna + "</strong></td>"
                        + "<td><strong>" + valor[i].Elex + "</strong></td>"
                        + "<td><strong>" + valor[i].Etkn + "</strong></td>"
                        + "</tr>";
                }
            }

            string[] text = { "<html>"
                ,"<head>"
                ,"<title>TABLA DE ERRORES</title>"
                ,"</head>"
                ,"<body>"
                ,"<h1> LFP PROYECTO NO.1 Listado de Errores</h1>"
                ,"<p>"
                ,fecha
                ,"</p>"
                ,"<p>"
                ,url
                ,"</p>"
                ,"<table border>"
                ,"<tr>"
                ,"<td><strong>No</strong></td>"
                ,"<td><strong>Fila</strong></td>"
                ,"<td><strong>Columna</strong></td>"
                ,"<td><strong>Caracter</strong></td>"
                ,"<td><strong>Descripcion</strong></td>"
                ,"</tr>"
                ,Etabla
                ,"</table>"
                ,"</body>"
                ,"</html> " };

            System.IO.File.WriteAllLines(@"C:\Users\libni\OneDrive\Escritorio\ReporteError.html", text);
        }

        public void ReporterSin(List<Parser> info)
        {
            string url = "Ruta de archivo html" + @"C:\Users\libni\OneDrive\Escritorio\ReporteSintactico.html";

            if (info.Count != 0)
            {
                for (int i = 0; i < info.Count; i++)
                {
                    sin = sin + "<tr>"
                        + "<td><strong>" + info[i].num + "</strong></td>"
                        + "<td><strong>" + info[i].fila + "</strong></td>"
                        + "<td><strong>" + info[i].tkn + "</strong></td>"
                        + "<td><strong>" + info[i].lex + "</strong></td>"
                        + "<td><strong>" + info[i].obtuvo + "</strong></td>"                        
                        + "</tr>";
                }
            }

            string[] text = { "<html>"
                ,"<head>"
                ,"<title>TABLA DE ERRORES</title>"
                ,"</head>"
                ,"<body>"
                ,"<h1> LFP PROYECTO NO.1 Listado de Errores</h1>"
                ,"<p>"
                ,fecha
                ,"</p>"
                ,"<p>"
                ,url
                ,"</p>"
                ,"<table border>"
                ,"<tr>"
                ,"<td><strong>No</strong></td>"
                ,"<td><strong>Fila</strong></td>"
                ,"<td><strong>Columna</strong></td>"
                ,"<td><strong>Caracter</strong></td>"
                ,"<td><strong>Descripcion</strong></td>"
                ,"</tr>"
                ,sin
                ,"</table>"
                ,"</body>"
                ,"</html> " };

            System.IO.File.WriteAllLines(@"C:\Users\libni\OneDrive\Escritorio\ReporteSintactico.html", text);
        }
    }
}
