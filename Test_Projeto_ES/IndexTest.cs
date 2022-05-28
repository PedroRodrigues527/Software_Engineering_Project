using Bunit;
using NUnit.Framework;
using Projeto_ES.Pages;

namespace Test_Projeto_ES
{
    public class IndexTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IndexPage()
        {
            // Arrange
            using var ctx = new Bunit.TestContext();
            var cut = ctx.RenderComponent<Index>();
            var paraElm = cut.Find("p");

            // Act
            cut.Find("button").Click();
            var paraElmText = paraElm.TextContent;

            // Assert
            paraElmText.MarkupMatches("Current count: 1");
        }
    }
}