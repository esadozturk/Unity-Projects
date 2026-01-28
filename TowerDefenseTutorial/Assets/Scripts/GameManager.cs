using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool GameIsOver;

    public GameObject gameOverUI;
    public GameObject completeLevelUI;

    void Start()
    {
        GameIsOver = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (PlayerStats.Lives <= 0)
        {
            if (GameIsOver)
            {
                return;
            }
            EndGame();
        }
    }
    
    private void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }
}
