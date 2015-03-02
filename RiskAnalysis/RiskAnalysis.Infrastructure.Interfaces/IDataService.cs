namespace RiskAnalysis.Infrastructure.Interfaces
{
    public interface IDataService
    {
        string SettledCsv { get; }
        string UnsettledCsv { get; }
    }
}
