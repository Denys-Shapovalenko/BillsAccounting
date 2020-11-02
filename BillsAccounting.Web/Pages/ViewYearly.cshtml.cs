using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BillsAccounting.DataAccess.Context;
using BillsAccounting.Models;
using BillsAccounting.Web.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BillsAccounting.DataAccess.Extensions;
using BillsAccounting.DataAccess.Specifications;

namespace MyApp.Namespace
{
    public class ViewYearlyModel : BillPageModel
    {
        public List<Bill> Bills { get; protected set; }
        
        public ViewYearlyModel(BillContext context) : base (context)
        {
            
        }
        public void OnGet()
        {
            Bills = Context.Bills
            .Include(bill => bill.Electricity)
            .Include(bill => bill.ColdWater)
            .Include(bill => bill.HotWaterAndHeating)
            .AsQueryable().Specify<Bill>(new CurrentYearBillSpecification()).
            ToList();
        }
    }
}