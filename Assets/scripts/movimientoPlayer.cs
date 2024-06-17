using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPlayer : MonoBehaviour
{
    public float regularSpeed = 5f; 
    public float maxSpeed = 10f;
    public float minSpeed = 1f;

    [HideInInspector] public float currentSpeed = 5f;

   
    void Start()
    {
        
    }

    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(dirX * currentSpeed, dirY * currentSpeed);
    }

    public void ChangeSpeedToFast()
    {
        currentSpeed = maxSpeed;
        Invoke("ResetSpeed", 3);
    }

    public void ChangeSpeedToSlow()
    {
        currentSpeed = minSpeed;
        Invoke("ResetSpeed", 7);
    }

    void ResetSpeed()
    {
        currentSpeed = regularSpeed;
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
