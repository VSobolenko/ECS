using Assets.Source;
using Leopotam.Ecs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Voody.UniLeo;

public partial class EcsGameStartup : MonoBehaviour
{
    private EcsWorld _world;
    private EcsSystems _system;

    private void Start()
    {
        _world = new EcsWorld();
        _system = new EcsSystems(_world);

        _system.ConvertScene();

        AddInjections();
        AddOneFrames();
        AddSystems();

        _system.Init();
    }

    private void Update()
    {
        _system.Run();
    }

    private void AddInjections()
    {

    }

    private void AddSystems()
    {
        _system.
            Add(new PlayerInputSystem()).
            Add(new MoveventSystem());
    }

    private void AddOneFrames()
    {

    }
    private void OnDestroy()
    {
        _system.Destroy();
        _system = null;
        _world.Destroy();
        _world = null;
    }
}
