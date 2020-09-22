using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Playfield.Node
{
    public class BlueNode : ANode
    {
        public BlueNode(Vector3 _pos, Grid _field) : base(_pos, _field)
        {

        }

        public BlueNode(Vector3 _pos, Grid _field, GameObject _obj) : base(_pos, _field, _obj)
        {

        }

        public override void Execute(Player _player)
        {
            throw new System.NotImplementedException();
        }
    }
}
