using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegisterHttpModule.TestModule {
    public class PreApplicationStartCode {
        public static void Start() {
            // Register our module
            Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(typeof(MyModule));
        }
    }
    
    public class MyModule: IHttpModule {
        public void Init(HttpApplication application) {
            application.BeginRequest += new EventHandler(OnBeginRequest);
        }

        void OnBeginRequest(object sender, EventArgs e) {
            ((HttpApplication)sender).Response.Write("MyModule.OnBeginRequest<br>");
        }

        public void Dispose() {
        }
    }
}
