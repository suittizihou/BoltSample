using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Bolt;

public class CameraInputManager : MonoBehaviour, @CameraInputAction.ICameraActionActions
{
    @CameraInputAction.CameraActionActions input;

    private void Awake()
    {
        input = new CameraInputAction.CameraActionActions(new @CameraInputAction());
        input.SetCallbacks(this);
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        CustomEvent.Trigger(this.gameObject, "OnRotate", context.ReadValue<Vector2>());
    }
}
