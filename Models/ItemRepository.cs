using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Models;

public class ItemRepository : IItemRepository
{
    private readonly AppDbContext _context;

    public ItemRepository(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public IEnumerable<Item> GetItems()
    {
        return _context.Items.ToList();
    }
}