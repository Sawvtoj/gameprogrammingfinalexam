using UnityEngine;
using UnityEngine.SceneManagement;

public class Stop : MonoBehaviour
{
    public void stopgame()
    {
        SceneManager.LoadScene("3Exit");
    }
}
