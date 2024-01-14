using System;

namespace HotelDesktop.Models.ExtendedModels;

public class BankCardsTabRecord
{
    public string Owner { get; set; }
 
    public string Number { get; set; }

    public DateOnly ExpiredDate { get; set; }

    public string PaymentSystem { get; set; }

    public string Bank { get; set; }
}