public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, string address, string weatherForecast)
        : base(title, description, date, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nWeather Forecast: {_weatherForecast}\nEvent Type: OutdoorGathering";
    }
}