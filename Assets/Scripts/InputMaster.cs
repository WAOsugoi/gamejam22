//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Scripts/InputMaster.inputactions
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
            ""name"": ""Stove1"",
            ""id"": ""06868ed6-696c-4715-98f3-b3a49201c4e8"",
            ""actions"": [
                {
                    ""name"": ""SwitchOn"",
                    ""type"": ""Button"",
                    ""id"": ""6c3e5d81-b591-4d45-86ac-803e75363d46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchOff"",
                    ""type"": ""Button"",
                    ""id"": ""d583348a-47ec-4bc7-b443-20fa1bcbc8d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""730446d4-aa99-4a21-b09c-125df382656c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""218633d4-62ca-45d8-bc69-7c48a1eeae03"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Stove2"",
            ""id"": ""b866b10e-0ec1-4329-99e3-65905399ed50"",
            ""actions"": [
                {
                    ""name"": ""SwitchOn"",
                    ""type"": ""Button"",
                    ""id"": ""fc141e41-35ba-4de1-a3de-1e79a0621577"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchOff"",
                    ""type"": ""Button"",
                    ""id"": ""d7895fe3-7cd8-454c-b4ce-827e07dde0c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7ec6daa7-c29e-42f6-ab82-b6bcab1bebb3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d326018f-eb69-4115-8bf6-942c160be2ba"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Stove3"",
            ""id"": ""d06b3611-3dd7-44e4-b3ed-a68f561f3ed9"",
            ""actions"": [
                {
                    ""name"": ""SwitchOn"",
                    ""type"": ""Button"",
                    ""id"": ""5e38eb8a-d59b-4db0-84e4-dcfb5408865b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchOff"",
                    ""type"": ""Button"",
                    ""id"": ""2e12ce54-ff11-487f-8314-6cc483ac9815"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c7fd0615-c8d6-4ee9-95df-a16f39231407"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88fe44f9-c72a-49ab-a07f-126ed41e2d83"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Stove4"",
            ""id"": ""ddc5a6b5-69cc-4c60-84a0-bd5452ab8991"",
            ""actions"": [
                {
                    ""name"": ""SwitchOn"",
                    ""type"": ""Button"",
                    ""id"": ""73294e3c-09e7-48df-abca-978990f09182"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchOff"",
                    ""type"": ""Button"",
                    ""id"": ""1849fe5b-4894-497e-b439-57d6b8065529"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""709126fe-f5cc-449c-8adb-4300ca89884b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f46bded5-702c-4779-9254-3e181e4672ed"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""New action map"",
            ""id"": ""2c5e8d35-1ad5-4c86-a686-bd94c3ad4cbb"",
            ""actions"": [
                {
                    ""name"": ""CAT_SwitchListText"",
                    ""type"": ""Button"",
                    ""id"": ""bec78854-c430-4eb2-9777-5e9b7abdeacb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""177753b7-380a-4bb7-b986-2122ff1dcb91"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CAT_SwitchListText"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Key1"",
            ""id"": ""739f6823-1de6-4a8e-b9cd-6c2c46636ec8"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""ef808e5c-4bd4-4825-9675-d15b529a2416"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6708caea-d9ab-42c0-91c0-7ff6265e8ed0"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Key2"",
            ""id"": ""1ae31844-c595-4e37-8c68-ced57f2bd2ed"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""2ef6146b-f32c-4614-81b5-cd979bd93667"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ec9895bf-e9b0-4097-bf39-06e7f174efcb"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Key3"",
            ""id"": ""07ebaa4b-6a19-4170-b1ad-e4f3486c89fa"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""4631ef0c-6659-42d1-928e-8f0d551927fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ec44f00a-1be6-47d8-afa4-56d9faefcc0f"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Key4"",
            ""id"": ""c5e5c654-6195-48ce-8321-7c1dfebdc027"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""2f474dd0-2b45-4978-8c39-a191c9a6f581"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2e1cb8c3-d0b2-445e-9b28-216bc12b61b3"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Stove1
        m_Stove1 = asset.FindActionMap("Stove1", throwIfNotFound: true);
        m_Stove1_SwitchOn = m_Stove1.FindAction("SwitchOn", throwIfNotFound: true);
        m_Stove1_SwitchOff = m_Stove1.FindAction("SwitchOff", throwIfNotFound: true);
        // Stove2
        m_Stove2 = asset.FindActionMap("Stove2", throwIfNotFound: true);
        m_Stove2_SwitchOn = m_Stove2.FindAction("SwitchOn", throwIfNotFound: true);
        m_Stove2_SwitchOff = m_Stove2.FindAction("SwitchOff", throwIfNotFound: true);
        // Stove3
        m_Stove3 = asset.FindActionMap("Stove3", throwIfNotFound: true);
        m_Stove3_SwitchOn = m_Stove3.FindAction("SwitchOn", throwIfNotFound: true);
        m_Stove3_SwitchOff = m_Stove3.FindAction("SwitchOff", throwIfNotFound: true);
        // Stove4
        m_Stove4 = asset.FindActionMap("Stove4", throwIfNotFound: true);
        m_Stove4_SwitchOn = m_Stove4.FindAction("SwitchOn", throwIfNotFound: true);
        m_Stove4_SwitchOff = m_Stove4.FindAction("SwitchOff", throwIfNotFound: true);
        // New action map
        m_Newactionmap = asset.FindActionMap("New action map", throwIfNotFound: true);
        m_Newactionmap_CAT_SwitchListText = m_Newactionmap.FindAction("CAT_SwitchListText", throwIfNotFound: true);
        // Key1
        m_Key1 = asset.FindActionMap("Key1", throwIfNotFound: true);
        m_Key1_Newaction = m_Key1.FindAction("New action", throwIfNotFound: true);
        // Key2
        m_Key2 = asset.FindActionMap("Key2", throwIfNotFound: true);
        m_Key2_Newaction = m_Key2.FindAction("New action", throwIfNotFound: true);
        // Key3
        m_Key3 = asset.FindActionMap("Key3", throwIfNotFound: true);
        m_Key3_Newaction = m_Key3.FindAction("New action", throwIfNotFound: true);
        // Key4
        m_Key4 = asset.FindActionMap("Key4", throwIfNotFound: true);
        m_Key4_Newaction = m_Key4.FindAction("New action", throwIfNotFound: true);
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

    // Stove1
    private readonly InputActionMap m_Stove1;
    private IStove1Actions m_Stove1ActionsCallbackInterface;
    private readonly InputAction m_Stove1_SwitchOn;
    private readonly InputAction m_Stove1_SwitchOff;
    public struct Stove1Actions
    {
        private @InputMaster m_Wrapper;
        public Stove1Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwitchOn => m_Wrapper.m_Stove1_SwitchOn;
        public InputAction @SwitchOff => m_Wrapper.m_Stove1_SwitchOff;
        public InputActionMap Get() { return m_Wrapper.m_Stove1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Stove1Actions set) { return set.Get(); }
        public void SetCallbacks(IStove1Actions instance)
        {
            if (m_Wrapper.m_Stove1ActionsCallbackInterface != null)
            {
                @SwitchOn.started -= m_Wrapper.m_Stove1ActionsCallbackInterface.OnSwitchOn;
                @SwitchOn.performed -= m_Wrapper.m_Stove1ActionsCallbackInterface.OnSwitchOn;
                @SwitchOn.canceled -= m_Wrapper.m_Stove1ActionsCallbackInterface.OnSwitchOn;
                @SwitchOff.started -= m_Wrapper.m_Stove1ActionsCallbackInterface.OnSwitchOff;
                @SwitchOff.performed -= m_Wrapper.m_Stove1ActionsCallbackInterface.OnSwitchOff;
                @SwitchOff.canceled -= m_Wrapper.m_Stove1ActionsCallbackInterface.OnSwitchOff;
            }
            m_Wrapper.m_Stove1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SwitchOn.started += instance.OnSwitchOn;
                @SwitchOn.performed += instance.OnSwitchOn;
                @SwitchOn.canceled += instance.OnSwitchOn;
                @SwitchOff.started += instance.OnSwitchOff;
                @SwitchOff.performed += instance.OnSwitchOff;
                @SwitchOff.canceled += instance.OnSwitchOff;
            }
        }
    }
    public Stove1Actions @Stove1 => new Stove1Actions(this);

    // Stove2
    private readonly InputActionMap m_Stove2;
    private IStove2Actions m_Stove2ActionsCallbackInterface;
    private readonly InputAction m_Stove2_SwitchOn;
    private readonly InputAction m_Stove2_SwitchOff;
    public struct Stove2Actions
    {
        private @InputMaster m_Wrapper;
        public Stove2Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwitchOn => m_Wrapper.m_Stove2_SwitchOn;
        public InputAction @SwitchOff => m_Wrapper.m_Stove2_SwitchOff;
        public InputActionMap Get() { return m_Wrapper.m_Stove2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Stove2Actions set) { return set.Get(); }
        public void SetCallbacks(IStove2Actions instance)
        {
            if (m_Wrapper.m_Stove2ActionsCallbackInterface != null)
            {
                @SwitchOn.started -= m_Wrapper.m_Stove2ActionsCallbackInterface.OnSwitchOn;
                @SwitchOn.performed -= m_Wrapper.m_Stove2ActionsCallbackInterface.OnSwitchOn;
                @SwitchOn.canceled -= m_Wrapper.m_Stove2ActionsCallbackInterface.OnSwitchOn;
                @SwitchOff.started -= m_Wrapper.m_Stove2ActionsCallbackInterface.OnSwitchOff;
                @SwitchOff.performed -= m_Wrapper.m_Stove2ActionsCallbackInterface.OnSwitchOff;
                @SwitchOff.canceled -= m_Wrapper.m_Stove2ActionsCallbackInterface.OnSwitchOff;
            }
            m_Wrapper.m_Stove2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SwitchOn.started += instance.OnSwitchOn;
                @SwitchOn.performed += instance.OnSwitchOn;
                @SwitchOn.canceled += instance.OnSwitchOn;
                @SwitchOff.started += instance.OnSwitchOff;
                @SwitchOff.performed += instance.OnSwitchOff;
                @SwitchOff.canceled += instance.OnSwitchOff;
            }
        }
    }
    public Stove2Actions @Stove2 => new Stove2Actions(this);

    // Stove3
    private readonly InputActionMap m_Stove3;
    private IStove3Actions m_Stove3ActionsCallbackInterface;
    private readonly InputAction m_Stove3_SwitchOn;
    private readonly InputAction m_Stove3_SwitchOff;
    public struct Stove3Actions
    {
        private @InputMaster m_Wrapper;
        public Stove3Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwitchOn => m_Wrapper.m_Stove3_SwitchOn;
        public InputAction @SwitchOff => m_Wrapper.m_Stove3_SwitchOff;
        public InputActionMap Get() { return m_Wrapper.m_Stove3; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Stove3Actions set) { return set.Get(); }
        public void SetCallbacks(IStove3Actions instance)
        {
            if (m_Wrapper.m_Stove3ActionsCallbackInterface != null)
            {
                @SwitchOn.started -= m_Wrapper.m_Stove3ActionsCallbackInterface.OnSwitchOn;
                @SwitchOn.performed -= m_Wrapper.m_Stove3ActionsCallbackInterface.OnSwitchOn;
                @SwitchOn.canceled -= m_Wrapper.m_Stove3ActionsCallbackInterface.OnSwitchOn;
                @SwitchOff.started -= m_Wrapper.m_Stove3ActionsCallbackInterface.OnSwitchOff;
                @SwitchOff.performed -= m_Wrapper.m_Stove3ActionsCallbackInterface.OnSwitchOff;
                @SwitchOff.canceled -= m_Wrapper.m_Stove3ActionsCallbackInterface.OnSwitchOff;
            }
            m_Wrapper.m_Stove3ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SwitchOn.started += instance.OnSwitchOn;
                @SwitchOn.performed += instance.OnSwitchOn;
                @SwitchOn.canceled += instance.OnSwitchOn;
                @SwitchOff.started += instance.OnSwitchOff;
                @SwitchOff.performed += instance.OnSwitchOff;
                @SwitchOff.canceled += instance.OnSwitchOff;
            }
        }
    }
    public Stove3Actions @Stove3 => new Stove3Actions(this);

    // Stove4
    private readonly InputActionMap m_Stove4;
    private IStove4Actions m_Stove4ActionsCallbackInterface;
    private readonly InputAction m_Stove4_SwitchOn;
    private readonly InputAction m_Stove4_SwitchOff;
    public struct Stove4Actions
    {
        private @InputMaster m_Wrapper;
        public Stove4Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwitchOn => m_Wrapper.m_Stove4_SwitchOn;
        public InputAction @SwitchOff => m_Wrapper.m_Stove4_SwitchOff;
        public InputActionMap Get() { return m_Wrapper.m_Stove4; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Stove4Actions set) { return set.Get(); }
        public void SetCallbacks(IStove4Actions instance)
        {
            if (m_Wrapper.m_Stove4ActionsCallbackInterface != null)
            {
                @SwitchOn.started -= m_Wrapper.m_Stove4ActionsCallbackInterface.OnSwitchOn;
                @SwitchOn.performed -= m_Wrapper.m_Stove4ActionsCallbackInterface.OnSwitchOn;
                @SwitchOn.canceled -= m_Wrapper.m_Stove4ActionsCallbackInterface.OnSwitchOn;
                @SwitchOff.started -= m_Wrapper.m_Stove4ActionsCallbackInterface.OnSwitchOff;
                @SwitchOff.performed -= m_Wrapper.m_Stove4ActionsCallbackInterface.OnSwitchOff;
                @SwitchOff.canceled -= m_Wrapper.m_Stove4ActionsCallbackInterface.OnSwitchOff;
            }
            m_Wrapper.m_Stove4ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SwitchOn.started += instance.OnSwitchOn;
                @SwitchOn.performed += instance.OnSwitchOn;
                @SwitchOn.canceled += instance.OnSwitchOn;
                @SwitchOff.started += instance.OnSwitchOff;
                @SwitchOff.performed += instance.OnSwitchOff;
                @SwitchOff.canceled += instance.OnSwitchOff;
            }
        }
    }
    public Stove4Actions @Stove4 => new Stove4Actions(this);

    // New action map
    private readonly InputActionMap m_Newactionmap;
    private INewactionmapActions m_NewactionmapActionsCallbackInterface;
    private readonly InputAction m_Newactionmap_CAT_SwitchListText;
    public struct NewactionmapActions
    {
        private @InputMaster m_Wrapper;
        public NewactionmapActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @CAT_SwitchListText => m_Wrapper.m_Newactionmap_CAT_SwitchListText;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NewactionmapActions set) { return set.Get(); }
        public void SetCallbacks(INewactionmapActions instance)
        {
            if (m_Wrapper.m_NewactionmapActionsCallbackInterface != null)
            {
                @CAT_SwitchListText.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnCAT_SwitchListText;
                @CAT_SwitchListText.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnCAT_SwitchListText;
                @CAT_SwitchListText.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnCAT_SwitchListText;
            }
            m_Wrapper.m_NewactionmapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CAT_SwitchListText.started += instance.OnCAT_SwitchListText;
                @CAT_SwitchListText.performed += instance.OnCAT_SwitchListText;
                @CAT_SwitchListText.canceled += instance.OnCAT_SwitchListText;
            }
        }
    }
    public NewactionmapActions @Newactionmap => new NewactionmapActions(this);

    // Key1
    private readonly InputActionMap m_Key1;
    private IKey1Actions m_Key1ActionsCallbackInterface;
    private readonly InputAction m_Key1_Newaction;
    public struct Key1Actions
    {
        private @InputMaster m_Wrapper;
        public Key1Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Key1_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Key1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Key1Actions set) { return set.Get(); }
        public void SetCallbacks(IKey1Actions instance)
        {
            if (m_Wrapper.m_Key1ActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_Key1ActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_Key1ActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_Key1ActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_Key1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public Key1Actions @Key1 => new Key1Actions(this);

    // Key2
    private readonly InputActionMap m_Key2;
    private IKey2Actions m_Key2ActionsCallbackInterface;
    private readonly InputAction m_Key2_Newaction;
    public struct Key2Actions
    {
        private @InputMaster m_Wrapper;
        public Key2Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Key2_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Key2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Key2Actions set) { return set.Get(); }
        public void SetCallbacks(IKey2Actions instance)
        {
            if (m_Wrapper.m_Key2ActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_Key2ActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_Key2ActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_Key2ActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_Key2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public Key2Actions @Key2 => new Key2Actions(this);

    // Key3
    private readonly InputActionMap m_Key3;
    private IKey3Actions m_Key3ActionsCallbackInterface;
    private readonly InputAction m_Key3_Newaction;
    public struct Key3Actions
    {
        private @InputMaster m_Wrapper;
        public Key3Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Key3_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Key3; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Key3Actions set) { return set.Get(); }
        public void SetCallbacks(IKey3Actions instance)
        {
            if (m_Wrapper.m_Key3ActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_Key3ActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_Key3ActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_Key3ActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_Key3ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public Key3Actions @Key3 => new Key3Actions(this);

    // Key4
    private readonly InputActionMap m_Key4;
    private IKey4Actions m_Key4ActionsCallbackInterface;
    private readonly InputAction m_Key4_Newaction;
    public struct Key4Actions
    {
        private @InputMaster m_Wrapper;
        public Key4Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Key4_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Key4; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Key4Actions set) { return set.Get(); }
        public void SetCallbacks(IKey4Actions instance)
        {
            if (m_Wrapper.m_Key4ActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_Key4ActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_Key4ActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_Key4ActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_Key4ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public Key4Actions @Key4 => new Key4Actions(this);
    public interface IStove1Actions
    {
        void OnSwitchOn(InputAction.CallbackContext context);
        void OnSwitchOff(InputAction.CallbackContext context);
    }
    public interface IStove2Actions
    {
        void OnSwitchOn(InputAction.CallbackContext context);
        void OnSwitchOff(InputAction.CallbackContext context);
    }
    public interface IStove3Actions
    {
        void OnSwitchOn(InputAction.CallbackContext context);
        void OnSwitchOff(InputAction.CallbackContext context);
    }
    public interface IStove4Actions
    {
        void OnSwitchOn(InputAction.CallbackContext context);
        void OnSwitchOff(InputAction.CallbackContext context);
    }
    public interface INewactionmapActions
    {
        void OnCAT_SwitchListText(InputAction.CallbackContext context);
    }
    public interface IKey1Actions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IKey2Actions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IKey3Actions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IKey4Actions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
