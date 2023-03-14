using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SceneInfo sceneInfo;
    public static GameManager instance;
    [SerializeField] private GameObject startCanvas;
    [SerializeField] private GameObject deathCanvas;
    [SerializeField] private GameObject scoreUI;
    public int score = 0;
    public int bestScore;

    private void Awake()
    {
        bestScore = sceneInfo.bestScore;
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        instance = this;
        ShowStartCanvas();
    }

    private void ShowStartCanvas()
    {
        startCanvas.SetActive(true);
        deathCanvas.SetActive(false);
        scoreUI.SetActive(false);
    }
    
    public void StartGame()
    {
        startCanvas.SetActive(false);
        scoreUI.SetActive(true);
        Time.timeScale = 1;
        Bird.instance.BirdJumps(0.028f);
    }
    public void Death()
    {
        bestScore = bestScore > score ? bestScore : score;  // check if actual score is greater
        sceneInfo.bestScore = bestScore;
        Time.timeScale = 0;
        scoreUI.SetActive(false);
        deathCanvas.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
