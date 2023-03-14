using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    private Text bestScoreTextComponent;

    private void Start()
    {
        bestScoreTextComponent = GetComponent<Text>();
    }

    private void Update()
    {
        bestScoreTextComponent.text = "Best Score: " + GameManager.instance.bestScore.ToString();
    }
}
