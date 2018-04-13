using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class DevCycle3Ethan1 {

    // Tests that mode 1 has catapult at 0
    [Test]
    public void CatAtZeroTest()
    {
        const int catAtZero = 1; //fist mode, when the catapult is at 0 and the target is at a positive number
        const int catTarPositive = 2; //second mode, when the catapult and target are at positive numbers
        int mode = catAtZero;

        System.Random rnd = new System.Random();
        int num1;
        int num2;
        if (mode == catAtZero)
        {
            num1 = 0;
            num2 = rnd.Next(6, 11) * 5;
            
        }
        else if (mode == catTarPositive)
        {
            num1 = rnd.Next(1, 6) * 5;
            num2 = rnd.Next(6, 11) * 5;
            
        }
        else
        {
            num1 = 99;
            num2 = 0;
           
        }
        Assert.True(num1 == 0 && num2 != 0);
    }
}
