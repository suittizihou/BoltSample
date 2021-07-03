using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Bolt;

public class PlayerInputManager : MonoBehaviour, PlayerInputAction.IPlayerInputActions
{
    PlayerInputAction.PlayerInputActions input;

    private void Awake()
    {
        input = new PlayerInputAction.PlayerInputActions(new @PlayerInputAction());
        input.SetCallbacks(this);
        input.Enable();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 velocity = context.ReadValue<Vector2>();
        CustomEvent.Trigger(gameObject, "OnMove", velocity.x, velocity.y);
    }
}
