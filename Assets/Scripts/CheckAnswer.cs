using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//Makes sure the answer submitted by user is correct.

public class CheckAnswer : MonoBehaviour
{
    //Creating modes for the user to switch between
    const int leftClick = 0;
    const int square_mode = 1;
    const int tri_mode = 2;
    const int cir_mode = 3;
    const int sqTri_mode = 4;
    const int sqCir_mode = 5;
    int _mode = square_mode;

    //Creating variable values and declaring necessary game objects
    public InputField userAnswer;
    public Text outputBox;
    public GameObject Square;
    public GameObject Triangle;
    public GameObject Circle;
    public GameObject sqCir1;
    public GameObject sqTri1;

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
    double crc_rad = 2;
    double crc_answer;

    double sqTri_width = 2;
    double sqTri_height = 3;
    double sqTri_triHatHeight = 3;
    double sqTri_answer;

    double sqCir_width = 2;
    double sqCir_height = 4;
    double sqCir_answer;

    //Goes through the modes created and changes the scene based on the mode activated
    public void CheckAnswerTest()
    {
        var rec_answer = rec_wid * rec_hgt;
        var tri_answer = half * tri_bse * tri_hgt;
        var crc_answer = (crc_rad * crc_rad);
        var sqTri_answer = (sqTri_width * sqTri_height) + ((sqTri_triHatHeight * sqTri_width)/ 2);
        var sqCir_answer = (sqCir_width * sqCir_height);
        if (userAnswer.text != "")
        {   
            //Starts active and changes to triangle's mode upon completeion
            if (_mode == square_mode && int.Parse(userAnswer.text) == rec_answer)
            {
                outputBox.text = "CORRECT!";
                userAnswer.Select();
                userAnswer.text = "";
                Triangle.SetActive(true);
                _mode = tri_mode;
            }
            //Activates when square_mode is completed and activates circle mode upon completeion
            else if (_mode == tri_mode && int.Parse(userAnswer.text) == tri_answer)
            {
                outputBox.text = "CORRECT!";
                userAnswer.Select();
                userAnswer.text = "";
                Circle.SetActive(true);
                _mode = cir_mode;
            }
            //Activates wehn tri_mode is completed and activates the triangle and square combination shape upon completion
            else if (_mode == cir_mode && int.Parse(userAnswer.text) == crc_answer)
            {
                outputBox.text = "Way to go! Thanks for helping me complete those buildings! I need 2 more buildings to complete. (Formulas for areas are attached to button called 'Fomrulas')";
                userAnswer.Select();
                userAnswer.text = "";
                Square.SetActive(false);
                Triangle.SetActive(false);
                Circle.SetActive(false);
                formulaButton.SetActive(true);
                sqTri1.SetActive(true);
                _mode = sqTri_mode;
            }
            //Activates when the cir_mode is completed and activates the square and two half circles upon completion
            else if (_mode == sqTri_mode && int.Parse(userAnswer.text) == sqTri_answer)
            {
                outputBox.text = "CORRECT!";
                userAnswer.Select();
                userAnswer.text = "";
                sqCir1.SetActive(true);
                _mode = sqCir_mode;
            }
            //Activates when the square_tri_mode is completed and activates next scene upon completion
            else if (_mode == sqCir_mode && int.Parse(userAnswer.text) == sqCir_answer)
            {
                outputBox.text = "CORRECT!";
                userAnswer.Select();
                userAnswer.text = "";
                this.enabled = false;
                SceneManager.LoadScene("SecondLevel");
            }
            //Prompts the user they got the incorrect answer
            else
            {
                outputBox.text = "FAILURE! Try again!";
            }
        }
    }
}