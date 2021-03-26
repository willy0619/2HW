using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2HW {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int n = 20;
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    s += i;
                }
            }
            Response.Write(s);
        }
    }
}
