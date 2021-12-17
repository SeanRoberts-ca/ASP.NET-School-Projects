using Restaurant_API.Models;
using Restaurant_API.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data
{
    public class Mapper
    {
        public MenuItems Map(MenuItemsDto input)
        {
            return new MenuItems
            {
                Name = input.Name,
                Price = input.Price
            };
        }

        public MenuItemsDto Map(MenuItems input)
        {
            return new MenuItemsDto
            {
                Name = input.Name,
                Price = input.Price
            };
        }
    }
}