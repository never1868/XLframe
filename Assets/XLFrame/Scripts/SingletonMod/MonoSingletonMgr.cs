/*
 * 描述：继承MONO的单例模式基类
 * 作者：王冬
 * 时间：2021.2.24
 * 修改：1.添加多线程安全机制 2021.3.6
 *       2.判断程序是否退出
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class MonoSingletonMgr<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance = null;

    private static readonly object locker = new object();

    private static bool isQuit;

    public static T Instance
    {
        get
        {
            if (isQuit)
            {
                instance = null;
                return instance;
            }

            lock (locker)
            {
                if (instance == null)
                {
                    instance = FindObjectOfType<T>();
                    if (FindObjectsOfType<T>().Length > 1)
                    {
                        Debug.LogError("不应该存在多个单例！");
                        return instance;
                    }

                    if (instance == null)
                    {
                        var monoSingleton = new GameObject();
                        instance = monoSingleton.AddComponent<T>();
                        monoSingleton.name = "(monoSingleton)" + typeof(T);
                        monoSingleton.hideFlags = HideFlags.None;
                        DontDestroyOnLoad(monoSingleton);
                    }
                    else
                        DontDestroyOnLoad(instance.gameObject);
                }
                instance.hideFlags = HideFlags.None;
                return instance;
            }
        }
    }

    private void Awake()
    {
        isQuit = false;
    }

    private void OnDestroy()
    {
        isQuit = true;
    }
}



