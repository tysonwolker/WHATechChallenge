using CsvHelper.Configuration;
using RiskAnalysis.Domain.Entities;

namespace RiskAnalysis.Infrastructure.Data.Repository
{
    public sealed class ParticipantMapper : CsvClassMap<Participant>
    {
        public ParticipantMapper()
        {
            Map(map => map.ParticipantId).Name("Participant");
        }
    }
}