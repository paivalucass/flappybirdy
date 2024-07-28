using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
public class Generator : MonoBehaviour
{
    public GameObject pipes;
    public float spawnRate = 5;
    private float timer = 0;
    private int RndNumber = 0;
    public int heightOffset = 5;
    public LogicScript logic;
    private Vector3 newpos;
    private System.Random rnd = new System.Random();

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnObject();  
            timer = 0;
        }
    }
    void SpawnObject()
    {
        RndNumber = rnd.Next(-heightOffset, heightOffset);
        newpos = transform.position + (Vector3.down * RndNumber);
        //logic.increasePipeVelocity();
        Instantiate(pipes, newpos, transform.rotation);
    }
}
