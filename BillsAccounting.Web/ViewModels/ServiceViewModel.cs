using BillsAccounting.Models.BillsComponents;

namespace BillsAccounting.Web.ViewModels
{
    public class ServiceViewModel
    {
        private string _field = string.Empty;
        public Service Service{ get; set; }

        public string PaymentField => $"{_field}.ToPay";

        public ServiceViewModel(string field, Service service)
        {
            _field = field;
            Service = service;
        }
    }
}