namespace UnitTest;

public class UnitTest1
{
    [Fact]
    public void EmptyString_ShouldReturnEmptyList()
    {
        string str = "";

        List<string> permutations = Permutations.FindPermutations(str);

        Assert.Empty(permutations);
    }

    [Fact]
    public void Intput_a()
    {
        string str = "a";

        List<string> permutations = Permutations.FindPermutations(str);

        Assert.Single(permutations);
        Assert.Equal(str, permutations[0]);
    }

    [Fact]
    public void Input_ab()
    {
        string str = "ab";

        List<string> permutations = Permutations.FindPermutations(str);

        Assert.Equal(2, permutations.Count);
        Assert.Contains(permutations, perm => perm == "ab");
        Assert.Contains(permutations, perm => perm == "ba");
    }

    [Fact]
    public void Input_abc()
    {
        string str = "abc";

        List<string> permutations = Permutations.FindPermutations(str);

        Assert.Equal(6, permutations.Count);
        Assert.Contains(permutations, perm => perm == "abc");
        Assert.Contains(permutations, perm => perm == "acb");
        Assert.Contains(permutations, perm => perm == "bac");
        Assert.Contains(permutations, perm => perm == "bca");
        Assert.Contains(permutations, perm => perm == "cab");
        Assert.Contains(permutations, perm => perm == "cba");
    }

    [Fact]
    public void Input_aabb()
    {
        string str = "aabb";

        List<string> permutations = Permutations.FindPermutations(str);

        Assert.Contains(permutations, perm => perm == "aabb");
        Assert.Contains(permutations, perm => perm == "abab");
        Assert.Contains(permutations, perm => perm == "abba");
        Assert.Contains(permutations, perm => perm == "baab");
        Assert.Contains(permutations, perm => perm == "baba");
        Assert.Contains(permutations, perm => perm == "bbaa");
    }
}