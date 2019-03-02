using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace homeworkGetTriangularArea
{
    public partial class homeworkGetTriangularArea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGet_Click1(object sender, EventArgs e)
        {
            double douA = Double.Parse(txtA.Text);
            double douB = Double.Parse(txtB.Text);
            double douC = Double.Parse(txtC.Text);

            double douMax = douA;
            douMax = douMax > douB ? douMax : douB;
            douMax = douMax > douC ? douMax : douC;

            // IsTriangle?
            // <=> douMin + douMed > douMax
            // <=> douMin + douMed + douMax > 2 * douMax
            if ((douA + douB + douC) > (2 * douMax))
            {
                // AideType?
                string strSideType;
                if (douA == douB && douB == douC)
                {
                    strSideType = "等边";
                }
                else if (douA == douB || douA == douC || douB == douC)
                {
                    strSideType = "等腰";
                }
                else
                {
                    strSideType = "一般";
                }

                // AngleType?
                string strAngleType;
                if ((douA * douA + douB * douB + douC * douC) > (2 * douMax * douMax))
                {
                    strAngleType = "锐角";
                }
                else if ((douA * douA + douB * douB + douC * douC) == (2 * douMax * douMax))
                {
                    strAngleType = "直角";
                }
                else
                {
                    strAngleType = "钝角";
                }

                // Area?
                double douP = 0.5 * (douA + douB + douC);
                double douArea = Math.Sqrt(douP * (douP - douA) * (douP - douB) * (douP - douC));

                // Response.Write
                // Response.Write("你输入的三条边组成了一个" + strSideType + strAngleType + "三角形，它的面积是" + douArea);
                txtOut.Text = "你输入的三条边组成了一个" + strSideType + strAngleType + "三角形，它的面积是" + douArea;
            }
            else
            {
                // Response.Write("你输入的三条边不能构成1个三角形");
                txtOut.Text = "你输入的三条边不能构成1个三角形";
            }
        }
    }
}