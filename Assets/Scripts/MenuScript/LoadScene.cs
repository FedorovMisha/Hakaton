using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame1()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayGame2()
    {
        SceneManager.LoadScene(2);
    }


    public void PlayGame3()
    {
        SceneManager.LoadScene(3);
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
