using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private UnityEngine.UI.Text scoreTextComponent;
    private void Start()
    {
        scoreTextComponent = GetComponent<UnityEngine.UI.Text>();
    }

    private void Update()
    {
        scoreTextComponent.text = GameManager.instance.score.ToString();
    }
}
