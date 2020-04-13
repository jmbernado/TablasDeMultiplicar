using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TablasDeMultiplicar.Models;
using TablasDeMultiplicar.Services;

namespace TablasDeMultiplicar.Controllers
{
    public class TablasController : Controller
    {
        private readonly MultiplicacionesService _tablesService;

        public TablasController(MultiplicacionesService tablesService)
        {
            _tablesService = tablesService;
        }


        public IActionResult Index()
        {
            List<List<Tablas>> Tables = _tablesService.GetTablas();
            
            return View(Tables);
        }
    }
}