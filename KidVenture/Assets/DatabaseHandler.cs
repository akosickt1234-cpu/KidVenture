// Must be inside CANVAS with NameInput and AgeInput to make it work po ^^
// This will be the code whereas we are going to save and load the players information

using UnityEngine;
using TMPro;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class DatabaseHandler : MonoBehaviour
{
    // The code will be a little bit messy but I will polish it after making the feature work
    public TextMeshProUGUI message;
    public TextMeshProUGUI greet;
    public GameObject nameInput;
    public GameObject ageIntput;
    public TMP_InputField namePlr;
    public TMP_InputField agePlr;
    public Button confirm;
    public GameObject addUserPanel;

    // Checking if complete
    void Start()
    {
        namePlr = nameInput.GetComponent<TMP_InputField>();
        agePlr = ageIntput.GetComponent<TMP_InputField>();

        confirm.onClick.AddListener(ConfirmClick);
    }

    // Update is called once per frame
    public void Play()
    {
        addUserPanel.SetActive(true);
    }

    void ConfirmClick()
    {
        if (namePlr.text != null && namePlr != null || agePlr.text != null && agePlr != null)
        {
            if (namePlr.text != null &&  agePlr.text != null)
            {
                message.text = "You are: " + namePlr.text + " | " + agePlr.text + " y.o.";
                if (greet != null)
                {
                    greet.text = "Hello " + namePlr.text + "!";
                }
            }
            

            addUserPanel.SetActive(false);
        }
    }
}
