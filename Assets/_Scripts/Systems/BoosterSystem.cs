using Entitas;
using UnityEngine;

public class BoosterSystem : IExecuteSystem
{
    private Contexts _contexts;

    public BoosterSystem(Contexts contexts)
    {
        _contexts = contexts;
    }
    
    public void Execute()
    {
        Debug.Log("BOOOOOOST!!!!!");
    }
}
