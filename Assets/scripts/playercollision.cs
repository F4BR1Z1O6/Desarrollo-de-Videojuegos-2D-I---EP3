using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    private Vector3 initPosition;
    private Light playerLight;

    void Start()
    {
        Debug.Log("accediendo al regular speed de otro componente" 
        + gameObject.GetComponent<movimientoPlayer>().regularSpeed);

        initPosition = gameObject.transform.position;
        playerLight = gameObject.GetComponentInChildren<Light>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PowerUpA")
        {
            gameObject.GetComponent<movimientoPlayer>().ChangeSpeedToFast();
            GameObject.Destroy(collision.gameObject);
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (collision.tag == "PowerUpB")
        {
            gameObject.transform.position = initPosition;
            collision.gameObject.GetComponent<AudioSource>().Play();
        }

        if (collision.tag == "PowerUpC")
        {
            gameObject.GetComponent<movimientoPlayer>().ChangeSpeedToSlow();
            GameObject.Destroy(collision.gameObject);
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (collision.tag == "PowerUpD")
        {
           gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
           GameObject.Destroy(collision.gameObject);
           Invoke("RestoreRigidBody", 7);
        }

        if (collision.tag == "PowerUpE")
        {
            playerLight.range = 20;
            Invoke("RestoreCharacterLight", 3);
            GameObject.Destroy(collision.gameObject);
        }

        if (collision.tag == "PowerUpF")
        {
            Camera.main.orthographicSize = 7;
            Invoke("RestoreCamera", 5);
            GameObject.Destroy(collision.gameObject);
        }
    }

    private void RestoreRigidBody()
    {
        gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }

    private void RestoreCharacterLight()
    {
        playerLight.range = 10;
    }

    private void RestoreCamera()
    {
        Camera.main.orthographicSize = 7;
    }
}
