﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vistas.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Horario()
        {
            return View();
        }
    }
}