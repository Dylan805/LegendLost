using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Script : MonoBehaviour
{
    // Update is called once per frame
    void OnMouseDown()
    {
        Debug.Log(gameObject + " clicked");
        Destroy(gameObject);
    }
}