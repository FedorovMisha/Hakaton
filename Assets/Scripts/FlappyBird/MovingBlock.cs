using System;
using System.Collections;
using System.Collections.Generic;
using FlappyBird;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private static float _speed = 6f;

    public static float Speed
    {
        get => _speed;
        set
        {
            _speed = value;
            if (_speed > 15f)
                _speed = 15f;
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Speed += 0.1f;
        transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(-_speed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        new FlappyBirdGameEnd().GameOver();
    }
}
