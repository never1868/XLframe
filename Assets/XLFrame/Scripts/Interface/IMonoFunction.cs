// 文件名称：IMonoFunction.cs
// 功能描述：
// 编写作者：曾理
// 编写日期：2024年6月14日
// 修改记录：

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.XLFrame.Scripts.System
{
    public interface IMonoFunction 
    {

        void OnAwake();
        void OnEnable();
        void OnUpdata();
        void OnDisEnable();
        void OnDestory();

    }
}