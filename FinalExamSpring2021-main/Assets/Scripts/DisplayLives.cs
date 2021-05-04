using UnityEngine;
using UnityEngine.UI;

public class DisplayLives : MonoBehaviour
{
    public Text liveText;

    void Update()
    {
        liveText.text = Lives.playerLives.ToString();
    }
}
