using System;
using BillsAccounting.Models.BillsComponents;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BillsAccounting.Models
{
    public class Bill
    {
        public Bill()
        {
            HotWaterAndHeating = new Service("Hot water and heating");
            Electricity = new Service("Electricity");
            ColdWater = new Service("Cold water");
        }
        [Key]
        public int BillId {get;set;}
        public int Number {get;set;} = 1;
        public decimal Overpayment { get; set; }
        public decimal TotalPay => ( HotWaterAndHeating.ToPay + Electricity.ToPay + ColdWater.ToPay - Overpayment);

        [ForeignKey("Service")]
        public int HotWaterAndHeatingId { get; set; } 
        [ForeignKey("Service")]
        public int ElectricityId { get; set; }
        [ForeignKey("Service")]
        public int ColdWaterId { get; set; }

        public Service HotWaterAndHeating { get; private set; }
        public Service Electricity { get; private set; }
        public Service ColdWater { get; private set; }
    }
}