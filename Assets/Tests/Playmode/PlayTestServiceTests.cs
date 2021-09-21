using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayTestServiceTests
{
    // A Test behaves as an ordinary method
    [Test]
    [TestCase("Name")]
    public void Create_WithName_ReturnGameObject(string name)
    {
        GameObject expected = new GameObject(name);

        GameObject result = PlayTestService.Create(name);

        Assert.AreEqual(expected.name, result.name);
    }
}
