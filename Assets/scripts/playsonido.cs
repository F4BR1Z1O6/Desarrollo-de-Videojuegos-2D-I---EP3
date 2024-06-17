using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsonido : MonoBehaviour
{
    public AudioSource aS1;
    public AudioSource aS2;

  
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
        {
            aS1.Play();
        }

      if (Input.GetKeyDown(KeyCode.Return))
        {
            if (aS2.isPlaying)
            {
                aS2.Pause();
            }
            else
            {
                aS2.Play();
            }
        }
    }
}
