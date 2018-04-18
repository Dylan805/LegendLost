using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level4CheckAnswer : MonoBehaviour {

    public GameObject AcknowledgeButton;
    public GameObject SubmitButton;
    public GameObject Input;
    public InputField UserAnswer;
    public Text HelpTextBox;
    public Text TimerSeconds;
    public Text FormulaTextBox;

    System.Random rnd = new System.Random();
    private int timeAllowed = 45;
    private int startTime;
    private int currentTime;
    private bool started = false;
    private bool finished = false;
    private int answer;
    private int num1, num2, num3;
    private int numberCorrect;
    
	public void AcknowledgedReading() {
        
        
        Input.SetActive(true);
        SubmitButton.SetActive(true);
        startTime = (int)Time.time;
        started = true;
        AcknowledgeButton.SetActive(false);
        HelpTextBox.text = "";
        ComputeAnswer();
    }

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
        else
        {
            TimerSeconds.text = "0";
            HelpTextBox.text = "TIMES UP!";
        }
    }
    
    private void ComputeAnswer ()
    {
        num1 = rnd.Next(1, 11);
        num2 = rnd.Next(1, 6);
        num3 = rnd.Next(-5, 6);
        HelpTextBox.text += " Solve for x...";
        FormulaTextBox.text = (num1 + " * " + num2 + " + " + num3 + " = ");
        answer = num1 * num2 + num3;
    }

    public void CheckAnswer()
    {
        int userAnswer = int.Parse(UserAnswer.text);
        if (answer == userAnswer)
        {
            HelpTextBox.text = "CORRECT! KEEP GOING!";
            ComputeAnswer();
            numberCorrect++;
        }
        else
        {
            HelpTextBox.text = "TRY AGAIN!";
        }
    }
}
