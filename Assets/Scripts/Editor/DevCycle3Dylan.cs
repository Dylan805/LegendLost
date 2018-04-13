using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class DevCycle3Dylan
{
    
    
    // Tests that 6 game objects can be compared to add up to one
    [Test]
    public void GameObjectsCompared()
    {
        const int ARRAY_SIZE = 6;
        var goList = new double[ARRAY_SIZE];
        goList[0] = .75;
        goList[1] = .75;
        goList[2] = .75;
        goList[3] = .5;
        goList[4] = .25;
        goList[5] = .75;
        bool onePassed = false;
        bool oneFailed = false;

        for(int i = 0; i < ARRAY_SIZE; i++)
        {
            for(int j = 0; j < ARRAY_SIZE; j++)
            {
                double combined = goList[i] + goList[j];

                if (goList[i] + goList[j] == 1)
                {
                    Debug.Log("Add to 1!");
                    Assert.AreEqual(combined, 1);
                    onePassed = true;
                }
                else
                {
                    Debug.Log("Do not add to 1");
                    Assert.AreNotEqual(combined, 1);
                    oneFailed = true;
                }
            }
        }

        Assert.True(oneFailed);
        Assert.True(onePassed);
    }
}
