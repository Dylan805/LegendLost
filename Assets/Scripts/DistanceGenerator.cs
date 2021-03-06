﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DistanceGenerator : MonoBehaviour
{
    public Text outputBoxL1;
    public Text outputBoxL2;
    public Text outputBoxL3;
    public Text outputBoxR1;
    public Text outputBoxR2;
    public Text outputBoxR3;
    public Text displayBox;
    public InputField input;
    public GameObject submit;
    public GameObject read;
    public GameObject ready;
    public GameObject catapult;
    public GameObject trainer;
    public GameObject stones;
    public GameObject stonenumbers;
    public GameObject inputBox;

    //primary variable declarations 
    const int catAtZero = 1; //fist mode, when the catapult is at 0 and the target is at a positive number
    const int catTarPositive = 2; //second mode, when the catapult and target are at positive numbers
    const int catTarEither = 3; //third mode, when the catapult and target can be at positive or negative numbers
    int mode = catAtZero;
    int correctCount = 0;
    
    
    // game setup
    public void ReadIntro()
    {
        catapult.SetActive(true);
        trainer.SetActive(true);
        stones.SetActive(true);
        stonenumbers.SetActive(true);
        read.SetActive(false);
        ready.SetActive(true);

        displayBox.text = "You will be shooting a catapult at a target. The target will be at a certain point and your goal is to find the distance between the catapult and the dummy. Round 1 Begins!";
    }


    //sets up the catapult and creates the random numbers
    public void NextButtonClickedAgain()
    {
        ready.SetActive(false);
        submit.SetActive(true);

        displayBox.text = "Find the distance to the target!";

        System.Random rnd = new System.Random();
        int num1;
        int num2; 
        if (mode == catAtZero)
        {
            num1 = 0;
            num2 = rnd.Next(1, 30);
            displayBox.text = "Let us start with something simple";
        }
        else if (mode == catTarPositive)
        {
            num1 = rnd.Next(1, 30);
            num2 = rnd.Next(30, 60);
            displayBox.text = "Okay! Now a little harder";
        }
        else if (mode == catTarEither)
        {
            num1 = rnd.Next(-30, 30);
            num2 = rnd.Next(-60, 60);
            displayBox.text = "Let us see what you can do! Remember you are finding the distance!";

        }
        else
        {
            num1 = 0;
            num2 = 0;
            displayBox.text = "Error. Something went wrong somewhere.";
        }

        outputBoxL1.text = (num1 - 5).ToString();
        outputBoxL2.text = (num1).ToString();
        outputBoxL3.text = (num1 + 5).ToString();
        outputBoxR1.text = (num2 - 5).ToString();
        outputBoxR2.text = (num2).ToString();
        outputBoxR3.text = (num2 + 5).ToString();
    }


    //checks the answer that was submitted is the correct answer and procedes accordingly
    public void AnswerSubmitted()
    { 
        int mark1 = int.Parse(outputBoxL2.text);
        int mark2 = int.Parse(outputBoxR2.text);
        int correctAnswer = Mathf.Abs(mark2 - mark1);
        int userAnswer = int.Parse(input.text);


        //if the answer is right then it computes a new place for the catapult and updates the number that the user has gotten correct
        if (userAnswer == correctAnswer)        
        {
            displayBox.text = "CORRECT!";
            input.text = "";
            submit.SetActive(false);
            ready.SetActive(true);
            inputBox.SetActive(false);
            correctCount++;
        }
        else
        {
            displayBox.text = "FAILURE, TRY AGAIN!";
        }
        if (correctCount > 4 && mode == catAtZero)
        {
            mode = catTarPositive;
        }
        else if (correctCount > 9 && mode == catTarPositive)
        {
            mode = catTarEither;
        }
        else if (correctCount > 14 && mode == catTarEither)
        {
            SceneManager.LoadScene("ThridLevel");           //go to next level
        }
    }
}