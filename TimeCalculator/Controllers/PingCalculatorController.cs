
using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class PingCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(PingCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }

            model.Result = model.CalculatePingTime();
            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Enter IPv4 Address and Calculate Ping Time";
        }

        public const String AlgorithmCode =
@"public String CalculatePingTime()
{
    Ping ping = new Ping();
    PingReply reply = ping.Send(InputOne);

    if (!reply.ToString().Equals(""Success""))
    {
        return Convert.ToString(reply.RoundtripTime);
    }
    else
    {
        return reply.ToString();
    }

}

";
    }
}