// Must be inside CANVAS with NameInput and AgeInput to make it work po ^^
// This will be the code whereas we are going to save and load the players information

using UnityEngine;
using TMPro;
//using UnityEngine.UIElements;
using UnityEngine.UI;
using Unity.VisualScripting;

public class DatabaseHandler : MonoBehaviour
{
    // The code will be a little bit messy but I will polish it after making the feature work
    public TextMeshProUGUI message;
    public TextMeshProUGUI greet;
    public TMP_InputField namePlr;
    public TMP_InputField agePlr;
    public Button confirm;
    public GameObject addUserPanel;

    public string userName;
    public string age;

    public void Play()
    {
        addUserPanel.SetActive(true);
    }

    public void ConfirmClick()
    {
        if (namePlr.text != null && namePlr != null)
        {
            userName = namePlr.text;
            
        }

        if (agePlr.text != null && agePlr != null)
        {
            age = agePlr.text;
        }

        if (userName != "" && age != "")
        {
            message.text = "You are: " + namePlr.text + " | " + agePlr.text + " y.o.";

            if (greet != null)
            {
                greet.text = "Hello " + namePlr.text + "!";
            }
        }

        addUserPanel.SetActive(false);
    }

    public void Back(GameObject Panel)
    {
        Panel.SetActive(false);
    }
}
