using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace SnelStart.B2B.Client.IntegrationTest
{
    internal class DependencyRoot
    {
        public static B2BClient Client { get; }

        static DependencyRoot()
        {
            var koppelSleutel = "WkxaYXp0d0lxME0yL0tvL3ZMU0dnc2g3VkM4cXlYNzB5eTQyVWVhWVBGejBUdW1Dcy9icVhWSHAwV0xKMmxEYXhMT0hscWR3Q3J2Ym5IY2NmRndCZHYyczc2aTV1Smprb1Q2SXNUR2JySmlnanpjcjBobXE5MnRNODA2WHRzV2tjM1ZkMWpiMDBOTGtmWmQrYTdKdnRDbU41YmdrRFRuQ3ZOVTYvSStPOEFNbWFMTU4vZUlDU1NEY3BzbjZFQUNrbzZ0azcydHNYZDFITEJ1MUpYS3UxTXRyQmdFTVh6TmtMQXJZdEk3OUdzZitJMzlaVmdJcVFhNVZ6NDA0d0VJQzphMlRTWUo4RUI3QTd4akR1VnlONmJSSEdQWlhCTXRyNXVWSWhMMTh6L3Q4VHNrS013bHErQmk3aXpDdEhNUEVYQnZVclZIcW5XS1BNVGNPZFFodmVpR0tiUmpnMWtmNnR2TmhQcEVyT3d1TXpSMHFVNWVpZldHKzZtdmJ1cXRYUjhqVXk3dmREbm8wTWpRdGRNOXdxNE8vS0JnSW1jYm1lbU5pT0xwYjR2b1B6WXlVcW5CclV2QzljVUluQTBVeHlNbFB4d1pyc2RJdDBwanlncmU0OGJOWHJrMjl0VDE1YVlOZDF6bEhHQWNlU3hud3grMVBNSDRacTBzc1MvN0N3";
            var subscriptionKey = "6b80901ae3144dacab0a6ea0e46aa5d1";


            if (string.IsNullOrEmpty(koppelSleutel))
            {
                Assert.Inconclusive("No koppelSleutel configured");
            }
            if (string.IsNullOrEmpty(subscriptionKey))
            {
                Assert.Inconclusive("No subscriptionKey configured");
            }

            Config = new Config(subscriptionKey, koppelSleutel);
            Config.Logger = x => Console.WriteLine(x);

            Client = new B2BClient(Config);
        }

        public static Config Config { get; }
    }
}