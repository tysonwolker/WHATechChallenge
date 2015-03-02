using CsvHelper.Configuration;
using RiskAnalysis.Domain.Entities;

namespace RiskAnalysis.Infrastructure.Data.Repository
{
    public sealed class CustomerMapper : CsvClassMap<Customer>
    {
        public CustomerMapper()
        {
            Map(map => map.CustomerId).Name("Customer");
        }
    }
}