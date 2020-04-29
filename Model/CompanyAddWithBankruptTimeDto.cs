using System;

namespace WebAPI.Model
{
    public class CompanyAddWithBankruptTimeDto : CompanyAddDto
    {
        public DateTime BankruptTime { get; set; }
    }
}
