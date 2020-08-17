using FluentAssertions;
using System;
using System.Data;
using System.IO;
using Xunit;

namespace UtilityBeltCore.UnitTests
{
    public class DatatableTests
    {
        [Fact(DisplayName = "Datatable GetInt 1()")]
        public void GetIntTest1()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn fNameColumn = new DataColumn();
            fNameColumn.DataType = System.Type.GetType("System.String");
            fNameColumn.ColumnName = "Fname";
            fNameColumn.DefaultValue = null;
            table.Columns.Add(fNameColumn);

            DataColumn ageColumn = new DataColumn();
            ageColumn.DataType = System.Type.GetType("System.Int32");
            ageColumn.ColumnName = "Age";
            ageColumn.DefaultValue = null;
            table.Columns.Add(ageColumn);

            DataRow row1 = table.NewRow();

            row1["Fname"] = "Tim";
            row1["Age"] = 33;
            table.Rows.Add(row1);

            //Act
            int returnModel = Datatable.GetInt(row1, "Age", -1);

            //Assert
            returnModel.Should().Be(33);
        }

        [Fact(DisplayName = "Datatable GetInt 2()")]
        public void GetIntTest2()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn fNameColumn = new DataColumn();
            fNameColumn.DataType = System.Type.GetType("System.String");
            fNameColumn.ColumnName = "Fname";
            fNameColumn.DefaultValue = null;
            table.Columns.Add(fNameColumn);

            DataColumn ageColumn = new DataColumn();
            ageColumn.DataType = System.Type.GetType("System.Int32");
            ageColumn.ColumnName = "Age";
            ageColumn.DefaultValue = null;
            table.Columns.Add(ageColumn);

            DataRow row1 = table.NewRow();

            row1["Fname"] = "Frank";
            row1["Age"] = 41;
            table.Rows.Add(row1);

            //Act
            int returnModel = Datatable.GetInt(row1, "Age", -1);

            //Assert
            returnModel.Should().Be(41);
        }

        [Fact(DisplayName = "Datatable GetInt 3()")]
        public void GetIntTest3()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn fNameColumn = new DataColumn();
            fNameColumn.DataType = System.Type.GetType("System.String");
            fNameColumn.ColumnName = "Fname";
            fNameColumn.DefaultValue = null;
            table.Columns.Add(fNameColumn);

            DataColumn ageColumn = new DataColumn();
            ageColumn.DataType = System.Type.GetType("System.Int32");
            ageColumn.ColumnName = "Age";
            ageColumn.DefaultValue = null;
            table.Columns.Add(ageColumn);

            DataRow row1 = table.NewRow();

            row1["Fname"] = "Jerry";
            row1["Age"] = 22;
            table.Rows.Add(row1);

            //Act
            int returnModel = Datatable.GetInt(row1, "Age", -1);

            //Assert
            returnModel.Should().Be(22);
        }

        [Fact(DisplayName = "Datatable GetInt Null()")]
        public void GetIntTestNull()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn fNameColumn = new DataColumn();
            fNameColumn.DataType = System.Type.GetType("System.String");
            fNameColumn.ColumnName = "Fname";
            fNameColumn.DefaultValue = null;
            table.Columns.Add(fNameColumn);

            DataColumn ageColumn = new DataColumn();
            ageColumn.DataType = System.Type.GetType("System.Int32");
            ageColumn.ColumnName = "Age";
            ageColumn.DefaultValue = null;
            table.Columns.Add(ageColumn);

            DataRow row1 = table.NewRow();

            row1["Fname"] = "Tim";
            row1["Age"] = DBNull.Value;
            table.Rows.Add(row1);

            //Act
            int returnModel = Datatable.GetInt(row1, "Age", -1);

            //Assert
            returnModel.Should().Be(-1);
        }

        [Fact(DisplayName = "Datatable GetDecimal 1()")]
        public void GetDecimalTest1()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn currencyColumn = new DataColumn();
            currencyColumn.DataType = System.Type.GetType("System.String");
            currencyColumn.ColumnName = "Currency Type";
            currencyColumn.DefaultValue = "US Dollars";
            table.Columns.Add(currencyColumn);

            DataColumn amountColumn = new DataColumn();
            amountColumn.DataType = System.Type.GetType("System.Decimal");
            amountColumn.ColumnName = "Amount";
            amountColumn.DefaultValue = null;
            table.Columns.Add(amountColumn);

            DataRow row1 = table.NewRow();

            row1["Currency Type"] = "US Dollars";
            row1["Amount"] = 13.00m;
            table.Rows.Add(row1);

            //Act
            decimal returnModel = Datatable.GetDecimal(row1, "Amount", 00.00m);

            //Assert
            returnModel.Should().Be(13.00m);
        }

        [Fact(DisplayName = "Datatable GetDecimal 2()")]
        public void GetDecimalTest2()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn currencyColumn = new DataColumn();
            currencyColumn.DataType = System.Type.GetType("System.String");
            currencyColumn.ColumnName = "Currency Type";
            currencyColumn.DefaultValue = "US Dollars";
            table.Columns.Add(currencyColumn);

            DataColumn amountColumn = new DataColumn();
            amountColumn.DataType = System.Type.GetType("System.Decimal");
            amountColumn.ColumnName = "Amount";
            amountColumn.DefaultValue = null;
            table.Columns.Add(amountColumn);

            DataRow row1 = table.NewRow();

            row1["Currency Type"] = "US Dollars";
            row1["Amount"] = 15.25m;
            table.Rows.Add(row1);

            //Act
            decimal returnModel = Datatable.GetDecimal(row1, "Amount", 00.00m);

            //Assert
            returnModel.Should().Be(15.25m);
        }

        [Fact(DisplayName = "Datatable GetDecimal 3()")]
        public void GetDecimalTest3()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn currencyColumn = new DataColumn();
            currencyColumn.DataType = System.Type.GetType("System.String");
            currencyColumn.ColumnName = "Currency Type";
            currencyColumn.DefaultValue = "US Dollars";
            table.Columns.Add(currencyColumn);

            DataColumn amountColumn = new DataColumn();
            amountColumn.DataType = System.Type.GetType("System.Decimal");
            amountColumn.ColumnName = "Amount";
            amountColumn.DefaultValue = null;
            table.Columns.Add(amountColumn);

            DataRow row1 = table.NewRow();

            row1["Currency Type"] = "US Dollars";
            row1["Amount"] = 100.39m;
            table.Rows.Add(row1);

            //Act
            decimal returnModel = Datatable.GetDecimal(row1, "Amount", 00.00m);

            //Assert
            returnModel.Should().Be(100.39m);
        }

        [Fact(DisplayName = "Datatable GetDecimal Null()")]
        public void GetDecimalTestNull()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn currencyColumn = new DataColumn();
            currencyColumn.DataType = System.Type.GetType("System.String");
            currencyColumn.ColumnName = "Currency Type";
            currencyColumn.DefaultValue = "US Dollars";
            table.Columns.Add(currencyColumn);

            DataColumn amountColumn = new DataColumn();
            amountColumn.DataType = System.Type.GetType("System.Decimal");
            amountColumn.ColumnName = "Amount";
            amountColumn.DefaultValue = null;
            table.Columns.Add(amountColumn);

            DataRow row1 = table.NewRow();

            row1["Currency Type"] = "US Dollars";
            row1["Amount"] = DBNull.Value;
            table.Rows.Add(row1);

            //Act
            decimal returnModel = Datatable.GetDecimal(row1, "Amount", 00.00m);

            //Assert
            returnModel.Should().Be(00.00m);
        }

        [Fact(DisplayName = "Datatable GetDate 1()")]
        public void GetDate1()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn holidayColumn = new DataColumn();
            holidayColumn.DataType = System.Type.GetType("System.String");
            holidayColumn.ColumnName = "Holiday";
            holidayColumn.DefaultValue = null;
            table.Columns.Add(holidayColumn);

            DataColumn dateColumn = new DataColumn();
            dateColumn.DataType = System.Type.GetType("System.DateTime");
            dateColumn.ColumnName = "Date";
            dateColumn.DefaultValue = null;
            table.Columns.Add(dateColumn);

            DataRow row1 = table.NewRow();

            row1["Holiday"] = "Labor Day";
            row1["Date"] = new DateTime(2018, 09, 03, 10, 00, 00);
            table.Rows.Add(row1);

            //Act
            DateTime returnModel = Datatable.GetDate(row1, "Date", new DateTime(1970, 1, 1, 10, 00, 00));

            //Assert
            returnModel.Should().Be(new DateTime(2018, 09, 03, 10, 00, 00));
        }

        [Fact(DisplayName = "Datatable GetDate 2()")]
        public void GetDate2()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn holidayColumn = new DataColumn();
            holidayColumn.DataType = System.Type.GetType("System.String");
            holidayColumn.ColumnName = "Holiday";
            holidayColumn.DefaultValue = null;
            table.Columns.Add(holidayColumn);

            DataColumn dateColumn = new DataColumn();
            dateColumn.DataType = System.Type.GetType("System.DateTime");
            dateColumn.ColumnName = "Date";
            dateColumn.DefaultValue = null;
            table.Columns.Add(dateColumn);

            DataRow row1 = table.NewRow();

            row1["Holiday"] = "The 4th of July";
            row1["Date"] = new DateTime(2018, 07, 04, 10, 15, 02);
            table.Rows.Add(row1);

            //Act
            DateTime returnModel = Datatable.GetDate(row1, "Date", new DateTime(1970, 1, 1, 10, 00, 00));

            //Assert
            returnModel.Should().Be(new DateTime(2018, 07, 04, 10, 15, 02));
        }

        [Fact(DisplayName = "Datatable GetDate 3()")]
        public void GetDate3()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn holidayColumn = new DataColumn();
            holidayColumn.DataType = System.Type.GetType("System.String");
            holidayColumn.ColumnName = "Holiday";
            holidayColumn.DefaultValue = null;
            table.Columns.Add(holidayColumn);

            DataColumn dateColumn = new DataColumn();
            dateColumn.DataType = System.Type.GetType("System.DateTime");
            dateColumn.ColumnName = "Date";
            dateColumn.DefaultValue = null;
            table.Columns.Add(dateColumn);

            DataRow row1 = table.NewRow();

            row1["Holiday"] = "Martin Luther King Day";
            row1["Date"] = new DateTime(2018, 01, 11, 08, 59, 59);
            table.Rows.Add(row1);

            //Act
            DateTime returnModel = Datatable.GetDate(row1, "Date", new DateTime(1970, 1, 1, 10, 00, 00));

            //Assert
            returnModel.Should().Be(new DateTime(2018, 01, 11, 08, 59, 59));
        }

        [Fact(DisplayName = "Datatable GetDate Null()")]
        public void GetDateNull()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn holidayColumn = new DataColumn();
            holidayColumn.DataType = System.Type.GetType("System.String");
            holidayColumn.ColumnName = "Holiday";
            holidayColumn.DefaultValue = null;
            table.Columns.Add(holidayColumn);

            DataColumn dateColumn = new DataColumn();
            dateColumn.DataType = System.Type.GetType("System.DateTime");
            dateColumn.ColumnName = "Date";
            dateColumn.DefaultValue = null;
            table.Columns.Add(dateColumn);

            DataRow row1 = table.NewRow();

            row1["Holiday"] = "Labor Day";
            row1["Date"] = DBNull.Value;
            table.Rows.Add(row1);

            //Act
            DateTime returnModel = Datatable.GetDate(row1, "Date", new DateTime(1900, 1, 1, 12, 00, 00));

            //Assert
            returnModel.Should().Be(new DateTime(1900, 01, 01, 12, 00, 00));
        }

        [Fact(DisplayName = "Datatable GetString 1()")]
        public void GetString1()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn userColumn = new DataColumn();
            userColumn.DataType = System.Type.GetType("System.String");
            userColumn.ColumnName = "User";
            userColumn.DefaultValue = null;
            table.Columns.Add(userColumn);

            DataColumn passwordColumn = new DataColumn();
            passwordColumn.DataType = System.Type.GetType("System.String");
            passwordColumn.ColumnName = "Password";
            passwordColumn.DefaultValue = null;
            table.Columns.Add(passwordColumn);

            DataRow row1 = table.NewRow();

            row1["User"] = "Mike";
            row1["Password"] = "12345";
            table.Rows.Add(row1);

            //Act
            string returnModel = Datatable.GetString(row1, "Password", "Enter Password");

            //Assert
            returnModel.Should().Be("12345");
        }

        [Fact(DisplayName = "Datatable GetString 2()")]
        public void GetString2()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn userColumn = new DataColumn();
            userColumn.DataType = System.Type.GetType("System.String");
            userColumn.ColumnName = "User";
            userColumn.DefaultValue = null;
            table.Columns.Add(userColumn);

            DataColumn passwordColumn = new DataColumn();
            passwordColumn.DataType = System.Type.GetType("System.String");
            passwordColumn.ColumnName = "Password";
            passwordColumn.DefaultValue = null;
            table.Columns.Add(passwordColumn);

            DataRow row1 = table.NewRow();

            row1["User"] = "John";
            row1["Password"] = "ABRA";
            table.Rows.Add(row1);

            //Act
            string returnModel = Datatable.GetString(row1, "Password", "Enter Password");

            //Assert
            returnModel.Should().Be("ABRA");
        }

        [Fact(DisplayName = "Datatable GetString 3()")]
        public void GetString3()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn userColumn = new DataColumn();
            userColumn.DataType = System.Type.GetType("System.String");
            userColumn.ColumnName = "User";
            userColumn.DefaultValue = null;
            table.Columns.Add(userColumn);

            DataColumn passwordColumn = new DataColumn();
            passwordColumn.DataType = System.Type.GetType("System.String");
            passwordColumn.ColumnName = "Password";
            passwordColumn.DefaultValue = null;
            table.Columns.Add(passwordColumn);

            DataRow row1 = table.NewRow();

            row1["User"] = "Aaron";
            row1["Password"] = "Aaron72";
            table.Rows.Add(row1);

            //Act
            string returnModel = Datatable.GetString(row1, "Password");

            //Assert
            returnModel.Should().Be("Aaron72");
        }

        [Fact(DisplayName = "Datatable GetString Null()")]
        public void GetStringNull()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn userColumn = new DataColumn();
            userColumn.DataType = System.Type.GetType("System.String");
            userColumn.ColumnName = "User";
            userColumn.DefaultValue = null;
            table.Columns.Add(userColumn);

            DataColumn passwordColumn = new DataColumn();
            passwordColumn.DataType = System.Type.GetType("System.String");
            passwordColumn.ColumnName = "Password";
            passwordColumn.DefaultValue = null;
            table.Columns.Add(passwordColumn);

            DataRow row1 = table.NewRow();

            row1["User"] = "Mike";
            row1["Password"] = DBNull.Value;
            table.Rows.Add(row1);

            //Act
            string returnModel = Datatable.GetString(row1, "Password");

            //Assert
            returnModel.Should().Be("");
        }

        [Fact(DisplayName = "Datatable GetUserID 1()")]
        public void GetUserID1()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn usernameColumn = new DataColumn();
            usernameColumn.DataType = System.Type.GetType("System.String");
            usernameColumn.ColumnName = "Username";
            usernameColumn.DefaultValue = null;
            table.Columns.Add(usernameColumn);

            DataColumn idColumn = new DataColumn();
            idColumn.DataType = System.Type.GetType("System.Int32");
            idColumn.ColumnName = "ID";
            idColumn.DefaultValue = null;
            table.Columns.Add(idColumn);

            DataRow row1 = table.NewRow();

            row1["Username"] = "John";
            row1["ID"] = 4930;
            table.Rows.Add(row1);

            //Act
            int returnModel = Datatable.GetUserID(row1, "ID");

            //Assert
            returnModel.Should().Be(4930);
        }

        [Fact(DisplayName = "Datatable GetUserID 2()")]
        public void GetUserID2()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn usernameColumn = new DataColumn();
            usernameColumn.DataType = System.Type.GetType("System.String");
            usernameColumn.ColumnName = "Username";
            usernameColumn.DefaultValue = null;
            table.Columns.Add(usernameColumn);

            DataColumn idColumn = new DataColumn();
            idColumn.DataType = System.Type.GetType("System.Int32");
            idColumn.ColumnName = "ID";
            idColumn.DefaultValue = null;
            table.Columns.Add(idColumn);

            DataRow row1 = table.NewRow();

            row1["Username"] = "Tim";
            row1["ID"] = 0710;
            table.Rows.Add(row1);

            //Act
            int returnModel = Datatable.GetUserID(row1, "ID");

            //Assert
            returnModel.Should().Be(0710);
        }

        [Fact(DisplayName = "Datatable GetUserID 3()")]
        public void GetUserID3()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn usernameColumn = new DataColumn();
            usernameColumn.DataType = System.Type.GetType("System.String");
            usernameColumn.ColumnName = "Username";
            usernameColumn.DefaultValue = null;
            table.Columns.Add(usernameColumn);

            DataColumn idColumn = new DataColumn();
            idColumn.DataType = System.Type.GetType("System.Int32");
            idColumn.ColumnName = "ID";
            idColumn.DefaultValue = null;
            table.Columns.Add(idColumn);

            DataRow row1 = table.NewRow();

            row1["Username"] = "Frank";
            row1["ID"] = 7272;
            table.Rows.Add(row1);

            //Act
            int returnModel = Datatable.GetUserID(row1, "ID");

            //Assert
            returnModel.Should().Be(7272);
        }

        [Fact(DisplayName = "Datatable GetYN 1()")]
        public void GetYN1()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn condition1Column = new DataColumn();
            condition1Column.DataType = System.Type.GetType("System.String");
            condition1Column.ColumnName = "Condition 1";
            condition1Column.DefaultValue = null;
            table.Columns.Add(condition1Column);

            DataColumn ynColumn = new DataColumn();
            ynColumn.DataType = System.Type.GetType("System.String");
            ynColumn.ColumnName = "Y / N";
            ynColumn.DefaultValue = null;
            table.Columns.Add(ynColumn);

            DataRow row1 = table.NewRow();

            row1["Condition 1"] = "job completed successfully?";
            row1["Y / N"] = "Y";
            table.Rows.Add(row1);

            //Act
            bool returnModel = Datatable.GetYN(row1, "Y / N", true);

            //Assert
            returnModel.Should().Be(true);
        }

        [Fact(DisplayName = "Datatable GetBit 1()")]
        public void GetBit1()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn condition1Column = new DataColumn();
            condition1Column.DataType = System.Type.GetType("System.String");
            condition1Column.ColumnName = "Condition 1";
            condition1Column.DefaultValue = null;
            table.Columns.Add(condition1Column);

            DataColumn bitColumn = new DataColumn();
            bitColumn.DataType = System.Type.GetType("System.String");
            bitColumn.ColumnName = "Bit";
            bitColumn.DefaultValue = null;
            table.Columns.Add(bitColumn);

            DataRow row1 = table.NewRow();

            row1["Condition 1"] = "job completed successfully?";
            row1["Bit"] = "1";
            table.Rows.Add(row1);

            //Act
            bool returnModel = Datatable.GetBit(row1, "Bit", true);

            //Assert
            returnModel.Should().Be(true);
        }

        [Fact(DisplayName = "Datatable GetActive 1()")]
        public void GetActive1()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn condition1Column = new DataColumn();
            condition1Column.DataType = System.Type.GetType("System.String");
            condition1Column.ColumnName = "Condition 1";
            condition1Column.DefaultValue = null;
            table.Columns.Add(condition1Column);

            DataColumn StatusColumn = new DataColumn();
            StatusColumn.DataType = System.Type.GetType("System.String");
            StatusColumn.ColumnName = "Status";
            StatusColumn.DefaultValue = null;
            table.Columns.Add(StatusColumn);

            DataRow row1 = table.NewRow();

            row1["Condition 1"] = "Online";
            row1["Status"] = "ACTIVE";
            table.Rows.Add(row1);

            //Act
            bool returnModel = Datatable.GetActive(row1, "Status", true);

            //Assert
            returnModel.Should().Be(true);
        }

        [Fact(DisplayName = "Datatable GetActive Null()")]
        public void GetActiveNull()
        {
            // Arrange
            DataTable table = new DataTable("TestTable");

            DataColumn condition1Column = new DataColumn();
            condition1Column.DataType = System.Type.GetType("System.String");
            condition1Column.ColumnName = "Condition 1";
            condition1Column.DefaultValue = null;
            table.Columns.Add(condition1Column);

            DataColumn StatusColumn = new DataColumn();
            StatusColumn.DataType = System.Type.GetType("System.String");
            StatusColumn.ColumnName = "Status";
            StatusColumn.DefaultValue = null;
            table.Columns.Add(StatusColumn);

            DataRow row1 = table.NewRow();

            row1["Condition 1"] = "Online";
            row1["Status"] = DBNull.Value;
            table.Rows.Add(row1);

            //Act
            bool returnModel = Datatable.GetActive(row1);

            //Assert
            returnModel.Should().Be(false);
        }

        [Fact(DisplayName = "ConvertToDataTableTest()")]
        public void ConvertToDataTableTestHeaderTrue()
        {
            // Arrange
            FileInfo FileLocation = new FileInfo("c:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation1\\EmployeeChartTest.csv");
            bool isRowOneHeader = true;

            DataTable EmployeeChartTest = new DataTable();

            DataColumn RowColumn = new DataColumn();
            RowColumn.DataType = Type.GetType("System.Int32");
            RowColumn.ColumnName = "Row #";
            RowColumn.DefaultValue = null;
            EmployeeChartTest.Columns.Add(RowColumn);

            DataColumn EmployeeIDColumn = new DataColumn();
            EmployeeIDColumn.DataType = Type.GetType("System.Int32");
            EmployeeIDColumn.ColumnName = "Employee ID";
            EmployeeIDColumn.DefaultValue = null;
            EmployeeChartTest.Columns.Add(EmployeeIDColumn);

            DataColumn StatusColumn = new DataColumn();
            StatusColumn.DataType = System.Type.GetType("System.String");
            StatusColumn.ColumnName = "Status";
            StatusColumn.DefaultValue = null;
            EmployeeChartTest.Columns.Add(StatusColumn);

            DataRow row1 = EmployeeChartTest.NewRow();
            row1["Row #"] = 1;
            row1["Employee ID"] = 123;
            row1["Status"] = "Y";
            EmployeeChartTest.Rows.Add(row1);

            DataRow row2 = EmployeeChartTest.NewRow();
            row2["Row #"] = 2;
            row2["Employee ID"] = 234;
            row2["Status"] = "Y";
            EmployeeChartTest.Rows.Add(row2);

            DataRow row3 = EmployeeChartTest.NewRow();
            row3["Row #"] = 3;
            row3["Employee ID"] = 345;
            row3["Status"] = "Y";
            EmployeeChartTest.Rows.Add(row3);

            DataRow row4 = EmployeeChartTest.NewRow();
            row4["Row #"] = 4;
            row4["Employee ID"] = 456;
            row4["Status"] = "N";
            EmployeeChartTest.Rows.Add(row4);

            //Act
            DataTable returnModel = Datatable.ConvertToDataTable(FileLocation, isRowOneHeader);

            //Assert
            returnModel.Rows[0][0].Should().Be("1");
        }

        [Fact(DisplayName = "ConvertToDataTableTest()")]
        public void ConvertToDataTableTestHeaderFalse()
        {
            // Arrange
            FileInfo FileLocation = new FileInfo("c:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation1\\EmployeeChartTest.csv");
            bool isRowOneHeader = false;

            DataTable EmployeeChartTest = new DataTable();

            DataColumn RowColumn = new DataColumn();
            RowColumn.DataType = Type.GetType("System.Int32");
            RowColumn.ColumnName = "Row #";
            RowColumn.DefaultValue = null;
            EmployeeChartTest.Columns.Add(RowColumn);

            DataColumn EmployeeIDColumn = new DataColumn();
            EmployeeIDColumn.DataType = Type.GetType("System.Int32");
            EmployeeIDColumn.ColumnName = "Employee ID";
            EmployeeIDColumn.DefaultValue = null;
            EmployeeChartTest.Columns.Add(EmployeeIDColumn);

            DataColumn StatusColumn = new DataColumn();
            StatusColumn.DataType = System.Type.GetType("System.String");
            StatusColumn.ColumnName = "Status";
            StatusColumn.DefaultValue = null;
            EmployeeChartTest.Columns.Add(StatusColumn);

            DataRow row1 = EmployeeChartTest.NewRow();
            row1["Row #"] = 1;
            row1["Employee ID"] = 123;
            row1["Status"] = "Y";
            EmployeeChartTest.Rows.Add(row1);

            DataRow row2 = EmployeeChartTest.NewRow();
            row2["Row #"] = 2;
            row2["Employee ID"] = 234;
            row2["Status"] = "Y";
            EmployeeChartTest.Rows.Add(row2);

            DataRow row3 = EmployeeChartTest.NewRow();
            row3["Row #"] = 3;
            row3["Employee ID"] = 345;
            row3["Status"] = "Y";
            EmployeeChartTest.Rows.Add(row3);

            DataRow row4 = EmployeeChartTest.NewRow();
            row4["Row #"] = 4;
            row4["Employee ID"] = 456;
            row4["Status"] = "N";
            EmployeeChartTest.Rows.Add(row4);

            //Act
            DataTable returnModel = Datatable.ConvertToDataTable(FileLocation, isRowOneHeader);

            //Assert
            returnModel.Rows[1][0].Should().Be("1");
        }

        [Fact(DisplayName = "ConvertToDataTableTest()")]
        public void ConvertToDataTableTestHeaderTrueR3C1()
        {
            // Arrange
            FileInfo FileLocation = new FileInfo("c:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation1\\EmployeeChartTest.csv");
            bool isRowOneHeader = true;

            DataTable EmployeeChartTest = new DataTable();

            DataColumn RowColumn = new DataColumn();
            RowColumn.DataType = Type.GetType("System.Int32");
            RowColumn.ColumnName = "Row #";
            RowColumn.DefaultValue = null;
            EmployeeChartTest.Columns.Add(RowColumn);

            DataColumn EmployeeIDColumn = new DataColumn();
            EmployeeIDColumn.DataType = Type.GetType("System.Int32");
            EmployeeIDColumn.ColumnName = "Employee ID";
            EmployeeIDColumn.DefaultValue = null;
            EmployeeChartTest.Columns.Add(EmployeeIDColumn);

            DataColumn StatusColumn = new DataColumn();
            StatusColumn.DataType = System.Type.GetType("System.String");
            StatusColumn.ColumnName = "Status";
            StatusColumn.DefaultValue = null;
            EmployeeChartTest.Columns.Add(StatusColumn);

            DataRow row1 = EmployeeChartTest.NewRow();
            row1["Row #"] = 1;
            row1["Employee ID"] = 123;
            row1["Status"] = "Y";
            EmployeeChartTest.Rows.Add(row1);

            DataRow row2 = EmployeeChartTest.NewRow();
            row2["Row #"] = 2;
            row2["Employee ID"] = 234;
            row2["Status"] = "Y";
            EmployeeChartTest.Rows.Add(row2);

            DataRow row3 = EmployeeChartTest.NewRow();
            row3["Row #"] = 3;
            row3["Employee ID"] = 345;
            row3["Status"] = "Y";
            EmployeeChartTest.Rows.Add(row3);

            DataRow row4 = EmployeeChartTest.NewRow();
            row4["Row #"] = 4;
            row4["Employee ID"] = 456;
            row4["Status"] = "N";
            EmployeeChartTest.Rows.Add(row4);

            //Act
            DataTable returnModel = Datatable.ConvertToDataTable(FileLocation, isRowOneHeader);

            //Assert
            returnModel.Rows[3][1].Should().Be("456");
        }

        [Fact(DisplayName = "ConvertToDataTableTest()")]
        public void ConvertToDataTableTestHeaderFalseR2C2()
        {
            // Arrange
            FileInfo FileLocation = new FileInfo("c:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation1\\EmployeeChartTest.csv");
            bool isRowOneHeader = false;

            DataTable EmployeeChartTest = new DataTable();

            DataColumn RowColumn = new DataColumn();
            RowColumn.DataType = Type.GetType("System.Int32");
            RowColumn.ColumnName = "Row #";
            RowColumn.DefaultValue = null;
            EmployeeChartTest.Columns.Add(RowColumn);

            DataColumn EmployeeIDColumn = new DataColumn();
            EmployeeIDColumn.DataType = Type.GetType("System.Int32");
            EmployeeIDColumn.ColumnName = "Employee ID";
            EmployeeIDColumn.DefaultValue = null;
            EmployeeChartTest.Columns.Add(EmployeeIDColumn);

            DataColumn StatusColumn = new DataColumn();
            StatusColumn.DataType = System.Type.GetType("System.String");
            StatusColumn.ColumnName = "Status";
            StatusColumn.DefaultValue = null;
            EmployeeChartTest.Columns.Add(StatusColumn);

            DataRow row1 = EmployeeChartTest.NewRow();
            row1["Row #"] = 1;
            row1["Employee ID"] = 123;
            row1["Status"] = "Y";
            EmployeeChartTest.Rows.Add(row1);

            DataRow row2 = EmployeeChartTest.NewRow();
            row2["Row #"] = 2;
            row2["Employee ID"] = 234;
            row2["Status"] = "Y";
            EmployeeChartTest.Rows.Add(row2);

            DataRow row3 = EmployeeChartTest.NewRow();
            row3["Row #"] = 3;
            row3["Employee ID"] = 345;
            row3["Status"] = "Y";
            EmployeeChartTest.Rows.Add(row3);

            DataRow row4 = EmployeeChartTest.NewRow();
            row4["Row #"] = 4;
            row4["Employee ID"] = 456;
            row4["Status"] = "N";
            EmployeeChartTest.Rows.Add(row4);

            //Act
            DataTable returnModel = Datatable.ConvertToDataTable(FileLocation, isRowOneHeader);

            //Assert
            returnModel.Rows[2][2].Should().Be("Y");
        }
    }
}
