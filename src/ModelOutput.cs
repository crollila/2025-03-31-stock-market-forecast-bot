using Microsoft.ML.Data;

namespace StockMarketBot {
class ModelOutput {
[ColumnName("Score")]
public float Close { get; set; }
}
}
