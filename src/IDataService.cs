using System.Collections.Generic;

namespace StockMarketBot {
interface IDataService {
List<double> GetHistoricData(string ticker, int period);
PredictedData GetPredictedData(string ticker, int period);
}
}
