# Week 01 

参与 华东师范大学 数据思维下的算法与程序设计 课程

Author: Tien Zhao

Last Update: 2019-02-28

 

### 课堂笔记与课后总结

* 安装Visual Studio Community
  * https://visualstudio.microsoft.com/zh-hans/downloads/

* 新建
  * 文件 -> 新建 ->项目Project
  * 左侧菜单栏 已安装->Visual C# -> Web -> ASP.NET应用程序类型
  * 输入项目名称和位置（路径）
  * 确定新建或者添加到现有的解决方案（比项目高一级）
  * 选择默认的ASP.NET框架
  * 选择“空”（没有Web窗体）或者“Web窗体”（一堆默认的Web窗体）

* 配置Web.config

  * 如果新建的是“空”项目，则需要首先配置Web.config，否则本地调试会出错
  * 打开Web.config，在`<configure>`标签中加入

  ```
  <system.webServer>
  	<directoryBrowse enabled="true" />
  </system.webServer>
  ```


* 新建Web窗体（Webform）
  * 在解决方案资源管理器中，右键单击项目 -> 添加 -> 新建项
  * 选择“Web窗体”并在最下方输入名称

* Web窗体文件介绍：
  * .aspx文件 - 美工
  * .aspx.cs文件 - 编程、事件
  * .aspx.designer.cs文件 - 连接上两个文件

* 调试文件
  * 在解决方案资源管理器中，右键单击Web窗体 -> 在浏览器中查看

* Web窗体的视图
  * 左下角切换Design设计视图、拆分试图、Source源（代码）视图

* 常用快捷键：
  * Ctrl + F5 支持热重载的运行，可以在浏览器刷新
  * Ctrl + Shift + S 保存全部打开的文件

### 作业：

- 模仿教材内容，创建HelloWorld，并在项目中添加output.aspx网页；
- 利用Response对象可以输出JS的特性，以弹出信息框的形式输出“欢迎学习数据思维下的算法与程序设计”；
- 并将该网页连同项目一并提交到github平台的repo中。