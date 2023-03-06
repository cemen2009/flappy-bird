using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameManager.instance.score++;
        audioSource.Play();
    }
}
