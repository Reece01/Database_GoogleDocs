using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis;
using Google.GData.Client;
using Google.GData.Extensions.AppControl;
using GoogleSheetsDatabase;

namespace Database_GoogleDocs
{
    //1YSj42ZFy7NSQ50qm5L1NQOu9dASByw9CU4lorNBRq7k
    
    class Program
    {

        static void Main(string[] args)
        {
            Task.Run(WriteAsync);
            Console.Write("Done");
            Console.ReadLine();
        }

        static async Task WriteAsync()
        {
            var sheetsDatabase = new GoogleSheetDatabase(
                spreadsheetId: "1ax3TUtzIMbTBxFXnQ85lE91HoCVphB0-dnK-1USzd7c",
                sheetsDatabaseClientEmail: "sheetsdbtestserviceaccount@sheetsdbtestproject-214208.iam.gserviceaccount.com",
                sheetsDatabasePrivateKey: "-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQDAtXTORiJAUQVm\nZS/UHrL/Nvrlh0OmFRXUqHxSMxfW+b9VvdQg/yVP8R2Vngsynez6VNyytgQNyVwT\nh75vupBD4JLlMYnNQcNbefgoxPIDhgfe8/+ezXNmGkQiHeYykKXRUcR9XvSsA4pQ\ni8uU8GLAoUlN9/7/KG+kLjLiM/SoFTRPahG7zox/w0TxgZnEFQ40MBeJVhPJ96hG\n5BYFAKtmKoo53pNLbeVHUXRwMJu02ZaSSr7WVnY/hFWe8vPr7i1I66KOUi5SVNtW\nDAGE1wtPQw5V29kn868uuJFfjQiAhiwrqN36IndI7I9HAO1y91ze4180BI5n7X4z\n2yi0akddAgMBAAECggEADDt4bp+FDRAXh6hkoNJSCmEzC97KLICqIhWPzqfvm3W+\n73JdRLrtY2WquxSNIWlk4X8Bg1aKa1WcwqCbNfxhq+1VZbb/SEgkXmoflnbp5c9c\nMIrMbwgbix+fs4qyUgNcgyztjAe7ADA5V2OISKv5mMCkJo7XYNrwOzuzfyhNH14c\n36eWebRDbshcfnqddpfd/bCZnkilcVUSO/KCiGrFs/nAT2tvW1Exo2Qr5lh2h+vV\nLhPNVqS24JEN9LLjqre7YYIK0GIS5RtJuJQXK3HVbq2CjHNeeDstZw6HT//IwRV3\nzNUST3BaySDzTr+m+nbNS26vlzwe+q3pfTS3H/rwAQKBgQD0npZP+2RVSjJjm9jp\n2wA3nJBc90JmGFaP7PgMislDj064hs96FLPZx2IUpDMtNGbxCj9YcFcKU3LVePm5\nZQPHAbmSAHtE9qQfaZSfZ6aZxohXT/Ngwon0L/CMJnRBD0Rg0zeZBtoa/EDXwfS0\nx6/oLorHfBmELi6l/c8TxCwSUQKBgQDJrJ05y5HGxpAvrtJKa7UMZ3bo6o2KnkZK\ngQPC5bSRRStPKnWS4/wzljlDlJVBL5BdC24kxWENEvcBw3XCjRtBR1qpBStjAjPC\nk/xSY4cJIiX2aP11torcVa2JQIl4nqih2Z6dScPK+jm4hdmnTtyj0BniL1IKyqzd\nb0PwN/41TQKBgF8NiKcHrpMdw7rFAmLMwKbbZZVaVyjI6EoA8Noey9o+w34clF6B\n0Okc+tW+gExegmnDa533+Tp/9q1Q1ujdgbxAxVUgbsX7eQbjxeazJh+275/N52p/\n7Y8/WZ98CcyGHDHroT0LVpEJ2EB+k5HzzjzQaQjfBiNAtsu1dlPd9KohAoGAcA7w\noc+CJZ/pOAV8pYtpYwYOZWcG1LITPoynSWEXTuzPHsLp53+0f/mFwg5KTJkgLwMN\n5XKi9X/HLfysbzi2nzQFpQrRS8dKeWB/AEx7GNEXpO47f2+5gqo8rZnliNcnvh7M\nans1RpB5CBWflb5VDNSxvSMsBAEPwk5zwoNqRbUCgYBZRxobc8gDgXxhv2boSQE0\nrKO4iLrFNvamTfvtrZT3PNerXuwBGBYYDOu0lvF834Evywgk3nfzGiwa9aBQovWH\nxx9d6KawD0GPKLrdBQj792YUpPqRXLY1tys1eO3KVzQVgVxB5WS3jsGeaYEz5Oyv\nfuE43EAhAtYKEl+AU/XG/g==\n-----END PRIVATE KEY-----\n");

            Guid guid = default(Guid);
            var valueToSave = new ConfigurationData
            {
                DictionaryProperty = new Dictionary<string, string>
                {
                    { "Key1", "Hello" },
                    { "Key2", "Value2" }
                },
                GuidProperty = guid,
                IntProperty = 1,
                StringProperty = "My dev config 1"
            };

            await sheetsDatabase.SetAsync("Sheet1", "DEV Config 1", valueToSave);
        }


        public class ConfigurationData
        {
            public int IntProperty { get; set; }
            public string StringProperty { get; set; }
            public Dictionary<string, string> DictionaryProperty { get; set; }
            public Guid GuidProperty { get; set; }
        }
    }
}
