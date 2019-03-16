using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeworkID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            //读取输入，声明全局变量
            string input = txtInput.Text.Trim().ToUpper();  //去除空格，统一为大写
            bool validity = true;                           //validity变量负责在验证失败后，使程序不执行之后的步骤

            //进行格式验证
            if (input.Length != 18)
            {
                validity = false;
            }
            else
            {
                //以下内容需放在else分支中，防止数组越界
                //一旦输入的前17位出现非数字，即不合法
                for (int i = 0; i <= 16; i++)
                {
                    char digit = input[i];
                    if (!char.IsDigit(digit))
                    {
                        validity = false;
                    }
                }
                //一旦输入的第18位出现非数字且不为'X'，即不合法
                if (!char.IsDigit(input[17]) && input[17] != 'X')
                {
                    validity = false;
                }
            }
            //格式验证出错时，输出格式非法，并通过validity变量跳出程序
            if (!validity)
            {
                Response.Write(" 格式非法");
            }
            
            //进行校验码验证
            if (validity)
            {
                int[] coefficientArr = new int[17] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 }; //乘法因数
                char[] checkCodeArr = new char[11] { '1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2' }; //校验码选择
                int c = 0;
                char checkCode = ' ';

                //运算校验码
                for (int i = 0; i <= 16; i++)
                {
                    int digit = Convert.ToInt16(input[i]) % 48; //数字0-9的ASCII码为48-57
                    int coefficient = coefficientArr[i];
                    c += (digit * coefficient);
                }
                c %= 11;                        //除以11取余数
                checkCode = checkCodeArr[c];    //选取校验码

                //比对校验码，不匹配时输出校验码非法，并通过validity变量跳出程序
                if (input[17] != checkCode)
                {
                    Response.Write(" 校验码非法");
                    validity = false;
                }
            }

            //当以上验证全部通过后，解析身份信息并输出
            if (validity)
            {
                Response.Write("格式合法，校验码合法； </br>");
                string birthYear, birthMonth, birthDay, gender;
                birthYear = input.Substring(6, 4);
                birthMonth = input.Substring(10, 2);
                birthDay = input.Substring(12, 2);
                if(Convert.ToInt16(input[16]) % 2 == 0)  //数字0-9的ASCII码为48-57，则char转int之后不改变奇偶性，偶数为女，奇数为男；
                {
                    gender = "女";
                }
                else
                {
                    gender = "男";
                }
                Response.Write("你的出生日期为" + birthYear + "年" + birthMonth + "月" + birthDay + "日，性别为" + gender + "。");
            }
        }
    }
}