using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level3Script : MonoBehaviour
{
    public bool selected = false; //Selected flag
    public float value; //Hard coded value for boxes, will be changed later

    private const float SWITDTH = 0.15F; //Scale Width
    private const float SHEIGHT = 0.15F; //Scale Hight
    private const float DISPLACE = 0.5F; //Displacement fix for scale adjust

    //Every mouse click on box will either select the box and enlarge it or deselect the box and return it to normal size.
    //The result is then logged to the debugger for ease of access
    void OnMouseDown()
    {
        //Branch for selected
        if (selected)
        {
            selected = false;
            gameObject.transform.localScale -= new Vector3(SWITDTH, SHEIGHT, 0);
            gameObject.transform.Translate(Vector3.up * DISPLACE);
        }
        //Branch for deselected
        else
        {
            selected = true;
            gameObject.transform.localScale += new Vector3(SWITDTH, SHEIGHT, 0);
            gameObject.transform.Translate(Vector3.up * -DISPLACE);
        }

        Debug.Log(gameObject + " clicked " + selected);
        //Logs the box that was clicked and if it was selected
    }
}