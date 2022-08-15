using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace BL
{
    public class Usuario
    {
        //--------------------------------------------ADD ------------------------------------------
        //public static ML.Result Add(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
        //        {
        //            string query = "INSERT INTO [Usuario]([Nombre],[ApellidoPaterno],[ApellidoMaterno] ,[Sexo],[CURP])VALUES (@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Sexo,@CURP)";

        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandText = query;
        //            cmd.Connection = context;

        //            SqlParameter[] collection = new SqlParameter[5];

        //            collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;

        //            collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;

        //            collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;

        //            collection[3] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
        //            collection[3].Value = usuario.Sexo;

        //            collection[4] = new SqlParameter("@CURP", System.Data.SqlDbType.VarChar);
        //            collection[4].Value = usuario.CURP;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int RowsAffected = cmd.ExecuteNonQuery();
        //            if (RowsAffected > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;

        //    }
        //    return result;
        //}


        //////--------------------update----------------------------------

        //public static ML.Result Update(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
        //        {
        //            string query = "UPDATE [Usuario] SET [Nombre]=@Nombre,[ApellidoPaterno]=@ApellidoPaterno,[ApellidoMaterno]=@ApellidoMaterno ," +
        //                "[Sexo]=@Sexo,[CURP]=@CURP WHERE IdUsuario=@IdUsuario";

        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandText = query;
        //            cmd.Connection = context;

        //            SqlParameter[] collection = new SqlParameter[6];

        //            collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;

        //            collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;

        //            collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;

        //            collection[3] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
        //            collection[3].Value = usuario.Sexo;

        //            collection[4] = new SqlParameter("@CURP", System.Data.SqlDbType.VarChar);
        //            collection[4].Value = usuario.CURP;

        //            collection[5] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
        //            collection[5].Value = usuario.IdUsuario;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int RowsAffected = cmd.ExecuteNonQuery();
        //            if (RowsAffected > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;

        //    }
        //    return result;

        //}
        //////------------------------------------------ delete--------------------------------------------
        //public static ML.Result Delete(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
        //        {
        //            string query = "DELETE FROM [Usuario] WHERE IdUsuario=@IdUsuario";

        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandText = query;
        //            cmd.Connection = context;

        //            SqlParameter[] collection = new SqlParameter[1];

        //            collection[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int RowsAffected = cmd.ExecuteNonQuery();
        //            if (RowsAffected > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;

        //    }
        //    return result;

        //}



        //------------------------------------------------------------------------------------------
        //STORED PROCEDURE
        //--------------------------------------------ADD ------------------------------------------
        public static ML.Result AddSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "UsuarioAdd";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[10];

                    collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                    collection[0].Value = usuario.Nombre;

                    collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                    collection[1].Value = usuario.ApellidoPaterno;

                    collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                    collection[2].Value = usuario.ApellidoMaterno;

                    collection[3] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
                    collection[3].Value = usuario.Sexo;

                    collection[4] = new SqlParameter("@CURP", System.Data.SqlDbType.VarChar);
                    collection[4].Value = usuario.CURP;

                    collection[5] = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);
                    collection[5].Value = usuario.UserName;

                    collection[6] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                    collection[6].Value = usuario.Email;

                    collection[7] = new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar);
                    collection[7].Value = usuario.Telefono;

                    collection[8] = new SqlParameter("@Celular", System.Data.SqlDbType.VarChar);
                    collection[8].Value = usuario.Celular;

                    collection[9] = new SqlParameter("@FechaNacimiento", System.Data.SqlDbType.VarChar);
                    collection[9].Value = usuario.FechaNacimiento;

                    cmd.Parameters.AddRange(collection);
                    cmd.Connection.Open();

                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }

                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;
        }

        //ADD CON ENTITY FRAMEWORK
        //public static ML.Result AddEF(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
        //        {
        //            var query = context.UsuarioAdd(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno,
        //                usuario.Sexo, usuario.CURP, usuario.UserName, usuario.Email, usuario.Telefono, usuario.Celular,
        //                usuario.FechaNacimiento, usuario.Rol.IdRol);

        //            if (query >= 1)
        //            {
        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "no se inserto el usuario";
        //            }
        //            result.Correct = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}
        //ADD CON LINQ
        public static ML.Result AddLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    DL_EF.Usuario usuarioDL = new DL_EF.Usuario();
                    usuarioDL.Nombre = usuario.Nombre;
                    usuarioDL.ApellidoPaterno = usuario.ApellidoPaterno;
                    usuarioDL.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioDL.Sexo = usuario.Sexo;
                    usuarioDL.Curp = usuario.CURP;
                    usuarioDL.UserName = usuario.UserName;
                    usuarioDL.Email = usuario.Email;
                    usuarioDL.Telefono = usuario.Telefono;
                    usuarioDL.Celular = usuario.Celular;
                    usuarioDL.FechaNacimiento = DateTime.ParseExact(usuario.FechaNacimiento, "dd/mm/yyyy", CultureInfo.InvariantCulture);

                    //DateTime.ParseExact(dateInString, "M/d/yyyy", CultureInfo.InvariantCulture);
                    context.Usuarios.Add(usuarioDL);
                    context.SaveChanges();
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;
        }
        //--------------------update----------------------------------

        public static ML.Result UpdateSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "UsuarioUpdate";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[11];

                    collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                    collection[0].Value = usuario.Nombre;

                    collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                    collection[1].Value = usuario.ApellidoPaterno;

                    collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                    collection[2].Value = usuario.ApellidoMaterno;

                    collection[3] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
                    collection[3].Value = usuario.Sexo;

                    collection[4] = new SqlParameter("@CURP", System.Data.SqlDbType.VarChar);
                    collection[4].Value = usuario.CURP;

                    collection[5] = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);
                    collection[5].Value = usuario.UserName;

                    collection[6] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                    collection[6].Value = usuario.Email;

                    collection[7] = new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar);
                    collection[7].Value = usuario.Telefono;

                    collection[8] = new SqlParameter("@Celular", System.Data.SqlDbType.VarChar);
                    collection[8].Value = usuario.Celular;

                    collection[9] = new SqlParameter("@FechaNacimiento", System.Data.SqlDbType.VarChar);
                    collection[9].Value = usuario.FechaNacimiento;

                    collection[10] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                    collection[10].Value = usuario.IdUsuario;

                    cmd.Parameters.AddRange(collection);
                    cmd.Connection.Open();

                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;

        }
        //UPDATE CON ENTITY FRAMEWORK
        //public static ML.Result UpdateEF(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
        //        {
        //            var updateResult = context.UsuarioUpdate(usuario.IdUsuario, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno,
        //                usuario.Sexo, usuario.CURP, usuario.UserName, usuario.Email, usuario.Telefono, usuario.Celular,
        //                usuario.FechaNacimiento,usuario.Rol.IdRol);


        //            if (updateResult >= 1)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "No se actualizo el usuario";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;

        //    }
        //    return result;

        //}
        //UPDATE CON LINQ
        public static ML.Result UpdateLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query= (from a in context.Usuarios
                                where a.IdUsuario==usuario.IdUsuario
                                select a).SingleOrDefault();

                    if (query != null)

                    {
                        
                        query.Nombre = usuario.Nombre;
                        query.ApellidoPaterno = usuario.ApellidoPaterno;
                        query.ApellidoMaterno = usuario.ApellidoMaterno;
                        query.Sexo = usuario.Sexo;
                        query.Curp = usuario.CURP;
                        query.UserName = usuario.UserName;
                        query.Email = usuario.Email;
                        query.Telefono = usuario.Telefono;
                        query.Celular = usuario.Celular;
                        query.FechaNacimiento = DateTime.ParseExact(usuario.FechaNacimiento, "dd/mm/yyyy", CultureInfo.InvariantCulture);

                        //DateTime.ParseExact(dateInString, "M/d/yyyy", CultureInfo.InvariantCulture);

                        context.SaveChanges();
                        result.Correct=true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;
        }



        //------------------------------------------ delete--------------------------------------------
        public static ML.Result DeleteSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "UsuarioDelete";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[1];

                    collection[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                    collection[0].Value = usuario.IdUsuario;

                    cmd.Parameters.AddRange(collection);
                    cmd.Connection.Open();

                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;

        }
        //DELETE CON ENTITY FRAMEWORK
        public static ML.Result DeleteEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = context.UsuarioDelete(usuario.IdUsuario);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "no se pudo eliminar el usuario";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;

        }
        //DELETE CON LINQ
        public static ML.Result DeleteLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = (from a in context.Usuarios
                                 where a.IdUsuario == usuario.IdUsuario
                                 select a).First();
                    context.Usuarios.Remove(query);
                    context.SaveChanges();
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;

        }
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "UsuarioGetAll";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection.Open();
                    DataTable usuarioTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(usuarioTable);

                    if (usuarioTable.Rows.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (DataRow row in usuarioTable.Rows)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = int.Parse(row[0].ToString());
                            usuario.Nombre = row[1].ToString();
                            usuario.ApellidoPaterno = row[2].ToString();
                            usuario.ApellidoMaterno = row[3].ToString();
                            usuario.Sexo = row[4].ToString();
                            usuario.CURP = row[5].ToString();
                            usuario.UserName = row[6].ToString();
                            usuario.Email = row[7].ToString();
                            usuario.Telefono = row[8].ToString();
                            usuario.Celular = row[9].ToString();
                            //error en conversion de date
                            usuario.FechaNacimiento = row[10].ToString();
                            result.Objects.Add(usuario);
                        }
                        result.Correct = true;
                    }
                    else

                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error al momento de mostrar el usuario";
                    }
                    cmd.Connection.Close();
                }

            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;


        }
        //DELETE CON ENTITY FRAMEWORK
        //public static ML.Result GetAllEF()
        //{
        //    ML.Result result = new ML.Result();

        //    try
        //    {
        //        using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
        //        {
        //            var usuarios = context.UsuarioGetAll().ToList();
        //            result.Objects = new List<object>();
        //            if (usuarios != null)
        //            {
        //                foreach (var obj in usuarios)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.IdUsuario = obj.IdUsuario;
        //                    usuario.Nombre = obj.UsuarioNombre;
        //                    usuario.ApellidoPaterno = obj.ApellidoPaterno;
        //                    usuario.ApellidoMaterno = obj.ApellidoMaterno;
        //                    usuario.Sexo = obj.Sexo;
        //                    usuario.CURP = obj.Curp;
        //                    usuario.UserName = obj.UserName;
        //                    usuario.Email = obj.Email;
        //                    usuario.Telefono = obj.Telefono;
        //                    usuario.Celular = obj.Celular;
        //                    usuario.FechaNacimiento = obj.FechaNacimiento.Value.ToString("dd-MM-yyyy");
        //                    //se debe inicializar el modelo rol para que tome el valor: usuario.Rol = new ML.Rol();
        //                    usuario.Rol = new ML.Rol();
        //                    usuario.Rol.IdRol = obj.IdRol;
        //                    usuario.Rol.Nombre = obj.RolNombre;
        //                    result.Objects.Add(usuario);
                            
        //                }


        //                result.Correct = true;
        //            }
        //            else

        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Ocurrió un error al momento de mostrar el usuario";
        //            }

        //        }

        //    }

        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;

        //    }
        //    return result;


        //}
        //GETALL CON LINQ
        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = (from Usuario in context.Usuarios
                                 select Usuario).ToList();
                    //select new
                    //{
                    //    aseguradora.IdAseguradora,
                    //    aseguradora.Nombre,
                    //    aseguradora.FechaCreacion
                    //    //   FechaModificacion = Aseguradora.FechaModificacion
                    //}).ToList();


                    result.Objects = new List<object>();

                    if (query != null && query.ToList().Count > 0)
                    {

                        foreach (var obj in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.Nombre = obj.Nombre;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno.ToString();
                            usuario.ApellidoMaterno = obj.ApellidoMaterno.ToString();
                            usuario.Sexo = obj.Sexo.ToString();
                            usuario.CURP = obj.Curp.ToString();
                            usuario.UserName = obj.UserName.ToString();
                            usuario.Email = obj.Email.ToString();
                            usuario.Telefono = obj.Telefono.ToString();
                            usuario.Celular = obj.Celular.ToString();
                            usuario.FechaNacimiento = obj.FechaNacimiento.ToString();
           
                            result.Objects.Add(usuario);
                        }
                        result.Correct = true;
                    }
                    else

                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error al momento de mostrar el usuario";
                    }

                }

            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;
        }
        public static ML.Result GetById(int IdUsuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "UsuarioGetById";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;


                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                        collection[0].Value = IdUsuario;

                        cmd.Parameters.AddRange(collection);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {

                            DataTable usuarioTable = new DataTable();
                            da.Fill(usuarioTable);
                            cmd.Connection.Open();

                            if (usuarioTable.Rows.Count > 0)
                            {
                                result.Objects = new List<object>();
                                DataRow row = usuarioTable.Rows[0];

                                ML.Usuario usuario = new ML.Usuario();
                                usuario.IdUsuario = int.Parse(row[0].ToString());
                                usuario.Nombre = row[1].ToString();
                                usuario.ApellidoPaterno = row[2].ToString();
                                usuario.ApellidoMaterno = row[3].ToString();
                                usuario.Sexo = row[4].ToString();
                                usuario.CURP = row[5].ToString();
                                usuario.UserName = row[6].ToString();
                                usuario.Email = row[7].ToString();
                                usuario.Telefono = row[8].ToString();
                                usuario.Celular = row[9].ToString();
                                usuario.FechaNacimiento = row[10].ToString();
                                result.Object = usuario;  //boxing    --unboxing

                                result.Correct = true;
                            }
                            else
                            {
                                result.Correct = false;
                                result.ErrorMessage = "No se encontraron registros en la tabla Materia";
                            }

                        }
                    }

                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;

        }

        public static ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                   var objUsuario= context.UsuarioGetById(IdUsuario).FirstOrDefault();
                    result.Objects = new List<object>();
                                if (objUsuario != null)
                            { 
                             ML.Usuario usuario= new ML.Usuario();
                        usuario.IdUsuario = objUsuario.IdUsuario;
                        usuario.Nombre = objUsuario.Nombre;
                        usuario.ApellidoPaterno = objUsuario.ApellidoPaterno;
                        usuario.ApellidoMaterno = objUsuario.ApellidoMaterno;
                        usuario.Sexo = objUsuario.Sexo;
                        usuario.CURP = objUsuario.Curp;
                        usuario.UserName = objUsuario.UserName;
                        usuario.Email = objUsuario.Email;
                        usuario.Telefono = objUsuario.Telefono;
                        usuario.Celular = objUsuario.Celular;
                        usuario.FechaNacimiento = objUsuario.FechaNacimiento.Value.ToString("dd-MM-yyyy");
                        usuario.Rol = new ML.Rol();
                        usuario.Rol.IdRol = objUsuario.IdRol.Value;
                        result.Object = usuario;
                        result.Correct = true;

                    }
                            else
                            {
                                result.Correct = false;
                                result.ErrorMessage = "No se encontraron registros en la tabla Materia";
                            }

                        }
                
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;

        }
        //GETBYID CON LINQ
        public static ML.Result GetByIdLINQ(int IdUsuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = (from Usuario in context.Usuarios
                                 where Usuario.IdUsuario == Usuario.IdUsuario
                                 select Usuario).FirstOrDefault();
                    result.Objects = new List<object>();

                    if (query != null)
                    {

                        ML.Usuario usuario = new ML.Usuario();

                        usuario.IdUsuario = query.IdUsuario;
                        usuario.Nombre = query.Nombre;
                        usuario.ApellidoPaterno = query.ApellidoPaterno.ToString();
                        usuario.ApellidoMaterno = query.ApellidoMaterno.ToString();
                        usuario.Sexo = query.Sexo.ToString();
                        usuario.CURP = query.Curp.ToString();
                        usuario.UserName = query.UserName.ToString();
                        usuario.Email = query.Email.ToString();
                        usuario.Telefono = query.Telefono.ToString();
                        usuario.Celular = query.Celular.ToString();
                        usuario.FechaNacimiento = query.FechaNacimiento.ToString();
                        result.Object = usuario;
                        

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error al momento de mostrar la aseguradora";
                    }

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;
        }



    }

  }



