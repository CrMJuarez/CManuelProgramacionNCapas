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
    public class Aseguradora
    {
        public static ML.Result AddSP(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "AseguradoraAdd";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter[] collection = new SqlParameter[2];

                    collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                    collection[0].Value = aseguradora.Nombre;

                    collection[1] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                    collection[1].Value = aseguradora.Usuario.IdUsuario;


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

        public static ML.Result AddEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = context.AseguradoraAdd(aseguradora.Nombre, aseguradora.Usuario.IdUsuario);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "no se pudo agregar la aseguradora";
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
        //ADD CON LINQ
        public static ML.Result AddLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    DL_EF.Aseguradora aseguradoraDL = new DL_EF.Aseguradora();
                   
                    aseguradoraDL.Nombre = aseguradora.Nombre;
                   // aseguradoraDL.FechaCreacion = DateTime.ParseExact(aseguradora.FechaCreacion, "dd/mm/yyyy", CultureInfo.InvariantCulture);
                    aseguradoraDL.IdUsuario = aseguradora.Usuario.IdUsuario;

                    context.Aseguradoras.Add(aseguradoraDL);
                    context.SaveChanges();

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

        public static ML.Result UpdateSP(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "AseguradoraUpdate";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[3];

                    collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                    collection[0].Value = aseguradora.Nombre;

                    collection[1] = new SqlParameter("@IdAseguradora", System.Data.SqlDbType.Int);
                    collection[1].Value = aseguradora.IdAseguradora;

                    collection[2] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                    collection[2].Value = aseguradora.Usuario.IdUsuario;

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
        //uPDATE CON ENTITY FRAMEWORK
        public static ML.Result UpdateEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var updateResult = context.AseguradoraUpdate(aseguradora.Nombre, aseguradora.IdAseguradora, aseguradora.Usuario.IdUsuario);
                    
                    
                    if (updateResult >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "no se pudo modificar la aseguradora";
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
        //UPDATE CON LINQ
        public static ML.Result UpdateLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = (from a in context.Aseguradoras
                                 where a.IdAseguradora == aseguradora.IdAseguradora
                                 select a).SingleOrDefault();


                    if (query != null)
                    {
                        query.Nombre = aseguradora.Nombre;
                        query.Nombre = aseguradora.IdAseguradora.ToString();
                        query.Nombre = aseguradora.Usuario.IdUsuario.ToString();

                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "no se pudo modificar la aseguradora";
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
        public static ML.Result DeleteSP(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "DeleteAseguradora";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[1];

                    collection[0] = new SqlParameter("@IdAseguradora", System.Data.SqlDbType.Int);
                    collection[0].Value = aseguradora.IdAseguradora;

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
        public static ML.Result DeleteEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = context.AseguradoraDelete(aseguradora.IdAseguradora);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo eliminar la aseguradora";
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
        //DELETE CON LINQ
        public static ML.Result DeleteLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = (from a in context.Aseguradoras
                                 where a.IdAseguradora == aseguradora.IdAseguradora
                                 select a).First();
                    context.Aseguradoras.Remove(query);
                    context.SaveChanges();
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
                    string query = "AseguradoraGetAll";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection.Open();
                    DataTable aseguradoraTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(aseguradoraTable);

                    if (aseguradoraTable.Rows.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (DataRow row in aseguradoraTable.Rows)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.IdAseguradora = int.Parse(row[0].ToString());
                            aseguradora.Nombre = row[1].ToString();
                            aseguradora.FechaCreacion = row[2].ToString();
                            aseguradora.FechaModificacion = row[3].ToString();
                            //aseguradora.IdUsuario = int.Parse(row[4].ToString());
                            
                       
                            result.Objects.Add(aseguradora);
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
        //GET ALL CON ENITTY FRAMEWORK
        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var aseguradoras = context.AseguradoraGetAll().ToList();
                    result.Objects = new List<object>();

                    if (aseguradoras!=null)
                    {
                        result.Objects = new List<object>();

                        foreach (var obj in aseguradoras)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();

                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.AseguradoraNombre;
                            aseguradora.FechaCreacion = obj.Fechacreacion.ToString();
                            aseguradora.FechaModificacion = obj.FechaModificacion.ToString();
                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.Usuario.IdUsuario = obj.IdUsuario;
                            aseguradora.Usuario.Nombre = obj.UsuarioNombre;


                            result.Objects.Add(aseguradora);
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
        //GET ALL CON LINQ
        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = (from aseguradora in context.Aseguradoras
                                 select aseguradora).ToList();
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
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = obj.FechaCreacion.ToString();
                            aseguradora.FechaModificacion = obj.FechaModificacion.ToString();
                            


                            result.Objects.Add(aseguradora);
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
        public static ML.Result GetById(int IdAseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "AseguradoraGetById";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];
                        collection[0] = new SqlParameter("@IdAseguradora", System.Data.SqlDbType.Int);
                        collection[0].Value = IdAseguradora;

                        cmd.Parameters.AddRange(collection);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {

                            DataTable aseguradoraTable = new DataTable();
                            da.Fill(aseguradoraTable);
                            cmd.Connection.Open();

                            if (aseguradoraTable.Rows.Count > 0)
                            {
                                result.Objects = new List<object>();
                                DataRow row = aseguradoraTable.Rows[0];

                                ML.Aseguradora aseguradora = new ML.Aseguradora();

                                aseguradora.IdAseguradora = int.Parse(row[0].ToString());
                                aseguradora.Nombre = row[1].ToString();
                                aseguradora.FechaCreacion = row[2].ToString();
                                aseguradora.FechaModificacion = row[3].ToString();
                                aseguradora.Usuario.IdUsuario = int.Parse(row[4].ToString());
                                result.Object = aseguradora;
                                result.Correct = true;
                            }
                            else
                            {
                                result.Correct = false;
                                result.ErrorMessage = "Ocurrió un error al momento de mostrar la aseguradora";
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
        //GET BY ID CON ENTITY FRAMEWORK
        public static ML.Result GetByIdEF(int IdAseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var objAseguradora = context.AseguradoraGetById(IdAseguradora).FirstOrDefault();
                    result.Objects = new List<object>();

                            if (objAseguradora != null)
                            {
                              
                                ML.Aseguradora aseguradora = new ML.Aseguradora();
                                aseguradora.Usuario = new ML.Usuario();
                                aseguradora.IdAseguradora = objAseguradora.IdAseguradora;
                                aseguradora.Nombre = objAseguradora.Nombre;
                                aseguradora.FechaCreacion = objAseguradora.Fechacreacion.ToString();
                                aseguradora.FechaModificacion = objAseguradora.FechaModificacion.ToString();
                                aseguradora.Usuario.IdUsuario = int.Parse(objAseguradora.IdUsuario.ToString());
                                result.Object = aseguradora;
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
        //GET BY ID CON LINQ
        public static ML.Result GetByIdLINQ(int IdAseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = (from aseguradora in context.Aseguradoras
                                 where aseguradora.IdAseguradora==aseguradora.IdAseguradora
                                 select aseguradora).FirstOrDefault();
                                 result.Objects = new List<object>();

                    if (query != null)
                    {
                        
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.IdAseguradora = query.IdAseguradora;
                            aseguradora.Nombre = query.Nombre;
                            aseguradora.FechaCreacion = query.FechaCreacion.ToString();
                            aseguradora.FechaModificacion = query.FechaModificacion.ToString();
                            aseguradora.Usuario.IdUsuario = int.Parse(query.IdUsuario.ToString());
                            result.Object=aseguradora;

                        
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

