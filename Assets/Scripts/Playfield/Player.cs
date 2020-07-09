using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Playfield
{
    public class Player : MonoBehaviour
    {
        public BasePlayer m_BasePlayer;
        public int Points { get; private set; }

        public void SetBasePlayer(int _id)
        {
            m_BasePlayer = DataManager.Instance.GetPlayerData().GetPlayerByID(_id);
        }

        public void SetBasePlayer(BasePlayer _bPlayer)
        {
            m_BasePlayer = _bPlayer;
        }

        public void OnMove(InputValue _value)
        {
            Vector2 move = _value.Get<Vector2>();
            Debug.Log(m_BasePlayer.m_Id + " Move " + move);
        }
    }
}
