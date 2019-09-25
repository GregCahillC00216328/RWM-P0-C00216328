using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    
    public class RunningTotalTest
    {
        // A Test behaves as an ordinary method
        RunningTotalFilter test=new RunningTotalFilter();
        [Test]
        
        public void RunningTotalTestSimplePasses()
        {
            float[] expected = { 1, 4, 9, 16, 25 };
            test.runningCalc(new float[5] { 1, 3, 5, 7, 9 });
            
            CollectionAssert.AreEqual(expected, test.result);
            // Use the Assert class to test conditions
        }

        
    }
}
