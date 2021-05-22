using System;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace SimpleChoise
{
    public class SpawnChoice : MonoBehaviour, ISpawn
    {
        private IGameEnd _gameEnd = new SimpleChoiceGameEnd();

        [FormerlySerializedAs("Choices")] public List<Choice> choices;

        [FormerlySerializedAs("SpawnPoints")] public List<Vector3> spawnPoints;

        [FormerlySerializedAs("WinPosition")] public Vector3 winPosition;
        
        private void Start()
        {
            Spawn();
        }

        public void Spawn()
        {
            var winIndex = Random.Range(0, choices.Count);
            var winObj = Instantiate(choices[winIndex]);
            winObj.Tap = _gameEnd.Next;
            winObj.transform.position = winPosition;
            winObj.transform.localScale = winObj.transform.localScale * 1.2f;
            
            
            var winChoiceObj = Instantiate(choices[winIndex]);
            var choicePoint = spawnPoints[Random.Range(0, spawnPoints.Count)];
            winChoiceObj.Tap = _gameEnd.Next;
            List<Vector3> copyPoints = new List<Vector3>(spawnPoints);
            List<Choice> copyChoices = new List<Choice>(choices);
            copyChoices.Remove(copyChoices[winIndex]);
            winChoiceObj.transform.position = choicePoint;
            copyPoints.Remove(choicePoint);
            
            while (copyPoints.Count > 0)
            {
                var spawnIndex = Random.Range(0, copyChoices.Count);
                var spawnObj = Instantiate(copyChoices[spawnIndex]);

                spawnObj.Tap = _gameEnd.GameOver;
                var point = copyPoints.FirstOrDefault();
                spawnObj.transform.position = point;

                copyPoints.Remove(point);
                copyChoices.Remove(copyChoices[spawnIndex]);

            }
        }
    }
}