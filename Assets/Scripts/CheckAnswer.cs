﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Made by Dylan and Wildman and Ethan
//Makes sure the answer submitted by user is correct.

public class CheckAnswer : MonoBehaviour
{
<<<<<<< HEAD
    const int sq_state = 1;
    const int tri_state = 2;
    const int cir_state = 3;
    const int sqtri_state = 4;
    const int sqcir_state = 5;
    int _mode = sq_state;
=======
    int _mode = 1; 
>>>>>>> 003f66612f06d5a76dd0ed754940b0d911215196
    public InputField userAnswer;
    public Text outputBox;
    public GameObject Square;
    public GameObject Triangle;
    public GameObject Circle;
    public Button submitButton;

    public Text recWidth;
    public Text recHeight;
    int rec_wid = 2;
    int rec_hgt = 2;

    public Text triBase;
    public Text triHeight;
    double half = 0.5;
    int tri_bse = 2;
    int tri_hgt = 2;
    double tri_answer;
  
    public Text crcRadius;
    double pi = 3;
    double crc_rad = 2;
    double crc_answer;
    public void CheckAnswerTest()
    {
        var rec_answer = rec_wid * rec_hgt;
        var tri_answer = half * tri_bse * tri_hgt;
        var crc_answer = pi * (crc_rad * crc_rad);
        if (userAnswer.text != "")
        {   
                if (_mode == sq_state && int.Parse(userAnswer.text) == rec_answer)
                {
                    outputBox.text = "CORRECT!";
                    userAnswer.Select();
                    userAnswer.text = "";
                    Triangle.SetActive(true);
                    _mode = tri_state;
                }
                else if (_mode == tri_state && int.Parse(userAnswer.text) == tri_answer)
                {
                    outputBox.text = "CORRECT!";
                    userAnswer.Select();
                    userAnswer.text = "";
                    Circle.SetActive(true);
                    _mode = cir_state;
                }
                else if (_mode == cir_state && int.Parse(userAnswer.text) == crc_answer)
                {
                    outputBox.text = "CORRECT!";
                    userAnswer.Select();
                    userAnswer.text = "";
                    Square.SetActive(false);
                    Triangle.SetActive(false);
                    Circle.SetActive(false);
<<<<<<< HEAD
                    sqTri.SetActive(true);
                    _mode = sqtri_state;
=======
                    //sqTri.SetActive(true);
                   // _mode = 4; 
>>>>>>> 003f66612f06d5a76dd0ed754940b0d911215196
                }
                else if (_mode == sqtri_state && int.Parse(userAnswer.text) == sqTri_answer)
                {
                    outputBox.text = "CORRECT!";
                    userAnswer.Select();
                    userAnswer.text = "";
                    sqCir.SetActive(true);
<<<<<<< HEAD
                    _mode = sqcir_state;
=======
                    _mode = 5; 
>>>>>>> 003f66612f06d5a76dd0ed754940b0d911215196
                }
                else if (_mode == sqcir_state && int.Parse(userAnswer.text) == sqCir_answer)
                {
                    outputBox.text = "CORRECT!";
                    userAnswer.Select();
                    userAnswer.text = "";
                    //go to next scene here
                }
               
            else
                {
                    outputBox.text = "FAILURE! Try again!";
                }
                
        }
    }
}
