namespace UnitTest;

public class UnitTest1
{
    [Fact]
    public void Input_7_Should_Return_7()
    {
        int[] input = [7];

        int result = Odd.FindOdd(input);
        Assert.Equal(7, result);
    }

    [Fact]
    public void Input_0_Should_Return_0()
    {
        int[] input = [0];

        int result = Odd.FindOdd(input);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Input_1_1_2_Should_Return_2()
    {
        int[] input = [1, 1, 2];

        int result = Odd.FindOdd(input);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Input_0_1_0_1_0_Should_Return_0()
    {
        int[] input = [0, 1, 0, 1, 0];

        int result = Odd.FindOdd(input);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Input_1_2_2_3_3_3_4_3_3_3_2_1_Should_Return_0()
    {
        int[] input = [1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1];

        int result = Odd.FindOdd(input);
        Assert.Equal(4, result);
    }
}