using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level3Answer : MonoBehaviour {

    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;
    public GameObject box6;

    private float total = 0;

    // Use this for initialization
    public void CheckLevel3Answer() {
        if (box1.GetComponent<Level3Script>().selected)
        {
            total += box1.GetComponent<Level3Script>().value;
        }
        if (box2.GetComponent<Level3Script>().selected)
        {
            total += box2.GetComponent<Level3Script>().value;
        }
        if (box3.GetComponent<Level3Script>().selected)
        {
            total += box3.GetComponent<Level3Script>().value;
        }
        if (box4.GetComponent<Level3Script>().selected)
        {
            total += box4.GetComponent<Level3Script>().value;
        }
        if (box5.GetComponent<Level3Script>().selected)
        {
            total += box5.GetComponent<Level3Script>().value;
        }
        if (box6.GetComponent<Level3Script>().selected)
        {
            total += box6.GetComponent<Level3Script>().value;
        }

        if(total == 1)
        {
            Debug.Log("passed");
            total = 0;
        }
        else
        {
            Debug.Log("failed");
            total = 0;
        }
    }
}
