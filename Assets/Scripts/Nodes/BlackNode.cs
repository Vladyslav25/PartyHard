using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Playfield.Node
{
    public class BlackNode : ANode
    {
        public BlackNode(Vector3 _pos, Grid _field) : base(_pos, _field)
        {

        }

        public BlackNode(Vector3 _pos, Grid _field, GameObject _obj) : base(_pos, _field, _obj)
        {

        }

        public override void Execute(Player _player)
        {
            throw new System.NotImplementedException();
        }
    }
}
