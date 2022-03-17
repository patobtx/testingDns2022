using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Threading.Tasks;
using System.Net.Http;

namespace testingDns2022
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            try
            {
                var client2 = new HttpClient();
                var endpoints2 = new[] { "https://google.com/", "https://youtube.com/" };
                var tasks2 = endpoints2.Select(endpoint => Task.Run(async () => await client2.GetAsync(endpoint)));
                Task.WhenAll(tasks2).GetAwaiter().GetResult();
                Application["msg3"] = "success 2";
            }
            catch (Exception z)
            {
                Application["msg3"] = "failed 2 " + z;
            }

            /*
          
            //1st try
            try
            {
                var client = new HttpClient();
                var endpoints = new[] { "https://google.com/", "https://youtube.com/" };
                var tasks = endpoints.Select(endpoint => Task.Run(async () => await client.GetAsync(endpoint)));
                Task.WhenAll(tasks).GetAwaiter().GetResult();
                Application["msg2"] = "success 1";
            }
            catch (Exception x)
            {
                Application["msg2"] = "failed 1 " + x;
            }

            //try IP address
            try
            {
                var client3 = new HttpClient();
                var endpoints3 = new[] { "http://142.250.191.238/", "https://1.1.1.1/" };
                var tasks3 = endpoints3.Select(endpoint => Task.Run(async () => await client3.GetAsync(endpoint)));
                Task.WhenAll(tasks3).GetAwaiter().GetResult();
                Application["msg4"] = "Ip test success 1";
            }
            catch (Exception y)
            {
                Application["msg4"] = "Ip test failed 1 " + y;
            }



            System.Threading.Thread.Sleep(5000);  //sleep 5s 


            */

            /*
            //2nd try
            try
            {
                var client2 = new HttpClient();
                var endpoints2 = new[] { "https://fakeaksgka353.com/", "https://youtube.com/" };
                var tasks2 = endpoints2.Select(endpoint => Task.Run(async () => await client2.GetAsync(endpoint)));
                Task.WhenAll(tasks2).GetAwaiter().GetResult();
                Application["msg3"] = "success 2";
            }
            catch (Exception z)
            {
                Application["msg3"] = "failed 2 " + z;
            }
            */




            /*
                        try
                        {
                            Console.Write("trying connect");
                            var client = new HttpClient();
                            var endpoints = new[] { "https://google.com/", "https://youtube.com/" };
                            var tasks = endpoints.Select(endpoint => Task.Run(async () => await client.GetAsync(endpoint)));
                            Task.WhenAll(tasks).GetAwaiter().GetResult();
                          //  var msg = Task.WhenAll(tasks).GetAwaiter().GetResult();
                            string msg1 = "success";
                           // Application["msg2"] = "success";
                        //    Console.Write(msg);
                            Console.Write("succeed");
                        }
                        catch (Exception x)
                        {
                            Console.Write("failed");
                        //    Application["msg2"] = "failed";
                        }
                        Console.Read();    

                        */

        }
    }
}