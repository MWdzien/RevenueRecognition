using RevenueRecognition.Domain.ValueObjects.DiscountValueObjects;

namespace RevenueRecognition.Domain.Entities;

public class Discount
{
    public DiscountCode DiscountCode { get; set; }
    public DiscountName Name { get; set; }
    public DiscountOffer Offer { get; set; }
    public DiscountRate Rate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Boolean IsActive { get; set; }

    public Discount(DiscountCode discountCode, DiscountName name, DiscountOffer offer, DiscountRate rate, DateTime startDate, DateTime endDate)
    {
        DiscountCode = discountCode;
        Name = name;
        Offer = offer;
        Rate = rate;
        StartDate = startDate;
        EndDate = endDate;

        IsActive = StartDate < DateTime.Now && EndDate > DateTime.Now;
    }
    
    
}