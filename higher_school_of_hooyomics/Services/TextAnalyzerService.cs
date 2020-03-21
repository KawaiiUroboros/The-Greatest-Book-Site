using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;


namespace higher_school_of_hooyomics.Services
{
    public interface ITextAnalyzerService
    {
        List<string> AnalyzeText(string text);
    }

    public class TextAnalyzerService : ITextAnalyzerService
    {
       
        private static readonly TextAnalyticsApiKeyCredential credentials = new TextAnalyticsApiKeyCredential("e57c61e12d6d44659abd856a47568cb1");
        private static readonly Uri endpoint = new Uri("https://hackuniv.cognitiveservices.azure.com/");
        private static TextAnalyticsClient client = new TextAnalyticsClient(endpoint, credentials);

        public List<string> AnalyzeText(string text)
        {
            List<string> tags = new List<string>();
            var response = client.ExtractKeyPhrases(text);
         
            Console.WriteLine("Key phrases:");

            foreach (string keyphrase in response.Value)
            {
                tags.Add(keyphrase);
            }
            return tags;
        }

    }
}
