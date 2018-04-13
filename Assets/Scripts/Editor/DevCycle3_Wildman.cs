using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class DevCycle3_Wildman
{
    // Tests the ability for unity to interpret ALT keys '227' (alt+227 = π) in a game object
    [Test]
    public void GameObject_Contains_Proper_ALTKEY()
    {
        var pi = new GameObject("π");
        Assert.AreEqual("π", pi.name);
    }
    // Tests the ability for unity to interpet ALT keys '227' (alt+227 = π) in a game object with regular text
    [Test]
    public void GameObject_Contains_Proper_ALTKEY_With_Other()
    {
        var pi_with_other = new GameObject("+ π");
        Assert.AreEqual("+ π", pi_with_other.name);
    }
    //Proves I'm not making these codes intnetionally fail
    [Test]
    public void GameObject_IsNot_Being_Forced_To_Pass()
    {
        var pi_with_diff = new GameObject("π");
        Assert.AreNotEqual("+ π", pi_with_diff.name);
    }
}
