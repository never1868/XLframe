// 文件名称：DeviceManagerSystem.cs
// 功能描述：状态接口
// 编写作者：曾理
// 编写日期：2023年6月13日
// 修改记录：

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Interfaces
{
    public interface IState
    {
        /// <summary>
        /// 状态加载
        /// </summary>
         void Enter();
        /// <summary>
        /// 状态退出
        /// </summary>
         void Exit();
    }
}
