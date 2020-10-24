using BillsAccounting.Models.BillsComponents;
using BillsAccounting.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BillsAccounting.Web.ViewComponents
{
    public class ServiceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string field, Service service)
        {
            return View(new ServiceViewModel(field, service));
        }
    }
}