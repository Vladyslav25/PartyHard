using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class Player : MonoBehaviour
    {
        BasePlayer m_basePlayer;

        public void SetBasePlayer(BasePlayer _bPlayer)
        {
            if (_bPlayer != null)
                m_basePlayer = _bPlayer;
        }

        public void OnStart()
        {
            if (m_basePlayer != null)
                if (DataManager.Instance.GetPlayerData().PlayerCount > 1 && m_basePlayer.m_Id == 0)
                {
                    SceneManager.LoadScene("Playfield");
                }
        }
    }
}
