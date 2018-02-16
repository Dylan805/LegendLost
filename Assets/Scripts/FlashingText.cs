using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

//Made by Ethan
//Makes the "Touch To Play" text flash on opening screen

public class FlashingTextScript : MonoBehaviour
{
    Text flashingText;
    public bool flashText = true;                          //set to true for loading screen and false otherwise
    void Start()
    {
        //get the Text component
        flashingText = GetComponent<Text>();
        //Call coroutine BlinkText on Start
        StartCoroutine(BlinkText());
        if (Input.GetMouseButtonDown(0))
        {
            StopCoroutine(BlinkText());
            flashingText.text = "";
            SceneManager.LoadScene("FirstLevel");
        }
    } 

    //function to blink the text
    public IEnumerator BlinkText()
    {
        //blink it forever. You can set a terminating condition depending upon your requirement
        while (flashText == true)
        {
            //set the Text's text to blank
            flashingText.text= "";
            //display blank text for 0.5 seconds
            yield return new WaitForSeconds(.5f);
            //display “I AM FLASHING TEXT” for the next 0.5 seconds
            flashingText.text= "-Touch Screen to Play-";
            yield return new WaitForSeconds(1f);
        }
    }
}