using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMsales2
{
    public class Helpers
    {

        public List<string> CurrencyList = new List<string>() { "UAH", "USD", "EUR" };
        public List<string> DeliveryList = new List<string>()
        {
            "NewPost", "NewExpress", "MistExpress", "DHL", "TNT", "Fedex", "ClientTransport",
            "SypplierTransport", "EXW", "OurTransport"
        };
        public List<string> MeasureUnits = new List<string>()
        {
            "piece", "set", "millimeter", "meter", "gramm", "kilogramm", "tonn", "litre", "CubicMeter"
        };
        public List<string> PaymentTypes = new List<string>()
        {
            "BankTransfer", "Cash", "Visa", "Private24", "COD" /*Cash On Delivery- наложенный платеж*/
        };
        public List<string> OrderStates = new List<string>()
        {
            "Registration", "Approval", "Executed", "Completed", "Canceled"
        };
        public List<string> SheduleDeliveriesAndPayment = new List<string>()// График поставок и оплат
        {
            "100% payment in advance",
            "30% payment in advance / 100% delivery",
            "50% payment in advance + 50% payment before shipment"
        };
        public static List<string> CountraprtyType = new List<string>() // Тип контрагента
        {
            //"Клиент",
            //"Конкурент",
            //"Наша компания",
            //"Партнер",
            //"Дилер",
            //"Поставщик"
        };
        public List<string> TypeOfOwnership = new List<string>() // Форма собственности
        {
            "ТОВ",
            "AТ",
            "ЗАТ",
            "ВАТ",
            "ФОП",
            "ПП"
        };

    }
}
