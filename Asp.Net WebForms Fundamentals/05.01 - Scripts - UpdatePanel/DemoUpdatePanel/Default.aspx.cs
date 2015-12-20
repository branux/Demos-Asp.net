using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoUpdatePanel
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //not postback -> só no Load da página
                getTime();
            }

        }

        protected void getTimeBtn_Click(object sender, EventArgs e)
        {
            getTime();
        }

        private void getTime()
        {
            timeLabel.Text = DateTime.Now.ToShortTimeString();
        }
    }
}