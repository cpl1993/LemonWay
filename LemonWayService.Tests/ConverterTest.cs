using System;
using LemonWayBusiness;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonWayService.Tests
{
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void If_Xml_Is_Good_Then_Return_Json()
        {
            // Arrange
            string xml = "<foo>bar</foo>";

            //Act
            var jsonResult = Converter.XmlToJson(xml);

            //Assert
            Assert.AreEqual("{\"foo\":\"bar\"}", jsonResult);
        }

        [TestMethod]
        public void If_Xml_Is_Bad_Then_Return_Error()
        {
            // Arrange
            string xml = "<foo>hello</bar>";

            //Act
            var jsonResult = Converter.XmlToJson(xml);

            //Assert
            Assert.AreEqual("Bad Xml format", jsonResult);
        }
    }
}
