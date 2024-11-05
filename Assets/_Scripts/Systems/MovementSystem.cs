using Entitas;
using UnityEngine;

public class MovementSystem : IExecuteSystem
{
    Contexts _contexts;

    public MovementSystem(Contexts contexts)
    {
        _contexts = contexts;
    }
    
    public void Execute()
    {
        Debug.Log("lol");
    }
}
