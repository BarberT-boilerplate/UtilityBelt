using FluentAssertions;
using System;
using System.Globalization;
using Xunit;


namespace UtilityBeltCore.UnitTests
{
    public class DateTimeHelperTests
    {
        [Fact(DisplayName = "DateTimeHelper GetNextWeekday 1()")]
        public void GetNextWeekdayTest1()
        {
            //Arrange
            DateTime DateTime = new DateTime(2018, 5, 16, 10, 0, 0);

            //Act
            DateTime returnModel = DateTimeHelper.GetNextWeekday(DateTime);

            //Assert
            returnModel.Should().Be(new DateTime(2018, 5, 17, 10, 0, 0));
        }

        [Fact(DisplayName = "DateTimeHelper GetNextWeekday 2()")]
        public void GetNextWeekdayTest2()
        {
            //Arrange
            DateTime DateTime = new DateTime(2018, 5, 18, 10, 0, 0);

            //Act
            DateTime returnModel = DateTimeHelper.GetNextWeekday(DateTime);

            //Assert
            returnModel.Should().Be(new DateTime(2018, 5, 21, 10, 0, 0));
        }
    }
}