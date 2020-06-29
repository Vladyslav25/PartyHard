using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "PlayersData", menuName = "ScObj/Data/Players", order = 1)]
public class PlayersData : ScriptableObject
{
    public List<BasePlayer> AllPlayers = new List<BasePlayer>();

    public int PlayerCount 
    {
        get
        {
            return AllPlayers.Count;
        }
        private set
        {
            PlayerCount = value;
        }
    }

    /// <summary>
    /// Add PlayerData to PlayersDate
    /// </summary>
    /// <param name="_player">The Player to add</param>
    /// <returns>retrun true if Player was added</returns>
    public bool AddPlayer(BasePlayer _player)
    {
        if (!AllPlayers.Contains(_player))
        {
            AllPlayers.Add(_player);
            return true;
        }
        return false;
    }

    /// <summary>
    /// Remove PlayerData to PlayersDate
    /// </summary>
    /// <param name="_player">The Player to remove</param>
    /// <returns>retrun true if Player was removed</returns>
    public bool RemovePlayer(BasePlayer _player)
    {
        if (!AllPlayers.Contains(_player))
        {
            AllPlayers.Remove(_player);
            return true;
        }
        return false;
    }

    /// <summary>
    /// Get the Player by ID
    /// </summary>
    /// <param name="_id">The ID the Player you looking for</param>
    /// <returns>The Player</returns>
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
