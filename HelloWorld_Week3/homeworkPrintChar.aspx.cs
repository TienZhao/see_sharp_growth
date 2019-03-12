using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class homeworkPrintChar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            int rowQty = int.Parse(txtNum.Text);   //行数
            if (rowQty <= 26)
            {
                for (int currentRow = 1; currentRow <= rowQty; currentRow++)
                {
                    //处理空格
                    int spaceQty = rowQty - currentRow;                                     //计算该行空格数量
                    string spaces = string.Concat(Enumerable.Repeat("&ensp;", spaceQty));   //将空格合为一个字符串，"&ensp;"对应半角空格，"&nbsp;"对应全角空格
                    //另一种方法
                    //string spaces = "";
                    //for (int i = 0; i < spaceQty; i++)
                    //{
                    //    spaces += "&ensp;";
                    //}

                    //处理字母
                    int letterQty = currentRow * 2 - 1;             //计算该行字母数量
                    char letter = Convert.ToChar(64 + currentRow);  //生成该行字母
                    string letters = new string(letter, letterQty); //将字母合为一个字符串
                    //另一种方法
                    //string letters = "";
                    //for (int i = 0; i < letterQty; i++)
                    //{
                    //    letters += letter;
                    //}

                    //输出
                    //Response.Write(spaces + letters + "</br>");                   //普通输出
                    Response.Write("<code>" + spaces + letters + "</code></br>");   //等宽输出
                }
            }
            else
            {
                Response.Write("行号错误");
            }
        }
    }
}