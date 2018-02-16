using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Made By Ethan Dylan and Zach
//Loads the first level.

public class StartGame : MonoBehaviour
{
    const int leftClick = 0;
    // Use this for initialization
    void Start ()
    {
        
    }
	
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButtonDown(leftClick))
        {
            this.enabled = false;
            SceneManager.LoadScene("FirstLevel");
        }
    }
}