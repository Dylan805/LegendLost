using UnityEngine;
using UnityEngine.SceneManagement;

//Made by Dylan
//Makes the loading screen move across the screen.

public class GridScroll : MonoBehaviour
{
    public GameObject StartingTile;
    public int scrollSpeed;
    
    private bool left = false;
    
    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("Move", 0.0f, 0.2f);
    }
	
    // Update is called once per frame
    void Move()
    {
        if (left)
        {
            transform.position = Vector3.right;
            left = false;
        }
        else
        {
            transform.position = Vector3.left;
            left = true;
        }
    }
}
