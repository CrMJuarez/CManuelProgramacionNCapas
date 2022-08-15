using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class PolizaController : Controller
    {
        // GET: Poliza
        public ActionResult GetAll()
        {
            ServicePoliza.PolizaClient polizaClient = new ServicePoliza.PolizaClient();
            var result = polizaClient.GetAll();
            ML.Poliza poliza = new ML.Poliza();
            //ML.Result result = BL.Poliza.GetAllEF();
            if (result.Correct)
            {
                poliza.Polizas = result.Objects.ToList();
                return View(poliza);
            }
            else
                ViewBag.Message = "ocurrio un problema" + result.ErrorMessage;
            return PartialView("Modal");
        }

        [HttpGet]
        public ActionResult Form(int? IdPoliza)
        {
            ML.Poliza poliza = new ML.Poliza();
            if (IdPoliza == null)
            {
                return View(poliza);
            }
            else
            {
                ServicePoliza.PolizaClient polizaClient = new ServicePoliza.PolizaClient();
                var result = polizaClient.GetById(IdPoliza.Value);
                //ML.Result result = BL.Poliza.GetByIdEF(IdPoliza.Value);
                if (result.Correct)
                {
                    poliza = (ML.Poliza)result.Object;
                    return View(poliza);
                }
                ViewBag.Message = result.ErrorMessage;
                return View();
            }
        }

        [HttpPost]

        public ActionResult Form(ML.Poliza poliza)
        {
            
            if (poliza.IdPoliza == 0)
            {
                ServicePoliza.PolizaClient polizaClient = new ServicePoliza.PolizaClient();
                var result = polizaClient.Add(poliza);
                //ML.Result result = BL.Poliza.AddEF(poliza);
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
                ServicePoliza.PolizaClient polizaClient = new ServicePoliza.PolizaClient();
                var result = polizaClient.Update(poliza);
                //ML.Result result = BL.Poliza.UpdateEF(poliza);
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int IdPoliza)
        {
            ML.Poliza poliza = new ML.Poliza();
            poliza.IdPoliza = IdPoliza;
            ServicePoliza.PolizaClient polizaClient = new ServicePoliza.PolizaClient();
            var result = polizaClient.Delete(poliza);
            //var result = BL.Poliza.DeleteEF(poliza);

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