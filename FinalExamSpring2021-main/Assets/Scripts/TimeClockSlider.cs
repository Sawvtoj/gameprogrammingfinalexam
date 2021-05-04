using UnityEngine;
using UnityEngine.UI;

public class TimeClockSlider : MonoBehaviour
{
    public Slider slider;
    public Text TimeClockDisplay;
    public static bool timeCheck = false;

    public void Awake()
    {
        slider = GameObject.FindWithTag("Speed").GetComponent<Slider>();
    }

    public void OnEnable()
    {
        slider.onValueChanged.AddListener(delegate { sliderCallBack(slider); });
    }

    public void sliderCallBack(Slider slider)
    {
        Timer.startTime = slider.value;
        timeCheck = true;
        TimeClockDisplay.text = slider.value.ToString();
    }
}
