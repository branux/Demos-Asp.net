using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoUpdateProgress
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                getTime();
        }

        protected void getTimebtn_Click(object sender, EventArgs e)
        {
            getTime();
        }

        private void getTime()
        {
            System.Threading.Thread.Sleep(2000);
            timeTextBox.Text = DateTime.Now.ToShortTimeString();
        }
    }
}