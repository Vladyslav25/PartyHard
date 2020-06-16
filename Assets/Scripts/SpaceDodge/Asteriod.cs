using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDodge
{
    [RequireComponent(typeof(CircleCollider2D))]
    public class Asteriod : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.tag == "Player")
            {
                Destroy(collision.gameObject);
            }
            if(collision.transform.tag == "Despawner")
            {
                Destroy(gameObject);
            }
        }
    }
}
