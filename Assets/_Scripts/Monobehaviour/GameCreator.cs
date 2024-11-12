using UnityEngine;

public class GameCreator : MonoBehaviour
{
    private Contexts _contexts;
    private MovementFeature _movementFeature;
    
    private void Start()
    {
        _contexts = Contexts.sharedInstance;
        
        // Create my features
        _movementFeature = new MovementFeature(_contexts);
        
        // Run the initialize systems in the features
        _movementFeature.Initialize();
    }

    private void Update()
    {
        // Update the execute systems in the features
        _movementFeature.Execute();
    }


    
}
