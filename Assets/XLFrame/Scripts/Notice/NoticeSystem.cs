// 文件名称：NoticeSystem.cs
// 功能描述：
// 编写作者：曾理
// 编写日期：2024年6月13日
// 修改记录：

using System;
using System.Collections.Generic;
using Assets.XLFrame.Scripts.System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XL;

namespace Assets.XLFrame.Scripts.Notice
{
    public class NoticeSystem : SystemBase
    {
        private Dictionary<string, Action<IData>> notice_list;

        public override void Initialize()
        {
            base.Initialize();
            notice_list = new Dictionary<string, Action<IData>>();
        }

        public void RegistrationNotice(string NoticeID, Action<IData> action)
        {
            if (notice_list.ContainsKey(NoticeID))
            {
                notice_list[NoticeID]+=action;
            }
            else
            {
                notice_list[NoticeID] = action;
            }

        }


        public void Notice(string NoticeID, IData data)
        {
            if (notice_list.ContainsKey(NoticeID))
            {
                notice_list[NoticeID].Invoke(data);
                LoggerTool.Log($"{NoticeID}通知添加完成!");
            }
        }

        public void UnRegistrationNotice(string NoticeID, Action<IData> action)
        {

            if (notice_list[NoticeID].GetInvocationList().Length == 0)
            {
                LoggerTool.Log($"消息“{NoticeID}”没有被注册");
                return;
            }

            if (notice_list.ContainsKey(NoticeID))
            {
                notice_list[NoticeID] -= action;

                if (notice_list[NoticeID]==null)
                {
                    notice_list.Remove(NoticeID);
                }
                LoggerTool.Log($"{NoticeID}删除成功!");
            }
            
        }
    }
}