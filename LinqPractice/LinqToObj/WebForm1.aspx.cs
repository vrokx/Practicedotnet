using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqToObj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //List<string> list = new List<string>();
            //list.Add("Vaibhav");
            //list.Add("Akshata");
            //list.Add("Ariba");
            //list.Add("Mohit");

            //GridView1.DataSource = from l in list
            //                       where l.Contains("Vaibhav") || l.Contains("Akshata")
            //                       select l;
            //GridView1.DataBind();

            //ArrayList arlist1 = new ArrayList();
            //arlist1.Add(1);
            //arlist1.Add("Bill");
            //arlist1.Add(" ");
            //arlist1.Add(true);
            //arlist1.Add(4.5);
            //arlist1.Add(null);

            //GridView1.DataSource = from l in arlist1 select l;
            //GridView1.DataBind();

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };

            var query = from x in arr
                        select x;

            GridView1.DataSource= query;
            GridView1.DataBind();
        }
    }
}