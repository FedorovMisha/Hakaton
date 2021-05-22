using DefaultNamespace;
using UnityEngine.SceneManagement;

namespace EdibleInedible
{
    public class EdibleInedibleGameEnd : IGameEnd
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