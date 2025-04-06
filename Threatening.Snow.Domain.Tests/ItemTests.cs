using System;
using Xunit;
using Threatening.Snow.Domain.Catalog;

namespace Threatening.Snow.Domain.Tests
{
    public class ItemTests
    {
        [Fact]
        public void Can_Create_Item()
        {
            var item = new Item("Name", "Description", "Brand", 10.00m);

            Assert.Equal("Name", item.Name);
            Assert.Equal("Description", item.Description);
            Assert.Equal("Brand", item.Brand);
            Assert.Equal(10.00m, item.Price);
        }

        [Fact]
        public void Can_Create_Add_Rating()
        {
            // Arrange
            var item = new Item("Name", "Description", "Brand", 10.00m);
            var rating = new Rating
            {
                Stars = 5,
                UserName = "Name",
                Review = "Review"
            };

            // Act
            item.AddRating(rating);

            // Assert
            Assert.Equal(rating, item.Ratings[0]);
        }
    }
}
