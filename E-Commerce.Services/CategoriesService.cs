﻿using E_Commerce.Database;
using E_Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Services
{
   public class CategoriesService
    {
        public Category GetCategory(int ID)
        {
            using (var context = new CBContext())
            {
                return context.Categories.Find(ID);
            }
        }
        public List<Category> GetCategories()
        {
            using (var context = new CBContext())
            {
                return context.Categories.ToList();
            }
        }
        public void SaveCategory(Category category)
        {
            using (var context = new CBContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
            public void UpdateCategory(Category category)
            {
                using (var context = new CBContext())
                {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();
                }
            }
        public void DeleteCategory(int ID)
        {
            using (var context = new CBContext())
            {
                // context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                var category = context.Categories.Find(ID);
                context.Categories.Remove(category);

                context.SaveChanges();
            }
        }
    }
}
