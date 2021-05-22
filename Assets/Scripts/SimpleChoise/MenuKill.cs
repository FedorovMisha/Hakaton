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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
