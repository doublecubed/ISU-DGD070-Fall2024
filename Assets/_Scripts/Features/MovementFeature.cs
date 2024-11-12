using System.Collections;
using System.Collections.Generic;
using Entitas;
using Unity.VisualScripting;
using UnityEngine;

public class MovementFeature : Feature
{
    Contexts _contexts;
    
    public MovementFeature(Contexts contexts)
    {
        _contexts = contexts;

        Add(new EntityCreatorSystem(contexts));
        Add(new MovementSystem(contexts));
        Add(new BoosterSystem(contexts));
    }

    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
    
}
