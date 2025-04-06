using _threatening.snow.Domain
using _threatening.snow.Domain.Catalog
namespace _threatening.snow.api_.Domain.Tests;

[TestClass]
public sealed class RatingTests
{
    [TestMethod]
    public void Can_Create_New_Rating()
    {
        // Arrange
        var rating = new Rating(1, "Mike", "Great fit!");

        // Act (empty)

        // Assert
        Assert.AreEqual(1, rating.Stars);
        Assert.AreEqual("Mike", rating.UserName);
        Assert.AreEqual("Great fit!", rating.Review);
    }
}
