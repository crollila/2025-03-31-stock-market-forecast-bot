using System;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace StockMarketBot {
class MLModel {
private static string MODEL_PATH = @"./model.zip";
public static PredictionEngine<ModelInput, ModelOutput> CreateModel() { var mlContext = new MLContext(); ITransformer mlModel = mlContext.Model.Load(MODEL_PATH, out var modelInputSchema); var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel); return predEngine; }
}
}
