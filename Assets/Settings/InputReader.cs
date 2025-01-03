using UnityEngine;
using UnityEngine.InputSystem;
using static Control;

public class InputReader : ScriptableObject,IPlayerActions
{
    public Vector2 InputVector { get; private set; }

    public void OnMovement(InputAction.CallbackContext context)
    {
        InputVector = context.ReadValue<Vector2>();
    }
}
