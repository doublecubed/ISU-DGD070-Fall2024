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

        // Initialize systems
        Add(new EntityCreatorSystem(contexts));
        
        // Execute systems
        Add(new FindEntitySystem(contexts));
        Add(new MovementSystem(contexts));
        Add(new BoosterSystem(contexts));
        
        // Cleanup systems
        Add(new MovementCompletedSystem(contexts));
    }

    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
    
}
