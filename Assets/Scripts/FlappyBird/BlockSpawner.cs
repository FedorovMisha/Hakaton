using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace FlappyBird
{
    public class BlockSpawner : MonoBehaviour, ISpawn
    {
        [FormerlySerializedAs("SpawnPositions")] public List<Vector3> spawnPositions;
        
        public float Duration
        {
            get => 10f - MovingBlock.Speed;
        }

        [SerializeField] private GameObject prefab;

        private void Start()
        {
            Spawn();
        }
        
        public void Spawn()
        {
            StartCoroutine(SpawnBlocks());
            
        }

        private IEnumerator SpawnBlocks()
        {
            while (true)
            {
                var obj = Instantiate(prefab);

                obj.transform.position = spawnPositions[Random.Range(0, spawnPositions.Count)];

                yield return new WaitForSeconds(Duration * 0.3f);
            }
        }
        
    }
}