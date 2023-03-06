using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public void ButtonClicked()
    {
        GameManager.instance.StartGame();
        Bird.buttonClicked = true;
    }
}
