using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public Rigidbody2D BirdRigidBody2D;
    public float FlyStrength;
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            BirdRigidBody2D.velocity = Vector2.up * FlyStrength;
        }
    }
    private void OnCollisionEnter2D (Collision2D collision)
    {
        logic.gameOver();
    }
}
