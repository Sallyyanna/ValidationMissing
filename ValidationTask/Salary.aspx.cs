using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationTask
{
    public partial class Salary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            Decimal monthly = Decimal.Parse(txtSalary.Text) / 12.0m;
            if (monthly >= 0 && monthly <= 200000000)
            {
                litSalary.Text = "<p>Your monthly salary is £" + monthly.ToString("0.00") + "</p>";
            }
            else
            {
                throw new Exception("Invalid salary amount");
            }
        }
    }
}