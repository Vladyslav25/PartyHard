using HotPotato;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;

public enum COLOR
{
    RED,
    BLUE,
    GREEN,
    YELLOW,

    NONE
}
public class BasePlayer
{
    public InputActionAsset m_inputActionRef { get; private set; } //Ref to the ActionMap
    public InputControlScheme m_ControlScheme { get; private set; } //The used ControlScheme
    public int m_Id { get; private set; } //The Player ID
    public COLOR m_color { get; private set; } // The Color the Player have
    public GameObject m_objRef { get; private set; } // The Ref to the GameObject of the Player

    private PlayerInput m_playerInputRef = null;

    /// <param name="_inputActionsRef">The Ref to the ActionMap</param>
    /// <param name="_playerInput">The Ref to the PlayerInput-Component</param>
    /// <param name="_controlScheme">The currend ControlScheme</param>
    /// <param name="_id">The Player ID</param>
    public BasePlayer(PlayerInput _playerInput, int _id)
    {
        SetPlayerInput(_playerInput);
        SetInputActionRef(_playerInput.actions);
        SetInputControlScheme(_playerInput.currentControlScheme);
        SetID(_id);
        m_color = (COLOR)_id;
    }

    private void SetPlayerInput(PlayerInput _playerInput)
    {
        if (_playerInput != null)
        {
            m_playerInputRef = _playerInput;
            m_objRef = _playerInput.gameObject;
        }
    }

    public void SetGameObjectRef(GameObject _obj)
    {
        if (_obj != null)
        {
            m_objRef = _obj;
            m_playerInputRef = _obj.GetComponent<PlayerInput>();
        }
    }

    public void SetInputActionRef(InputActionAsset _inputActionsRef)
    {
        m_inputActionRef = _inputActionsRef;
    }

    public bool SetInputControlScheme(string _name)
    {
        if (_name == "" || _name == null)
            return false;

        foreach (InputControlScheme cs in m_inputActionRef.controlSchemes)
            if (cs.name == _name)
            {
                m_ControlScheme = cs;
                return true;
            }

        return false;
    }

    public void SetID(int _id)
    {
        m_Id = _id;
    }

    /// <summary>
    /// Change the curendActionMap of the Player
    /// </summary>
    /// <param name="_actionMap">The ActionMap to Change</param>
    /// <returns>Retirn true if it change</returns>
    public bool SetActionMap(InputActionMap _actionMap)
    {
        foreach (InputActionMap AM in m_inputActionRef.actionMaps)
            if (AM == _actionMap)
            {
                m_playerInputRef.currentActionMap = _actionMap;
                return true;
            }
        return false;
    }
}
