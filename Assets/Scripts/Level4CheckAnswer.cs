using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level4CheckAnswer : MonoBehaviour {
    public GameObject racer1;
    public GameObject racer2;
    public GameObject racer3;
    public GameObject racer4;
    public GameObject racer5;
    public GameObject racer6;
    public GameObject racer7;

    public GameObject AcknowledgeButton;
    public GameObject SubmitButton;
    public GameObject Input;
    public InputField UserAnswer;
    public Text HelpTextBox;
    public Text TimerSeconds;
    public Text FormulaTextBox;

    System.Random rnd = new System.Random();
    private int timeAllowed = 90;
    private int startTime;
    private int currentTime;
    private bool started = false;
    private bool finished = false;
    private int answer;
    private int num1, num2, num3;
    private int numberCorrect;
    
	public void AcknowledgedReading()
    {
        if (numberCorrect == 10)
        {
            SceneManager.LoadScene("TitleScreen");      //restarts the game if the user has completed the level and again presses the acknowleged button
        }
        //this section is called at the beginning of the game when the user acknowledges the instructions. it is the setup of the beginning of the game
        else
        {
            AcknowledgeButton.SetActive(false);
            Input.SetActive(true);
            SubmitButton.SetActive(true);
            startTime = (int)Time.time;
            started = true;
            HelpTextBox.text = "";
            ComputeAnswer();
        }
    }

    //on each frame the timer counts and updates
    private void Update()
    {
        if (started && !(finished))
        {
            currentTime = (int)Time.time;
            TimerSeconds.text = (timeAllowed - (currentTime - startTime)).ToString();
            if ((timeAllowed - (currentTime - startTime)) <= 0)
            {
                finished = true;
            }
        }
        else if (finished == false)
        {
            TimerSeconds.text = "0";
        }
        else if (finished == true && numberCorrect == 10)
        {
            HelpTextBox.text = "YOU WIN!" + '\n' + "CLICK THE ARROW TO RESTART THE GAME";
        }
        else
        {
            SubmitButton.SetActive(false);
            Input.SetActive(false);
            TimerSeconds.text = "0";
            HelpTextBox.text = "TIMES UP!" + '\n' + "TRY THE RACE AGAIN";
            currentTime = (int)Time.time;
            if ((timeAllowed - (currentTime - startTime)) <= (-5))
            {
                SceneManager.LoadScene("FourthLevel");
            }
        }
    }
    
    //computes a formula and a solution and displays the formula 
    private void ComputeAnswer ()
    {
        //create random numbers to put in the formula
        num1 = rnd.Next(1, 11);
        num2 = rnd.Next(1, 6);
        num3 = rnd.Next(-5, 6);
        HelpTextBox.text += '\n' + " Solve for x...";


        //when the user gets more answers correct the formulas get more difficult
        if(numberCorrect <= 2) 
        {
            FormulaTextBox.text = (num1 + " - " + num2 + " + " + num3 + " = ");
            answer = num1 - num2 + num3;
        }
        else if (numberCorrect <= 5)
        {
            FormulaTextBox.text = (num1 + " * " + num2 + " + " + num3 + " = ");
            answer = num1 * num2 + num3;
        }
        else if (numberCorrect <= 8)
        {
            num1 *= num2;
            FormulaTextBox.text = (num1 + " / " + num2 + " + " + num3 + " = ");
            answer = num1 / num2 + num3;
        }
        else if (numberCorrect == 9)
        {
            num1 *= num2;                                //this ensures that the division will always produce an integer for ease of solving
            FormulaTextBox.text = ("( " + num1 + " / " + num2 + " ) " + " * " + num3 + " = ");
            answer = num1 / num2 * num3;
        }
        


    }


    //this function checks that the answer submitted is the correct answer and if it is it updates the number correct
    public void CheckAnswer()
    {
        int userAnswer = int.Parse(UserAnswer.text);
        if (answer == userAnswer && numberCorrect != 10)
        {
            HelpTextBox.text = "CORRECT! KEEP GOING!";
            ComputeAnswer();
            numberCorrect++;
        }
        else
        {
            HelpTextBox.text = "TRY AGAIN!";
        }
        if (numberCorrect == 1)
        {
            racer1.SetActive(false);
            racer2.SetActive(true);
        }
        else if (numberCorrect == 3)
        {
            racer2.SetActive(false);
            racer3.SetActive(true);
        }
        else if (numberCorrect == 5)
        {
            racer3.SetActive(false);
            racer4.SetActive(true);
        }
        else if (numberCorrect == 6)
        {
            racer4.SetActive(false);
            racer5.SetActive(true);
        }
        else if (numberCorrect == 7)
        {
            racer5.SetActive(false);
            racer6.SetActive(true);
        }
        else if (numberCorrect == 9)
        {
            racer6.SetActive(false);
            racer7.SetActive(true);
        }
        else if (numberCorrect == 10)                               //the end of the game. Disables entering of answers and enables restart of game if desired.
        {
            racer7.SetActive(false);
            racer1.SetActive(true);
            SubmitButton.SetActive(false);
            Input.SetActive(false);
            AcknowledgeButton.SetActive(true);
            FormulaTextBox.text = "";
            finished = true;
        }
    }
}
