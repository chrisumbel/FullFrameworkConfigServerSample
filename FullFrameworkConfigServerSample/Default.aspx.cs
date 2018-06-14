using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FullFrameworkConfigServerSample
{
    public partial class _Default : Page
    {
        public string IpAddress { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ApplicationConfig.Configuration.Reload();
            this.IpAddress = ApplicationConfig.Configuration["customer:0:ipAddress"];
        }
        
    }
}