using System.ComponentModel;
using UnityEngine;
using Zenject;

public class EngineInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<GameData>().AsSingle().NonLazy();   
    }
}