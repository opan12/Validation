using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week_11_1.Persistence.Context;
using Week11_1.Domain.Entities;

namespace Week_11.WebAPİ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        public PerfectDbContext _perfectAppDbContext;

        public BankAccountController(PerfectDbContext perfectDbContext)
        {

            _perfectAppDbContext perfectDvContext;
        }
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
                PhoneNumber = "5537230946
                     Balance = 500.0m,
                CreatedByUserId = "asd123",
                CreatedOn = DateTime.UtcNow,

            }
        };

