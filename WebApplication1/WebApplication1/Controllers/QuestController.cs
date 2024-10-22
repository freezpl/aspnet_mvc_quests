﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTOModels.Model;
using Microsoft.AspNetCore.Mvc;
using QuestBLL.Interfaces;

namespace QuestWebApp.Controllers
{
    public class QuestController : Controller
    {
        IService _service;

        public QuestController(IService service)
        {
            _service = service;
        }

        async public Task<IActionResult> Quests()
        {
            return View(await _service.GetQuestsAsync());
        }

        [HttpPost]
        async public Task<PartialViewResult> Filter([FromBody]string data)
        {
            List<QuestDTO> quests = await _service.SearchQuestsAsync(data);
            return PartialView(quests);
        }
    }
}