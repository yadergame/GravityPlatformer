using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerController _controller;
    [SerializeField] private MoveScript _move;
    public SceneManager sceneManager;
    
    private void Awake()
    {
        _controller = new PlayerController();
    }

    private void OnEnable()
    {
        _controller.Player.Enable();
        _controller.Player.Move.performed += OnMove;
        _controller.Player.Move.canceled += OnMoveStop;
        _controller.Player.Use.started += OnUse;
    }

    private void OnDisable()
    {
        _controller.Player.Disable();
        _controller.Player.Move.performed -= OnMove;
        _controller.Player.Move.canceled -= OnMoveStop;
        _controller.Player.Use.started -= OnUse;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        float direction = context.ReadValue<float>();
        _move.direction = direction;
        Debug.Log($"Move: {direction}");
    }

    private void OnMoveStop(InputAction.CallbackContext context)
    {
        _move.direction = 0;
        Debug.Log("Move stopped");
    }
    

    private void OnUse(InputAction.CallbackContext context)
    {
        _move.Use();
    }

    public void Death()
    {
        sceneManager.Spawn();
        Destroy(this.gameObject);        
    }
}