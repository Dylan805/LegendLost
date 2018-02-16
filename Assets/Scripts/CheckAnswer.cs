using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Made by Dylan
//Makes sure the answer submitted by user is correct.

public class CheckAnswer : MonoBehaviour
{
    public InputField userAnswer;
    public Text outputBox;

    public void CheckAnswerTest()
    {
        var answer = 4;
        if (userAnswer.text != "")
        {
            if (int.Parse(userAnswer.text) == answer)
            {
                outputBox.text = "CORRECT!";
            }
            else
            {
                outputBox.text = "FAILURE! Try again!";
            }
        }
    }
}