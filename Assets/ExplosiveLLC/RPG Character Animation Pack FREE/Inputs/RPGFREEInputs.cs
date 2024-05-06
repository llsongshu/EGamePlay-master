// GENERATED AUTOMATICALLY FROM 'Assets/ExplosiveLLC/RPG Character Animation Pack FREE/Inputs/RPGFREEInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace RPGCharacterAnimsFREE
{
    public class @RPGFREEInputs : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @RPGFREEInputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""RPGFREEInputActions"",
    ""maps"": [
        {
            ""name"": ""RPGCharacter"",
            ""id"": ""3ead366c-a6b7-44d2-8381-0a0b951f5df8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""43308ce0-cc64-42b2-a9dd-3295b6ef9f15"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Facing"",
                    ""type"": ""Value"",
                    ""id"": ""dd5a4ce2-a4d1-4d8a-bee7-3759c067ffd6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Targeting"",
                    ""type"": ""Button"",
                    ""id"": ""aafb5408-6a4f-4fd7-a596-caf6387fc87e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5679467b-966e-49db-b5a9-aa9e28fc90d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Face"",
                    ""type"": ""Button"",
                    ""id"": ""787a80ae-a794-4ad0-8aad-2e110194e427"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackL"",
                    ""type"": ""Button"",
                    ""id"": ""12f351ba-2710-419f-bda3-bf2abf737ff4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackR"",
                    ""type"": ""Button"",
                    ""id"": ""01a71673-bab7-492e-8129-87f3109d7a58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KickL"",
                    ""type"": ""Button"",
                    ""id"": ""8adf7ca3-6cd8-41b2-b282-20a4241f0a00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KickR"",
                    ""type"": ""Button"",
                    ""id"": ""5dff7773-c15e-405f-beac-d8ef7acba2f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""f6a094d5-bf2c-432a-be73-f32274a37dbd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LightHit"",
                    ""type"": ""Button"",
                    ""id"": ""c6381ffb-3d89-4857-b599-53b47c05849c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Death"",
                    ""type"": ""Button"",
                    ""id"": ""8fbfea2e-d59e-48dc-ae84-73e9c0d479f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""9b8a647f-12ad-455b-bc4e-d14bc34f084e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WeaponSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""ae0d5111-b008-4443-8ac0-8b971ad35b20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bbdbdafb-66ad-4206-9f76-c60d53269a1b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.125,max=0.925)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""2e85cef7-c1cb-4b22-8597-350bec0aa14d"",
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
                    ""id"": ""2120b965-d816-4b44-838a-869511df56c4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""826155c0-f5d3-45d0-a964-1cd39e4de24d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""57c3d98e-ba54-40a2-87d3-9640624cf46d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ded9887c-d549-4d24-8f18-e42ff97d6611"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""444d5689-a373-4ff8-bc62-5a0435ff4833"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false),StickDeadzone(min=0.125,max=0.925)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Facing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cff3abbd-e163-4163-8ebb-7e52d1508789"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Targeting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2370bb3d-b1ab-48cd-ae80-53046637c82c"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Targeting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f11c46ab-cc0b-4bff-8583-9afa124803f9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e97cf5e-f636-4a8f-a9e5-e9ab48dbcc74"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63104a7a-9566-435a-be44-cab8f87e4ab2"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Face"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49d9ee54-833f-4704-9579-a66ccde8c535"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AttackL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0acae91-204f-447c-9ff5-24d26ff3cee5"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AttackR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36a9d2d3-deaf-44e5-8805-5f4731241e0a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press(pressPoint=0.5)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""KickL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a37556aa-5777-4ec8-90d9-f60c3cf4fd79"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Press(pressPoint=0.5)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""KickR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d79770ca-5c77-4b53-ac33-9712a4cb8ee2"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb2ae42d-7bed-49d3-ada1-dbaffc27b8db"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LightHit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9417228-53a0-4d27-8d6d-d45b933fcd4e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Death"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c1b111f-b14e-4638-95be-9154e3b9b55e"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Mouse and Keyboard"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a2bc915-4b04-443e-b134-8620b71cf761"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WeaponSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        },
        {
            ""name"": ""Mouse and Keyboard"",
            ""bindingGroup"": ""Mouse and Keyboard"",
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
        }
    ]
}");
            // RPGCharacter
            m_RPGCharacter = asset.FindActionMap("RPGCharacter", throwIfNotFound: true);
            m_RPGCharacter_Move = m_RPGCharacter.FindAction("Move", throwIfNotFound: true);
            m_RPGCharacter_Facing = m_RPGCharacter.FindAction("Facing", throwIfNotFound: true);
            m_RPGCharacter_Targeting = m_RPGCharacter.FindAction("Targeting", throwIfNotFound: true);
            m_RPGCharacter_Jump = m_RPGCharacter.FindAction("Jump", throwIfNotFound: true);
            m_RPGCharacter_Face = m_RPGCharacter.FindAction("Face", throwIfNotFound: true);
            m_RPGCharacter_AttackL = m_RPGCharacter.FindAction("AttackL", throwIfNotFound: true);
            m_RPGCharacter_AttackR = m_RPGCharacter.FindAction("AttackR", throwIfNotFound: true);
            m_RPGCharacter_KickL = m_RPGCharacter.FindAction("KickL", throwIfNotFound: true);
            m_RPGCharacter_KickR = m_RPGCharacter.FindAction("KickR", throwIfNotFound: true);
            m_RPGCharacter_Block = m_RPGCharacter.FindAction("Block", throwIfNotFound: true);
            m_RPGCharacter_LightHit = m_RPGCharacter.FindAction("LightHit", throwIfNotFound: true);
            m_RPGCharacter_Death = m_RPGCharacter.FindAction("Death", throwIfNotFound: true);
            m_RPGCharacter_Roll = m_RPGCharacter.FindAction("Roll", throwIfNotFound: true);
            m_RPGCharacter_WeaponSwitch = m_RPGCharacter.FindAction("WeaponSwitch", throwIfNotFound: true);
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

        // RPGCharacter
        private readonly InputActionMap m_RPGCharacter;
        private IRPGCharacterActions m_RPGCharacterActionsCallbackInterface;
        private readonly InputAction m_RPGCharacter_Move;
        private readonly InputAction m_RPGCharacter_Facing;
        private readonly InputAction m_RPGCharacter_Targeting;
        private readonly InputAction m_RPGCharacter_Jump;
        private readonly InputAction m_RPGCharacter_Face;
        private readonly InputAction m_RPGCharacter_AttackL;
        private readonly InputAction m_RPGCharacter_AttackR;
        private readonly InputAction m_RPGCharacter_KickL;
        private readonly InputAction m_RPGCharacter_KickR;
        private readonly InputAction m_RPGCharacter_Block;
        private readonly InputAction m_RPGCharacter_LightHit;
        private readonly InputAction m_RPGCharacter_Death;
        private readonly InputAction m_RPGCharacter_Roll;
        private readonly InputAction m_RPGCharacter_WeaponSwitch;
        public struct RPGCharacterActions
        {
            private @RPGFREEInputs m_Wrapper;
            public RPGCharacterActions(@RPGFREEInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_RPGCharacter_Move;
            public InputAction @Facing => m_Wrapper.m_RPGCharacter_Facing;
            public InputAction @Targeting => m_Wrapper.m_RPGCharacter_Targeting;
            public InputAction @Jump => m_Wrapper.m_RPGCharacter_Jump;
            public InputAction @Face => m_Wrapper.m_RPGCharacter_Face;
            public InputAction @AttackL => m_Wrapper.m_RPGCharacter_AttackL;
            public InputAction @AttackR => m_Wrapper.m_RPGCharacter_AttackR;
            public InputAction @KickL => m_Wrapper.m_RPGCharacter_KickL;
            public InputAction @KickR => m_Wrapper.m_RPGCharacter_KickR;
            public InputAction @Block => m_Wrapper.m_RPGCharacter_Block;
            public InputAction @LightHit => m_Wrapper.m_RPGCharacter_LightHit;
            public InputAction @Death => m_Wrapper.m_RPGCharacter_Death;
            public InputAction @Roll => m_Wrapper.m_RPGCharacter_Roll;
            public InputAction @WeaponSwitch => m_Wrapper.m_RPGCharacter_WeaponSwitch;
            public InputActionMap Get() { return m_Wrapper.m_RPGCharacter; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RPGCharacterActions set) { return set.Get(); }
            public void SetCallbacks(IRPGCharacterActions instance)
            {
                if (m_Wrapper.m_RPGCharacterActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnMove;
                    @Facing.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnFacing;
                    @Facing.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnFacing;
                    @Facing.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnFacing;
                    @Targeting.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnTargeting;
                    @Targeting.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnTargeting;
                    @Targeting.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnTargeting;
                    @Jump.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnJump;
                    @Face.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnFace;
                    @Face.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnFace;
                    @Face.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnFace;
                    @AttackL.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnAttackL;
                    @AttackL.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnAttackL;
                    @AttackL.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnAttackL;
                    @AttackR.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnAttackR;
                    @AttackR.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnAttackR;
                    @AttackR.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnAttackR;
                    @KickL.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnKickL;
                    @KickL.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnKickL;
                    @KickL.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnKickL;
                    @KickR.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnKickR;
                    @KickR.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnKickR;
                    @KickR.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnKickR;
                    @Block.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnBlock;
                    @Block.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnBlock;
                    @Block.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnBlock;
                    @LightHit.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnLightHit;
                    @LightHit.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnLightHit;
                    @LightHit.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnLightHit;
                    @Death.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnDeath;
                    @Death.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnDeath;
                    @Death.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnDeath;
                    @Roll.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnRoll;
                    @Roll.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnRoll;
                    @Roll.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnRoll;
                    @WeaponSwitch.started -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnWeaponSwitch;
                    @WeaponSwitch.performed -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnWeaponSwitch;
                    @WeaponSwitch.canceled -= m_Wrapper.m_RPGCharacterActionsCallbackInterface.OnWeaponSwitch;
                }
                m_Wrapper.m_RPGCharacterActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Facing.started += instance.OnFacing;
                    @Facing.performed += instance.OnFacing;
                    @Facing.canceled += instance.OnFacing;
                    @Targeting.started += instance.OnTargeting;
                    @Targeting.performed += instance.OnTargeting;
                    @Targeting.canceled += instance.OnTargeting;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Face.started += instance.OnFace;
                    @Face.performed += instance.OnFace;
                    @Face.canceled += instance.OnFace;
                    @AttackL.started += instance.OnAttackL;
                    @AttackL.performed += instance.OnAttackL;
                    @AttackL.canceled += instance.OnAttackL;
                    @AttackR.started += instance.OnAttackR;
                    @AttackR.performed += instance.OnAttackR;
                    @AttackR.canceled += instance.OnAttackR;
                    @KickL.started += instance.OnKickL;
                    @KickL.performed += instance.OnKickL;
                    @KickL.canceled += instance.OnKickL;
                    @KickR.started += instance.OnKickR;
                    @KickR.performed += instance.OnKickR;
                    @KickR.canceled += instance.OnKickR;
                    @Block.started += instance.OnBlock;
                    @Block.performed += instance.OnBlock;
                    @Block.canceled += instance.OnBlock;
                    @LightHit.started += instance.OnLightHit;
                    @LightHit.performed += instance.OnLightHit;
                    @LightHit.canceled += instance.OnLightHit;
                    @Death.started += instance.OnDeath;
                    @Death.performed += instance.OnDeath;
                    @Death.canceled += instance.OnDeath;
                    @Roll.started += instance.OnRoll;
                    @Roll.performed += instance.OnRoll;
                    @Roll.canceled += instance.OnRoll;
                    @WeaponSwitch.started += instance.OnWeaponSwitch;
                    @WeaponSwitch.performed += instance.OnWeaponSwitch;
                    @WeaponSwitch.canceled += instance.OnWeaponSwitch;
                }
            }
        }
        public RPGCharacterActions @RPGCharacter => new RPGCharacterActions(this);
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_MouseandKeyboardSchemeIndex = -1;
        public InputControlScheme MouseandKeyboardScheme
        {
            get
            {
                if (m_MouseandKeyboardSchemeIndex == -1) m_MouseandKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse and Keyboard");
                return asset.controlSchemes[m_MouseandKeyboardSchemeIndex];
            }
        }
        public interface IRPGCharacterActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnFacing(InputAction.CallbackContext context);
            void OnTargeting(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnFace(InputAction.CallbackContext context);
            void OnAttackL(InputAction.CallbackContext context);
            void OnAttackR(InputAction.CallbackContext context);
            void OnKickL(InputAction.CallbackContext context);
            void OnKickR(InputAction.CallbackContext context);
            void OnBlock(InputAction.CallbackContext context);
            void OnLightHit(InputAction.CallbackContext context);
            void OnDeath(InputAction.CallbackContext context);
            void OnRoll(InputAction.CallbackContext context);
            void OnWeaponSwitch(InputAction.CallbackContext context);
        }
    }
}
