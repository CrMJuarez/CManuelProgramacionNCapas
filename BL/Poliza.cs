using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Poliza
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = context.PolizaNombreGetAll();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Poliza poliza = new ML.Poliza();
                            poliza.IdPoliza = obj.IdPoliza;
                            poliza.Nombre = obj.Nombre;

                            result.Objects.Add(poliza);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontro registro de la poliza";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }
            return result;
        }

        public static ML.Result AddEF(ML.Poliza poliza)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = context.PolizaAdd(poliza.Nombre,poliza.NumeroPoliza,poliza.FechaCreacion,poliza.FechaModificacion,
                        poliza.Usuario.IdUsuario,poliza.SubPoliza.IdSubPoliza);

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

       
       
        public static ML.Result UpdateEF(ML.Poliza poliza)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var updateResult = context.PolizaUpdate(poliza.Nombre, poliza.NumeroPoliza, poliza.FechaCreacion, poliza.FechaModificacion,
                        poliza.Usuario.IdUsuario, poliza.SubPoliza.IdSubPoliza,poliza.IdPoliza);


                    if (updateResult >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se actualizo el usuario";
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

        public static ML.Result DeleteEF(ML.Poliza poliza)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = context.PolizaDelete(poliza.IdPoliza);

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

        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())
                {
                    var query = context.PolizaGetAll().ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Poliza poliza = new ML.Poliza();
                            poliza.IdPoliza = obj.IdPoliza;
                            poliza.Nombre = obj.Nombre;
                            poliza.NumeroPoliza = obj.NumeroPoliza;
                            poliza.FechaCreacion = obj.FechaCreacion.Value.ToString("dd-mm-yyyy");
                            poliza.FechaModificacion = obj.FechaModificacion.Value.ToString("dd-mm-yyyy");
                            poliza.Usuario= new ML.Usuario();
                            poliza.Usuario.IdUsuario = obj.IdUsuario.Value;
                            poliza.SubPoliza=new ML.SubPoliza();
                            poliza.SubPoliza.IdSubPoliza = obj.IdSubPoliza.Value;


                            result.Objects.Add(poliza);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontro registro de la poliza";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }
            return result;
        }


        public static ML.Result GetByIdEF(int IdPoliza)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.CManuelProgramacionNCapasEntities context = new DL_EF.CManuelProgramacionNCapasEntities())

                {
                    var objPoliza = context.PolizaGetById(IdPoliza).FirstOrDefault();

                    result.Objects = new List<object>();

                    if (objPoliza != null)
                    {
                        ML.Poliza poliza = new ML.Poliza();
                        poliza.IdPoliza = objPoliza.IdPoliza;
                        poliza.Nombre = objPoliza.Nombre;
                        poliza.NumeroPoliza = objPoliza.NumeroPoliza;
                        poliza.FechaCreacion = objPoliza.FechaCreacion.Value.ToString("dd-mm-yyyy");
                        poliza.FechaModificacion = objPoliza.FechaModificacion.Value.ToString("dd-mm-yyyy");
                        
                        poliza.Usuario = new ML.Usuario();
                        poliza.Usuario.IdUsuario = objPoliza.IdUsuario.Value;
                        poliza.SubPoliza = new ML.SubPoliza();
                        poliza.SubPoliza.IdSubPoliza = objPoliza.IdSubPoliza.Value;

                        result.Object = poliza;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontraron registros.";
                    }
                }
            }
            catch (Exception ex)
            {

                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }

            return result;
        }

    }



}
