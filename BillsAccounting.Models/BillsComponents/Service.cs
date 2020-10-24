using System;
using System.ComponentModel.DataAnnotations;

namespace BillsAccounting.Models.BillsComponents
{
    public class Service
    {
        [Key]
        public int SercviceId {get;set;}
        public string Name { get; set; }
        public decimal ToPay { get; set; }

        public Service(string name, decimal toPay)
        {
            Name = name;
            ToPay = toPay;
        }

        public Service(string name) : this(name, 0.0m) {  }
    }
}