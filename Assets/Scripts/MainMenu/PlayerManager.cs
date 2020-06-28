using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MainMenu
{
    public class PlayerManager : MonoBehaviour
    {
        public InputActionAsset m_InputActionRef;

        private int count = -1;
        public void OnPlayerJoined(PlayerInput _playerInput)
        {
            count++;
            if (count < 4)
            {
                BasePlayer tmpPlayer = new BasePlayer(_playerInput.actions,
                                                        _playerInput.gameObject,
                                                        _playerInput.currentControlScheme,
                                                        (COLOR)count + 1,
                                                        count);

                DataManager.Instance.GetPlayerData().AddPlayer(tmpPlayer);
                PlayersData d = DataManager.Instance.GetPlayerData();

                if(_playerInput.currentControlScheme == null)
                {
                    Debug.Log("NoGameObj");
                }
                Debug.Log("Add PlayerID: " + tmpPlayer.m_Id + " Color: " + tmpPlayer.m_Color.ToString());
            }
        }
    }
}
