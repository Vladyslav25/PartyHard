using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private PlayerInputManager m_inputManager;

    private Vector3 m_startPoint = new Vector3(7, 1, 7);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPlayerJoined(PlayerInput _playerInput)
    {
        _playerInput.transform.position = m_startPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
