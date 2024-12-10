using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Unique, Config]
public class ResolutionConfigComponent : IComponent
{
    public Vector2Int Value;
}
