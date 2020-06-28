using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;

public enum COLOR
{
    NONE,
    RED,
    BLUE,
    GREEN,
    YELLOW
}
public class BasePlayer
{
    public InputActionAsset m_inputActionRef { get; private set; }
    public InputControlScheme m_ControlScheme { get; private set; }
    public COLOR m_Color { get; private set; }
    public int m_Id { get; private set; }


    private GameObject objRef;

    public BasePlayer(InputActionAsset _inputActionsRef, GameObject _objRef, string _controlScheme, COLOR _color, int _id)
    {
        objRef = _objRef;
        SetInputActionRef(_inputActionsRef);
        SetInputControlScheme(_controlScheme);
        SetColor(_color);
        SetID(_id);
    }

    public void SetInputActionRef(InputActionAsset _inputActionsRef)
    {
        m_inputActionRef = _inputActionsRef;
    }

    public bool SetInputControlScheme(string _name)
    {
        if (_name == "" || _name == null)
            return false;
        if (m_inputActionRef.controlSchemes.Contains(new InputControlScheme(_name)))
        {
            return true;
        }
        return false;
    }

    public void SetColor(COLOR _color)
    {
        m_Color = _color;
    }

    public void SetID(int _id)
    {
        m_Id = _id;
    }
}
