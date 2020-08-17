using FluentAssertions;
using Xunit;

namespace UtilityBeltCore.UnitTests
{
    public class ExtensionMethodsTests
    {
        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 1st")]
        public void ToOrdinaTest1st()
        {
            int testInt = 1;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("1st");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 2nd")]
        public void ToOrdinalTest2nd()
        {
            int testInt = 2;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("2nd");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 3rd")]
        public void ToOrdinalTest3rd()
        {
            int testInt = 3;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("3rd");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 4th")]
        public void ToOrdinalTest4th()
        {
            int testInt = 4;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("4th");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 5th")]
        public void ToOrdinalTest5th()
        {
            int testInt = 5;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("5th");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 7th")]
        public void ToOrdinalTest7th()
        {
            int testInt = 7;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("7th");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 9th")]
        public void ToOrdinalTest9th()
        {
            int testInt = 9;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("9th");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 11th")]
        public void ToOrdinalTest11th()
        {
            int testInt = 11;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("11th");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 13th")]
        public void ToOrdinalTest13th()
        {
            int testInt = 13;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("13th");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 19th")]
        public void ToOrdinalTest19th()
        {
            int testInt = 19;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("19th");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 21st")]
        public void ToOrdinalTest21st()
        {
            int testInt = 21;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("21st");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 22nd")]
        public void ToOrdinalTest22nd()
        {
            int testInt = 22;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("22nd");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 23rd")]
        public void ToOrdinalTest23rd()
        {
            int testInt = 23;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("23rd");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 29th")]
        public void ToOrdinalTest29th()
        {
            int testInt = 29;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("29th");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 30th")]
        public void ToOrdinalTest30th()
        {
            int testInt = 30;


            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("30th");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 33rd")]
        public void ToOrdinalTest33rd()
        {
            int testInt = 33;
            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("33rd");
        }

        [Fact(DisplayName = "ExtensionMethods ToOrdinal() 38th")]
        public void ToOrdinalTest38th()
        {
            int testInt = 38;
            //Act
            var returnString = testInt.ToOrdinal();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("38th");
        }
    
        [Fact(DisplayName = "ExtensionMethods ToDate 1st () ")]
        public void ToDateTest1st()
        {
            string testString = "2017-01-13 10:13:01";
            //Act
            var returnString = testString.ToDate();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("1/13/2017");
        }

        [Fact(DisplayName = "ExtensionMethods ToDate 2nd () ")]
        public void ToDateTest2nd()
        {
            string testString = "2018-05-21 05:22:11";
            //Act
            var returnString = testString.ToDate();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("5/21/2018");
        }

        [Fact(DisplayName = "ExtensionMethods ToDate 3rd () ")]
        public void ToDateTest3rd()
        {
            string testString = "2019-05-15 05:22:11";
            //Act
            var returnString = testString.ToDate();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("5/15/2019");
        }
      
        [Fact(DisplayName = "ExtensionMethods ToDollar Int 1P() ")]
        public void ToDollarTestInt1P()
        {
            int testInt = 3;

            //Act
            var returnString = testInt.ToDollar();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("$3.00");
        }

        [Fact(DisplayName = "ExtensionMethods ToDollar Int 2P() ")]
        public void ToDollarTestInt2P()
        {
            int testInt = 13;

            //Act
            var returnString = testInt.ToDollar();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("$13.00");
        }

        [Fact(DisplayName = "ExtensionMethods ToDollar Int 3P() ")]
        public void ToDollarTestInt3P()
        {
            int testInt = 999;

            //Act
            var returnString = testInt.ToDollar();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("$999.00");
        }

        [Fact(DisplayName = "ExtensionMethods ToDollar Double 1P () ")]
        public void ToDollarTestDouble1P()
        {
            double testInt = 1.00;

            //Act
            var returnString = testInt.ToDollar();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("$1.00");
        }

        [Fact(DisplayName = "ExtensionMethods ToDollar Double 2P () ")]
        public void ToDollarTestDouble2P()
        {
            double testInt = 37.12;

            //Act
            var returnString = testInt.ToDollar();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("$37.12");
        }

        [Fact(DisplayName = "ExtensionMethods ToDollar Double 3P () ")]
        public void ToDollarTestDouble3P()
        {
            double testInt = 492.81;

            //Act
            var returnString = testInt.ToDollar();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("$492.81");
        }

        [Fact(DisplayName = "ExtensionMethods ToDollar Decimal 3P () ")]
        public void ToDollarTestDecimal3P()
        {
            decimal testInt = 736.42m;

            //Act
            var returnString = testInt.ToDollar();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("$736.42");
        }

        [Fact(DisplayName = "ExtensionMethods ToDollar Decimal 2P () ")]
        public void ToDollarTestDecimal2P()
        {
            decimal testInt = 36.42m;

            //Act
            var returnString = testInt.ToDollar();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("$36.42");
        }

        [Fact(DisplayName = "ExtensionMethods ToDollar Decimal 1P () ")]
        public void ToDollarTestDecimal1P()
        {
            decimal testInt = 6.42m;

            //Act
            var returnString = testInt.ToDollar();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("$6.42");
        }

        [Fact(DisplayName = "ExtensionMethods ToPercent Int 1P() ")]
        public void ToPercentTestInt1P()
        {
            int testInt = 3;
            //Act
            var returnString = testInt.ToPercent();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("3%");
        }

        [Fact(DisplayName = "ExtensionMethods ToPercent Int 2P() ")]
        public void ToPercentTestInt2P()
        {
            int testInt = 35;
            //Act
            var returnString = testInt.ToPercent();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("35%");
        }

        [Fact(DisplayName = "ExtensionMethods ToPercent Double 1P () ")]
        public void ToPercentTestDouble1P()
        {
            double testInt = 5.00;
            //Act
            var returnString = testInt.ToPercent();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("5%");
        }

        [Fact(DisplayName = "ExtensionMethods ToPercent Double 2P () ")]
        public void ToPercentTestDouble2P()
        {
            double testInt = 75.00;
            //Act
            var returnString = testInt.ToPercent();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("75%");
        }

        [Fact(DisplayName = "ExtensionMethods ToPercent Decimal 1P () ")]
        public void ToPercentTestDecimal1P()
        {
            decimal testInt = 5m;
            //Act
            var returnString = testInt.ToPercent();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("5%");
        }

        [Fact(DisplayName = "ExtensionMethods ToPercent Decimal 2P () ")]
        public void ToPercentTestDecimal2P()
        {
            decimal testInt = 82m;
            //Act
            var returnString = testInt.ToPercent();

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("82%");
        }

        [Fact(DisplayName = "ExtensionMethods ToDigitsOnly_ABC123() ")]
        public void ToDigitsOnly_ABC123()
        {
            //Arrange
            string Input = "abc123";

            //Act
            string returnString = ExtensionMethods.ToDigitsOnly(Input);

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("123");
        }

        [Fact(DisplayName = "ExtensionMethods ToDigitsOnly_123() ")]
        public void ToDigitsOnly_123()
        {
            //Arrange
            string Input = "123";

            //Act
            string returnString = ExtensionMethods.ToDigitsOnly(Input);

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("123");
        }

        [Fact(DisplayName = "ExtensionMethods ToDigitsOnly_ABC() ")]
        public void ToDigitsOnly_ABC()
        {
            //Arrange
            string Input = "abc";

            //Act
            string returnString = ExtensionMethods.ToDigitsOnly(Input);

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("");
        }

        [Fact(DisplayName = "ExtensionMethods ToTitleCase_ABC() ")]
        public void ToTitleCase_ABC()
        {
            //Arrange
            string Input = "abc";

            //Act
            string returnString = ExtensionMethods.ToTitleCase(Input);

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("Abc");
        }

        [Fact(DisplayName = "ExtensionMethods ToTitleCase_Name() ")]
        public void ToTitleCase_Name()
        {
            //Arrange
            string Input = "timothy hewitt";

            //Act
            string returnString = ExtensionMethods.ToTitleCase(Input);

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("Timothy Hewitt");
        }

        [Fact(DisplayName = "ExtensionMethods ToTitleCase_Numbers() ")]
        public void ToTitleCase_Numbers()
        {
            //Arrange
            string Input = "timothy 123 hewitt";

            //Act
            string returnString = ExtensionMethods.ToTitleCase(Input);

            //Assert
            returnString.Should().NotBeNull();
            returnString.Should().Be("Timothy 123 Hewitt");
        }

    }
}
