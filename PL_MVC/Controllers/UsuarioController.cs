﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        //public ActionResult GetAll()
        //{
        //    ML.Usuario usuario = new ML.Usuario();
        //    ML.Result result = BL.Usuario.GetAllEF();
           

        //    if (result.Correct)
        //    {
        //        usuario.Usuarios = result.Objects.ToList();
        //        return View(usuario);
        //    }
        //    else
        //        ViewBag.Message = "ocurrio un problema" + result.ErrorMessage;
        //    return PartialView("Modal");
        //}

        [HttpGet]
        public ActionResult Form(int? IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            ML.Result resultRol = BL.Rol.GetAll();
            if (IdUsuario == null)
            {
                ViewBag.Titulo = "Agregar un Usuario";
                ViewBag.Accion = "Agregar";
                usuario.Rol = new ML.Rol();
                usuario.Rol.Roles = resultRol.Objects.ToList();
                return View(usuario);
            }
            else
            {
                ViewBag.Titulo = "Actualizar un Usuario";
                ViewBag.Accion = "Actualizar";
                ML.Result result= BL.Usuario.GetByIdEF(IdUsuario.Value);
                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object;
                    usuario.Rol.Roles = resultRol.Objects.ToList();
                    return View(usuario);
                }
                else
                {
                    ViewBag.Message = result.ErrorMessage;
                    return View();
                }
            }
        }
        [HttpPost]

        //public ActionResult Form(ML.Usuario usuario)
        //{
        //    if (usuario.IdUsuario == 0)
        //    {
        //        ML.Result result = BL.Usuario.AddEF(usuario);
        //        if (result.Correct)
        //        {
        //            ViewBag.Message = "Se agrego correctamente el usuario";
        //            return PartialView("Modal");
        //        }
        //        else
        //        {
        //            ViewBag.Message = "ocurrio un problema" + result.ErrorMessage;
        //            return PartialView("Modal");
        //        }

        //    }
        //    else
        //    {
        //        ML.Result result = BL.Usuario.UpdateEF(usuario);
        //        if (result.Correct)
        //        {
        //            ViewBag.Message = "Se actualizo el usuario";
        //            return PartialView("Modal");
        //        }
        //        else
        //        {
        //            ViewBag.Message = "No se pudo actualizar el usuario";
        //            return PartialView("Modal");

        //        }


        //    }
        //}

        [HttpGet]
        public ActionResult Delete(int IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.IdUsuario = IdUsuario;
            var result = BL.Usuario.DeleteEF(usuario);

            if (result.Correct)
            {
                ViewBag.Message = "Se elimino correctamente el usuario";

            }
            else
            {
                ViewBag.Message = "ocurrio un problema" + result.ErrorMessage;

            }

            return PartialView("Modal");


        }


    }

    }
