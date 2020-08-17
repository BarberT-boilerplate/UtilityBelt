using FluentAssertions;
using System.Xml;
using Xunit;

namespace UtilityBeltCore.UnitTests
{
    public class XMLNodeHelperTests
    {
        [Fact(DisplayName = "ExtensionMethods GetStringValue_1() ")]
        public void GetStringValue_1()
        {
            //Arrange
            XmlDocument Menu = new XmlDocument();
            Menu.LoadXml("<breakfast_menu>" +
                            "<food1>" +
                                "<name>Belgian Waffles</name>" +
                                "<price>$5.95</price >" +
                            "</food1>" +
                            "<food2>" +
                                "<name>Strawberry Belgian Waffles</name>" +
                                "<price>$7.95</price>" +
                            "</food2>" +
                            "<food3>" +
                                "<name>Homestyle Breakfast</name>" +
                                "<price>$6.95</price>" +
                            "</food3>" +
                            "<food4>" +
                                "<name>French Toast</name>" +
                                "<price>$4.50</price>" +
                            "</food4>" +
                        "</breakfast_menu>");

            string xPath = ("/breakfast_menu/food1/name");

            //Act
            string returnModel = XMLNodeHelper.GetStringValue(Menu, xPath);

            //Assert
            returnModel.Should().Be("Belgian Waffles");
        }

        [Fact(DisplayName = "ExtensionMethods GetStringValue_2() ")]
        public void GetStringValue_2()
        {
            //Arrange
            XmlDocument Menu = new XmlDocument();
            Menu.LoadXml("<breakfast_menu>" +
                            "<food1>" +
                                "<name>Belgian Waffles</name>" +
                                "<price>$5.95</price >" +
                            "</food1>" +
                            "<food2>" +
                                "<name>Strawberry Belgian Waffles</name>" +
                                "<price>$7.95</price>" +
                            "</food2>" +
                            "<food3>" +
                                "<name>Homestyle Breakfast</name>" +
                                "<price>$6.95</price>" +
                            "</food3>" +
                            "<food4>" +
                                "<name>French Toast</name>" +
                                "<price>$4.50</price>" +
                            "</food4>" +
                        "</breakfast_menu>");

            string xPath = ("/breakfast_menu/food3/name");

            //Act
            string returnModel = XMLNodeHelper.GetStringValue(Menu, xPath);

            //Assert
            returnModel.Should().Be("Homestyle Breakfast");
        }

        [Fact(DisplayName = "ExtensionMethods GetStringValue_3() ")]
        public void GetStringValue_3()
        {
            //Arrange
            XmlDocument Menu = new XmlDocument();
            Menu.LoadXml("<breakfast_menu>" +
                            "<food1>" +
                                "<name>Belgian Waffles</name>" +
                                "<price>$5.95</price >" +
                            "</food1>" +
                            "<food2>" +
                                "<name>Strawberry Belgian Waffles</name>" +
                                "<price>$7.95</price>" +
                            "</food2>" +
                            "<food3>" +
                                "<name>Homestyle Breakfast</name>" +
                                "<price>$6.95</price>" +
                            "</food3>" +
                            "<food4>" +
                                "<name>French Toast</name>" +
                                "<price>$4.50</price>" +
                            "</food4>" +
                        "</breakfast_menu>");

            string xPath = ("/breakfast_menu/food3/price");

            //Act
            string returnModel = XMLNodeHelper.GetStringValue(Menu, xPath);

            //Assert
            returnModel.Should().Be("$6.95");
        }

        [Fact(DisplayName = "ExtensionMethods GetDecimalValue_1() ")]
        public void GetDecimalValue_1()
        {
            //Arrange
            XmlDocument Menu = new XmlDocument();
            Menu.LoadXml("<breakfast_menu>" +
                            "<food1>" +
                                "<name>Belgian Waffles</name>" +
                                "<price>5.95</price >" +
                            "</food1>" +
                            "<food2>" +
                                "<name>Strawberry Belgian Waffles</name>" +
                                "<price>7.95</price>" +
                            "</food2>" +
                            "<food3>" +
                                "<name>Homestyle Breakfast</name>" +
                                "<price>6.95</price>" +
                            "</food3>" +
                            "<food4>" +
                                "<name>French Toast</name>" +
                                "<price>4.50</price>" +
                            "</food4>" +
                        "</breakfast_menu>");

            string xPath = ("/breakfast_menu/food3/price");

            //Act
            decimal returnModel = XMLNodeHelper.GetDecimalValue(Menu, xPath);

            //Assert
            returnModel.Should().Be(6.95m);
        }

        [Fact(DisplayName = "ExtensionMethods GetDecimalValue_2() ")]
        public void GetDecimalValue_2()
        {
            //Arrange
            XmlDocument Menu = new XmlDocument();
            Menu.LoadXml("<breakfast_menu>" +
                            "<food1>" +
                                "<name>Belgian Waffles</name>" +
                                "<price>5.95</price >" +
                            "</food1>" +
                            "<food2>" +
                                "<name>Strawberry Belgian Waffles</name>" +
                                "<price>7.95</price>" +
                            "</food2>" +
                            "<food3>" +
                                "<name>Homestyle Breakfast</name>" +
                                "<price>6.95</price>" +
                            "</food3>" +
                            "<food4>" +
                                "<name>French Toast</name>" +
                                "<price>4.50</price>" +
                            "</food4>" +
                        "</breakfast_menu>");

            string xPath = ("/breakfast_menu/food4/price");

            //Act
            decimal returnModel = XMLNodeHelper.GetDecimalValue(Menu, xPath);

            //Assert
            returnModel.Should().Be(4.50m);
        }

        [Fact(DisplayName = "ExtensionMethods GetDecimalValue_3() ")]
        public void GetDecimalValue_3()
        {
            //Arrange
            XmlDocument Menu = new XmlDocument();
            Menu.LoadXml("<breakfast_menu>" +
                            "<food1>" +
                                "<name>Belgian Waffles</name>" +
                                "<price>5.95</price >" +
                            "</food1>" +
                            "<food2>" +
                                "<name>Strawberry Belgian Waffles</name>" +
                                "<price>7.95</price>" +
                            "</food2>" +
                            "<food3>" +
                                "<name>Homestyle Breakfast</name>" +
                                "<price>6.95</price>" +
                            "</food3>" +
                            "<food4>" +
                                "<name>French Toast</name>" +
                                "<price>4.50</price>" +
                            "</food4>" +
                        "</breakfast_menu>");

            string xPath = ("/breakfast_menu/food1/price");

            //Act
            decimal returnModel = XMLNodeHelper.GetDecimalValue(Menu, xPath);

            //Assert
            returnModel.Should().Be(5.95m);
        }

        [Fact(DisplayName = "ExtensionMethods GetIntValue_1_Doc() ")]
        public void GetIntValue_1_Doc()
        {
            //Arrange
            XmlDocument Menu = new XmlDocument();
            Menu.LoadXml("<breakfast_menu>" +
                            "<food1>" +
                                "<name>Belgian Waffles</name>" +
                                "<rating>7</rating>" +
                            "</food1>" +
                            "<food2>" +
                                "<name>Strawberry Belgian Waffles</name>" +
                                "<rating>8</rating>" +
                            "</food2>" +
                            "<food3>" +
                                "<name>Homestyle Breakfast</name>" +
                                "<rating>1</rating>" +
                            "</food3>" +
                            "<food4>" +
                                "<name>French Toast</name>" +
                                "<rating>10</rating>" +
                            "</food4>" +
                        "</breakfast_menu>");

            string xPath = ("/breakfast_menu/food1/rating");

            //Act
            int returnModel = XMLNodeHelper.GetIntValue(Menu, xPath);

            //Assert
            returnModel.Should().Be(7);
        }

        [Fact(DisplayName = "ExtensionMethods GetIntValue_2_Doc() ")]
        public void GetIntValue_2_Doc()
        {
            //Arrange
            XmlDocument Menu = new XmlDocument();
            Menu.LoadXml("<breakfast_menu>" +
                            "<food1>" +
                                "<name>Belgian Waffles</name>" +
                                "<rating>7</rating>" +
                            "</food1>" +
                            "<food2>" +
                                "<name>Strawberry Belgian Waffles</name>" +
                                "<rating>8</rating>" +
                            "</food2>" +
                            "<food3>" +
                                "<name>Homestyle Breakfast</name>" +
                                "<rating>1</rating>" +
                            "</food3>" +
                            "<food4>" +
                                "<name>French Toast</name>" +
                                "<rating>10</rating>" +
                            "</food4>" +
                        "</breakfast_menu>");

            string xPath = ("/breakfast_menu/food4/rating");

            //Act
            int returnModel = XMLNodeHelper.GetIntValue(Menu, xPath);

            //Assert
            returnModel.Should().Be(10);
        }

        [Fact(DisplayName = "ExtensionMethods GetIntValue_3_Doc() ")]
        public void GetIntValue_3_Doc()
        {
            //Arrange
            XmlDocument Menu = new XmlDocument();
            Menu.LoadXml("<breakfast_menu>" +
                            "<food1>" +
                                "<name>Belgian Waffles</name>" +
                                "<rating>7</rating>" +
                            "</food1>" +
                            "<food2>" +
                                "<name>Strawberry Belgian Waffles</name>" +
                                "<rating>8</rating>" +
                            "</food2>" +
                            "<food3>" +
                                "<name>Homestyle Breakfast</name>" +
                                "<rating>1</rating>" +
                            "</food3>" +
                            "<food4>" +
                                "<name>French Toast</name>" +
                                "<rating>10</rating>" +
                            "</food4>" +
                        "</breakfast_menu>");

            string xPath = ("/breakfast_menu/food2/rating");

            //Act
            int returnModel = XMLNodeHelper.GetIntValue(Menu, xPath);

            //Assert
            returnModel.Should().Be(8);
        }

        [Fact(DisplayName = "ExtensionMethods GetIntValue_1_Node() ")]
        public void GetIntValue_1_Node()
        {
            //Arrange
            XmlDocument Menu = new XmlDocument();
            Menu.LoadXml("<breakfast_menu>" +
                            "<food>" +
                                "<name1>Belgian Waffles</name1>" +
                                "<rating>7</rating>" +
                            "</food>" +
                            "<food>" +
                                "<name>Strawberry Belgian Waffles</name>" +
                                "<rating>8</rating>" +
                            "</food>" +
                            "<food>" +
                                "<name>Homestyle Breakfast</name>" +
                                "<rating>1</rating>" +
                            "</food>" +
                            "<food>" +
                                "<name>French Toast</name>" +
                                "<rating>10</rating>" +
                            "</food>" +
                        "</breakfast_menu>");

            XmlNode node = Menu.FirstChild;
            XmlNode node2 = node.FirstChild;


            string xPath = ("/breakfast_menu/food/rating");

            //Act
            int returnModel = XMLNodeHelper.GetIntValue(node2, xPath);

            //Assert
            returnModel.Should().Be(7);
        }
    }
}
