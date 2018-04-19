using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3SpriteUpdate : MonoBehaviour {

    //Sprites to use
    public Sprite oneEighth;
    public Sprite twoEighth;
    public Sprite threeEighth;
    public Sprite fourEighth;
    public Sprite fiveEighth;
    public Sprite sixEighth;
    public Sprite sevenEighth;

    //Used to keep track of current value of box objects
    private float val;

    //Runs on start-up
    private void Start()
    {
        //Gets current val form attached object
        val = this.GetComponentInParent<Level3Script>().value;

        //Based on value, assigns appropriate sprite
        if (val == .125F)
        {
            this.GetComponent<SpriteRenderer>().sprite = oneEighth;
        }
        else if (val == .25F)
        {
            this.GetComponent<SpriteRenderer>().sprite = twoEighth;
        }
        else if (val == .375F)
        {
            this.GetComponent<SpriteRenderer>().sprite = threeEighth;
        }
        else if (val == .5F)
        {
            this.GetComponent<SpriteRenderer>().sprite = fourEighth;
        }
        else if (val == .625F)
        {
            this.GetComponent<SpriteRenderer>().sprite = fiveEighth;
        }
        else if (val == .75F)
        {
            this.GetComponent<SpriteRenderer>().sprite = sixEighth;
        }
        else if (val == .875F)
        {
            this.GetComponent<SpriteRenderer>().sprite = sevenEighth;
        }
        else
        {
            Debug.Log("NO SPRITE FOUND");
        }
    }

    // Update is called once per frame
    void Update () {
        val = this.GetComponentInParent<Level3Script>().value;

        //Same statements as before just used in Update to adjust every mode
        if (val == .125F)
        {
            this.GetComponent<SpriteRenderer>().sprite = oneEighth;
        }
        else if (val == .25F)
        {
            this.GetComponent<SpriteRenderer>().sprite = twoEighth;
        }
        else if (val == .375F)
        {
            this.GetComponent<SpriteRenderer>().sprite = threeEighth;
        }
        else if (val == .5F)
        {
            this.GetComponent<SpriteRenderer>().sprite = fourEighth;
        }
        else if (val == .625F)
        {
            this.GetComponent<SpriteRenderer>().sprite = fiveEighth;
        }
        else if (val == .75F)
        {
            this.GetComponent<SpriteRenderer>().sprite = sixEighth;
        }
        else if (val == .875F)
        {
            this.GetComponent<SpriteRenderer>().sprite = sevenEighth;
        }
        else
        {
            Debug.Log("NO SPRITE FOUND");
        }
    }
}
