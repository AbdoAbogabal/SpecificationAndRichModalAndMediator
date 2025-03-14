namespace SpecificationPattern.UnitTest.Tests;

public class AddressCityTests
{

    [Theory]
    [InlineData(null)]  // Test case 1
    [InlineData("")]   // Test case 2
    [InlineData(null)]   // Test case 3


    /*
    public static IEnumerable<object[]> GetTestData()
      {
          yield return new object[] { null, "" };  // Test case 1
          yield return new object[] { "", null };  // Test case 1
      }

      [Theory]
      [MemberData(nameof(GetTestData))]
    */


    /*
      [Theory]
    [ClassData(typeof(CalculatorTestData))]
    */
    public void Create_Should_ReturnThrowAnException_IfNameIsEmptyOrLengthMoreThan25(string? value)
    {
        // Arrage -> SetUp Instance

        // Act -> Operation
        //var addressCity = AddressCity.Create(value);


        // Assert -> result Value
        Assert.Throws<Exception>(() => AddressCity.Create(value));

        //Assert.True(condition);
        //Assert.False(condition);

        //Assert.Equal(expected, actual);
        //Assert.NotEqual(expected, actual);

        //Assert.Null(value);
        //Assert.NotNull(value);

        //Assert.Same(expected, actual);
        //Assert.NotSame(expected, actual);

        //Assert.Contains(value, collection);
        //Assert.DoesNotContain(value, collection);

        //Assert.Empty(collection);
        //Assert.NotEmpty(collection);

        //Assert.Throws<ExceptionType>(() => TheActionToTheException);
        //await Assert.ThrowsAsync<ExceptionType>(async () => await TheAsyncActionToTheException());

        //Assert.InRange(value, from, to);
        //Assert.NotInRange(value, from, to);

        //Assert.IsType<Type>(value);
        //Assert.IsNotType<Type>(value);

        //Assert.EndsWith(expectedStartWith, value);
        //Assert.StartsWith(expectedStartWith, value);

        //Assert.Matches(pattern, value);
        //Assert.DoesNotMatch(pattern, value);

    }
}


public class CalculatorTestData : TheoryData<string>
{
    public CalculatorTestData()
    {
        // Add test cases
        Add(null);    // Test case 1
        Add(string.Empty);    // Test case 1
        Add(null);    // Test case 1
        Add(string.Empty);    // Test case 1
    }
}