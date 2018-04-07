using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Web.Models;
using System.Web.Security;
using System.Data.SqlClient;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autorizar(ELogin usuario)
        {
            SGAEntities sga = new SGAEntities();

            string SQL = "LoginUsers \n @UsuarioID, @Password";
            var u = sga.Database.SqlQuery<ELogin>(SQL,
                new SqlParameter() { ParameterName = "@UsuarioID", Value = usuario.UserID},
                new SqlParameter() { ParameterName = "@Password", Value = usuario.Password }
                ).ToList().FirstOrDefault();
            if (u == null)
            {
                usuario.ERROR_MENSAJE = "Usuario o Contraseña incorrecto";
            }
            else
            {
                FormsAuthentication.SetAuthCookie(usuario.NOMBRES, false);
                Session["MATRICULA"] = usuario.UserID;
                //ELogin e = new ELogin();
                Session["Name"] = u.NOMBRES;
                Session["Tipo"] = u.TIPO;
                return RedirectToAction("Index", "Cuenta");
            }
            return View("Index", usuario);
        }

        public ActionResult Salir()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}