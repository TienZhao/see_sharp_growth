# Week 03

参与 华东师范大学 数据思维下的算法与程序设计 课程

Author: Tien Zhao

Last Update: 2019-03-07

 

### 课堂笔记与课后总结

- 循环结构

  - for循环`for(表达式0;表达式1;表达式2){代码块}`

    - 执行顺序：表达式0 -> 表达式1? -> 表达式2/跳出 -> 表达式1? -> 表达式2/跳出
    - 表达式0：通常用于循环计数器声明
    - 表达式1：循环条件
    - 表达式2：通常用于改变循环计数器

  - 练习1：用循环输出10的阶乘

    ```
    int s = 1;
    int a = 10;
    for (int i=1; i<=a; i++){
        s *= i;
    }
    Response.Write(s);
    ```

  - 练习2：用双重循环解决鸡兔同笼问题

    ```
    string strOutput = "";
    int intHead = 35;
    int intFoot = 94;
    
    int intChick, intRabbit;
    
    for (intChick = 0; intChick<=intHead; intChick++) 
    {
        for (intRabbit = 0; intRabbit<=intHead; intRabbit++)
        {
            if (intChick + intRabbit == intHead && intChick * 2 + intRabbit * 4 == intFoot)
            {
                strOutput = "有鸡" + intChick.ToString() + "只；有兔" + intRabbit.ToString() + "只";
            }
        }
    }
    
    if (strOutput == "")
    {
        Response.Write("无解");
    }
    else
    {
        Response.Write(strOutput);
    }
    
    ```

- 程序的结构控制  —— 以下关键字通常要放在`if`中，一定不能直接放在循环体中

  - `Response.End();`——终止浏览器运行 

  - `return;` ——终止最近的一个函数结构并返回一个值

  - `break;` ——终止最近的一个函数结构

  - `continue;` ——终止循环的一步并开始下一给循环

  - 练习：用`break;`改良鸡兔同笼问题

    ```
    int intHead = 35;
    int intFoot = 94;
    int intChick, intRabbit;
    
    for (intChick = 0; intChick<=intHead; intChick++) 
    {
        for (intRabbit = 0; intRabbit<=intHead; intRabbit++)
        {
            if (intChick + intRabbit == intHead && intChick * 2 + intRabbit * 4 == intFoot)
            {
                Resposnse.Write("有鸡" + intChick.ToString() + "只；有兔" + intRabbit.ToString() + "只";)
                break;
            }
            // break不能放这里
        }
    }
    ```

- foreach循环

  - 循环数组：

    ```
    char[] Alphabet = {'a', 'b', 'c'};
    foreach (c in Alphabet)
    {
        ...
    }
    ```

  - 循环字符串：

    ```
    str Alphabet = "abc";
    foreach (c in Alphabet)
    {
        ...
    }
    ```

### 作业：

- 