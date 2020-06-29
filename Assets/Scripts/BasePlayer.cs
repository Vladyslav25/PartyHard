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
    public InputActionAsset m_inputActionRef { get; private set; }
    public InputControlScheme m_ControlScheme { get; private set; }
    public int m_Id { get; private set; }
    public COLOR m_color { get; private set; }

    private GameObject objRef;

    public BasePlayer(InputActionAsset _inputActionsRef, GameObject _objRef, string _controlScheme, int _id)
    {
        objRef = _objRef;
        SetInputActionRef(_inputActionsRef);
        SetInputControlScheme(_controlScheme);
        SetID(_id);
        m_color = (COLOR)_id;
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
}
