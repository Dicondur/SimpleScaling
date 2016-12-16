using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceConsumerWebApp.CalculateSoap;

namespace ServiceConsumerWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateWSSoapClient client = new CalculateWSSoapClient();
            InputQuery serviceInp = new InputQuery();
            serviceInp.ScaledMin = Convert.ToDouble(txtScaledMin.Text);
            serviceInp.ScaledMax = Convert.ToDouble(txtScaledMax.Text);
            serviceInp.RawMin = Convert.ToDouble(txtRawMin.Text);
            serviceInp.RawMax = Convert.ToDouble(txtRawMax.Text);

            if (txtScaledInp.Text == "" && txtRawInp.Text != "")
            {
                serviceInp.RawInput = Convert.ToDouble(txtRawInp.Text);
            }
            else if (txtScaledInp.Text != "" && txtRawInp.Text == "")
            {
                serviceInp.ScaledInput = Convert.ToDouble(txtScaledInp.Text);
            }
            
            
            
            

            lblOutput.Text = Convert.ToString(client.CalculateService(serviceInp));

            
        }
    }
}