using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanciaaudio : MonoBehaviour
{
    public Transform jugador;
    public AudioSource audioSource;
    public float distanciaMaxima = 10f;

    void Update()
    {
        float distanciaAlJugador = Vector3.Distance(transform.position, jugador.position);

        float volumen = 1f - (distanciaAlJugador / distanciaMaxima);
        volumen = Mathf.Clamp01(volumen); 

        audioSource.volume = volumen;
    }
}