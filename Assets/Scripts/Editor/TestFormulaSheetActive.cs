using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEditor;

public class TestFormulaSheetActive
{
    // Test if object is true
    [UnityTest]
    public IEnumerator _Instantiation_Formula_Button_Active()
    {
        var formula = new GameObject();
        formula.SetActive(true);

        Assert.IsTrue(formula);
        return null;
    }
    // Test if object is false
    [UnityTest]
    public IEnumerator _Instantiation_Formula_Button_Inactive()
    {
        var formula = new GameObject();
        formula.SetActive(false);

        Assert.IsTrue(formula);
        return null;
    }
}
