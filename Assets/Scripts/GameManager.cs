using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] GameObject GameOverUI;

    [SerializeField] GameObject PipeSpawner;

    [SerializeField] GameObject StartButton;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        Time.timeScale = 1.0f;
    }

    public void GameOver()
    {
        GameOverUI.SetActive(true);

        PipeSpawner.SetActive(false);
        Debug.Log("GameOver");
    }

    public void RestartGame()
    {
        PipeSpawner.SetActive(true);

        StartButton.SetActive(false);
        Debug.Log("RestartGame");
    }

    public void StartGame()
    {
        Debug.Log("StartGame");
        SceneManager.LoadScene("SampleScene");
        
    }

}
