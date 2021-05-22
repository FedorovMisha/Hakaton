using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FlappyBird
{
    public class FlappyBirdGameEnd :IGameEnd
    {
        public void GameOver()
        {
            SceneManager.LoadScene("LoseScene");
        }

        public void Next()
        {
            
        }
    }
}