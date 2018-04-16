using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level3Script : MonoBehaviour
{
    // Update is called once per frame
    public bool selected = false;
    public float value;

    void OnMouseDown()
    {
        if(selected)
        {
            selected = false;
            gameObject.transform.localScale -= new Vector3(0.1F, 0.1F, 0);
            gameObject.transform.Translate(Vector3.up * 0.3F);
        }
        else
        {
            selected = true;
            gameObject.transform.localScale += new Vector3(0.1F, 0.1F, 0);
            gameObject.transform.Translate(Vector3.up * -0.3F);
        }

        Debug.Log(gameObject + " clicked " + selected);
    }
}