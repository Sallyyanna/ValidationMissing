using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationTask
{
    public partial class RegisterPhone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPhoneRegister_Click(object sender, EventArgs e)
        {
            //check length
            if (txtPhone.Text.Length != 11)
            {
                throw new Exception("Error registering for phone notifications - invalid length");
            }

            //check all digits
            var allNumbers = true;
            foreach (var digit in txtPhone.Text)
            {
                int number;
                if (!int.TryParse(digit.ToString(), out number))
                {
                    allNumbers = false;
                }
            }

            if (!allNumbers)
            {
                throw new Exception("Error registering for phone notifications - non numeric character in number");
            }

            //otherwise OK
            divRegister.Visible = false;
            divSuccess.Visible = true;

        }
    }
}