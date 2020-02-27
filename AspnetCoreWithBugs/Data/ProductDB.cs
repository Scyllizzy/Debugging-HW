using AspnetCoreWithBugs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreWithBugs.Data
{
    /// <summary>
    /// A helper class to manage CRUD functionality for products.
    /// </summary>
    public static class ProductDB
    {
        /// <summary>
        /// Adds a product to the database.
        /// Returns the product with the ID populated.
        /// </summary>
        /// <param name="p">The product to be added to the database.</param>
        public async static Task<Product> Create(Product p, ProductContext context)
        {
            await context.AddAsync(p);
            await context.SaveChangesAsync();

            return p;
        }

        /// <summary>
        /// Updates the product in the database with it's new information.
        /// </summary>
        /// <param name="p">The product to be edited.</param>
        public async static Task<Product> Edit(Product p, ProductContext context)
        {
            context.Update(p);
            await context.SaveChangesAsync();

            return p;
        }

        /// <summary>
        /// Deletes the product in the database that was passed in.
        /// </summary>
        /// <param name="p">The product to be deleted.</param>
        public async static Task Delete(Product p, ProductContext context)
        {
            context.Remove(p);
            await context.SaveChangesAsync();
        }
    }
}
