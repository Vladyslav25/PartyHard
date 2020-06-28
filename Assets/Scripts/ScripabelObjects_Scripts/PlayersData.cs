using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayersData", menuName = "ScObj/Data/Players", order = 1)]
public class PlayersData : ScriptableObject
{
    public List<BasePlayer> AllPlayers = new List<BasePlayer>();

    public int PlayerCount
    {
        get
        {
            if (AllPlayers != null)
                return AllPlayers.Count;
            return 0;
        }
    }

    public bool AddPlayer(BasePlayer _player)
    {
        if (!AllPlayers.Contains(_player))
        {
            AllPlayers.Add(_player);
            return true;
        }
        return false;
    }

    public bool RemovePlayer(BasePlayer _player)
    {
        if (!AllPlayers.Contains(_player))
        {
            AllPlayers.Remove(_player);
            return true;
        }
        return false;
    }
}
