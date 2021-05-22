using DefaultNamespace;
using UnityEngine;

namespace SimpleChoise
{
    public class SimpleChoiceGameEnd : IGameEnd
    {
        public static SimpleChoiceGameEnd GameEnd { get => new SimpleChoiceGameEnd(); }

        public void GameOver()
        {
            Debug.Log("Lose");
        }

        public void Next()
        {
            Debug.Log("win");
        }
    }
}