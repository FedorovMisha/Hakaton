using System;
using UnityEngine;

namespace EdibleInedible
{
    public class Item : MonoBehaviour
    {

        [SerializeField] private EdibleInedibleStatus _status;
        
        private void OnMouseDown()
        {
            if (State.EdibleState == _status)
            {
                GamePoints.EdibleInedible++;
                Destroy(this.gameObject);
            }
            else
            {
                new EdibleInedibleGameEnd().GameOver();
            }
        }
    }
}