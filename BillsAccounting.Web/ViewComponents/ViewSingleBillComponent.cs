using BillsAccounting.Models;
using Microsoft.AspNetCore.Mvc;

namespace BillsAccounting.Web.ViewComponents
{
    public class ViewSingleBillComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Bill bill)
        {
            return View(bill);
        }
    }
}