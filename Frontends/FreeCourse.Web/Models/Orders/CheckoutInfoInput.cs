using System.ComponentModel.DataAnnotations;

namespace FreeCourse.Web.Models.Orders
{
    public class CheckoutInfoInput
    {
        [Display(Name ="İl")]
        public string Province { get; private set; }

        [Display(Name = "İlçe")]
        public string District { get; private set; }

        [Display(Name = "Cadde")]
        public string Street { get; private set; }

        [Display(Name = "Posta Kodu")]
        public string ZipCode { get; private set; }

        [Display(Name = "Adres")]
        public string Line { get; private set; }

        [Display(Name = "Kart isim soyisim")]
        public string CardName { get; set; }

        [Display(Name = "Kart no")]
        public string CardNumber { get; set; }

        [Display(Name = "Son kullanma tarihi(ay/yıl)")]
        public string Expiration { get; set; }

        [Display(Name = "CVV/CVC2 numarası")]
        public string CVV { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
