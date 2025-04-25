using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Xunit.Abstractions;
using Newtonsoft.Json;

namespace AgileTest.Tests.Core
{
    public class IntegrationTestsCore
    {
        protected readonly TestServer Server;
        protected readonly HttpClient Client;
        protected readonly ITestOutputHelper Output;
        protected readonly ServiceProvider ServiceProvider;

        public IntegrationTestsCore()
        {
            var webHost = new WebHostBuilder()
                .UseStartup<Startup>();

            Server = new TestServer(webHost);

            Client = Server.CreateClient();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddMvc();

            var builder = new ConfigurationBuilder()
                         .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                         .AddEnvironmentVariables();

            var configuration = builder.Build();
  
            ServiceProvider = serviceCollection.BuildServiceProvider();

        }

        public IntegrationTestsCore(ITestOutputHelper output) : this()
        {
            Output = output;
        }

        public async Task<T> Get<T>(string url)
        {
            var response = await Client.GetAsync(url);

            Output.WriteLine(response.Content.ReadAsStringAsync().Result);

            response.EnsureSuccessStatusCode();

            return await DeserializeJSON<T>(response);
        }

        public async Task<T> Post<T>(string url, object request)
        {
            var json = JsonConvert.SerializeObject(request);

            var response = await Client.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));

            Output.WriteLine(await response.Content.ReadAsStringAsync());

            response.EnsureSuccessStatusCode();

            return await DeserializeJSON<T>(response);
        }

        public async Task<HttpResponseMessage> Post(string url, object request)
        {
            var json = JsonConvert.SerializeObject(request);

            var response = await Client.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));

            Output.WriteLine(await response.Content.ReadAsStringAsync());

            return response;
        }

        public async Task<T> Put<T>(string url, object request)
        {
            var json = JsonConvert.SerializeObject(request);

            var response = await Client.PutAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));

            Output.WriteLine(response.Content.ReadAsStringAsync().Result);

            response.EnsureSuccessStatusCode();

            return await DeserializeJSON<T>(response);
        }

        public async Task<T> Delete<T>(string url)
        {
            var response = await Client.DeleteAsync(url);

            Output.WriteLine(response.Content.ReadAsStringAsync().Result);

            response.EnsureSuccessStatusCode();

            return await DeserializeJSON<T>(response);
        }

        public async Task<HttpResponseMessage> Get(string url)
        {
            var response = await Client.GetAsync(url);

            return response;
        }

        public async Task<HttpResponseMessage> Delete(string url)
        {
            var response = await Client.DeleteAsync(url);

            return response;
        }

        public async Task<T> DeserializeJSON<T>(HttpResponseMessage response)
        {
            var json = await response.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<T>(json);

            return model;
        }

        public string CreateQueryString(object obj)
        {
            StringBuilder getAtributes = new StringBuilder();
            getAtributes.Append("?");

            foreach (PropertyInfo pi in obj.GetType().GetProperties())
            {
                if (pi.PropertyType.IsArray && !Object.ReferenceEquals(pi.GetValue(obj, null), null))
                {
                    foreach (object item in pi.GetValue(obj, null) as Array)
                    {
                        getAtributes.Append(pi.Name + "=" + item.ToString() + "&");
                    }
                }
                else if (pi.PropertyType.IsInstanceOfType(DateTime.Now))
                {

                    DateTime? aux = pi.GetValue(obj, null) as DateTime?;
                    if (aux != null && aux.HasValue)
                    {
                        getAtributes.Append(pi.Name + "=" + aux.Value.ToString("yyyy-MM-ddTHH:mm:ss") + "&");
                    }
                }
                else
                {
                    getAtributes.Append(pi.Name + "=" + pi.GetValue(obj, null) + "&");
                }
            }
            getAtributes.Length--;

            return getAtributes.ToString();
        }

    }
}
