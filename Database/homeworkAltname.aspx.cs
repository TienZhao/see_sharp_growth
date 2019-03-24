using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQL;
using System.Data.SqlClient;
// 需要使用学号密码，登陆华东师范大学VPN使用，详见：https://docs.ecnu.edu.cn/vpn/

namespace Database
{
    public partial class homeworkAltname : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string inputName = txtInput.Text;
            string result = "";
            if (inputName.Length < 1)
            {
                Response.Write("请输入一个人名！");
            }

            SQLHelper sh = new SQLHelper();
            SqlDataReader sdr;
            string sql = string.Format("Select BIOG_MAIN.c_personid,c_alt_name_chn from ALTNAME_DATA left join BIOG_MAIN on ALTNAME_DATA.c_personid=BIOG_MAIN.c_personid where BIOG_MAIN.c_name_chn='{0}'", inputName);

            try
            {
                Response.Write(string.Format("数据库连接成功</br>"));
                sh.RunSQL(sql, out sdr);
                if (sdr.Read()) //查找曾用名是否有结果
                {
                    result = string.Format("姓名：{0}，TA的曾用名：{1}", inputName, sdr["c_alt_name_chn"]); //将第一个结果放入待输出字符串
                    while (sdr.Read()) //如果还有更多结果
                    {
                        result += "、";
                        result += sdr["c_alt_name_chn"].ToString(); //逐一放入待输出字符串
                    }
                }
                else
                {
                    result = "没有找到该记录</br>";
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                Response.Write(result);
                sh.Close();
            }
        }
    }
}