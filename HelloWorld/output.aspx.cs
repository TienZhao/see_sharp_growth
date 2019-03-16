using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld00
{
    public partial class output : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script>alert('欢迎学习数据 思维下的算法与程序设计')</script>");

            //int a = 'A';
            //Response.Write(a);

            //int b;
            //Response.Write(b);
            //int声明没有初始值

            int a = 10;
            //int b = 3;
            //double c = 3.0;

            Response.Write(a+a+a+a);
            //输出3

            
            Response.Write(a*4);
            //输出3

            Response.Write(a<<2);
            //输出3.33
        }
    }
}