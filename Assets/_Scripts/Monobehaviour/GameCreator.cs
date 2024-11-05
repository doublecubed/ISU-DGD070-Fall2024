using System;
using Entitas;
using UnityEngine;

public class GameCreator : MonoBehaviour
{
    private GameContext _context;
    private GameEntity _entityOne;

    private MovementFeature _movementFeature;
    
    private void Start()
    {
        _movementFeature = new MovementFeature(Contexts.sharedInstance);
        
        #region HIDE
        _context = Contexts.sharedInstance.game;

        _entityOne = _context.CreateEntity();
        _entityOne.AddPosition(Vector3.zero);
        _entityOne.AddSpeed(new Vector3(1f,0f,0f));
        _entityOne.isMoving = true;
        #endregion
    }

    private void Update()
    {
        _movementFeature.Execute();
        
        #region INPUT CODE
        
        if (Input.GetKeyDown(KeyCode.Space))
            _entityOne.isMoving = !_entityOne.isMoving;

        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 newSpeed = Vector3.right * 5f;
            if (_entityOne.hasSpeed)
            {
                Vector3 previousSpeed = _entityOne.speed.Value;
                newSpeed = previousSpeed + new Vector3(1f, 0f, 0f);
            }

            _entityOne.ReplaceSpeed(newSpeed);
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            _entityOne.RemoveSpeed();
        }
        
        #endregion
    }
    
}
