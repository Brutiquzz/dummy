using Xunit.Abstractions;

namespace dummy.test
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Test1()
        {
            output.WriteLine("Hello from test 1");
            Assert.Equal(1, 1);
        }

        [Fact]
        public void Test2()
        {
            output.WriteLine("Hello from test 2");
            Assert.Equal(1, 2);
        }
    }
}