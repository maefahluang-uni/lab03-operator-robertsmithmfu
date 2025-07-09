namespace test_program;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;
public class UnitTest
{
    [Fact]
    public void testProgram()
    {
        Console.SetIn(new StringReader("10 \n 5"));
        StringWriter output = new StringWriter();
        Console.SetOut(output);
        Program.run();
       
        Assert.Contains("Are the first and second numbers equal? No", output.ToString());
        Assert.Contains("Is the first number greater than the second number? Yes", output.ToString());
        Assert.Contains("Is the first number even? Yes", output.ToString());
        Assert.Contains("The remainder when the first number is divided by the second number is 0", output.ToString());
    }
}