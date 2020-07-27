using UnityEngine;
using Zenject;

public class ZenjectSample : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<MainModel>().FromNew().AsSingle();
    }
}