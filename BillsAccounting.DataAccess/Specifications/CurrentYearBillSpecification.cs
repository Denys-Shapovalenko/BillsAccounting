using System;
using BillsAccounting.Abstract.BasicClasses;
using BillsAccounting.Models;

namespace BillsAccounting.DataAccess.Specifications
{
    public class CurrentYearBillSpecification : BaseSpecification<Bill>
    {
        public CurrentYearBillSpecification()
        {
            Criteria = b => b.CreationDate.Year == DateTime.Today.Year;
            Includes.Add(b => b);
        }
    }
}