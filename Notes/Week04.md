# Week 04

参与 华东师范大学 数据思维下的算法与程序设计 课程

Author: Tien Zhao

Last Update: 2019-03-14

 

### 课堂笔记与课后总结

- 数组

  - 声明

    - 一维数组：`int[] numbers；`
    - 多维数组：`string[,] names;`
    - 数组的数组：`byte[][] scores;`
    - 单纯声明数组是并不会创建数组；数组内的变量必须为同一类型。

  - 创建

    - 创建不定长数组：`int[] numbers = new int[]{1,2,3};` 放在栈中，效率较低
    - 创建定长数组：`int[] numbers = new int[3]{1,2,3}; 放在队中，效率较高`

  - 索引

    - c#的数组索引是从0开始的整数，没有负数
    - 查询方法：`string.IndexOf("subString");`，返回索引值或-1

  - 数组长度

    - 数组长度属性为`.Length`

  - 数组遍历

    ```
    int[] numbers = {1,2,3,4,5};
    foreach (int i in numbers)
    {
        Response.Write(i);
    }
    ```

  - 字符串数组的分割

    ```
    string email = "xxx@gmail.com";
    string[] email_arr = email.Split('@');
    ```

  - 字符串的比较

    - `a.Equals(b)`或者`a == b`在C#中都可以

  - 字符串的截取

    - `a.Substring(substring, start, length);`

  - 字符串的格式操作

    - `.ToUpper()`，`.ToLower()` 转换大小写

- dropdownlist控件

  - 定义和用法：用于创建下拉列表，一般以ddl前缀命名
  - 常用属性：
    - `AutoPostBack` 自动回传，当它为`true`时当用户一选择就会发送给服务器，适用于联动表格
    - `DataValueField`数据库主键字段
    - `DataTextField`数据库内容字段，将在下拉列表中直接显示
  - 常用事件：
    - `SelectedIndexChanged`

- Calender控件

  - 定义和用法：用于创建日期选择框
  - 常用属性

### 作业：

* 身份证验真页面
  * 长度验证
  * 字符类型验证
  * 验证码验证

* 开根页面
  * Math.Sqrt开根
  * 指定迭代次数，逼近开根