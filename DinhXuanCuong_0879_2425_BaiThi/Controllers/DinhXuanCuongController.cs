namespace DinhXuanCuong_0879_2425_BaiThi.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class NameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(string x)
        {
            return View();
        }

       
    }
}