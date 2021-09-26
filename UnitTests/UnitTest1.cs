using GitHubActionsWpfDemo;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var model = new Model();

            Assert.Equal(90, model.Calc(9));
        }
    }
}
