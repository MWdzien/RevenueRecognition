using RevenueRecognition.Domain.Exceptions;
using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Domain.Entities;

public class CompanyCustomer : Customer
{
    private CustomerName _companyName;
    private CustomerKrs _krs;

}