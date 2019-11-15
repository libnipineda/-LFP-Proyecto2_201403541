using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LFP_Proyecto2_201403541
{
    class Funcionalidad : Lexico
    {
        string ruta = @"C:\Users\libni\OneDrive\Escritorio\";

        public List<Lista> ListaC = new List<Lista>();

        StreamWriter archivo;       

        public List<Lista> ObtenerInfo(List<Lista> info)
        {
            // ----------------------------------------- Lexemas a eliminar -----------------------------------------
            info.RemoveAll(x => x.Lexema.Contains("class"));
            info.RemoveAll(x => x.Lexema.Contains("{"));
            info.RemoveAll(x => x.Lexema.Contains("}"));
            info.RemoveAll(x => x.Lexema.Contains(";"));
            info.RemoveAll(x => x.Lexema.Contains("static"));
            info.RemoveAll(x => x.Lexema.Contains("void"));
            info.RemoveAll(x => x.Lexema.Contains("Main"));
            info.RemoveAll(x => x.Lexema.Contains("string"));
            info.RemoveAll(x => x.Lexema.Contains("args"));
            info.RemoveAll(x => x.Lexema.Contains("int"));
            info.RemoveAll(x => x.Lexema.Contains("float"));
            info.RemoveAll(x => x.Lexema.Contains("char"));
            info.RemoveAll(x => x.Lexema.Contains("bool"));

            // ----------------------------------------- Crear Archivo Txt -----------------------------------------
            archivo = new StreamWriter(ruta + "Comandos" + ".txt");                        

            archivo.WriteLine("# codign: utf-8");
            archivo.WriteLine("# Your code here:");

            foreach (Lista lista in info)
            {
                Console.WriteLine(lista.Lexema);

                for (int i = 0; i < info.Count; i++)
                {
                    string aux = info[i].Tkn;
                }

                archivo.WriteLine(lista.Lexema);
            }
            archivo.Close();
            return ListaC;
        }
    }
}