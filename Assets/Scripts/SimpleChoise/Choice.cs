using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using SimpleChoise;
using UnityEngine;
using UnityEngine.Serialization;

public class Choice : MonoBehaviour
{
    public ChoiceTypes ChoiceType { get; set; }

    [FormerlySerializedAs("Sprite")] [SerializeField]private Sprite sprite;

    public Action Tap { get; set; } 
    
    public Choice ComparerChoice { get; set; }

    public void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
        transform.localScale = transform.localScale * 2;
    }

    private void OnMouseDown()
    {
        Debug.Log("Click");
        Tap.Invoke();
        // if (ComparerChoice != null)
        // {
        //     if (ComparerChoice.ChoiceType == this.ChoiceType)
        //     {
        //         Tap.Invoke();
        //     }
        // }
    }
    
    private void OnMouseEnter()
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + 0.2f,
            gameObject.transform.localScale.y + 0.2f, gameObject.transform.localScale.z + 0.2f);
    }

    private void OnMouseExit()
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x - 0.2f,
            gameObject.transform.localScale.y - 0.2f, gameObject.transform.localScale.z - 0.2f);;
    }
}
