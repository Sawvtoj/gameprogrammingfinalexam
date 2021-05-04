using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("2Game");
        ChangePoints.points = 0;
        if (Lives.lifeCheck == false)
        {
            Lives.playerLives = 5;
        }
        if (TimeClockSlider.timeCheck == false)
        {
            Timer.startTime = 45f;
        }
        if(GetName.nameCheck == false)
        {
            GetName.username = "Player 1";
        }
    }
}
