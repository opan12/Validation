using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week_11.WebAPİ.Models;
using Week_11_1.Persistence.Context;
using Week11_1.Domain.Entities;

namespace Week_11.WebAPİ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        public PerfectAppDbContext _perfectAppDbContext;

        public BankAccountsController(PerfectAppDbContext perfectAppDbContext)
        {
            _perfectAppDbContext = perfectAppDbContext;
        }
        [HttpPost("[action")]
    public void SetDefaultUsersData()
    {
        List<BankAccount> customer = new()
        {
            new BankAccount
            {
                Id = Guid.Parse("fcbb248d-9499-4c8f-8e59-1684d15692b6"),
                FirstName = "songul",
                LastName = "opan",
                PhoneName="53725445",
                     Balance = 500.0m,
                CreatedByUserId = "opan123",
                CreatedOn = DateTime.UtcNow,

            }
        };
            _perfectAppDbContext.BankAccounts.AddRange(customer);
            _perfectAppDbContext.SaveChanges();
        }
    [HttpGet("[action]/{bankAccountId:guid}")]
    public GetBankAccountDataResponseModel GetBankAccountData(Guid bankAccountId)
    {
        var bankAccount = _perfectAppDbContext.BankAccounts.FirstOrDefault(x => x.Id == bankAccountId);

        var response = new GetBankAccountDataResponseModel()
        {
            FirstName = bankAccount.FirstName,
            LastName = bankAccount.LastName,
            Balance = bankAccount.Balance,
        };

        return response;
    }
}}