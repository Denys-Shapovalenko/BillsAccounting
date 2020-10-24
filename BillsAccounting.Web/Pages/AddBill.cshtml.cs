using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BillsAccounting.DataAccess.Context;
using BillsAccounting.Models;

namespace BillsAccounting.Web 
{
    public class AddBillModel : PageModel
    {
        public BillContext Context { get; private set; }
        [BindProperty]
        public Bill BillData { get; set; }
        public void OnGet()
        {
            BillData = new Bill();
        }

        public void OnPost()
        {
            try
            {
                Context.Bills.Add(BillData);
                Context.SaveChanges();
                TempData["Status"] = $"Счет {BillData.Number} сохранен";
            }
            catch (Exception ex)
            {
                TempData["Status"] = $"Сохранить счет не удалось. {ex.Message} сохранен";
            }
        }

        public AddBillModel(BillContext context)
        {
            Context = context;
        }
    }
}
