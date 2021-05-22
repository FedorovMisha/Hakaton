using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEditor.SearchService.Scene;

namespace SimpleChoise
{
    public class SimpleChoiceGameEnd : IGameEnd
    {
        public static SimpleChoiceGameEnd GameEnd { get => new SimpleChoiceGameEnd(); }

        public void GameOver()
        {
            SceneManager.LoadScene("LoseScene");
            Debug.Log("Lose");
        }

        public void Next()
        {
            GamePoints.SimpleChoise++;
            ChoiceTimer.GlobalTime -= 1f;
            // TODO Remake Reload 
            SceneManager.LoadScene("SimpleChoise");
            Debug.Log("win: " + GamePoints.SimpleChoise);
        }
    }
}