# Week 02 

参与 华东师范大学 数据思维下的算法与程序设计 课程

Author: Tien Zhao

Last Update: 2019-02-28

 

### 课堂笔记与课后总结

- 数据类型

  - 整形数据
    - sbyte - 1Byte - 有符号
    - short - 2Byte - 有符号
    - int - 4Byte - 有符号
    - long - 8Byte - 有符号
    - byte - 1Byte - 无符号
    - ushort - 2Byte - 无符号
    - uint - 4Byte - 无符号
    - ulong - 8Byte - 无符号
  - 浮点数据
    - float - 1Byte
    - double - 2Byte
    - decimal - 16Byte
  - 布尔类型
    - bool - 1bit - true或false
  - 字符类型
    - char - 2Byte - Unicode字符
  - 引用类型
    - object - 万能类型
    - string  - 字符串

- 变量与常量

  - 命名
    - 变量名开头：字母、_、@
    - 变量名组成：字母、_、数字
    - 不能与保留字重复（变蓝色的字）
    - 大小写敏感
    - 同一变量不能重复定义，但能重复赋值
  - 声明和赋值
    1. 声明时复制 `cahr a = 'a'; //必须用单引号括起来`
    2. 先声明，后复制 `int b; b = 1;`
    3. 声明多个同类型变量，随后赋值 `double c,d,e; `
  - 常量的声明和赋值
    - 命名和变量相似，声明时前加const `const int MAX_VALUE = 10`

- 类型转换

  - 其他类型转字符串：`a.ToString() //不会失真` 
  - 字符串转其他类型：`double.Parse(string) //数据类型.Parse(字符串)`
  - 某些类型转换：`Convert.ToDecimal(double) //Convert.To数据类型的方法(原始数据类型)`

- 运算符

  - 详细介绍：http://www.runoob.com/csharp/csharp-operators.html
  - 二元运算符，运算结果为输入元中占用字节较大的类型

  ```asp
  int a = 10;
  int b = 3;
  double c = 3.0;
  
  Response.Write(a/b);
  //输出3
  
  double d = a/b;
  Response.Write(d);
  //输出3
  
  Response.Write(a/c);
  //输出3.33333333333333
  ```

  - 自加减运算符与赋值运算符的优先级

    - c = a++    先将 a 赋值给 c，再对 a 进行自增运算
    - c = ++a    先将 a 进行自增运算，再将 a 赋值给 c

  - 运算符的效率

    - 移位效率最高，占用的机器周期比乘法少一半，*2时可以优先考虑
    - 对于有乘法器的硬件，乘法比加法更快
    - 机制的编译器可以进行翻译，选择最快的处理方法

    ```asp
    int a = 10;
    
    Response.Write(a+a+a+a);
    //输出40，最差
    
    Response.Write(a*4);
    //输出40，次优
    
    Response.Write(a<<2);
    //输出40，最优在解决方案资源管理器中，右键单击项目 -> 添加 -> 新建项
    ```

* 分支结构

  * 嵌套if多分支结构：http://www.runoob.com/csharp/csharp-nested-if.html

  ```
  string gender = "男";
  if (gender== "男")
  {
      Response.Write("先生");
  }
  else if (gender == "女")
  {
      Response.Write("女士");
  }
  else
  {
      Response.Write("性别有误");
  }
  ```

  * switch-case多分支结构： http://www.runoob.com/csharp/csharp-switch.html

  ```
  char grade = 'B';
  
  switch (grade)
  {
  	case 'A':
      	Console.WriteLine("很棒！");
      break;
      case 'B':
      case 'C':
      	Console.WriteLine("做得好");
      break;
      case 'D':
      	Console.WriteLine("您通过了");
      break;
      case 'F':
      	Console.WriteLine("最好再试一下");
      break;
      default:
      	Console.WriteLine("无效的成绩");
      break;
  }
  
  //输出：做的好
  //case B中没有语句，但会尝试继续执行之后的语句，直到break为止
  ```

  * 运算符`? :`

    * 对于表达式`Exp1 ? Exp2 : Exp3`
    * 当控制表达式`Exp1`为真时，`Exp2`的值即为整个表达式的值
    * 当控制表达式`Exp2`为假时，`Exp3`的值即为整个表达式的值

    求最大值算法：

    ```
    double num1 = double.Parse(txtInput1.Text);
    double num2 = double.Parse(txtInput2.Text);
    double num3 = double.Parse(txtInput3.Text);
    
    double max = num1;
    max = max > num2 ? max : num2;
    max = max > num3 ? max : num3;
    
    Response.Write("x,y,c的最大值是" + max);
    ```


### 作业：

- 新建一个网页homeworkGetTriangularArea.aspx，在网页上放置三个文本框和一个按钮，按钮文字标注为“求三角形面积”，文本框用来输入三角形的三条边，单击按钮输出结果：

  输出结果格式如下：

  `你输入的三条边不能构成1个三角形`

  或

  `你输入的三条边组成了一个（等边、等腰、一般）（直角、钝角、锐角 ） 三角形，它的面积是s`

  注： 

  * （）里的内容输出只能选其一
  * C#中求平方根，使用Math.Sqrt,比如求9的平方根就是 Math.Sqrt(9)
  * 除了提示内容，作用中绝对不能出现上课没有讲过的内容！！！！！