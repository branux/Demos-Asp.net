using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeSeparationPageClass
{
    public partial class Codigo_Separado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OutPut.Text = DateTime.Now.ToShortTimeString();
        }
    }
}