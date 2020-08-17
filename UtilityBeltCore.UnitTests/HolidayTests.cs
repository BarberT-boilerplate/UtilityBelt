using FluentAssertions;
using System;
using System.Data;
using System.IO;
using Xunit;
namespace UtilityBeltCore.UnitTests
{
    public class HolidayTests
    {

        [Fact(DisplayName = "Holiday IsFederalHoliday 1()")]
        public void IsFederalHolidayTest1()
        {
            // Arrange
            DateTime Today = new DateTime(2020, 06, 26);

            //Act
            bool returnModel = Holiday.IsFederalHoliday(Today);

            //Assert
            returnModel.Should().Be(false);

        }

        [Fact(DisplayName = "Holiday IsFederalHoliday 2()")]
        public void IsFederalHolidayTest2()
        {
            // Arrange
            DateTime Today = new DateTime(2020,11,26); // Thanksgiving Day    Thursday

            //Act
            bool returnModel = Holiday.IsFederalHoliday(Today);

            //Assert
            returnModel.Should().Be(true);

        }

        //	2017/01/01	New Year's Day	Sunday
        //	2017/01/02	New Year's Day (observed)	Monday
        //	2017/01/16	Martin Luther King Day	Monday
        //	2017/02/20	Presidents' Day*	Monday
        //	2017/05/29	Memorial Day	Monday
        //	2017/07/04	Independence Day	Tuesday
        //	2017/09/04	Labor Day	Monday
        //	2017/10/09	Columbus Day	Monday
        //	2017/11/10	Veterans Day (observed)	Friday
        //	2017/11/11	Veterans Day	Saturday
        //	2017/11/23	Thanksgiving Day	Thursday
        //	2017/12/25	Christmas Day	Monday
        //	2018/01/01	New Year's Day	Monday
        //	2018/01/15	Martin Luther King Day	Monday
        //	2018/02/19	Presidents' Day*	Monday
        //	2018/05/28	Memorial Day	Monday
        //	2018/07/04	Independence Day	Wednesday
        //	2018/09/03	Labor Day	Monday
        //	2018/10/08	Columbus Day	Monday
        //	2018/11/11	Veterans Day	Sunday
        //	2018/11/12	Veterans Day (observed)	Monday
        //	2018/11/22	Thanksgiving Day	Thursday
        //	2018/12/25	Christmas Day	Tuesday
        //	2019/01/01	New Year's Day	Tuesday
        //	2019/01/21	Martin Luther King Day	Monday
        //	2019/02/18	Presidents' Day*	Monday
        //	2019/05/27	Memorial Day	Monday
        //	2019/07/04	Independence Day	Thursday
        //	2019/09/02	Labor Day	Monday
        //	2019/10/14	Columbus Day	Monday
        //	2019/11/11	Veterans Day	Monday
        //	2019/11/28	Thanksgiving Day	Thursday
        //	2019/12/25	Christmas Day	Wednesday
        //	2020/01/01	New Year's Day	Wednesday
        //	2020/01/20	Martin Luther King Day	Monday
        //	2020/02/17	Presidents' Day*	Monday
        //	2020/05/25	Memorial Day	Monday
        //	2020/07/03	Independence Day (observed)	Friday
        //	2020/07/04	Independence Day	Saturday
        //	2020/09/07	Labor Day	Monday
        //	2020/10/12	Columbus Day	Monday
        //	2020/11/11	Veterans Day	Wednesday
        //	2020/11/26	Thanksgiving Day	Thursday
        //	2020/12/25	Christmas Day	Friday
        //	2021/01/01	New Year's Day	Friday
        //	2021/01/18	Martin Luther King Day	Monday
        //	2021/02/15	Presidents' Day*	Monday
        //	2021/05/31	Memorial Day	Monday
        //	2021/07/04	Independence Day	Sunday
        //	2021/07/05	Independence Day (observed)	Monday
        //	2021/09/06	Labor Day	Monday
        //	2021/10/11	Columbus Day	Monday
        //	2021/11/11	Veterans Day	Thursday
        //	2021/11/25	Thanksgiving Day	Thursday
        //	2021/12/24	Christmas Day (observed)	Friday
        //	2021/12/25	Christmas Day	Saturday
        //	2021/12/31	New Year's Day (observed)	Friday
        //	2022/01/01	New Year's Day	Saturday
        //	2022/01/17	Martin Luther King Day	Monday
        //	2022/02/21	Presidents' Day*	Monday
        //	2022/05/30	Memorial Day	Monday
        //	2022/07/04	Independence Day	Monday
        //	2022/09/05	Labor Day	Monday
        //	2022/10/10	Columbus Day	Monday
        //	2022/11/11	Veterans Day	Friday
        //	2022/11/24	Thanksgiving Day	Thursday
        //	2022/12/25	Christmas Day	Sunday
        //	2022/12/26	Christmas Day (observed)	Monday
    }
}
