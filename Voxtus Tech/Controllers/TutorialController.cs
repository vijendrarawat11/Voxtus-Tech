﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Voxtus_Tech.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("learn/canvas-application/introduction-to-power-apps")]
        public IActionResult Introduction()
        {
            return View();	
        }
        [Route("learn/canvas-application/setting-up-power-apps-environment")]
        public IActionResult SettingupEnvironment()
        {
            return View();
        }
        [Route("learn/canvas-application/exploring-power-apps")]
        public IActionResult ExploringthePowerApps()
        {
            return View();
        }
        [Route("learn/canvas-application/how-to-create-new-environment-publisher-solution")]
        public IActionResult EnvironmentPublisherSolution()
        {
            return View();
        }
        [Route("learn/canvas-application/understanding-dataverse")]
        public IActionResult DataSource()
        {
            return View();
        }
        [Route("learn/canvas-application/creating-first-canvas-app")]
        public IActionResult CreatingCanvasapp()
        {
            return View();
        }
        [Route("learn/canvas-application/canvas-app-interface")]
        public IActionResult CanvasAppInterface()
        {
            return View();
        }
        [Route("learn/canvas-application/layout-and-components")]
        public IActionResult Layoutandcomponents()
        {
            return View();
        }
        [Route("learn/canvas-application/controls-and-properties")]
        public IActionResult ControlsandProperties()
        {
            return View();
        }
        [Route("learn/canvas-application/build-a-canvas-application-quickly")]
        public IActionResult BuildCanvasAppQuickly()
        {
            return View();
        }
        [Route("learn/canvas-application/adding-screens")]
        public IActionResult Addingscreens()
        {
            return View();
        }
        [Route("learn/canvas-application/customizing-screen-layouts")]
        public IActionResult Customizingscreenlayouts()
        {
            return View();
        }
        [Route("learn/canvas-application/navigating-between-screens")]
        public IActionResult Navigatingbetweenscreens()
        {
            return View();
        }
        [Route("learn/canvas-application/variables-(set,contex,collection)")]
        public IActionResult Variables()
        {
            return View();
        }
        [Route("learn/canvas-application/functions")]
        public IActionResult Functions()
        {
            return View();
        }
        [Route("learn/canvas-application/integrating-data-from-various-sources")]
        public IActionResult Integratingdatasources()
        {
            return View();
        }
        [Route("learn/canvas-application/creating-connections-and-configuring-data-sources")]
        public IActionResult Creatingconnections()
        {
            return View();
        }
        [Route("learn/canvas-application/working-with-controls-in-power-apps-canvas-apps")]
        public IActionResult WorkingwithControls()
        {
            return View();
        }
        [Route("learn/canvas-application/responsive-design-and-layout-techniques")]
        public IActionResult Responsivedesignandlayouttechniques()
        {
            return View();
        }
        [Route("learn/canvas-application/understanding-variables-in-power-apps")]
        public IActionResult UnderstandingVariablesinPowerApps()
        {
            return View();
        }
        [Route("learn/canvas-application/practical-uses-of-variables-in-power-apps")]
        public IActionResult PracticalUsesofVariablesinPowerApps()
        {
            return View();
        }
        [Route("learn/canvas-application/configuring-app-permissions")]
        public IActionResult ConfiguringAppPermissions()
        {
            return View();
        }
        [Route("learn/canvas-application/implementing-role-based-access-control")]
        public IActionResult ImplementingRoleBasedAccessControl()
        {
            return View();
        }
    }
}
