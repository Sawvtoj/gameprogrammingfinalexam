using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour
{
    public InputField playerNameInput;
    public Text nameText;
    public static string username = "Player 1";
    public static bool nameCheck = false;

    public void FindName()
    {
        username = playerNameInput.text;
        nameCheck = true;
    }

    void Start()
    {
        nameText.text = username;
    }
}
