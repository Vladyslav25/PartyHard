using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField]
    private PlayfieldData playfieldDataRef;
    [SerializeField]
    private HoverEffectSettings hoverEffectSettingRef;

    private static DataManager m_instance;

    private static PlayfieldData playfieldData;
    private static HoverEffectSettings hoverEffectSetting;

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

            DontDestroyOnLoad(this.gameObject);
        }
    }

    public static PlayfieldData GetPlayfiledData()
    {
        if (playfieldData != null)
            return playfieldData;
        return null;
    }

    public static void SetPlayfieldData(PlayfieldData _dataRef)
    {
        playfieldData = _dataRef;
    }

    public static HoverEffectSettings GetHoverEffectSettings()
    {
        if (hoverEffectSetting != null)
            return hoverEffectSetting;
        return null;
    }

    public static void SetHoverEffectSettings(HoverEffectSettings _dataRef)
    {
        hoverEffectSetting = _dataRef;
    }

}
