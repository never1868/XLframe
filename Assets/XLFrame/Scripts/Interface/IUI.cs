// 文件名称：IUI.cs
// 功能描述：
// 编写作者：曾理
// 编写日期：2024年6月13日
// 修改记录：

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.XLFrame.Scripts.UI
{
    public interface IUI
    {

        void Initialize();

        void Delete();

        void HideUI();

        void ShowUI();

        T GetUI<T>(string name);

    }
}