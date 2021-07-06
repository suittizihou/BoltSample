// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/CameraInput/CameraInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CameraInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CameraInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CameraInputAction"",
    ""maps"": [
        {
            ""name"": ""CameraAction"",
            ""id"": ""596c7bcb-7960-4c28-8299-9241847b9b8e"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""0b12837e-dadf-4ee4-88bf-49ab520a640f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""be681dbd-4b57-49f2-a833-bf80e14caaed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.4,y=0.4)"",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7a94e670-ae5e-43bb-b7d1-f90cecd064bf"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6979154b-a03a-4cd1-86fd-ea64de89e4d9"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""24aa977e-cfd8-41c1-a6fa-c8ecf84c5898"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8fb0e167-4ef8-4417-921c-426391f414c4"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d42aebe7-00d2-4585-9019-38c9ded49bd5"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.4,y=0.4)"",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6479f41-95da-4e66-84c2-3149cff5ea1a"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CameraAction
        m_CameraAction = asset.FindActionMap("CameraAction", throwIfNotFound: true);
        m_CameraAction_Rotate = m_CameraAction.FindAction("Rotate", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // CameraAction
    private readonly InputActionMap m_CameraAction;
    private ICameraActionActions m_CameraActionActionsCallbackInterface;
    private readonly InputAction m_CameraAction_Rotate;
    public struct CameraActionActions
    {
        private @CameraInputAction m_Wrapper;
        public CameraActionActions(@CameraInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_CameraAction_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_CameraAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActionActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActionActions instance)
        {
            if (m_Wrapper.m_CameraActionActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_CameraActionActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_CameraActionActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_CameraActionActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_CameraActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public CameraActionActions @CameraAction => new CameraActionActions(this);
    public interface ICameraActionActions
    {
        void OnRotate(InputAction.CallbackContext context);
    }
}
