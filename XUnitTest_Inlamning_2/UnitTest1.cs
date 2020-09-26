using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.IO;
using System.Runtime.InteropServices;
using Xunit;
using Xunit.Sdk;

namespace XUnitTest_Inlamning_2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.StartsWith("___", Layout.StandardLayout)
        }
    }
}
