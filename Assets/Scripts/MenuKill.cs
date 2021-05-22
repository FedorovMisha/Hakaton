using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKill : MonoBehaviour
{
    public static GameObject KillMenu;

    public GameObject killMenuObj;


    // Start is called before the first frame update
    void Awake()
    {
        KillMenu = killMenuObj;
    }

    public void ReturnGame()
    {
        // Debug.Log(ChoiceTimer.GlobalTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
