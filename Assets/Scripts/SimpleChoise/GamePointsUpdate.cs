using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePointsUpdate : MonoBehaviour
{
    private Text _text;
    
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _text.text = "Points: " + GamePoints.SimpleChoiсe;
    }
}
