// 文件名称：Log.cs
// 功能描述：
// 编写作者：曾理
// 编写日期：
// 修改记录：

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace XL
{
    public class LoggerTool
    {
        static public void LogFormat(LogType logType, Object context, string format, params object[] args)
        {
           
        }

        static public void LogException(Exception exception, Object context)
        {
            throw new NotImplementedException();
        }


        static public void Log(object message)
        {
            throw new NotImplementedException();
        }

        static public void Log(string tag, object message)
        {
            throw new NotImplementedException();
        }

        static public void Log(string tag, object message, Object context)
        {
            throw new NotImplementedException();
        }

        static public void LogWarning(string tag)
        {
            throw new NotImplementedException();
        }

        static public void LogWarning(string tag, object message)
        {
            throw new NotImplementedException();
        }

        static public void LogWarning(string tag, object message, Object context)
        {
            throw new NotImplementedException();
        }

        static public void LogError(object message)
        {
            //throw new NotImplementedException();
        }

        static public void LogError(string tag, object message)
        {
            throw new NotImplementedException();
        }

        static public void LogError(string tag, object message, Object context)
        {
            throw new NotImplementedException();
        }

        static public void LogFormat(LogType logType, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        static public void LogException(Exception exception)
        {
            throw new NotImplementedException();
        }

    }
}


