using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Aseguradora
    {
        public static void AddLINQ()
        //public static void AddEF()

        //public static void AddSP()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            Console.WriteLine("Agregar Aseguradora");

            Console.WriteLine("Ingrese Nombre");
            aseguradora.Nombre = Console.ReadLine();
           
            Console.WriteLine("Ingrese su Id de usuario");
            aseguradora.Usuario.IdUsuario =int.Parse (Console.ReadLine());

            //ML.Result result = BL.Aseguradora.AddSP(aseguradora);
            ML.Result result = BL.Aseguradora.AddLINQ(aseguradora);
            if (result.Correct)
            {
                Console.WriteLine("Se ha registrado la aseguradora");
            }
            else
            {
                Console.WriteLine("No se ha podido registrar la aseguradora" + result.ErrorMessage);
            }
        }
        public static void UpdateLINQ()
             //public static void UpdateSP()
                     //public static void UpdateEF()

        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            Console.WriteLine("Actualizar Aseguradora");
            Console.WriteLine("Ingrese Nombre");
            aseguradora.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el ID de la aseguradora");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ID de su usuario");
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());


            //ML.Result result = BL.Aseguradora.UpdateSP(aseguradora);
            ML.Result result = BL.Aseguradora.UpdateLINQ(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("Se ha modificado la aseguradora");
            }
            else
            {
                Console.WriteLine("No se ha podido modificar la aseguradora" + result.ErrorMessage);
            }
        }
        public static void DeleteLINQ()
            //public static void DeleteEF()
        //public static void DeleteSP()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Eliminar Aseguradora");

            Console.WriteLine("Ingrese el ID de la aseguradora para eliminarla");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            ML.Result result = BL.Aseguradora.DeleteLINQ(aseguradora);
            //ML.Result result = BL.Aseguradora.DeleteSP(aseguradora);
            if (result.Correct)
            {
                Console.WriteLine("Se ha eliminado la aseguradora");
            }
            else
            {
                Console.WriteLine("No se ha podido eliminar la aseguradora" + result.ErrorMessage);
            }
        }
        public static void GetAllLINQ()
            //public static void GetAllEF()
        // public static void GetAllSP()
        {

            
            ML.Result result = BL.Aseguradora.GetAllLINQ();
            //ML.Result result = BL.Aseguradora.GetAll();
            if (result.Correct)
            {
                foreach (ML.Aseguradora aseguradora in result.Objects)
                {
                    Console.WriteLine("IdAseguradora: " + aseguradora.IdAseguradora);
                    Console.WriteLine("Nombre: " + aseguradora.Nombre);
                    Console.WriteLine("FechaCreacion: " + aseguradora.FechaCreacion);
                    Console.WriteLine("FechaModificacion: " + aseguradora.FechaModificacion);
                    //Console.WriteLine("IdUsuario: " + aseguradora.IdUsuario);
                    



                    Console.WriteLine("--------");
                }
                Console.WriteLine(result.Objects);
            }
            else

            {
                Console.WriteLine("Ocurrió un error al traer la información de la Aseguradora: " + result.ErrorMessage);
            }
        }
        public static void GetByIdLINQ()
            //public static void GetByIdEF()
        //public static void GetByIdSP()

        {

            ML.Aseguradora aseguradora = new ML.Aseguradora();



            Console.WriteLine("Ingrese el Id de la aseguradora que desea mostrar");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Aseguradora.GetById(aseguradora.IdAseguradora);
            ML.Result result = BL.Aseguradora.GetByIdLINQ(aseguradora.IdAseguradora);
            if (result.Correct)
            {
                Console.WriteLine("IdAseguradora: " + ((ML.Aseguradora)result.Object).IdAseguradora); //unboxing
                Console.WriteLine("Nombre: " + ((ML.Aseguradora)result.Object).Nombre); //unboxing
                Console.WriteLine("FechaCreacion: " + ((ML.Aseguradora)result.Object).FechaCreacion); //unboxing
                Console.WriteLine("FechaModificacion: " + ((ML.Aseguradora)result.Object).FechaModificacion); //unboxing
                Console.WriteLine("IdUsuario: " + ((ML.Aseguradora)result.Object).Usuario.IdUsuario); //unboxing
               
              
            }

            else

            {
                Console.WriteLine("Ocurrió un error al traer la información de la aseguradora: " + result.ErrorMessage);
            }
        }
    }
}
