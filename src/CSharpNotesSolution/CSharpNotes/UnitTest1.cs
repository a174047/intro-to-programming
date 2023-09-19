namespace CSharpNotes;

public class UnitTest1
{
    [Fact]
    public void CanAddTwoSpecificIntegers()
    {
        // Given
        int a = 10;
        int b = 20;
        int sum;

        // When
        sum = a + b;

        // Then
        Assert.Equal(30, sum);
    }

    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(20, 30, 50)]
    [InlineData(200, 30, 230)]
    public void GivenAnyTwoIntegersWeCanAddThemTogether(int a, int b, int expected)
    {
        int sum = a + b;
        Assert.Equal(expected, sum);
    }
}