using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdRender : MonoBehaviour
{

    public float Freg  = 2;
        public float Amp = 0.25f;
        public float t = 0;
        public float offset = 0;
        public Vector2 StartPos;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    public void FixedUpdate()
        {
             t = t +Time.deltaTime;
             offset = Amp* Mathf.Sin(t*Freg);

             transform.position = StartPos + new Vector2(0,offset);
        }
}
