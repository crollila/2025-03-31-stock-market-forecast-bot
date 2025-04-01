using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace StockMarketBot {
class DataService : IDataService {
HttpClient client = new HttpClient();
public List<double> GetHistoricData(string ticker, int period) { //implementation }
public PredictedData GetPredictedData(string ticker, int period) { //implementation }
}
}
