 using System.Collections.Generic;

namespace SentimentAnalysis
{
    internal class TestSentimentData
    {
        internal static readonly IEnumerable<SentimentData> Sentiments = new[]
        {
            //new SentimentData
            //{
            //    SentimentText = "Contoso's 11 is a wonderful experience",
            //    Sentiment = 0
            //},
            //new SentimentData
            //{
            //    SentimentText = "The acting in this movie is very bad",
            //    Sentiment = 0
            //},
            //new SentimentData
            //{
            //    SentimentText = "Joe versus the Volcano Coffee Company is a great film.",
            //    Sentiment = 0
            //}

            new SentimentData
            {
                SentimentText = "p90RSK blockade inhibits dual BRAF and MEK inhibitor-resistant melanoma by targeting protein synthesis. https://t.co/7wqK5zF7AZ.",
                Sentiment = 1
            },
            new SentimentData
            {
                SentimentText = "RT @PCGddCdd: Braf croesawu Leanne Wood i Ogledd Caerdydd. Great to have the support of Leanne Wood in Cardiff North  Vote... https://t.co/…",
                Sentiment = 0
            },
            new SentimentData
            {
                SentimentText = "RT @emhlung: Promising news of a new target in a subset of lung cancer: BRAF V600-mutant adenocarcinoma https://t.co/ng6NPlyb6F via @Cancer…..",
                Sentiment = 1
            }
            ,
            new SentimentData
            {
            SentimentText = "RT @CTywydd: Tywydd I nifer heddiw! Cofiwch wylio ar @S4C a dilynwch ein cyfrifon Twitter ,facebook ac Instagram / Not too bad today",
            Sentiment = 0
            },


            new SentimentData
            {
                SentimentText = " Combinations of inhibitor and anti-PD-1/PD-L1 antibody improve survival and tumour immunity in an immunocompetent model of orthotopic murine anaplastic thyroid cancer. ",
                Sentiment = 1
            },



            new SentimentData
            {
                SentimentText = "@HeleddAnj wherever you choose Heledd, make sure you are not too far away from facilities, yn enwedig gydar un bach..syniad braf #Adventure ",
                Sentiment = 1
            },


          

        };
    }
}
