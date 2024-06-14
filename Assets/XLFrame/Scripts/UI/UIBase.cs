using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.XLFrame.Scripts.System;
using UnityEngine;

namespace Assets.XLFrame.Scripts.UI
{
    class UIBase:MonoBehaviour,IUI, IMonoFunction
    {
        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void OnAwake()
        {
            throw new NotImplementedException();
        }

        public void OnEnable()
        {
            throw new NotImplementedException();
        }

        public void OnUpdata()
        {
            throw new NotImplementedException();
        }

        public void OnDisEnable()
        {
            throw new NotImplementedException();
        }

        public void OnDestory()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void HideUI()
        {
            gameObject.SetActive(false);
        }

        public void ShowUI()
        {
            gameObject.SetActive(true);
        }

        public T GetUI<T>(string name)
        {
            var child = transform.GetComponentInChildren<T>();
            return child;
        }

        public Transform GetUI(string name)
        {
            var child = transform.GetComponentInChildren<Transform>();
            return child;
        }
    }
}
