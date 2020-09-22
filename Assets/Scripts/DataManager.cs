using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField]
    private PlayfieldData playfieldDataRef;
    [SerializeField]
    private HoverEffectSettings hoverEffectSettingRef;
    [SerializeField]
    private PlayersData playerDataRef;

    private static DataManager m_instance;

    public static DataManager Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = FindObjectOfType<DataManager>();

                if (m_instance == null)
                {
                    GameObject container = new GameObject("DataManager");
                    m_instance = container.AddComponent<DataManager>();
                }
            }
            return m_instance;
        }
    }
    private void Awake()
    {
        if (m_instance != null && m_instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            m_instance = this;

            SetPlayfieldData(playfieldDataRef);
            SetHoverEffectSettings(hoverEffectSettingRef);
            SetPlayerDataRef(playerDataRef);

            ResetData();

            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void ResetData()
    {
        playfieldDataRef.Round = 0;
    }

    public PlayfieldData GetPlayfiledData()
    {
        if (playfieldDataRef != null)
            return playfieldDataRef;
        return null;
    }

    public void SetPlayfieldData(PlayfieldData _dataRef)
    {
        playfieldDataRef = _dataRef;
    }

    public HoverEffectSettings GetHoverEffectSettings()
    {
        if (hoverEffectSettingRef != null)
            return hoverEffectSettingRef;
        return null;
    }

    public void SetHoverEffectSettings(HoverEffectSettings _dataRef)
    {
        hoverEffectSettingRef = _dataRef;
    }

    public PlayersData GetPlayerData()
    {
        if (playerDataRef != null)
            return playerDataRef;
        return null;
    }

    public void SetPlayerDataRef(PlayersData _dataref)
    {
        playerDataRef = _dataref;
    }
}
