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

    public IGameEnd GameEnd; 
    
    public Choice ComparerChoice { get; set; }
    
    
    
    private void OnMouseDown()
    {
        Debug.Log("Click");

        if (ComparerChoice != null)
        {
            if (ComparerChoice.ChoiceType == this.ChoiceType)
            {
                GamePoints.SimpleChoise++;
                GameEnd.Next();
                return;
            }
            
            GameEnd.GameOver();
        }
    }
}
