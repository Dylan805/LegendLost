using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //public 
    public Text TimerBox;
    private float Second_Counter = 15f;

    void Start()
    {
        //clicking acknowledge button activates this script
        TimerBox = GetComponent<Text>();
    }

    void Update()
    {
        if (Second_Counter <= 0)
        {
            Second_Counter = 0;
            return; //sends it back to the other script.
        }
        else
        {
            Second_Counter = Second_Counter - Time.deltaTime;
            TimerBox.text = Second_Counter.ToString("f2");
        }
    }
}
