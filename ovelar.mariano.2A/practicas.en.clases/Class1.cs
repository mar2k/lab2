using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas.en.clases
{
    class Sello
    {
        static public String mensaje ="HOLA MUNDO";

        static public String imprimir()
        {
            Console.Write("{0}", Sello.ArmarFormatoMensaje());
            return mensaje;
        }
       /* static public void imprimirEnColor()
        {

        }*/
        static private String ArmarFormatoMensaje()
        {
            string ateriscos="";
            int i;
            int tam=0;
            string retorno="";
            string cadena="";

            if(Sello.TryParse(Sello.mensaje,out cadena))
            {
                tam = Sello.mensaje.Length;

                for (i = 0; i < tam + 2; i++)
                {
                    ateriscos += "*";
                }
                ateriscos += "\n";

                retorno = ateriscos + "*" + Sello.mensaje + "*\n" + ateriscos;
            }

            return retorno;
        }

        private static bool TryParse(string mensaje,out string cadena)
        {
            bool retorno=true;
            if(mensaje.Length<1)
            {
                retorno = false;
            }

            cadena = "ERROR";
            
            return retorno;
        }
        
    }
}
