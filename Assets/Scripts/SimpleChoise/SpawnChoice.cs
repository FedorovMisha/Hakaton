using System;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using UnityEngine;

namespace SimpleChoise
{
    public class SpawnChoice : MonoBehaviour, ISpawn
    {
        public List<Sprite> Sprites { get; set; }

        public List<ChoiceTypes> ChoiceTypesList { get; set; } =
            Enum.GetValues(typeof(ChoiceTypes)).Cast<ChoiceTypes>().ToList();

        public Vector3 MainChoiceCoordinate { get; set; }
        
        public GameObject ChoicePrefab { get; set; }

        public void Spawn()
        {
            var spawnObject = Instantiate(ChoicePrefab);

            var mainChoice = spawnObject.GetComponent<Choice>();
            
            
        }
    }
}