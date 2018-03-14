using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Made by Dylan and Wildman
//Makes sure the answer submitted by user is correct.

public class CheckAnswer : MonoBehaviour
{
    public InputField userAnswer;
    public Text outputBox;
    public GameObject Triangle;
    public GameObject Circle;

    public Text recWidth;
    public Text recHeight;
    int rec_wid = 2;
    int rec_hgt = 2;

    public Text triBase;
    public Text triHeight;
    double half = 0.5;
    int tri_bse = 2;
    int tri_hgt = 2;

    public Text crcRadius;
    double pi = 3;
    double crc_rad = 2;

    public void CheckAnswerTest()
    {
        var rec_answer = rec_wid * rec_hgt;
        
        if (userAnswer.text != "")
        {
            if (int.Parse(userAnswer.text) == rec_answer)
            {
                outputBox.text = "CORRECT!";
                userAnswer.Select();
                userAnswer.text = "";
                Triangle.SetActive(true);
                var tri_answer = half * tri_bse * tri_hgt;
                
                if (int.Parse(userAnswer.text) == tri_answer)
                {
                    outputBox.text = "CORRECT!";
                    userAnswer.Select();
                    userAnswer.text = "";
                    Circle.SetActive(true);
                    var crc_answer = pi * crc_rad * crc_rad;

                    if (int.Parse(userAnswer.text) == crc_answer)
                    {
                        outputBox.text = "CORRECT!";
                    }
                    else
                    {
                        outputBox.text = "FAILURE! Try again!";
                    }
                }
                else
                {
                    outputBox.text = "FAILURE! Try again!";
                    userAnswer.text = "";
                }
            }
            else
            {
                outputBox.text = "FAILURE! Try again!";
                userAnswer.text = "";
            }
        }
    }
}