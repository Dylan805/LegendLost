using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level3Answer : MonoBehaviour {

    //Makes variables for the 6 gameObjects
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;
    public GameObject box6;

    //Textbox
    public Text textbox;

    //Shapes in gameObjects
    public GameObject box1Object;
    public GameObject box2Object;
    public GameObject box3Object;
    public GameObject box4Object;
    public GameObject box5Object;
    public GameObject box6Object;

    //Text in Objects
    public Text box1Text;
    public Text box2Text;
    public Text box3Text;
    public Text box4Text;
    public Text box5Text;
    public Text box6Text;

    //Initialize private vars
    private float total = 0;
    private int mode = 0;

    //Gathers each selected boxes values and adds them together to check if equal to whole.
    //If equal or not equal to whole value, the response is logged to debugger for ease of access.
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
            textbox.text = "CORRECT!";
            mode++;

        }
        else
        {
            Debug.Log("failed");
            total = 0;
            textbox.text = "Failure, try again";
        }

        //Circle parts only
        if (mode == 0)
        {
            box1.GetComponent<Level3Script>().value = .375F;
            box2.GetComponent<Level3Script>().value = .125F;
            box3.GetComponent<Level3Script>().value = .25F;
            box4.GetComponent<Level3Script>().value = .875F;
            box5.GetComponent<Level3Script>().value = .375F;
            box6.GetComponent<Level3Script>().value = .75F;
        }
        else if (mode == 1)
        {
            box1.GetComponent<Level3Script>().value = .25F;
            box2.GetComponent<Level3Script>().value = .25F;
            box3.GetComponent<Level3Script>().value = .25F;
            box4.GetComponent<Level3Script>().value = .25F;
            box5.GetComponent<Level3Script>().value = .25F;
            box6.GetComponent<Level3Script>().value = .25F;
        }
        else if (mode == 2)
        {
            box1.GetComponent<Level3Script>().value = .25F;
            box2.GetComponent<Level3Script>().value = .25F;
            box3.GetComponent<Level3Script>().value = .25F;
            box4.GetComponent<Level3Script>().value = .25F;
            box5.GetComponent<Level3Script>().value = .25F;
            box6.GetComponent<Level3Script>().value = .25F;
        }
        //Fractions only
        else if (mode == 3)
        {
            //Switch box to fractions componants
            box1Object.SetActive(false);
            box2Object.SetActive(false);
            box3Object.SetActive(false);
            box4Object.SetActive(false);
            box5Object.SetActive(false);
            box6Object.SetActive(false);

            box1Text.text = "1/8";
            box2Text.text = "2/8";
            box3Text.text = "1/4";
            box4Text.text = "3/8";
            box5Text.text = "1/2";
            box6Text.text = "1/8";

            box1.GetComponent<Level3Script>().value = .125F;
            box2.GetComponent<Level3Script>().value = .25F;
            box3.GetComponent<Level3Script>().value = .25F;
            box4.GetComponent<Level3Script>().value = .375F;
            box5.GetComponent<Level3Script>().value = .5F;
            box6.GetComponent<Level3Script>().value = .125F;
        }
        else if (mode == 4)
        {
            box1.GetComponent<Level3Script>().value = .25F;
            box2.GetComponent<Level3Script>().value = .25F;
            box3.GetComponent<Level3Script>().value = .25F;
            box4.GetComponent<Level3Script>().value = .25F;
            box5.GetComponent<Level3Script>().value = .25F;
            box6.GetComponent<Level3Script>().value = .25F;
        }
        else if (mode == 5)
        {
            box1.GetComponent<Level3Script>().value = .25F;
            box2.GetComponent<Level3Script>().value = .25F;
            box3.GetComponent<Level3Script>().value = .25F;
            box4.GetComponent<Level3Script>().value = .25F;
            box5.GetComponent<Level3Script>().value = .25F;
            box6.GetComponent<Level3Script>().value = .25F;
        }
        //Mixed groups
        else if (mode == 6)
        {
            //Switch box to mixed componants

            box1.GetComponent<Level3Script>().value = .25F;
            box2.GetComponent<Level3Script>().value = .25F;
            box3.GetComponent<Level3Script>().value = .25F;
            box4.GetComponent<Level3Script>().value = .25F;
            box5.GetComponent<Level3Script>().value = .25F;
            box6.GetComponent<Level3Script>().value = .25F;
        }
        else if (mode == 7)
        {
            box1.GetComponent<Level3Script>().value = .25F;
            box2.GetComponent<Level3Script>().value = .25F;
            box3.GetComponent<Level3Script>().value = .25F;
            box4.GetComponent<Level3Script>().value = .25F;
            box5.GetComponent<Level3Script>().value = .25F;
            box6.GetComponent<Level3Script>().value = .25F;
        }
        else if (mode == 8)
        {
            box1.GetComponent<Level3Script>().value = .25F;
            box2.GetComponent<Level3Script>().value = .25F;
            box3.GetComponent<Level3Script>().value = .25F;
            box4.GetComponent<Level3Script>().value = .25F;
            box5.GetComponent<Level3Script>().value = .25F;
            box6.GetComponent<Level3Script>().value = .25F;
        }
        else if (mode == 9)
        {
            //Next Level
            SceneManager.LoadScene("FourthLevel");
        }
        else
        {
            Debug.Log("ERROR: NO MODE FOUND");
        }
    }
}
