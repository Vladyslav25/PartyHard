using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor;
using UnityEngine;

namespace Playfield.Node
{
    public abstract class ANode
    {
        public ANode Above = null;
        public ANode Under = null;
        public ANode Left = null;
        public ANode Right = null;

        public GameObject obj;

        public Vector3 Pos;
        private Grid m_field;

        public ANode(Vector3 _pos, Grid _field, GameObject _obj = null)
        {
            Pos = _pos;
            m_field = _field;
            obj = _obj;

            if (_obj != null)
            {
                HoverEffect HE = obj.transform.GetComponentInChildren<HoverEffect>();
                if (HE != null)
                {
                    HE.Speed = m_field.GridSetting.Speed;
                    HE.Offset = m_field.GridSetting.Offset;
                }
            }
        }

        public virtual void SetObjectRef(GameObject _obj)
        {
            obj = _obj;
        }

        public abstract void Execute(Player _player);

        public virtual void PrintNeighbor()
        {
            string output = "";
            if(Above != null)
            {
                output += $" | Above: {Above.Pos}";
            }
            if (Under != null)
            {
                output += $" | Under: {Under.Pos}";
            }
            if (Right != null)
            {
                output += $" | Right: {Right.Pos}";
            }
            if (Left != null)
            {
                output += $" | Left: {Left.Pos}";
            }
            Debug.Log($"Pos: {Pos}{output}");
        }
    }
}
