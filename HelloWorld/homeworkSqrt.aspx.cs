using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeworkSqrt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStart_Click(object sender, EventArgs e)
        {

            //读取输入值
            double input = 0;
            Double.TryParse(txtInput.Text, out input);
            int step = 0;
            int.TryParse(txtStep.Text, out step);

            //当输入合法时，进行开根号操作
            if(input > 1 && step != 0)
            {
                // Math.Sqrt开根号
                double outputMath = Math.Sqrt(input);

                // 二分法开根
                double outputBiselect = 1;
                double lower = 1;
                double upper = input;
                for (int i = 0; i < step; i++)
                {
                    outputBiselect = (lower + upper) / 2;
                    if (outputBiselect * outputBiselect == input)
                    {
                        break;
                    }
                    else if (outputBiselect * outputBiselect < input)
                    {
                        lower = outputBiselect;
                    }
                    else
                    {
                        upper = outputBiselect;
                    }
                }

                // 牛顿法开根
                double outputNewton = input;
                for (int i = 0; i < step; i++)
                {
                    outputNewton = (outputNewton + input/outputNewton) / 2;
                }
                Response.Write(" 二分法开方结果：" + outputBiselect + "</br>");
                Response.Write(" 牛顿法开方结果：" + outputNewton + "</br>");
                Response.Write(" Math.Sqrt开方结果：" + outputMath);
            }
            else
            {
                Response.Write(" 输入错误");
            }
        }
    }
}