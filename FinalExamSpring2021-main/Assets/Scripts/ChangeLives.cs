using UnityEngine;
using UnityEngine.UI;

public class ChangeLives : MonoBehaviour
{

    public void AddLives()
    {
        Lives.playerLives += 1;
    }

    public void SubtractLives()
    {
        Lives.playerLives -= 1;
    }
}
