using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDodge
{
    public class Spawner : MonoBehaviour
    {
        [Header("Prefabs")]
        [SerializeField]
        private GameObject AsteroidPrefab;
        [Header("Settings")]
        [SerializeField]
        private float minTime;
        [SerializeField]
        private float maxTime;
        [SerializeField]
        private int SpeedImprove;

        private int level = 0;

        private int speed = 100;
        private float speedTimer = 0;

        private float spawnTimer = 0;
        private float fixSpawnTimer = 0;
        void Start()
        {
            SetRandomTime();
        }

        void Update()
        {
            speedTimer += Time.deltaTime;
            if (speedTimer > 7f)
            {
                speed += SpeedImprove;
                speedTimer = 0;
                level++;
                if (level % 2 == 0)
                {
                    if (maxTime > 0.3f)
                        maxTime -= 0.35f;
                    if (minTime > 0.2f)
                        minTime -= 0.15f;
                }
                Debug.Log(speed);
            }

            spawnTimer += Time.deltaTime;
            if (spawnTimer > fixSpawnTimer)
            {
                spawnTimer = 0;

                SpawnAsteroid();
                SetRandomTime();
            }
        }

        private void SpawnAsteroid()
        {
            GameObject tmp = Instantiate(AsteroidPrefab, new Vector3(12f, UnityEngine.Random.Range(-3, 6), 0), new Quaternion(0, 0, 0, 0), transform);
            tmp.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * speed);
        }

        private void SetRandomTime()
        {
            fixSpawnTimer = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}
