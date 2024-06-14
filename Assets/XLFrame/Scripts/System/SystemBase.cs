// 文件名称：SystemBase.cs
// 功能描述：
// 编写作者：曾理
// 编写日期：2024年6月14日
// 修改记录：

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NotImplementedException = System.NotImplementedException;

namespace Assets.XLFrame.Scripts.System
{
    public class SystemBase : ISystem,IMonoFunction
    {
         public virtual void Initialize()
        {
           
        }

         public virtual void Dispose()
         {
         }

         public virtual void OnAwake()
        {
            throw new NotImplementedException();
        }

         public virtual void OnEnable()
        {
            throw new NotImplementedException();
        }

         public virtual void OnUpdata()
        {
        }

         public virtual void OnDisEnable()
        {
            throw new NotImplementedException();
        }

         public virtual void OnDestory()
        {
            throw new NotImplementedException();
        }
    }
}