// 文件名称：ISerialize.cs
// 功能描述：序列化接口
// 编写作者：曾理
// 编写日期：2023年7月6日
// 修改记录：

using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Scripts.Interfaces
{

    public interface ISerialize
    {
        /// <summary>
        /// 序列化
        /// </summary>
        /// <returns></returns>
       JObject Serialize();

        /// <summary>
        /// 反序列化
        /// </summary>
        void Deserialize(JObject jObject);

    }
}