using Entitas;
using UnityEngine;

public class SetResolutionSystem : IInitializeSystem
{
    private ConfigContext _configContext;

    public SetResolutionSystem(Contexts contexts)
    {
        _configContext = contexts.config;
    }
    
    public void Initialize()
    {
        int screenWidth = Screen.width;
        int screenHeight = Screen.height;
        Vector2Int screenResolution = new Vector2Int(screenWidth, screenHeight);
        
        _configContext.ReplaceResolutionConfig(screenResolution);
    }
}
