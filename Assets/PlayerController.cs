using UnityEngine;
using UnityEngine.XR;
using System;

public class PlayerController : MonoBehaviour
{
    int speed = 10;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.linearVelocity = new Vector3(0, 1);
        }
        
    }

}



public class Game
{
    public Rigidbody2D rb;


    public void Run()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector3(1, rb.linearVelocity.y);

    }





    private T GetComponent<T>()
    {
        throw new NotImplementedException();
    }






}
