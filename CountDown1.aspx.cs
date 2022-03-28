using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountDown
{
    public partial class CountDown1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateTimer_Tick(sender,e);
             ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "script", "startTimer(duration, display);", true);
        }
        protected void UpdateTimer_Tick(object sender, EventArgs e)
        {
            DateStampLabel.Text = DateTime.Now.ToString();
        }
    }
}