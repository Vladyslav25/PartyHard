using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MainMenu
{
    public class PlayerManager : MonoBehaviour
    {
        private int count = -1;
        public void OnPlayerJoined(PlayerInput _playerInput)
        {
            int  i = _playerInput.devices.Count;
            count++;
            if (count < 4)
            {
                BasePlayer tmpPlayer = new BasePlayer(_playerInput.actions,
                                                        _playerInput.gameObject,
                                                        _playerInput.currentControlScheme,
                                                        count);

                DataManager.Instance.GetPlayerData().AddPlayer(tmpPlayer);

                Debug.Log("Add PlayerID: " + tmpPlayer.m_Id+ " CS: " + tmpPlayer.m_ControlScheme.name);
            }
        }
    }
}
