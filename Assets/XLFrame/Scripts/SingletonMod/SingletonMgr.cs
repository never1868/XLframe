/*
 * 描述：不继承MonoBehaviour的单例模式基类
 * 作者：王冬
 * 时间：2021.2.24
 * 修改：1.添加多线程安全机制 2021.3.6
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class SingletonMgr<T> where T : class, new()
{
    private static T instance = null;

    // 多线程安全机制
    private static readonly object locker = new object();    //修改1

    public static T Instance
    {
        get
        {
            lock (locker)
            {
                if (instance == null)
                    instance = new T();
                return instance;
            }
        }
    }
}

