using EssentialTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace EssentialTool.Controllers
{
    public class HomeController : Controller
    {
        Product[] products =
        {
            new Product{Name="Kayak", Category="Watersports", Price=275M},
            new Product{Name="Lifejacket", Category="Watersports", Price=48.95M},
            new Product{Name="Soccer ball", Category="Soccer", Price=19.50M},
            new Product{Name="Corner flag", Category="Soccer", Price=34.95M}
        };

        // GET: Home
        public ActionResult Index()
        {
            //当需要一个对象时, 将使用这个内核而不是使用一个new 关键字
            IKernel ninjectKernel = new StandardKernel();
            //每一个接口希望使用的实现对象
            ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
            //IValueCalculator calc = new LinqValueCalculator();
            //change to below
            //Get 方法所使用的类型参数告诉Ninject,指定的是哪一个接口,而该方法的结果是刚才用TO 方法指定的实现类型的一个实例
            IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}