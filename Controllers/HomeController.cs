/**
 * Author:    Gabrielius A Kudirka
 * Date:      09/01/2020  *Course:    CS 4540, University of Utah, School of Computing
 * Copyright: CS 4540 and Gabrielius A Kudirka - This work may not be copied for use in Academic Coursework.
 *
 * I, Gabrielius A Kudirka, certify that I wrote this code from scratch and did 
 * not copy it in part or whole from another source.  Any references used 
 * in the completion of the assignment are cited in my README file and in
 * the appropriate method header.
 *
 * File Contents
 *
 *    This is the controller for the URC website. This page controls which views a user sees when they visit
 *    pages within the website.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using URC_2.Models;

namespace URC_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Opportunities_Handmade()
        {
            return View();
        }

        public IActionResult Details_Handmade()
        {
            return View();
        }

        public IActionResult Application()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
