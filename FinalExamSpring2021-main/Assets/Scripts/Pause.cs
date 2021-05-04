using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Stop();
            }
        }
    }

    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Stop()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Save()
    {
        PlayerPrefs.SetString("Player Name", GetName.username);
        PlayerPrefs.SetInt("Points", ChangePoints.points);
        PlayerPrefs.SetInt("Lives", Lives.playerLives);
        PlayerPrefs.SetFloat("Time", Timer.startTime);
    }

    public void Load()
    {
        GetName.username = PlayerPrefs.GetString("Player Name", GetName.username);
        ChangePoints.points = PlayerPrefs.GetInt("Points", ChangePoints.points);
        Lives.playerLives = PlayerPrefs.GetInt("Lives", Lives.playerLives);
        Timer.startTime = PlayerPrefs.GetFloat("Time", Timer.startTime);
    }

    public void NewGame()
    {
        SceneManager.LoadScene("1Intro");
        Lives.lifeCheck = false;
        TimeClockSlider.timeCheck = false;
        GetName.nameCheck = false;
    }
}
