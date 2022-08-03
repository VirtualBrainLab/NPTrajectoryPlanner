using System.Collections;
using NUnit.Framework;
using SensapexLink;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class CommunicationManagerTests
    {
        
        private CommunicationManager _communicationManager;

        [SetUp]
        public void Setup()
        {
            SceneManager.LoadScene("Scenes/TrajectoryPlanner");
            _communicationManager = GameObject.Find("SensapexLink").GetComponent<CommunicationManager>();
        }
        // A Test behaves as an ordinary method
        [Test]
        public void CommunicationManagerTestsSimplePasses()
        {
            const string input = "Hello";
            Assert.That(input, Is.EqualTo("Hello"));
        }

        [Test]
        public void HasAccessToManager()
        {
            Assert.That(_communicationManager, Is.Not.Null);
        }
    }
}