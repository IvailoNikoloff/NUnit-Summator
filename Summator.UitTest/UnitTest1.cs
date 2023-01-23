using System;

namespace Summator.UitTest
{
    public class Tests
{
    [Test]
    public void Test_Summator_Two_Positive_Numbers()
    {
        var nums = new int[] { 1, 2 };
        var expected = 3;
        
        var actual = Summator.Sum(nums);
        
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public  void Test_Summator_Two_Negative_Numbers()
    {
        var nums = new int[] { -1, -99 };
        var expected = -100;
        
        var actual = Summator.Sum(nums);
        
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public  void Test_Summator_one_number()
    {
        var nums = new int[] { 6 };
        var expected = 6;
        
        var actual = Summator.Sum(nums);
        
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public  void Test_Summator_ZeroNumber()
    {
        var nums = new int[] {};
        var expected = 0;
        
        var actual = Summator.Sum(nums);
        
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public  void Test_Summator_BigNumbers()
    {
        var nums = new int[] {2000000000, 2000000000, 2000000000 };
        var expected = 6000000000;
        
        var actual = Summator.Sum(nums);
        
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Average_Two_Positive_intNumbers_With_Expected_IntResult()
    {
        var nums = new int[] {1, 2, 3};
        var expected = 2;

        var actual = Summator.Average(nums);
        
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void Test_Average_Two_Positive_intNumbers_With_Expected_DoubleResult()
    {
        var nums = new int[] {1, 3, 4};
        var expected = 2.67;

        var actual = Summator.Average(nums);
        
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void Test_Average_Two_Negative_intNumbers_With_Expected_DoubleResult()
    {
        var nums = new int[] {-1, -3, -4};
        var expected = -2.67;

        var actual = Summator.Average(nums);
        
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void Test_Average_Zero_Numbers()
    {
        // Test with exception
        var nums = new int[] {};
        Assert.Throws<DivideByZeroException>(
            delegate { throw new DivideByZeroException(); }); 
        
    }
    
    
}
}

