using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void NGame()
    {
        SceneManager.LoadScene("1Intro");
        Lives.lifeCheck = false;
        TimeClockSlider.timeCheck = false;
        GetName.nameCheck = false;
    }
}
