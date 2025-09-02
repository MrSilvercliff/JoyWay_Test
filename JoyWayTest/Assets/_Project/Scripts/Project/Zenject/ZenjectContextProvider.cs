using Assets._Project.Scripts.Project.Log;
using System.ComponentModel;
using UnityEngine;
using Zenject;

namespace Assets._Project.Scripts.Project.Zenject
{
    public interface IZenjectContextProvider
    {
        DiContainer GetContainer();
        void UpdateContext(SceneContext context);
    }

    public class ZenjectContextProvider : IZenjectContextProvider
    {
        private DiContainer _container;

        public ZenjectContextProvider()
        {
            _container = null;
        }

        public DiContainer GetContainer()
        {
            if (_container == null)
            {
                if (!ProjectContext.HasInstance)
                {
                    DebugLog.Error(this, $"CANNOT GET DICONTAINER: PROJECT CONTEXT NOT INITIALIZED YET!");
                    return null;
                }

                _container = ProjectContext.Instance.Container;
            }

            return _container;
        }

        public void UpdateContext(SceneContext context)
        {
            if (context == null)
            {
                _container = ProjectContext.Instance.Container;
                return;
            }

            _container = context.Container;
        }
    }
}