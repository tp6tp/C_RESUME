using C_RESUME.Models;
using C_RESUME_DTO.CommonDTO;
using C_RESUME_SYS_UserManagerServices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace C_RESUME.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly ISYS_UserManagerServices _ISYSUserManagerServices;

        public HomeController(ISYS_UserManagerServices ISYS_UserManagerServices)
        {
            this._ISYSUserManagerServices = ISYS_UserManagerServices;
        }

        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Login() //待開發..後台
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Logins(SignDTO DTO)
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult SignUp(SignDTO DTO)
        //{
        //    object[] result = _ISYSUserManagerServices.CreateSignUpData(DTO);
        //    if ((bool)result[0])
        //    {
        //        ViewBag.result = "true";
        //        ViewBag.resultMsg = result[1];
        //        return View("Login");
        //    }
        //    ViewBag.result = "false";
        //    ViewBag.resultMsg = result[1];
        //    return View("Login");
        //}


        [HttpPost]
        public IActionResult ViewJobExperi(string viewName)
        {
            return PartialView(viewName);
        }
        [HttpPost]
        public IActionResult ViewPortfolio(string viewName)
        {
            return PartialView(viewName);
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}