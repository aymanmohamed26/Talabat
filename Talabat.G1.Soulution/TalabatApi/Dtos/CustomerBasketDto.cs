using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TalabatApi.Dtos
{
    public class CustomerBasketDto
    {
        [Required]
        public string Id { get; set; }
        public List <BasketItemDto> Items { get; set; }

        public string? PaymentIntentId { get; set; }//todo edit here
        public string? ClientSecret { get; set; } //todo edit here
        public int? DeliveryMethoudId { get; set; }
        public Decimal ShippingCost { get; set; }
    }
}
