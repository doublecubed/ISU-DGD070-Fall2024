using UnityEngine;

public class GameCreator : MonoBehaviour
{
    private Contexts _contexts;
    private MovementFeature _movementFeature;
    private PlayerInputFeature _playerInputFeature;
    private ConfigurationFeature _configurationFeature;
    
    private void Start()
    {
        _contexts = Contexts.sharedInstance;

        
        // Create my features
        _configurationFeature = new ConfigurationFeature(_contexts);
        _movementFeature = new MovementFeature(_contexts);
        _playerInputFeature = new PlayerInputFeature(_contexts);
        
        // Run the initialize systems in the features
        _configurationFeature.Initialize();
        _playerInputFeature.Initialize();
        _movementFeature.Initialize();
    }

    private void Update()
    {
        // Update the execute systems in the features
        _configurationFeature.Execute();
        _playerInputFeature.Execute();
        _movementFeature.Execute();
    }

    private void LateUpdate()
    {
        // Update the cleanup systems in the features
        _configurationFeature.Cleanup();
        _playerInputFeature.Cleanup();
        _movementFeature.Cleanup();
    }


    
}
