using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Dropdown cDropdown;

    public static int playerLives = 5;
    public static bool lifeCheck = false;

    public void LifeChoice()
    {
        switch (cDropdown.value)
        {
            default:
                playerLives = 5;
                lifeCheck = true;
                break;

            case 1:
                playerLives = 1;
                lifeCheck = true;
                break;

            case 2:
                playerLives = 2;
                lifeCheck = true;
                break;

            case 3:
                playerLives = 3;
                lifeCheck = true;
                break;

            case 4:
                playerLives = 4;
                lifeCheck = true;
                break;

            case 5:
                playerLives = 5;
                lifeCheck = true;
                break;

            case 6:
                playerLives = 6;
                lifeCheck = true;
                break;

            case 7:
                playerLives = 7;
                lifeCheck = true;
                break;

            case 8:
                playerLives = 8;
                lifeCheck = true;
                break;

            case 9:
                playerLives = 9;
                lifeCheck = true;
                break;
        }
    }
}
