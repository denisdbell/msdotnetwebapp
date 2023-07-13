using buildapp.Modules;

namespace buildtest
{
    public class BuildTest
    {
        [Fact]
        public void Test1()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "Value should be equal to 1");
        }
        
        [Fact]
        public void CheckAddFunction()
        {
            Functions func = new Functions();

            int y = func.Add(3, 2);

            bool result = false;

            if (y == 5) result = true;
            Assert.True(result, "Value should be equal to 5");
        }
    }
}