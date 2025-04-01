using Microsoft.ML.Data;

namespace StockMarketBot {
class ModelInput {
[ColumnName("Label"), LoadColumn(0)]
public float Close { get; set; }

[LoadColumn(1)]
public float Volume { get; set; }
}
}
