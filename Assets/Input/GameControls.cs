//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Input/GameControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @GameControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""City Controls"",
            ""id"": ""284f72d6-ba10-49aa-a27d-c15a46276643"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""695a0e4f-5095-4a1c-a0ec-814f94b8d8cf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""88002754-98cc-41a3-b4e7-76b239979009"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""bcddb156-9673-4a21-b553-4c79f580d2a9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f51ba291-cef5-43e7-884e-7d3d28718050"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b61aeb91-01d2-4b06-95e5-82fec9d93d8e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3d16564e-9c32-49c6-87c1-e908602c7908"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0242b641-8e13-4fb4-a017-12e139e2af4d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b1af032c-9c2f-49d1-99cb-a138894f830d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mouse Controls"",
            ""id"": ""58bcd16e-4ce2-4d1c-9d77-10a0d2f34248"",
            ""actions"": [
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""050ea180-6b0d-4a3d-bc31-2d0428ac7f91"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""951b10bb-3d6e-4382-ab81-2490b984e171"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4f667ef9-1a3f-4b38-a59f-9319a9ff488e"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36bc74e6-9e4b-46f2-9139-6cff9ba54244"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI Controls"",
            ""id"": ""04cd0e20-eaef-4905-b562-bdd2b0398d84"",
            ""actions"": [
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""8b2e1def-bee9-4f1d-8197-846b8408a221"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""cdeeee27-72c0-49bf-9121-6cacb6cb3fe6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""ca638d67-b55d-4113-936d-9b8996b1f251"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""530a90e9-de94-44a0-9366-3895f3058886"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fa452525-f5a0-41d4-a8e7-25ba6d187ac4"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ea3294cc-0489-4b35-a2c2-066365eb917b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1df2593d-af4c-45c0-a16d-fb0a06b41490"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""aab2cc5a-72ae-4bb3-8bcc-bc5eef6a1289"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6391fbe6-ea8f-49f2-94ef-cd0463793979"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2948ddec-812e-42da-acd6-0854c7dc8bf5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9c0738a7-2add-4fb9-af92-2f3f2c3370ad"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""022936f4-dc09-4023-a962-eb9b3a23ea9c"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31b5112e-3e28-4412-8075-eb5cad2bb297"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<SwitchProControllerHID>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // City Controls
        m_CityControls = asset.FindActionMap("City Controls", throwIfNotFound: true);
        m_CityControls_Walk = m_CityControls.FindAction("Walk", throwIfNotFound: true);
        m_CityControls_Interact = m_CityControls.FindAction("Interact", throwIfNotFound: true);
        // Mouse Controls
        m_MouseControls = asset.FindActionMap("Mouse Controls", throwIfNotFound: true);
        m_MouseControls_Point = m_MouseControls.FindAction("Point", throwIfNotFound: true);
        m_MouseControls_Submit = m_MouseControls.FindAction("Submit", throwIfNotFound: true);
        // UI Controls
        m_UIControls = asset.FindActionMap("UI Controls", throwIfNotFound: true);
        m_UIControls_Point = m_UIControls.FindAction("Point", throwIfNotFound: true);
        m_UIControls_Move = m_UIControls.FindAction("Move", throwIfNotFound: true);
        m_UIControls_Submit = m_UIControls.FindAction("Submit", throwIfNotFound: true);
        m_UIControls_Cancel = m_UIControls.FindAction("Cancel", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // City Controls
    private readonly InputActionMap m_CityControls;
    private ICityControlsActions m_CityControlsActionsCallbackInterface;
    private readonly InputAction m_CityControls_Walk;
    private readonly InputAction m_CityControls_Interact;
    public struct CityControlsActions
    {
        private @GameControls m_Wrapper;
        public CityControlsActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_CityControls_Walk;
        public InputAction @Interact => m_Wrapper.m_CityControls_Interact;
        public InputActionMap Get() { return m_Wrapper.m_CityControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CityControlsActions set) { return set.Get(); }
        public void SetCallbacks(ICityControlsActions instance)
        {
            if (m_Wrapper.m_CityControlsActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_CityControlsActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_CityControlsActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_CityControlsActionsCallbackInterface.OnWalk;
                @Interact.started -= m_Wrapper.m_CityControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_CityControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_CityControlsActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_CityControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public CityControlsActions @CityControls => new CityControlsActions(this);

    // Mouse Controls
    private readonly InputActionMap m_MouseControls;
    private IMouseControlsActions m_MouseControlsActionsCallbackInterface;
    private readonly InputAction m_MouseControls_Point;
    private readonly InputAction m_MouseControls_Submit;
    public struct MouseControlsActions
    {
        private @GameControls m_Wrapper;
        public MouseControlsActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Point => m_Wrapper.m_MouseControls_Point;
        public InputAction @Submit => m_Wrapper.m_MouseControls_Submit;
        public InputActionMap Get() { return m_Wrapper.m_MouseControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMouseControlsActions instance)
        {
            if (m_Wrapper.m_MouseControlsActionsCallbackInterface != null)
            {
                @Point.started -= m_Wrapper.m_MouseControlsActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_MouseControlsActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_MouseControlsActionsCallbackInterface.OnPoint;
                @Submit.started -= m_Wrapper.m_MouseControlsActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_MouseControlsActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_MouseControlsActionsCallbackInterface.OnSubmit;
            }
            m_Wrapper.m_MouseControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
            }
        }
    }
    public MouseControlsActions @MouseControls => new MouseControlsActions(this);

    // UI Controls
    private readonly InputActionMap m_UIControls;
    private IUIControlsActions m_UIControlsActionsCallbackInterface;
    private readonly InputAction m_UIControls_Point;
    private readonly InputAction m_UIControls_Move;
    private readonly InputAction m_UIControls_Submit;
    private readonly InputAction m_UIControls_Cancel;
    public struct UIControlsActions
    {
        private @GameControls m_Wrapper;
        public UIControlsActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Point => m_Wrapper.m_UIControls_Point;
        public InputAction @Move => m_Wrapper.m_UIControls_Move;
        public InputAction @Submit => m_Wrapper.m_UIControls_Submit;
        public InputAction @Cancel => m_Wrapper.m_UIControls_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_UIControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIControlsActions set) { return set.Get(); }
        public void SetCallbacks(IUIControlsActions instance)
        {
            if (m_Wrapper.m_UIControlsActionsCallbackInterface != null)
            {
                @Point.started -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnPoint;
                @Move.started -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnMove;
                @Submit.started -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_UIControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public UIControlsActions @UIControls => new UIControlsActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface ICityControlsActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IMouseControlsActions
    {
        void OnPoint(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
    }
    public interface IUIControlsActions
    {
        void OnPoint(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
