using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category
                {
                            CategoryId = 1,
                            CategoryName = "Fruit pies",
                            Description="All-fruity pies"
                }, //since adding to a list, comma is used between elements
                new Category
                {
                            CategoryId = 2,
                            CategoryName = "Cheese cakes",
                            Description="Cheesy all the way"
                },
                new Category
                {
                            CategoryId = 3,
                            CategoryName = "Seasonal pies",
                            Description="Get in the mood for a seasonal pie"
                },
            };
        //Allcategories is an attribute which has been assigned a list of Category objects created using new category keywork and assigning default values to Category class's attributes.

    }
}
