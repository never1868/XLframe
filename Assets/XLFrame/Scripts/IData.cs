// 文件名称：IData.cs
// 功能描述：
// 编写作者：曾理
// 编写日期：
// 修改记录：

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IData
{

}

public class IData<T0> : IData
{
   public T0 data0 { get; set; }
}

public class IData<T0, T1> : IData<T0>
{
    public T1 data1 { get; set; }
}

public class IData<T0, T1, T2> : IData<T0, T1>
{
    public T2 data2 { get; set; }
}

public class IData<T0, T1, T2, T3> : IData<T0, T1, T2>
{
    public T3 data3 { get; set; }
}

public class IData<T0, T1, T2, T3, T4> : IData<T0, T1, T2, T3>
{
    public T4 data4 { get; set; }
}

public class IData<T0, T1, T2, T3, T4, T5> : IData<T0, T1, T2, T3, T4>
{
    public T5 data5 { get; set; }
}