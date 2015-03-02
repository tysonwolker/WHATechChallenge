using CsvHelper.Configuration;
using RiskAnalysis.Domain.Entities;

namespace RiskAnalysis.Infrastructure.Data.Repository
{
    public sealed class EventMapper : CsvClassMap<Event>
    {
        public EventMapper()
        {
            Map(map => map.EventId).Name("Event");
        }
    }
}