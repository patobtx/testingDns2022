using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testingDns2022
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        //    Application["msg2"] = "success";

            /*
            //test 1 results
            var result = Convert.ToString(Application["msg2"]);
           lblResult.Text = result;
            */


            //test 2 results
            var result2 = Convert.ToString(Application["msg3"]);
            lblResult2.Text = result2;


            /*
            //IP test results
            var result3 = Convert.ToString(Application["msg4"]);
            lblIpResult.Text = result3;
            */

        }
    }
}