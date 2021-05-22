using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using SimpleChoise;
using UnityEngine;
using UnityEngine.Serialization;

public class Choice : MonoBehaviour
{
    [FormerlySerializedAs("ChoiceType")] [SerializeField]private ChoiceTypes choiceType;

    [FormerlySerializedAs("Sprite")] [SerializeField]private Sprite sprite;

    public IGameEnd GameEnd; 
    
    public Choice ComparerChoice { get; set; }
    
    
    
    private void OnMouseDown()
    {
        Debug.Log("Click");

        if (ComparerChoice != null)
        {
            
        }
    }
}
