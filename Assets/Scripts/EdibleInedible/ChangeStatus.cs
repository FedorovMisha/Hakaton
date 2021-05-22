using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace EdibleInedible
{
    public class ChangeStatus : MonoBehaviour
    {
        private Text _text;
        
        public void Start()
        {
            _text = GetComponent<Text>();
            StartCoroutine(ChangeState());
        }

        private IEnumerator ChangeState()
        {
            while (true)
            {
                if (State.EdibleState == EdibleInedibleStatus.Edible)
                {
                    _text.text = "Inedible";
                    State.EdibleState = EdibleInedibleStatus.Inedible;
                }
                else
                {
                    _text.text = "Edible";
                    State.EdibleState = EdibleInedibleStatus.Edible;
                }

                yield return new WaitForSeconds(3f);
            }
        }
    }
}