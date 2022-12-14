//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/input actions/InputMaster.inputactions
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

public partial class @InputMaster : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ad8604b0-9259-4e6e-bd2f-6f4dba5fc76e"",
            ""actions"": [
                {
                    ""name"": ""Movment"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6572eb16-7732-4857-8b3a-49a8f24414f4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e37a7ad1-6f61-47bf-88a0-1b7e0570dd5a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""479abfe6-62c0-4f8a-9c3d-0053488676be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a6828951-61fd-4267-8c0d-00fb135df197"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8f425c67-94b4-4edf-a4e2-2a03d6f79a74"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""299096c2-5432-4d4f-ba8d-fca5c310991c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d62c1f63-bc62-48a6-aed0-8918d62f656d"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5b1875ae-40e4-4ffb-8998-aaad6a934cc2"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0acd57cc-5840-4f87-88ce-230a309b2028"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""6b2e9c31-d393-45ad-8315-1650c7c64e34"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9cb00c47-6df6-43af-9981-1502710f9664"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4bfe69c1-edf2-4c89-9078-0c50ee54aa1a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6bce6834-c0e1-452f-90f6-231151b31bd5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f6d44c14-d809-4c38-956f-5c1d8be93483"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamePad"",
                    ""id"": ""bd92e064-2d91-426d-a989-97f43df4e6a8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""561cb177-9f35-4b07-b8f0-9d87f7d7b682"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1af69ecc-5309-44d2-a0d0-ea40bcbba372"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5f52c679-4149-4b5d-aacd-cbd32224cc14"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1c127b47-d9b2-404a-8c57-05242fccfb4b"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""80f2107a-74ca-45f4-92e1-35b469c8b3f6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73222e3a-ee0f-4659-af31-4f8b5cdcccf8"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a65790fc-6639-4b37-9f8b-02926406e021"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffbd9062-6938-410a-93cf-71e847b7e206"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aeae0aa6-bc07-4841-8fa1-04c31101ab87"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Inventory"",
            ""id"": ""0bd2f3ba-e762-48bc-86e8-0cfcbb9e0788"",
            ""actions"": [
                {
                    ""name"": ""P1"",
                    ""type"": ""Button"",
                    ""id"": ""9649bbad-e205-4c5c-8d84-c4ee7d9163a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P2"",
                    ""type"": ""Button"",
                    ""id"": ""d73a4d2e-12b3-46b7-b5c8-1d9e1296c719"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P3"",
                    ""type"": ""Button"",
                    ""id"": ""1e537df4-70df-454a-8bd5-41d592056c29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P4"",
                    ""type"": ""Button"",
                    ""id"": ""d1457449-8fd4-4c6d-9630-4876c8c9f6be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P5"",
                    ""type"": ""Button"",
                    ""id"": ""53004f61-3da0-472a-bd5a-e6798d8418ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P6"",
                    ""type"": ""Button"",
                    ""id"": ""0302e01e-36c1-43ff-b5f8-3fc52125d539"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P7"",
                    ""type"": ""Button"",
                    ""id"": ""22da4d91-0215-4745-add8-a053f387b686"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P8"",
                    ""type"": ""Button"",
                    ""id"": ""4cd2ae4e-c80f-4fae-8f55-54248050c40a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""P9"",
                    ""type"": ""Button"",
                    ""id"": ""c8a8bc6c-1ebd-498d-af84-0693af505c96"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7c7cf737-c972-48ea-9ede-78961ee85731"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07738cf6-ac90-4e02-9138-6506b80f0c9b"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9e1cf53-57ea-49bc-a33f-65e173eed0be"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf00135c-af71-4ce3-8145-78831d5af117"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24613f7a-0113-4810-a350-438f4de5f4b0"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da4ba11b-9986-43c3-bb4e-29557df1ab02"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1b0e099-72b4-4076-ba84-a68e10d42bb4"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc1cf4a3-0e95-48fc-ab39-be0007f81118"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36f14b6e-6baa-4d1f-b970-75dd50c16467"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P9"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movment = m_Player.FindAction("Movment", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
        // Inventory
        m_Inventory = asset.FindActionMap("Inventory", throwIfNotFound: true);
        m_Inventory_P1 = m_Inventory.FindAction("P1", throwIfNotFound: true);
        m_Inventory_P2 = m_Inventory.FindAction("P2", throwIfNotFound: true);
        m_Inventory_P3 = m_Inventory.FindAction("P3", throwIfNotFound: true);
        m_Inventory_P4 = m_Inventory.FindAction("P4", throwIfNotFound: true);
        m_Inventory_P5 = m_Inventory.FindAction("P5", throwIfNotFound: true);
        m_Inventory_P6 = m_Inventory.FindAction("P6", throwIfNotFound: true);
        m_Inventory_P7 = m_Inventory.FindAction("P7", throwIfNotFound: true);
        m_Inventory_P8 = m_Inventory.FindAction("P8", throwIfNotFound: true);
        m_Inventory_P9 = m_Inventory.FindAction("P9", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movment;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Pause;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movment => m_Wrapper.m_Player_Movment;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movment.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovment;
                @Movment.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovment;
                @Movment.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovment;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movment.started += instance.OnMovment;
                @Movment.performed += instance.OnMovment;
                @Movment.canceled += instance.OnMovment;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Inventory
    private readonly InputActionMap m_Inventory;
    private IInventoryActions m_InventoryActionsCallbackInterface;
    private readonly InputAction m_Inventory_P1;
    private readonly InputAction m_Inventory_P2;
    private readonly InputAction m_Inventory_P3;
    private readonly InputAction m_Inventory_P4;
    private readonly InputAction m_Inventory_P5;
    private readonly InputAction m_Inventory_P6;
    private readonly InputAction m_Inventory_P7;
    private readonly InputAction m_Inventory_P8;
    private readonly InputAction m_Inventory_P9;
    public struct InventoryActions
    {
        private @InputMaster m_Wrapper;
        public InventoryActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @P1 => m_Wrapper.m_Inventory_P1;
        public InputAction @P2 => m_Wrapper.m_Inventory_P2;
        public InputAction @P3 => m_Wrapper.m_Inventory_P3;
        public InputAction @P4 => m_Wrapper.m_Inventory_P4;
        public InputAction @P5 => m_Wrapper.m_Inventory_P5;
        public InputAction @P6 => m_Wrapper.m_Inventory_P6;
        public InputAction @P7 => m_Wrapper.m_Inventory_P7;
        public InputAction @P8 => m_Wrapper.m_Inventory_P8;
        public InputAction @P9 => m_Wrapper.m_Inventory_P9;
        public InputActionMap Get() { return m_Wrapper.m_Inventory; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryActions instance)
        {
            if (m_Wrapper.m_InventoryActionsCallbackInterface != null)
            {
                @P1.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP1;
                @P1.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP1;
                @P1.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP1;
                @P2.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP2;
                @P2.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP2;
                @P2.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP2;
                @P3.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP3;
                @P3.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP3;
                @P3.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP3;
                @P4.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP4;
                @P4.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP4;
                @P4.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP4;
                @P5.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP5;
                @P5.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP5;
                @P5.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP5;
                @P6.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP6;
                @P6.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP6;
                @P6.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP6;
                @P7.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP7;
                @P7.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP7;
                @P7.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP7;
                @P8.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP8;
                @P8.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP8;
                @P8.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP8;
                @P9.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP9;
                @P9.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP9;
                @P9.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnP9;
            }
            m_Wrapper.m_InventoryActionsCallbackInterface = instance;
            if (instance != null)
            {
                @P1.started += instance.OnP1;
                @P1.performed += instance.OnP1;
                @P1.canceled += instance.OnP1;
                @P2.started += instance.OnP2;
                @P2.performed += instance.OnP2;
                @P2.canceled += instance.OnP2;
                @P3.started += instance.OnP3;
                @P3.performed += instance.OnP3;
                @P3.canceled += instance.OnP3;
                @P4.started += instance.OnP4;
                @P4.performed += instance.OnP4;
                @P4.canceled += instance.OnP4;
                @P5.started += instance.OnP5;
                @P5.performed += instance.OnP5;
                @P5.canceled += instance.OnP5;
                @P6.started += instance.OnP6;
                @P6.performed += instance.OnP6;
                @P6.canceled += instance.OnP6;
                @P7.started += instance.OnP7;
                @P7.performed += instance.OnP7;
                @P7.canceled += instance.OnP7;
                @P8.started += instance.OnP8;
                @P8.performed += instance.OnP8;
                @P8.canceled += instance.OnP8;
                @P9.started += instance.OnP9;
                @P9.performed += instance.OnP9;
                @P9.canceled += instance.OnP9;
            }
        }
    }
    public InventoryActions @Inventory => new InventoryActions(this);
    public interface IPlayerActions
    {
        void OnMovment(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IInventoryActions
    {
        void OnP1(InputAction.CallbackContext context);
        void OnP2(InputAction.CallbackContext context);
        void OnP3(InputAction.CallbackContext context);
        void OnP4(InputAction.CallbackContext context);
        void OnP5(InputAction.CallbackContext context);
        void OnP6(InputAction.CallbackContext context);
        void OnP7(InputAction.CallbackContext context);
        void OnP8(InputAction.CallbackContext context);
        void OnP9(InputAction.CallbackContext context);
    }
}
