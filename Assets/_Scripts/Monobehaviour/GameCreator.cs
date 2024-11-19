using UnityEngine;

public class GameCreator : MonoBehaviour
{
    private Contexts _contexts;
    private MovementFeature _movementFeature;
    private PlayerInputFeature _playerInputFeature;
    
    
    private void Start()
    {
        _contexts = Contexts.sharedInstance;
        
        // Create my features
        _movementFeature = new MovementFeature(_contexts);
        _playerInputFeature = new PlayerInputFeature(_contexts);
        
        // Run the initialize systems in the features
        _movementFeature.Initialize();
    }

    private void Update()
    {
        // Update the execute systems in the features
        _playerInputFeature.Execute();
        
        _movementFeature.Execute();
    }

    private void LateUpdate()
    {
        // Update the cleanup systems in the features
        _movementFeature.Cleanup();
    }


    
}
