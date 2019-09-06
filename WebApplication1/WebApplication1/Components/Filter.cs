using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestWebApp.Components
{
    public class Filter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Default", "Hi!");
        }
    }
}
