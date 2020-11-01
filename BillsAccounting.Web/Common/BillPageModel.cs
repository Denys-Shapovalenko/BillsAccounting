using BillsAccounting.DataAccess.Context;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BillsAccounting.Web.Common
{
    public class BillPageModel : PageModel
    {
        protected BillContext Context {get; private set;}
        public BillPageModel(BillContext context)
        {
            Context = context;
        }
    }
}