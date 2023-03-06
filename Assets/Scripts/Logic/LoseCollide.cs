using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollide : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.Death();
        audioSource.Play();
    }
}
