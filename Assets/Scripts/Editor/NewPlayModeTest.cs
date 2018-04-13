using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewPlayModeTest
{
    //test that an object that is created act
    [Test]
    public void GameObject_CreatedWithGiven_WillHaveTheName()
    {
        var go = new GameObject("helpText");
        Assert.AreEqual("helpText", go.name);
    }

    [Test]
    public void GameObjectHasNumber()
    {
        System.Random rnd = new System.Random();

        var num = new System.Int32();
        num = rnd.Next(1, 5);
        Assert.GreaterOrEqual(num, 0);
    }

    [Test]
    public void GameObjectIsRightOrWrong()
    {
        System.Random rnd = new System.Random();
        const int FALSE = 0;
        const int TRUE = 1;

        var answer = rnd.Next(0, 2);
        var response = "";
        if (answer == FALSE)
        {
            response = "INCORRECT"; 
        }
        if (answer == TRUE)
        {
            response = "CORRECT";
        }

        if(answer == FALSE)
        {
            Assert.AreEqual(response, "INCORRECT");
        }
        else if(answer == TRUE)
        {
            Assert.AreEqual(response, "CORRECT");
        }
        else
        {
            Assert.Fail("Does not pass");
        }
    }
}
