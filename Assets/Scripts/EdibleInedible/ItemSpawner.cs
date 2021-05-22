using System;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using Random = UnityEngine.Random;

namespace EdibleInedible
{
    public class ItemSpawner : MonoBehaviour, ISpawn
    {

        [SerializeField] private List<GameObject> prefabs;

        private GameObject _currentObj;

        private void FixedUpdate()
        {
            Spawn();
        }

        public void Spawn()
        {
            if (_currentObj == null)
            {
                _currentObj = Instantiate(prefabs[Random.Range(0, prefabs.Count)]);

                _currentObj.transform.position = gameObject.transform.position;
            }
        }
    }
}