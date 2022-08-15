using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        //public static void Add()
        //{
        //    ML.Usuario usuario = new ML.Usuario();
        //    Console.WriteLine("Agregar Usuario");

        //    Console.WriteLine("Ingrese Nombre");
        //    usuario.Nombre = Console.ReadLine();

        //    Console.WriteLine("Ingrese ApellidoPaterno");
        //    usuario.ApellidoPaterno = Console.ReadLine();

        //    Console.WriteLine("Ingrese ApellidoMaterno");
        //    usuario.ApellidoMaterno = Console.ReadLine();

        //    Console.WriteLine("Ingrese el Sexo");
        //    usuario.Sexo = Console.ReadLine();

        //    Console.WriteLine("Ingrese el CURP");
        //    usuario.CURP = Console.ReadLine();

        //    ML.Result result = BL.Usuario.Add(usuario);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Se ha registrado el usuario");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No se ha podido registrar el usuario" + result.ErrorMessage);
        //    }
        //}
        //public static void Update()
        //{
        //    ML.Usuario usuario = new ML.Usuario();
        //    Console.WriteLine("Actualizar Usuario");
        //    Console.WriteLine("Ingrese Nombre");
        //    usuario.Nombre = Console.ReadLine();

        //    Console.WriteLine("Ingrese ApellidoPaterno");
        //    usuario.ApellidoPaterno = Console.ReadLine();

        //    Console.WriteLine("Ingrese ApellidoMaterno");
        //    usuario.ApellidoMaterno = Console.ReadLine();

        //    Console.WriteLine("Ingrese el Sexo");
        //    usuario.Sexo = Console.ReadLine();

        //    Console.WriteLine("Ingrese el CURP");
        //    usuario.CURP = Console.ReadLine();

        //    Console.WriteLine("Ingrese el ID de usuario");
        //    usuario.IdUsuario = int.Parse(Console.ReadLine());

        //    ML.Result result = BL.Usuario.Update(usuario);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Se ha modificado el usuario");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No se ha podido modificar el usuario" + result.ErrorMessage);
        //    }
        //}
        //public static void Delete()
        //{
        //    ML.Usuario usuario = new ML.Usuario();

        //    Console.WriteLine("Eliminar Usuario");

        //    Console.WriteLine("Ingrese el ID del usuario para eliminarlo");
        //    usuario.IdUsuario = int.Parse(Console.ReadLine());

        //    ML.Result result = BL.Usuario.Delete(usuario);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Se ha eliminado el usuario");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No se ha podido eliminar el usuario" + result.ErrorMessage);
        //    }
        //}



        //STORED PROCEDURE---------------
      public static void AddLINQ()
            //public static void AddEF()
        //public static void AddSP()


        {
            
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Agregar Usuario");

            Console.WriteLine("Ingrese Nombre");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese ApellidoPaterno");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese ApellidoMaterno");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el Sexo");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingrese el CURP");
            usuario.CURP = Console.ReadLine();

            Console.WriteLine("Ingrese el un nombre de usuario");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese un correo electronico");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingrese telefono local");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese numero de celular");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingrese su fecha de nacimiento");
            usuario.FechaNacimiento = Console.ReadLine();

            //ML.Result result = BL.Usuario.AddSP(usuario);
            ML.Result result = BL.Usuario.AddLINQ(usuario);
            if (result.Correct)
            {
                Console.WriteLine("Se ha registrado el usuario");
            }
            else
            {
                Console.WriteLine("No se ha podido registrar el usuario" + result.ErrorMessage);
            }
        }
        public static void UpdateLINQ()
           // public static void UpdateEF()
        //public static void UpdateSP()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Actualizar Usuario");
            Console.WriteLine("Ingrese Nombre");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese ApellidoPaterno");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese ApellidoMaterno");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el Sexo");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingrese el CURP");
            usuario.CURP = Console.ReadLine();

            Console.WriteLine("Ingrese el un nombre de usuario");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese un correo electronico");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingrese telefono local");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese numero de celular");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingrese su fecha de nacimiento");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingrese el ID de usuario");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.UpdateLINQ(usuario);
            //ML.Result result = BL.Usuario.UpdateSP(usuario);

            if (result.Correct)
            {
                Console.WriteLine("Se ha modificado el usuario");
            }
            else
            {
                Console.WriteLine("No se ha podido modificar el usuario" + result.ErrorMessage);
            }
        }
        
        public static void DeleteLINQ()
            //public static void DeleteSP()
            //public static void DeleteEF()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Eliminar Usuario");

            Console.WriteLine("Ingrese el ID del usuario para eliminarlo");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.DeleteLINQ(usuario);
            //ML.Result result = BL.Usuario.DeleteSP(usuario);

            if (result.Correct)
            {
                Console.WriteLine("Se ha eliminado el usuario");
            }
            else
            {
                Console.WriteLine("No se ha podido eliminar el usuario" + result.ErrorMessage);
            }
        }
        public static void GetAllLINQ()
            // public static void GetAllEF()
        //public static void GetAll()
        {

            ML.Result result = BL.Usuario.GetAllLINQ();
            //ML.Result result = BL.Usuario.GetAll();
            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
                    Console.WriteLine("Nombre: " + usuario.Nombre);
                    Console.WriteLine("ApellidoPaterno: " + usuario.ApellidoPaterno);
                    Console.WriteLine("ApellidoMaterno: " + usuario.ApellidoMaterno);
                    Console.WriteLine("Sexo: " + usuario.Sexo);
                    Console.WriteLine("CURP: " + usuario.CURP);
                    Console.WriteLine("UserName: " + usuario.UserName);
                    Console.WriteLine("Email: " + usuario.Email);
                    Console.WriteLine("Telefono: " + usuario.Telefono);
                    Console.WriteLine("Celular: " + usuario.Celular);
                    Console.WriteLine("FechaNacimiento: " + usuario.FechaNacimiento);



                    Console.WriteLine("--------");
                }
                Console.WriteLine(result.Objects);
            }
            else

            {
                Console.WriteLine("Ocurrió un error al traer la información del usuario: " + result.ErrorMessage);
            }
        }
        public static void GetByIdLINQ()
            //public static void GetByIdEF()
        // public static void GetByIdSP()

        {

            ML.Usuario usuario = new ML.Usuario();



            Console.WriteLine("Ingrese el Id del usuario que desea mostrar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.GetByIdLINQ(usuario.IdUsuario);
            //ML.Result result = BL.Usuario.GetById(usuario.IdUsuario);

            if (result.Correct)
            {
                Console.WriteLine("IdUsuario: " + ((ML.Usuario)result.Object).IdUsuario); //unboxing
                Console.WriteLine("Nombre: " + ((ML.Usuario)result.Object).Nombre); //unboxing
                Console.WriteLine("ApellidoPaterno: " + ((ML.Usuario)result.Object).ApellidoPaterno); //unboxing
                Console.WriteLine("ApellidoMaterno: " + ((ML.Usuario)result.Object).ApellidoMaterno); //unboxing
                Console.WriteLine("Sexo: " + ((ML.Usuario)result.Object).Sexo); //unboxing
                Console.WriteLine("CURP: " + ((ML.Usuario)result.Object).CURP); //unboxing
                Console.WriteLine("UserName: " + ((ML.Usuario)result.Object).UserName); //unboxing
                Console.WriteLine("Email: " + ((ML.Usuario)result.Object).Email); //unboxing
                Console.WriteLine("Telefono: " + ((ML.Usuario)result.Object).Telefono); //unboxing
                Console.WriteLine("Celular: " + ((ML.Usuario)result.Object).Celular); //unboxing
                Console.WriteLine("FechaNacimiento: " + ((ML.Usuario)result.Object).FechaNacimiento); //unboxing
                
            }
        
            else

            {
                Console.WriteLine("Ocurrió un error al traer la información del usuario: " + result.ErrorMessage);
            }
        }
    }
    }

