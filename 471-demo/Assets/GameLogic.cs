using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;


public class GameLogic : MonoBehaviour
{
    public TextMeshProUGUI counter;
    public GameObject winScreen; 
    public int targetCount;
    private int totalTargets = 8;

    void Start()
    {
        targetCount = 0;
        winScreen.SetActive(false); 
        UpdateCounterUI();
    }

    public void UpdateCounterUI()
    {
        if (counter != null)
        {
            counter.text = targetCount + "/" + totalTargets;
        }
        else
        {
            Debug.LogError("Counter TextMeshProUGUI component is not assigned!");
        }

        if (targetCount >= totalTargets) // Check if player won
        {
            ShowWinScreen();
        }
    }

    void ShowWinScreen()
    {
        winScreen.SetActive(true); 
        Time.timeScale = 0f; 
    }
    public void ReplayGame()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}
