using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NumberSorter
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)        // button function for sorting comma-separated numbers
        {
            StringSorterService.Service1Client Stringsorter = new StringSorterService.Service1Client(); // initializing ServiceClient object with Service Reference "StringSorterService"
            string s = TextBox1.Text;               // string s will take the value of text in the textbox "TextBox1"
            s = Stringsorter.sort(s);               // The numbers in "s" will be sorted using function sort()
            Label1.Text = s;                        // displaying the sorted comma-separated numbers through label "Label1"
        }
    }
}