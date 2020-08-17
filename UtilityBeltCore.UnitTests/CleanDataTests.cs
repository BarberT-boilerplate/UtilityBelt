using FluentAssertions;
using Xunit;


namespace UtilityBeltCore.UnitTests
{
    public class CleanDataTests
    {
        [Fact(DisplayName = "CleanDataClass GetCleanDollar_TestNull()")]
        public void GetCleanDollar_TestNull()
        {
            //Arrange
            string Test = "";

            //Act
            decimal returnModel = CleanData.GetCleanDollar(Test);

            //Assert
            returnModel.Should().Be(0m);
        }

        [Fact(DisplayName = "CleanDataClass GetCleanDollar_TestDecimalCheck() ")]
        public void GetCleanDollar_TestDecimalCheck()
        {
            //Arrange
            string Test = "13";

            //Act
            decimal returnModel = CleanData.GetCleanDollar(Test);

            //Assert
            returnModel.Should().Be(13.00m);
        }

        [Fact(DisplayName = "CleanDataClass GetCleanDollar_Test3() ")]
        public void GetCleanDollar_Test3()
        {
            //Arrange
            string Test = "13.33";

            //Act
            decimal returnModel = CleanData.GetCleanDollar(Test);

            //Assert
            returnModel.Should().Be(13.33m);
        }

        [Fact(DisplayName = "CleanDataClass GetCleanPhone_Test1() ")]
        public void GetCleanPhone_Test1()
        {
            //Arrange
            string UserPhone = "8163928808";

            //Act
            string returnModel = CleanData.GetCleanPhone(UserPhone);

            //Assert
            returnModel.Should().Be("8163928808");
        }

        [Fact(DisplayName = "CleanDataClass GetCleanPhone_Test2() ")]
        public void GetCleanPhone_Test2()
        {
            //Arrange
            string UserPhone = "816-392-8808";

            //Act
            string returnModel = CleanData.GetCleanPhone(UserPhone);

            //Assert
            returnModel.Should().Be("8163928808");
        }

        [Fact(DisplayName = "CleanDataClass GetCleanPhone_Test3() ")]
        public void GetCleanPhone_Test3()
        {
            //Arrange
            string UserPhone = "abc-392-8808";

            //Act
            string returnModel = CleanData.GetCleanPhone(UserPhone);

            //Assert
            returnModel.Should().Be("3928808");
        }

        [Fact(DisplayName = "CleanDataClass GetCleanPhone_Test4() ")]
        public void GetCleanPhone_Test4()
        {
            //Arrange
            string UserPhone = "(816)-392-8808";

            //Act
            string returnModel = CleanData.GetCleanPhone(UserPhone);

            //Assert
            returnModel.Should().Be("8163928808");
        }

        [Fact(DisplayName = "CleanDataClass GetCleanSSN_Test1() ")]
        public void GetCleanSSN_Test1()
        {
            //Arrange
            string UserImput = "123-45-6789";

            //Act
            string returnModel = CleanData.GetCleanSSN(UserImput);

            //Assert
            returnModel.Should().Be("123456789");
        }

        [Fact(DisplayName = "CleanDataClass GetCleanSSN_Test2() ")]
        public void GetCleanSSN_Test2()
        {
            //Arrange
            string UserImput = "123de6789";

            //Act
            string returnModel = CleanData.GetCleanSSN(UserImput);

            //Assert
            returnModel.Should().Be("");
        }

        [Fact(DisplayName = "CleanDataClass GetCleanSSN_Test3() ")]
        public void GetCleanSSN_Test3()
        {
            //Arrange
            string UserImput = "987 65 4321";

            //Act
            string returnModel = CleanData.GetCleanSSN(UserImput);

            //Assert
            returnModel.Should().Be("987654321");
        }

        [Fact(DisplayName = "CleanDataClass GetBoolValue_T_F()")]
        public void GetBoolValue_T_F()
        {
            //Arrange
            string input = "t";

            //Act
            bool returnModel = CleanData.GetBoolValue(input);

            //Assert
            returnModel.Should().Be(true);
        }

        [Fact(DisplayName = "CleanDataClass GetBoolValue_True_False()")]
        public void GetBoolValue_True_False()
        {
            //Arrange
            string input = "false";

            //Act
            bool returnModel = CleanData.GetBoolValue(input);

            //Assert
            returnModel.Should().Be(false);
        }

        [Fact(DisplayName = "CleanDataClass GetBoolValue_0_1()")]
        public void GetBoolValue_0_1()
        {
            //Arrange
            string input = "1";

            //Act
            bool returnModel = CleanData.GetBoolValue(input);

            //Assert
            returnModel.Should().Be(true);
        }

        [Fact(DisplayName = "CleanDataClass GetBoolValue_Y_N()")]
        public void GetBoolValue_Y_N()
        {
            //Arrange
            string input = "y";

            //Act
            bool returnModel = CleanData.GetBoolValue(input);

            //Assert
            returnModel.Should().Be(true);
        }

        [Fact(DisplayName = "CleanDataClass GetBoolValue_Yes_No()")]
        public void GetBoolValue_Yes_No()
        {
            //Arrange
            string input = "no";

            //Act
            bool returnModel = CleanData.GetBoolValue(input);

            //Assert
            returnModel.Should().Be(false);
        }

        [Fact(DisplayName = "CleanDataClass GetPayFrequency_Weekly()")]
        public void GetPayFrequency_Weekly()
        {
            //Arrange
            string input = "WEEKLY";

            //Act
            string returnModel = CleanData.GetPayFrequency(input);

            //Assert
            returnModel.Should().Be("w");
        }

        [Fact(DisplayName = "CleanDataClass GetPayFrequency_Bi_Weekly()")]
        public void GetPayFrequency_Bi_Weekly()
        {
            //Arrange
            string input = "BI WEEKLY";

            //Act
            string returnModel = CleanData.GetPayFrequency(input);

            //Assert
            returnModel.Should().Be("bi");
        }

        [Fact(DisplayName = "CleanDataClass GetPayFrequency_Monthly()")]
        public void GetPayFrequency_Monthly()
        {
            //Arrange
            string input = "MONTHLY";

            //Act
            string returnModel = CleanData.GetPayFrequency(input);

            //Assert
            returnModel.Should().Be("m");
        }

        [Fact(DisplayName = "CleanDataClass GetPayFrequency_Null()")]
        public void GetPayFrequency_Null()
        {
            //Arrange
            string input = "";

            //Act
            string returnModel = CleanData.GetPayFrequency(input);

            //Assert
            returnModel.Should().Be("sm");
        }

        [Fact(DisplayName = "CleanDataClass IsCardNumberValid_Test1()")]
        public void IsCardNumberValid_Test1()
        {
            //Arrange
            bool SpaceAllowed = true;
            string CardNumber = "1234 5678 1234 5678";

            //Act
            bool returnModel = CleanData.IsCardNumberValid(CardNumber, SpaceAllowed);

            //Assert
            returnModel.Should().Be(false);
        }

        [Fact(DisplayName = "CleanDataClass IsCardNumberValid_Test2()")]
        public void IsCardNumberValid_Test2()
        {
            //Arrange
            bool SpaceAllowed = true;
            string CardNumber = "1234 5647 1234 5678";

            //Act
            bool returnModel = CleanData.IsCardNumberValid(CardNumber, SpaceAllowed);

            //Assert
            returnModel.Should().Be(true);
        }

        [Fact(DisplayName = "CleanDataClass IsCardNumberValid_Test3()")]
        public void IsCardNumberValid_Test3()
        {
            //Arrange
            bool SpaceAllowed = true;
            string CardNumber = "1111 1111 1111 1111";
            //Act
            bool returnModel = CleanData.IsCardNumberValid(CardNumber, SpaceAllowed);

            //Assert
            returnModel.Should().Be(false);
        }
    }
}
