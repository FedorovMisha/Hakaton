using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEditor.SearchService.Scene;

namespace SimpleChoise
{
     

    public class SimpleChoiceGameEnd : MonoBehaviour, IGameEnd
    {

        private  GameObject _menuKill;
        public static SimpleChoiceGameEnd GameEnd { get => new SimpleChoiceGameEnd(); }
    

        public void GameOver()
        {
            _menuKill = MenuKill.KillMenu;
            Time.timeScale = 0;
            _menuKill.SetActive(true);
        }

        public void Next()
        {
           GamePoints.SimpleChoiсe++;
            ChoiceTimer.GlobalTime -= 1f;
            // TODO Remake Reload 
            SceneManager.LoadScene("SimpleChoise");
            Debug.Log("win: " + GamePoints.SimpleChoiсe);
        }
    }
}