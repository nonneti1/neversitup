namespace UnitTest;

public class UnitTest1
{
    [Fact]
    public void Input_3_Faces_Should_Return_2()
    {
        var input = new string[] { ":)", ";(", "}", ":-D" };
        var result = Smile.CountSmileyFace(input);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Input_4_Faces_Should_Return_3()
    {
        var input = new string[] { ";D", ":-(", ":-)", ";)" };
        var result = Smile.CountSmileyFace(input);

        Assert.Equal(3, result);
    }

    [Fact]
    public void Input_5_Faces_Should_Return_1()
    {
        var input = new string[] { ";]", ":[", ";*", ":$", ";-D" };
        var result = Smile.CountSmileyFace(input);

        Assert.Equal(1, result);
    }
}