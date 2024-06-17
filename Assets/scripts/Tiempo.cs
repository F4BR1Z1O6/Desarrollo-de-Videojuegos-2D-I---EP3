using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{
    public TMP_Text texto;
    public float Tiemp = 0;

    
    void Update()
    {
        Tiemp -= Time.deltaTime;
        texto.text = "" + Tiemp.ToString("f2");

        if (Tiemp < 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
