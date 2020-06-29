using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "PlayersData", menuName = "ScObj/Data/Players", order = 1)]
public class PlayersData : ScriptableObject
{
    public List<BasePlayer> AllPlayers = new List<BasePlayer>();

    public int PlayerCount = 0;

    public bool AddPlayer(BasePlayer _player)
    {
        if (!AllPlayers.Contains(_player))
        {
            AllPlayers.Add(_player);
            PlayerCount++;
            return true;
        }
        return false;
    }

    public bool RemovePlayer(BasePlayer _player)
    {
        if (!AllPlayers.Contains(_player))
        {
            AllPlayers.Remove(_player);
            PlayerCount--;
            return true;
        }
        return false;
    }

    public BasePlayer GetPlayerByID(int _id)
    {
        foreach (BasePlayer player in AllPlayers)
        {
            if (player.m_Id == _id)
                return player;
        }
        return null;
    }
}
