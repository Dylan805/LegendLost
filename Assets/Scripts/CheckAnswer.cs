using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//Made by Dylan and Wildman
//Makes sure the answer submitted by user is correct.

public class CheckAnswer : MonoBehaviour
{
    const int leftClick = 0;
    const int square_mode = 1;
    const int tri_mode = 2;
    const int cir_mode = 3;
    const int sqTri_mode = 4;
    const int sqCir_mode = 5;
    int _mode = square_mode;

    public InputField userAnswer;
    public Text outputBox;
    public GameObject Square;
    public GameObject Triangle;
    public GameObject Circle;
    public GameObject sqCir1;
    public GameObject sqCir2;
    public GameObject sqCir3;
    public GameObject sqTri1;
    public GameObject sqTri2;
    public GameObject sqTri3;

    public Button submitButton;
    public GameObject formulaButton;

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

    double sqTri_width = 2;
    double sqTri_height = 3;
    double sqTri_answer;

    double sqCir_width = 2;
    double sqCir_height = 4;
    double sqCir_answer;
    public void CheckAnswerTest()

    {
        var rec_answer = rec_wid * rec_hgt;
        var tri_answer = half * tri_bse * tri_hgt;
        var crc_answer = pi * (crc_rad * crc_rad);
        var sqTri_answer = (sqTri_width * sqTri_height) * (3 / 2);
        var sqCir_answer = (sqCir_width * sqTri_height) + (pi * ((sqCir_width / 2) * (sqCir_width / 2)));
        if (userAnswer.text != "")
        {   
                if (_mode == square_mode && int.Parse(userAnswer.text) == rec_answer)
                {
                    outputBox.text = "CORRECT!";
                    userAnswer.Select();
                    userAnswer.text = "";
                    Triangle.SetActive(true);
                    _mode = tri_mode;
                }
                else if (_mode == tri_mode && int.Parse(userAnswer.text) == tri_answer)
                {
                    outputBox.text = "CORRECT!";
                    userAnswer.Select();
                    userAnswer.text = "";
                    Circle.SetActive(true);
                    _mode = cir_mode;
                }
                else if (_mode == cir_mode && int.Parse(userAnswer.text) == crc_answer)
                {
                    outputBox.text = "Way to go! Thanks for helping me complete those buildings! I need 2 more buildings to complete. (Formulas for areas are attached to button called 'Fomrulas')";
                    userAnswer.Select();
                    userAnswer.text = "";
                    Square.SetActive(false);
                    Triangle.SetActive(false);
                    Circle.SetActive(false);
                    //formulaButton.SetActive(true);
                    sqTri1.SetActive(true);
                    sqTri2.SetActive(true);
                    sqTri3.SetActive(true);
                    _mode = sqTri_mode;
                }
             else if (_mode == sqTri_mode && int.Parse(userAnswer.text) == sqTri_answer)
            {
                outputBox.text = "CORRECT!";
                userAnswer.Select();
                userAnswer.text = "";
                sqCir1.SetActive(true);
                sqCir2.SetActive(true);
                sqCir3.SetActive(true);
                _mode = sqCir_mode;
            }
            else if (_mode == sqCir_mode && int.Parse(userAnswer.text) == sqCir_answer)
            {
                outputBox.text = "CORRECT!";
                userAnswer.Select();
                userAnswer.text = "";
                if (Input.GetMouseButtonDown(leftClick))
                {
                    this.enabled = false;
                    SceneManager.LoadScene("SecondLevel");
                }
            }

            else
            {
                    outputBox.text = "FAILURE! Try again!";
                }
                
        }
    }
}