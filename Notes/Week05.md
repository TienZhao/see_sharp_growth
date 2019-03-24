# Week 05

参与 华东师范大学 数据思维下的算法与程序设计 课程

Author: Tien Zhao

Last Update: 2019-03-21

 

### 课堂笔记与课后总结

* 运用`try{}catch{}`进行异常处理

  * 案例代码：

  ```
  try
  {
  	可能会引发异常的代码段
  }
  catch(Exception ex)    //可省略，可重复分别catch不同类型的错误
  {
  	发生异常之后的处理程序
  }
  finally                //可省略
  {
  	不管是否发生异常都会执行的语句
  }
  ```


* 设为启动项目

  * 在解决方案资源管理器中，右键单击项目，在菜单中选择“设为启动项目”，即可选择调试的项目

* 与SQL Server的连接
  * 将SQLHelper.cs复制到项目目录中

  * 在解决方案资源管理器中，右键单击项目，在菜单中选择“添加”，次级菜单选择“现有项”，窗口中选中SQLHelper.cs文件，即可完成SQLHelper.cs的添加，对项目进行“生成”，确认没有报错

  * 打开Web.config，在`<configure>`标签中加入：

    ```
      <connectionStrings>
        <add name="ApplicationServices" connectionString="Data Source=202.120.84.196;Initial Catalog=20170829CBDBavBase;User ID=stu;Password=123456;"/>
      </connectionStrings>
    ```
    * `name="ApplicationServices"`与SQLHelper.cs的`ConfigurationManager.ConnectionStrings[]`列表中一致
    * `connectionString`中包含IP地址、目录名、用户名、密码

* 连接SQL的案例代码

  ```
  protected void Page_Load(object sender, EventArgs e)
  {
      SQLHelper sh = new SQLHelper();
      string sql = "select count(*) from BIOG_MAIN";
      try
      {
          sh.RunSQL(sql);
          Response.Write("数据库连接成功");
      }
      catch(Exception ex)
      {
          Response.Write("数据库连接失败，原因为：" + ex.Message);
      }
      finally
      {
          sh.Close();
      }
  }
  ```


### 作业：

- 打开HelloWorld解决方案，在项目ProjectAlgorithm中，新建homeworkAltname.aspx网页，在网页上放置一个文本框和一个按钮，按钮文字标注为“查找曾用名”，文本框用来输入人物名称。当用户输入之后，单击按钮，在CBDB数据库中检索出所有这个人物的曾用名。

  测试用例：输入“杜甫”

  输出格式：TA的曾用名：子美 杜二 杜工部                        

  参考最新的第4章教程PDF