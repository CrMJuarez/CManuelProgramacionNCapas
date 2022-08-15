using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Poliza
    {
        public static void Add()
        {
            
            ML.Poliza poliza = new ML.Poliza();
            Console.WriteLine("Agregar Poliza");

            Console.WriteLine("Ingrese Nombre");
            poliza.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese NumeroPoliza");
            poliza.NumeroPoliza = Console.ReadLine();
            Console.WriteLine("Ingrese FechaCreacion");
            poliza.FechaCreacion = Console.ReadLine();
            Console.WriteLine("Ingrese FechaModificacion");
            poliza.FechaModificacion = Console.ReadLine();
            Console.WriteLine("Ingrese su Id de usuario");
            poliza.Usuario = new ML.Usuario();
            poliza.Usuario.IdUsuario =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Id de SubPoliza");
            poliza.SubPoliza = new ML.SubPoliza();
            poliza.SubPoliza.IdSubPoliza = int.Parse(Console.ReadLine());

           
            ML.Result result = BL.Poliza.AddEF(poliza);
            if (result.Correct)
            {
                Console.WriteLine("Se ha registrar la poliza");
            }
            else
            {
                Console.WriteLine("No se ha podido registrar la poliza" + result.ErrorMessage);
            }
        }
    }
}
