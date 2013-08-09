using System;
using Funq;
using System.Web;
using ServiceStack.WebHost.Endpoints;
using ServiceStackHelloSample.Interface;

namespace ServiceStackHelloSample.Web
{
    public class Global : HttpApplication
    {
        public class AppHost : AppHostBase
        {
            public AppHost() : base("ServiceStack Hello Web Service", typeof(HelloService).Assembly) { }
            public override void Configure(Container container)
            {
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            (new AppHost()).Init();
        }
    }
}