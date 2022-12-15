
using SimpleApi.Controllers;
namespace SimpleApi.Test;

public class UnitTest1
{
    EmployeeController employeeController = new EmployeeController();

    [Fact]
    public void GetReturnsMyName()
    {
        var returnvalue = employeeController.GetValues(1);
        Assert.Equal("sample test", returnvalue.Value);

    }

    [Fact]
    public void Test1()
    {

    }
}