using UnityEngine;
using Zenject;

namespace Assets._Project.Scripts.Project.Zenject
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallZenjectServices();
        }

        private void InstallZenjectServices()
        { 
            Container.Bind<IZenjectContextProvider>().To<ZenjectContextProvider>().AsSingle();
        }
    }
}