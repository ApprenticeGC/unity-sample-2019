// GENERATED AUTOMATICALLY FROM 'Assets/_/Data Assets/Game Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace GiantCroissant.InputSystemFirstLook
{
    public class GameControls : IInputActionCollection, IDisposable
    {
        private InputActionAsset asset;
        public GameControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Game Controls"",
    ""maps"": [
        {
            ""name"": ""Battle"",
            ""id"": ""aa4fd960-c116-4439-b533-d7fda8207cae"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1d8db868-14a9-4841-b689-dca863f0f384"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""331a4ffd-c3cd-4a11-b4c2-091e3d5d1037"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e593773a-681c-45cf-acb2-64cfa1d4269d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector - WASD"",
                    ""id"": ""7d76dd8c-2369-42d8-8c50-c0f831da0996"",
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
                    ""id"": ""ba997668-34e1-4be7-a9cf-60a4e48181a5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""427d86ad-53b1-4cc0-a5ac-5538c55d186a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bb76206d-dd98-4304-9f8e-d914897d05df"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5f37fdd0-7266-43c1-b9cc-2177355c92b7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector - Arrow"",
                    ""id"": ""42d0e193-57da-4f4b-be0e-5a7a416e3062"",
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
                    ""id"": ""54e3490e-6643-4625-8d0c-67f6fdd107ee"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e5e63abf-aefd-4faf-add0-d22bffcb769b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fd28b267-9e8f-402e-93ee-83258430fd23"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7f9dfdc3-0db2-4dbb-8816-527a4f2db4a3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c89462ee-427a-49f0-83a7-4e1e8e22f98b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b29488de-3689-4fa9-8f5d-51a8e40932cf"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Battle
            m_Battle = asset.FindActionMap("Battle", throwIfNotFound: true);
            m_Battle_Move = m_Battle.FindAction("Move", throwIfNotFound: true);
            m_Battle_Fire = m_Battle.FindAction("Fire", throwIfNotFound: true);
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

        // Battle
        private readonly InputActionMap m_Battle;
        private IBattleActions m_BattleActionsCallbackInterface;
        private readonly InputAction m_Battle_Move;
        private readonly InputAction m_Battle_Fire;
        public struct BattleActions
        {
            private GameControls m_Wrapper;
            public BattleActions(GameControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Battle_Move;
            public InputAction @Fire => m_Wrapper.m_Battle_Fire;
            public InputActionMap Get() { return m_Wrapper.m_Battle; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BattleActions set) { return set.Get(); }
            public void SetCallbacks(IBattleActions instance)
            {
                if (m_Wrapper.m_BattleActionsCallbackInterface != null)
                {
                    Move.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnMove;
                    Move.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnMove;
                    Move.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnMove;
                    Fire.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnFire;
                    Fire.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnFire;
                    Fire.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnFire;
                }
                m_Wrapper.m_BattleActionsCallbackInterface = instance;
                if (instance != null)
                {
                    Move.started += instance.OnMove;
                    Move.performed += instance.OnMove;
                    Move.canceled += instance.OnMove;
                    Fire.started += instance.OnFire;
                    Fire.performed += instance.OnFire;
                    Fire.canceled += instance.OnFire;
                }
            }
        }
        public BattleActions @Battle => new BattleActions(this);
        public interface IBattleActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnFire(InputAction.CallbackContext context);
        }
    }
}
