using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Playfield
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        private Transform pointsParentTrans;

        [SerializeField]
        private GameObject pointsPrefabObj;

        [SerializeField]
        private Text movePointsText;

        [SerializeField]
        private Text newDirText;

        private static UIManager m_instance;

        public static UIManager Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = FindObjectOfType<UIManager>();

                    if (m_instance == null)
                    {
                        GameObject container = new GameObject("UIManager");
                        m_instance = container.AddComponent<UIManager>();
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
            }

            for (int i = 0; i < DataManager.Instance.GetPlayerData().PlayerCount; i++)
            {
                BasePlayer bp = DataManager.Instance.GetPlayerData().GetPlayerByID(i);
                GameObject uiElement = Instantiate(pointsPrefabObj, pointsParentTrans);
                Text txt = uiElement.GetComponent<Text>();
                txt.text = bp.m_Points.ToString() +" Points";
                switch (bp.m_color)
                {
                    case COLOR.RED:
                        txt.color = Color.red;
                        break;
                    case COLOR.BLUE:
                        txt.color = Color.blue;
                        break;
                    case COLOR.GREEN:
                        txt.color = Color.green;
                        break;
                    case COLOR.YELLOW:
                        txt.color = Color.yellow;
                        break;
                    case COLOR.NONE:
                    default:
                        txt.gameObject.SetActive(false);
                        break;
                }
            }
            ClearMovePoints();
            SetNewDirText(false);
        }

        public void SetMovePoints(int _nummber)
        {
            int nummber = _nummber;
            if (_nummber < 0)
            {
                nummber = 0;
            }
            movePointsText.text = $"{nummber} Moves";
        }

        public void ClearMovePoints()
        {
            movePointsText.text = "";
        }

        public bool IsNewDirTextActiv()
        {
            return newDirText.gameObject.activeSelf;
        }

        public void SetNewDirText(bool _activ)
        {
            newDirText.gameObject.SetActive(_activ);
        }
    }
}
