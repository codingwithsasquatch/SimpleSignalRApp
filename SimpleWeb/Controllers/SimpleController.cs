﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace SimpleWeb.Controllers
{
    [Route("api/[controller]")]
    public class SimpleController : Controller
    {
        private IHubContext<NotificationsHub> _hubContext;

        public SimpleController(IHubContext<NotificationsHub> hubContext)
        {
            _hubContext = hubContext;
        }

        // GET api/simple
        [HttpGet]
        public string Get()
        {
            _hubContext.Clients.All.InvokeAsync("updateStuff", "some random text");
            return "I have been called!";
        }

    }
}
