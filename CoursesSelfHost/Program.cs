using CoursesServiceLibrary;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace CoursesSelfHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var baseUrlTcp = "net.tcp://localhost:6789/";
            var tcpBaseAddress = new Uri(baseUrlTcp);

            //var baseUrlHttp = "http://localhost:6790/";
            //var httpBaseAddress = new Uri(baseUrlHttp);

            var serviceHost = new ServiceHost(typeof(Courses), new Uri[] { tcpBaseAddress });

            var tcpBinding = new NetTcpBinding { ReceiveTimeout = new TimeSpan(0, 1, 0) };
            var serviceEndpoint = serviceHost.AddServiceEndpoint(typeof(ICourses), tcpBinding, baseUrlTcp);

            //basic http doesn't have support for sessions!
            //var httpServiceEndpoint = serviceHost.AddServiceEndpoint(typeof(ICourses), new BasicHttpBinding(), baseUrlHttp);

            var behavior = new ServiceMetadataBehavior();
            serviceHost.Description.Behaviors.Add(behavior);

            var baseMexUrl = "net.tcp://localhost:6789/mex";
            var tcpMex = serviceHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), baseMexUrl);

            serviceHost.Open();

            Console.WriteLine("Service started...");

            foreach (var endpoint in serviceHost.Description.Endpoints)
            {
                Console.WriteLine($"Address: {endpoint.Address}");
                Console.WriteLine($"Binding: {endpoint.Binding}");
                Console.WriteLine($"Contract: {endpoint.Contract.Name}\n");
            }

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();

            serviceHost.Close();
        }
    }
}
