using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TablasDeMultiplicar.Services;

namespace TablasDeMultiplicar.Controllers
{
    public class EjerciciosController : Controller
    {
        private readonly MultiplicacionesService _tablesService;

        public EjerciciosController(MultiplicacionesService tablesService)
        {
            _tablesService = tablesService;
        }

        public IActionResult MuyFaciles(int tabla)
        {
            var exerciselist = _tablesService.GetEjercicios(tabla, 10);
            return View(exerciselist);
        }

        public IActionResult Faciles(int tabla)
        {
            var exerciselist = _tablesService.GetEjercicios(tabla, 10);
            return View(exerciselist);
        }
    }
}