// GENERATED AUTOMATICALLY FROM 'Assets/FPControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @FPControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @FPControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FPControl"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""198e3775-a736-430e-808b-012ab3c78817"",
            ""actions"": [
                {
                    ""name"": ""Walking"",
                    ""type"": ""Value"",
                    ""id"": ""7c79cca7-784a-4bec-88e4-711ea2fe260c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack/Break"",
                    ""type"": ""Button"",
                    ""id"": ""12b32083-b295-4d41-a8f5-37820e993a6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Looking"",
                    ""type"": ""Value"",
                    ""id"": ""7c01d097-1b8a-4607-9191-6b7c23523cf9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crafting"",
                    ""type"": ""Button"",
                    ""id"": ""676c31ba-8a50-4c40-a980-a7a7a1c9f94e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8dc2b162-e3b6-4ad4-94ec-4426b0cf5b94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e9b5d3f7-8731-46c5-8cd1-bcf08eeec31c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2fda38f0-e042-485b-81d4-aa2f1b374ee9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3fd64d8e-79dc-4de4-8710-437dd5913a35"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""62929546-d435-42e3-914c-75162b77d508"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b0bfaf41-7be8-4335-b689-e67b71eb1287"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6932d533-ac85-4310-82be-dd569aff9c8a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""009190e1-b677-4a37-b2b1-9e428f0d50b0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack/Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bae81385-1289-437f-ba55-58a5d2aa73ae"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Looking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19fdce8c-402c-4189-bbab-e3b8d09947ea"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crafting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bae1ea1-18b2-4f2e-b8f4-ee0e1744e1dc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Walking = m_PlayerControls.FindAction("Walking", throwIfNotFound: true);
        m_PlayerControls_AttackBreak = m_PlayerControls.FindAction("Attack/Break", throwIfNotFound: true);
        m_PlayerControls_Looking = m_PlayerControls.FindAction("Looking", throwIfNotFound: true);
        m_PlayerControls_Crafting = m_PlayerControls.FindAction("Crafting", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Walking;
    private readonly InputAction m_PlayerControls_AttackBreak;
    private readonly InputAction m_PlayerControls_Looking;
    private readonly InputAction m_PlayerControls_Crafting;
    private readonly InputAction m_PlayerControls_Jump;
    public struct PlayerControlsActions
    {
        private @FPControl m_Wrapper;
        public PlayerControlsActions(@FPControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walking => m_Wrapper.m_PlayerControls_Walking;
        public InputAction @AttackBreak => m_Wrapper.m_PlayerControls_AttackBreak;
        public InputAction @Looking => m_Wrapper.m_PlayerControls_Looking;
        public InputAction @Crafting => m_Wrapper.m_PlayerControls_Crafting;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Walking.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnWalking;
                @Walking.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnWalking;
                @Walking.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnWalking;
                @AttackBreak.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackBreak;
                @AttackBreak.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackBreak;
                @AttackBreak.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackBreak;
                @Looking.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLooking;
                @Looking.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLooking;
                @Looking.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLooking;
                @Crafting.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrafting;
                @Crafting.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrafting;
                @Crafting.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrafting;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walking.started += instance.OnWalking;
                @Walking.performed += instance.OnWalking;
                @Walking.canceled += instance.OnWalking;
                @AttackBreak.started += instance.OnAttackBreak;
                @AttackBreak.performed += instance.OnAttackBreak;
                @AttackBreak.canceled += instance.OnAttackBreak;
                @Looking.started += instance.OnLooking;
                @Looking.performed += instance.OnLooking;
                @Looking.canceled += instance.OnLooking;
                @Crafting.started += instance.OnCrafting;
                @Crafting.performed += instance.OnCrafting;
                @Crafting.canceled += instance.OnCrafting;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnWalking(InputAction.CallbackContext context);
        void OnAttackBreak(InputAction.CallbackContext context);
        void OnLooking(InputAction.CallbackContext context);
        void OnCrafting(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
