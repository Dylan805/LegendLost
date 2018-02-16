using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Made by Wildman
//Makes the yes button create the box with a width and height and displays it to the user

public class DisplayMessage : MonoBehaviour
{
    /*int wid = 2;
    int hgt = 2;*/
    public Text outputBox;

    public void yesButtonClicked ()
    {
        outputBox.text = "Read the formula for Area";
    }
}