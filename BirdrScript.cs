using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdrScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public logicScript logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength; 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       logic.gameOver();
       birdIsAlive = false;
    }
    
}
