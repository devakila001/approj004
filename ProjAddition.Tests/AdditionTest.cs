using ProjAddition;
namespace ProjAddition.Tests;

public class AdditionTest
{
    [Fact]
    public void CheckIf2Plus2is4Test()
    {
        //Arrange        
        Adder adderObject = new Adder();
        //Act
        int sumOf2Plus2 = adderObject.Sum(2,2);
        //Assert
        Assert.Equal(4,sumOf2Plus2);
    }

    [Fact]
    public void CheckIf2Plus10is12Test()
    {
        //Arrange        
        Adder adderObject = new Adder();
        //Act
        int sumOf2Plus2 = adderObject.Sum(2,10);
        //Assert
        Assert.Equal(12,sumOf2Plus2);
    }

}