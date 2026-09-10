// Must be inside CANVAS with NameInput and AgeInput to make it work po ^^
// This will be the code whereas we are going to save and load the players information

using UnityEngine;
using TMPro;

public class DatabaseHandler : MonoBehaviour
{
    // The code will be a little bit messy but I will polish it after making the feature work
    public TextMeshProUGUI message;
    public GameObject nameInput;
    public GameObject ageIntput;
    public TMP_InputField namePlr;
    public TMP_InputField agePlr;

    // Checking if complete
    void Start()
    {
        namePlr = nameInput.GetComponent<TMP_InputField>();
        agePlr = ageIntput.GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        if (namePlr.text != null && namePlr != null || agePlr.text != null && agePlr != null) 
        {
            message.text = "You are: " + namePlr.text + "| " + agePlr.text + " y.o.";
        }
    }
}
