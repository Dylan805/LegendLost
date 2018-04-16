using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Made by Wildman
//Makes the yes button create the box with a width and height and displays it to the user

public class DisplayMessage : MonoBehaviour
{
    public Text outputBox;

    public void yesButtonClicked ()
    {
        outputBox.text = "Read the formula for Area";
    }

    public void yesButtonClickedLvl3()
    {
        outputBox.text = "Choose the pieces of the circles that make a whole circle";
    }
}