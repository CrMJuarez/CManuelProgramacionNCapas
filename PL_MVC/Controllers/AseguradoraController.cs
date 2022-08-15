using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class AseguradoraController : Controller
    {
        // GET: Aseguradora
        public ActionResult GetAll()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            ML.Result result = BL.Aseguradora.GetAllEF();
            if (result.Correct)
            {
                aseguradora.Aseguradoras = result.Objects.ToList();
                return View(aseguradora);
            }
            else               
                ViewBag.Message = "ocurrio un problema" + result.ErrorMessage;
            return PartialView("Modal");
            

        }
        [HttpGet]
        public ActionResult Form(int? IdAseguradora)
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            if (IdAseguradora == null)
            {
                return View(aseguradora);
            }
            else
            {
                ML.Result result = BL.Aseguradora.GetByIdEF(IdAseguradora.Value);
                if (result.Correct)
                {
                    aseguradora = (ML.Aseguradora)result.Object;
                    return View(aseguradora);
                }
                ViewBag.Message = result.ErrorMessage;
                return View();
            }
        }

        [HttpPost]
        
        public ActionResult Form(ML.Aseguradora aseguradora)
        {
            if (aseguradora.IdAseguradora == 0)
            {
                ML.Result result = BL.Aseguradora.AddEF(aseguradora);
                if (result.Correct)
                {
                    ViewBag.Message = "Se agrego correctamente el usuario";
                    return PartialView("Modal");
                }
                else
                {
                    ViewBag.Message = "ocurrio un problema" + result.ErrorMessage;
                    return PartialView("Modal");
                }
            }
            else
            {
                ML.Result result = BL.Aseguradora.UpdateEF(aseguradora);
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int IdAseguradora)
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            aseguradora.IdAseguradora = IdAseguradora;
            var result = BL.Aseguradora.DeleteEF(aseguradora);

            if (result.Correct)
            {
                ViewBag.Message = "Se elimino correctamente la aseguradora";
               
            }
            else
            {
                ViewBag.Message = "ocurrio un problema" + result.ErrorMessage;
               
            }

            return PartialView("Modal");


        }
    }
}
