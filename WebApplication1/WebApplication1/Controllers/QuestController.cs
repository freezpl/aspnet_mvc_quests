using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QuestWebApp.Controllers
{
    public class QuestController : Controller
    {
        public IActionResult Quests()
        {

            return View();
        }
    }
}