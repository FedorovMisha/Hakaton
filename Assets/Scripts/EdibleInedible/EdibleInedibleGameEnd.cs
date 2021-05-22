using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EdibleInedible
{
    public class EdibleInedibleGameEnd : IGameEnd
    {
        public void GameOver()
        {
            Debug.Log("GameOver");
            
            Debug.Log(SceneManager.GetActiveScene().buildIndex - 1);
            MovingBlock.Speed = 6f;
            Time.timeScale = 0;
            MenuKill.KillMenu.SetActive(true);
        }

        public void Next()
        {
            
        }
    }
}