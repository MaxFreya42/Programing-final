//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/PlayerController.inputactions
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

public partial class @PlayerController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""MainGamePlay"",
            ""id"": ""2b722f84-1dcf-44ed-a96e-e7479c962852"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""13496691-6ec6-4150-a30d-879c25f62c58"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Begin"",
                    ""type"": ""Button"",
                    ""id"": ""9454d890-6208-47d8-820d-62ae3c8649f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e875c53e-9bfc-4b3b-b17c-fdccf7763aca"",
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
                    ""id"": ""dcca5f2d-c809-4d05-ac58-fc4d36c51d76"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Begin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Permanent"",
            ""id"": ""81749f9e-079d-42b2-986b-d449d93b1d07"",
            ""actions"": [
                {
                    ""name"": ""MousePos"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e6ac221c-799e-4908-be17-31d822cbedd8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""15745c76-db7f-47f3-a4e3-48172c9a3fd7"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MainGamePlay
        m_MainGamePlay = asset.FindActionMap("MainGamePlay", throwIfNotFound: true);
        m_MainGamePlay_Look = m_MainGamePlay.FindAction("Look", throwIfNotFound: true);
        m_MainGamePlay_Begin = m_MainGamePlay.FindAction("Begin", throwIfNotFound: true);
        // Permanent
        m_Permanent = asset.FindActionMap("Permanent", throwIfNotFound: true);
        m_Permanent_MousePos = m_Permanent.FindAction("MousePos", throwIfNotFound: true);
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

    // MainGamePlay
    private readonly InputActionMap m_MainGamePlay;
    private List<IMainGamePlayActions> m_MainGamePlayActionsCallbackInterfaces = new List<IMainGamePlayActions>();
    private readonly InputAction m_MainGamePlay_Look;
    private readonly InputAction m_MainGamePlay_Begin;
    public struct MainGamePlayActions
    {
        private @PlayerController m_Wrapper;
        public MainGamePlayActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_MainGamePlay_Look;
        public InputAction @Begin => m_Wrapper.m_MainGamePlay_Begin;
        public InputActionMap Get() { return m_Wrapper.m_MainGamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainGamePlayActions set) { return set.Get(); }
        public void AddCallbacks(IMainGamePlayActions instance)
        {
            if (instance == null || m_Wrapper.m_MainGamePlayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MainGamePlayActionsCallbackInterfaces.Add(instance);
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Begin.started += instance.OnBegin;
            @Begin.performed += instance.OnBegin;
            @Begin.canceled += instance.OnBegin;
        }

        private void UnregisterCallbacks(IMainGamePlayActions instance)
        {
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Begin.started -= instance.OnBegin;
            @Begin.performed -= instance.OnBegin;
            @Begin.canceled -= instance.OnBegin;
        }

        public void RemoveCallbacks(IMainGamePlayActions instance)
        {
            if (m_Wrapper.m_MainGamePlayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMainGamePlayActions instance)
        {
            foreach (var item in m_Wrapper.m_MainGamePlayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MainGamePlayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MainGamePlayActions @MainGamePlay => new MainGamePlayActions(this);

    // Permanent
    private readonly InputActionMap m_Permanent;
    private List<IPermanentActions> m_PermanentActionsCallbackInterfaces = new List<IPermanentActions>();
    private readonly InputAction m_Permanent_MousePos;
    public struct PermanentActions
    {
        private @PlayerController m_Wrapper;
        public PermanentActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePos => m_Wrapper.m_Permanent_MousePos;
        public InputActionMap Get() { return m_Wrapper.m_Permanent; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PermanentActions set) { return set.Get(); }
        public void AddCallbacks(IPermanentActions instance)
        {
            if (instance == null || m_Wrapper.m_PermanentActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PermanentActionsCallbackInterfaces.Add(instance);
            @MousePos.started += instance.OnMousePos;
            @MousePos.performed += instance.OnMousePos;
            @MousePos.canceled += instance.OnMousePos;
        }

        private void UnregisterCallbacks(IPermanentActions instance)
        {
            @MousePos.started -= instance.OnMousePos;
            @MousePos.performed -= instance.OnMousePos;
            @MousePos.canceled -= instance.OnMousePos;
        }

        public void RemoveCallbacks(IPermanentActions instance)
        {
            if (m_Wrapper.m_PermanentActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPermanentActions instance)
        {
            foreach (var item in m_Wrapper.m_PermanentActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PermanentActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PermanentActions @Permanent => new PermanentActions(this);
    public interface IMainGamePlayActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnBegin(InputAction.CallbackContext context);
    }
    public interface IPermanentActions
    {
        void OnMousePos(InputAction.CallbackContext context);
    }
}
