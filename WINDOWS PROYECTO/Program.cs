using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINDOWS_PROYECTO
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        ///COMENTARIO
        ///DE VARIAS LINEA
        ///SON 3 SLASH
        /*
         * DESPUES DE ESTE CODIGO TODO ES COMENTARIO
         * Y PARA TERMINARLO HAY QUE PONER UN SLAS A LA DERECHA
         */ 

        //ESTO ES UN COMENTARIO DE UNA LINEA
        [STAThread]
        static void Main()
        
            //TIPOS DE VARIABLES
        {
        //    string Nombre = "miguel";//esta es una variable de cadena de texto
        //    int num1 = 600;   //numeros enteros negativos o positivos
        //    uint num2 = 640;   //numeros enteros pero solo positivos

        //    float num3 = 35.6f;   //numeros con decimales la f es para no hacer presision
        //    double num4 = 99.6;    //numeros con decimales pero numero mas grandes que el float
        //    decimal num5 = 563.565651m;     //numero con decimal para cuando es mas preciso y la m es para ser mas preciso
        //    byte num6 = 252;     //numero muy pequeños que solo abarca hasta el 255
        //    bool acceso = false; //solo acepta dos el true o el false 
        //    DateTime fecha = DateTime.Today;//muestra fecha
        //    //declarara varias variables del mismo tipo
        //    int num7, num8, num9, num10;
        //        num7 = 26; num8 = 36; num9 = 69; num10 = 69;

        //    //constantes son las que no cambian sus numero
        //    const string dato = "prueba de constante";
            

        //    MessageBox.Show(dato);
        //    MessageBox.Show(acceso.ToString());
        //    MessageBox.Show(Nombre);
        //    MessageBox.Show(num1.ToString());//convertir numero en texto
        //    MessageBox.Show(fecha.Year.ToString());//con toshort es formato de fecha corto



            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
