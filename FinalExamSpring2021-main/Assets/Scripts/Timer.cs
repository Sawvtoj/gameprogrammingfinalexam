using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float startTime = 45;

    public Text timeText;

    void Start()
    {
        timeText.text = startTime.ToString();
    }

    void Update()
    {
        startTime -= Time.deltaTime;
        timeText.text = Mathf.Round(startTime).ToString();

        if(startTime <= 0)
        {
            startTime = 0;
        }
    }
}
