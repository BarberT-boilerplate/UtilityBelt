using FluentAssertions;
using System.IO;
using Xunit;

namespace UtilityBeltCore.UnitTests
{
    public class FileManagerTests
    {
        [Fact(DisplayName = "FileManagerTests MoveFileToAppFolder_1()")]
        public void MoveFileToAppFolder_1()
        {
            //Arrange
            string oldPath = "";
            string newPath = "";

            if (File.Exists("C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation1\\Test Doc.txt"))
            {
                oldPath = "C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation1\\Test Doc.txt";
                newPath = "C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation2\\Test Doc.txt";
            }
            else
            {
                oldPath = "C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation2\\Test Doc.txt";
                newPath = "C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation1\\Test Doc.txt";
            }
            //Act
            bool returnModel = FileManager.MoveFileToAppFolder(oldPath, newPath);

            //Assert
            returnModel.Should().Be(true);
        }

        [Fact(DisplayName = "FileManagerTests MoveFileToAppFolder_2()")]
        public void MoveFileToAppFolder_2()
        {
            //Arrange
            string oldPath = "";
            string newPath = "";

            if (File.Exists("C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation1\\Test Doc.txt"))
            {
                oldPath = "C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation3\\Test Doc.txt";
                newPath = "C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation4\\Test Doc.txt";
            }
            else
            {
                oldPath = "C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation3\\Test Doc.txt";
                newPath = "C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation4\\Test Doc.txt";
            }
            //Act
            bool returnModel = FileManager.MoveFileToAppFolder(oldPath, newPath);

            //Assert
            returnModel.Should().Be(false);
        }

        [Fact(DisplayName = "FileManagerTests MoveFileToAppFolder_CreatNewLocation()")]
        public void MoveFileToAppFolder_CreatNewLocation()
        {
            //Arrange
            string oldPath = "";
            string newPath = "";


            if (File.Exists("C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation1\\Test Doc.txt"))
            {
                oldPath = "C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation1\\Test Doc.txt";
                newPath = "C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation4\\Test Doc.txt";
            }
            else
            {
                oldPath = "C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation2\\Test Doc.txt";
                newPath = "C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation4\\Test Doc.txt";
            }
            //Act
            bool returnModel = FileManager.MoveFileToAppFolder(oldPath, newPath);

            //Assert
            returnModel.Should().Be(true);
            File.Move(newPath, oldPath);

            //This was an attempt to have it delete the newPath so that it would be creating a new location each time. 
            //if (File.Exists("C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation4"))
            //{
            //    Directory.Delete("C:\\TFS\\UtilityBeltCore\\UtilityBeltCore.UnitTests\\TestLocation4", true);
            //}
        }
    }
}
