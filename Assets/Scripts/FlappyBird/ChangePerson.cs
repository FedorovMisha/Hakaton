using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ChangePerson : MonoBehaviour
{
    [SerializeField] private List<GameObject> persons;

    private GameObject VisiblePerson { get; set; }

    private int _visibleIndex = 0;
    
    private void Start()
    {
        persons.ForEach(x => x.SetActive(false));

        VisiblePerson = persons.FirstOrDefault();
        if (VisiblePerson != null)
        {
            VisiblePerson.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        VisiblePerson.SetActive(false);
        _visibleIndex = (_visibleIndex + 1) % persons.Count;
        VisiblePerson = persons[_visibleIndex];
        VisiblePerson.SetActive(true);
    }
}
