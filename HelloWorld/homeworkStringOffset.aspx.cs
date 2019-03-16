using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeworkStringOffset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            // 读取输入值
            string strInput = txtInput.Text;
            int intOffset = int.Parse(txtOffset.Text);
            string strOutput = "";
            
            // 判断偏移位数是否符合要求
            if(intOffset > 26 || intOffset < 0)
            {
                txtOutput.Text = "偏移位数输入错误";    //异常输出
            }
            else
            {
                foreach (char c in strInput)
                {
                    char cNormal, cOverflow, cOffset;
                    //如果是大写字母
                    if (c >= 'A' && c <= 'Z')
                    {
                        cNormal = Convert.ToChar(Convert.ToInt32(c) + intOffset);           //普通方法右移后的字母
                        cOverflow = Convert.ToChar(Convert.ToInt32(c) + intOffset - 26);    //右移后重新循环的字母
                        cOffset = cNormal <= 'Z' ? cNormal : cOverflow;                     //根据右移后的字母后是否越界('Z')，选择正确的新字母
                    }
                    //如果是小写字母
                    else if (c >= 'a' && c <= 'z')
                    {
                        cNormal = Convert.ToChar(Convert.ToInt32(c) + intOffset);           //普通方法右移后的字母
                        cOverflow = Convert.ToChar(Convert.ToInt32(c) + intOffset - 26);    //右移后重新循环的字母
                        cOffset = cNormal <= 'z' ? cNormal : cOverflow;                     //根据右移后的字母后是否越界('z')，选择正确的新字母
                    }
                    //如果不是字母
                    else
                    {
                        cOffset = c;        //不进行右移，新字符保持原样
                    }
                    strOutput += cOffset;   //将新字符附在输出字符串的末尾
                }
            }
            txtOutput.Text = strOutput;     //正常输出

        }
    }
}