using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength = 10;
    public LogicManager logicManager;
    public bool birdIsAlive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
            //Debug.Log("Space key was pressed.");
        } 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicManager.GameOver();
        birdIsAlive = false;
    }
}
