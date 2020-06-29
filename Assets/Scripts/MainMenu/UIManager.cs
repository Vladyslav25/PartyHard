using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MainMenu
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        CanvasGroup[] m_PlayerSlots = new CanvasGroup[4];

        [SerializeField]
        Text[] m_PlayerSlotsText = new Text[4];

        [SerializeField]
        CanvasGroup m_Continue;

        private void Awake()
        {
            foreach (CanvasGroup cg in m_PlayerSlots)
            {
                cg.alpha = 0f;
            }
            m_Continue.alpha = 0f;
        }

        public void AddPlayer(BasePlayer _player)
        {
            if (_player == null) return;
            m_PlayerSlots[_player.m_Id].alpha = 1f;
            m_PlayerSlotsText[_player.m_Id].text = _player.m_ControlScheme.name;

            if (_player.m_Id == 0)
            {
                if (_player.m_ControlScheme.name == "Keyboard")
                    m_Continue.GetComponentInChildren<Text>().text = "Player 1 - Press 'Space' to Start";
                else
                    m_Continue.GetComponentInChildren<Text>().text = "Player 1 - Press 'Start' to Start";
            }

            if (DataManager.Instance.GetPlayerData().PlayerCount > 1)
            {
                m_Continue.alpha = 1f;
            }
        }
    }
}
