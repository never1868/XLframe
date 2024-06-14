// 文件名称：Game.cs
// 功能描述：
// 编写作者：曾理
// 编写日期：
// 修改记录：

using System.Collections;
using System.Collections.Generic;
using Assets.XLFrame.Scripts.Notice;
using Assets.XLFrame.Scripts.System;
using UnityEngine;

public class GameManager : MonoSingletonMgr<GameManager>
{
    private List<SystemBase> systems = new List<SystemBase>();


    private void Awake()
    {
        Register<NoticeSystem>();

       
        GetSystem<NoticeSystem>().RegistrationNotice("测试消息1", Test);
    }

    private void OnDestroy()
    {

    }

    private void OnEnable()
    {

    }

    private void Start()
    {
        IData data = new IData<string, int>()
        {
            data0="data",
            data1=5
        };
            GetSystem<NoticeSystem>().Notice("测试消息1", data);
    }

    private void Update()
    {
        for (int i = 0; i < systems.Count; i++)
        {
            systems[i].OnUpdata();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {

            GetSystem<NoticeSystem>().UnRegistrationNotice("测试消息1", Test);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            IData data = new IData<string, int>()
            {
                data0 = "data336",
                data1 = 15
            };
            GetSystem<NoticeSystem>().Notice("测试消息1", data);
        }
    }

    T GetSystem<T>() where T : SystemBase
    {
        for (int i = 0; i < systems.Count; i++)
        {
            if (systems[i] is T)
            {
                return systems[i] as T;
            }
        }

        return null;
    }

    void Register<T>() where T : SystemBase,new()
    {
        if (GetSystem<T>()==null)
        {
            var systemBase = new T();
            if (systems.Contains(systemBase))
            {
                Debug.LogError($"{systemBase.GetType()}已注册,请勿重复注册!");
                return;
            }

            systemBase.Initialize();

            systems.Add(systemBase);
        }

        XL.LoggerTool.LogError($"无法注册系统");
    }

    void Unregister<T>() where T : SystemBase, new()
    {
        var systemBase = GetSystem<T>();
        if (systemBase == null)
        {
            XL.LoggerTool.LogWarning($"此{systemBase.GetType()}系统没有注册！");
        }
    }

    void Test(IData data)
    {
        var data9 = data as IData<string, int>;

        Debug.LogError($"拿到消息{data9.data0}\\{data9.data1 + 1}");
    }

}
