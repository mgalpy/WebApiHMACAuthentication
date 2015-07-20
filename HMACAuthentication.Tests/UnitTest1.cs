using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HMACAuthentication.Client;
using System.Diagnostics;

namespace HMACAuthentication.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllOrders_ShouldReturnAllOrders()
        {
            double totalSeconds = 0;

            for (int i = 0; i <= 1000; i++)
            {

                DateTime epochStartAPIRequest = new DateTime(1970, 01, 01, 0, 0, 0, 0, DateTimeKind.Utc);
                TimeSpan timeSpanAPIRequest = DateTime.UtcNow - epochStartAPIRequest;
                double start = timeSpanAPIRequest.TotalSeconds;

               // Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
               // Trace.WriteLine("Calling the back-end API : " + start);

                Program.RunAsync().Wait();

                DateTime epochStartAPIResponse = new DateTime(1970, 01, 01, 0, 0, 0, 0, DateTimeKind.Utc);
                TimeSpan timeSpanAPIResonse = DateTime.UtcNow - epochStartAPIResponse;
                double end = timeSpanAPIResonse.TotalSeconds;
                totalSeconds = totalSeconds + (end - start);

               // Trace.WriteLine("Recieved response from back-end API : " + end);
            }

            Trace.WriteLine("totalSeconds: " + totalSeconds);
            
        }
    }
}
