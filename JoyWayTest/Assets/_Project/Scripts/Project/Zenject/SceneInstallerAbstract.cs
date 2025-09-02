using Assets._Project.Scripts.Project.Log;
using UnityEngine;
using Zenject;

namespace Assets._Project.Scripts.Project.Zenject
{
    public abstract class SceneInstallerAbstract : MonoInstaller
    {
        [SerializeField] private SceneContext _sceneContext;

        [Inject] private IZenjectContextProvider _contextProvider;

        public override void InstallBindings()
        {
            DebugLog.Log(this, $"Install bindings");
            OnInstallBindings();
            _contextProvider.UpdateContext(_sceneContext);
        }

        protected abstract void OnInstallBindings();
    }
}