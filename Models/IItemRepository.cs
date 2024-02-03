using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Models;

public interface IItemRepository
{
    IEnumerable<Item> GetItems();
}
