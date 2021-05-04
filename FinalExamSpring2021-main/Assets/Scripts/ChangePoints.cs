using UnityEngine;
using UnityEngine.UI;

public class ChangePoints : MonoBehaviour
{
    public static int points;
    public Text pointsText;

    public void AddPoints()
    {
        points += 1;
    }

    public void SubtractPoints()
    {
        points -= 1;
    }

    void Update()
    {
        pointsText.text = points.ToString();
    }
}
