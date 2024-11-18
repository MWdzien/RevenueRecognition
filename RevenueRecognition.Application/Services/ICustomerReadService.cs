namespace RevenueRecognition.Application.Services;

public interface ICustomerReadService
{
    Task<bool> ExistsByEmailAsync(string email);
    Task<bool> ExistsByPeselAsync(string pesel);
    Task<bool> ExistsByKrsAsync(string krs);
}