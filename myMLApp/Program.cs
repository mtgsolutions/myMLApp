using MyMLApp;

namespace myMLApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read avaliation 
            Console.WriteLine("Enter your sentiment after eat our food: ");
            var avaliation = Console.ReadLine();
            //Load sample data
            var sampleData = new Sentiment.ModelInput()
            {
                Col0 = @avaliation,
            };

            //Load model and predict output
            var result = Sentiment.Predict(sampleData);

            // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
            var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
            Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
        }
    }
}
