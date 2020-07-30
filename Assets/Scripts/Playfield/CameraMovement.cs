using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Playfield
{

    public class CameraMovement : MonoBehaviour
    {
        [SerializeField]
        Vector3 offset;

        bool isMoving = false;
        Vector3 destination;

        public void MoveCameraToPos(Vector3 _playerPos)
        {
            destination = _playerPos + offset;
            isMoving = true;
        }

        public void MoveCameraToPlayer(BasePlayer _player)
        {
            MoveCameraToPlayer(_player.m_Id);
        }

        public void MoveCameraToPlayer(int _id)
        {
            MoveCameraToPos(DataManager.Instance.GetPlayerData().GetPlayerByID(_id).m_objRef.transform.position);
        }

        private void Update()
        {
            if (isMoving)
            {
                transform.position = Vector3.MoveTowards(transform.position, destination, Time.deltaTime * 10f);
            }

            if (transform.position == destination)
            {
                isMoving = false;
            }
        }
    }
}
