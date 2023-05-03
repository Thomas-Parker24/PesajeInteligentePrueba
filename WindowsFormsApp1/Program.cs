using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Contexto context = new Contexto();
            //Empresa aux = new Empresa();
            //aux.Nombre = "Testeo";
            //aux.Codigo = 123;
            //aux.Direccion = "Copacabana";
            //aux.Telefono = "123";
            //aux.Ciudad = "Copacabana";
            //aux.Departamento = "Antioquia";
            //aux.Pais = "Colombia";
            //aux.Creacion = DateTime.Today.Date;
            //aux.Modificacion = DateTime.Today.Date;

            //context.Empresas.Add(aux);
            //context.SaveChanges();

            Application.Run(new Form1(context));
        }
    }
}
