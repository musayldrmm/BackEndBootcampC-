﻿using Microsoft.AspNetCore.Mvc;

namespace YemekTarifiWebApi.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
