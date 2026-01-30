using Ef_core_summery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ef_core_summery.Contexts
{
    internal static class LibararyDbContextSeed
    {
        public static bool SeedData(LibararyDbContext dbContext)
        {
            var Transaction = dbContext.Database.BeginTransaction();
            try
            {
                dbContext.Database.Migrate();
                bool HasAuthors = dbContext.Authors.Any();
                bool HasCat = dbContext.Categories.Any();
                bool HasBook = dbContext.Books.Any();
                bool HasMembers = dbContext.Members.Any();
                if (HasAuthors && HasBook && HasCat && HasMembers) return false;    
                if (!HasAuthors)
                {
                    var authors = LoadDataFromJison<Author>("C:\\Users\\Abdullah Emam\\Source\\Repos\\Ef-core_summery\\bin\\Debug\\net10.0\\Files\\Authors.json");
                    dbContext.Authors.AddRange(authors);
                }
                if (!HasCat)
                {
                    var categories = LoadDataFromJison<Category>("C:\\Users\\Abdullah Emam\\Source\\Repos\\Ef-core_summery\\bin\\Debug\\net10.0\\Files\\Categories.json");
                    dbContext.Categories.AddRange(categories);
                }
                dbContext.SaveChanges();
                if (!HasBook)
                {
                    var books = LoadDataFromJison<Book>("C:\\Users\\Abdullah Emam\\Source\\Repos\\Ef-core_summery\\bin\\Debug\\net10.0\\Files\\Books.json");
                    dbContext.Books.AddRange(books);
                }
                if (!HasMembers)
                {
                    var members = LoadDataFromJison<Member>("C:\\Users\\Abdullah Emam\\Source\\Repos\\Ef-core_summery\\bin\\Debug\\net10.0\\Files\\Members.json");
                    dbContext.Members.AddRange(members);
                }
                dbContext.SaveChanges();
                Transaction.Commit();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while seeding the database: {ex.Message}");
                if (ex.InnerException != null)
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                Transaction.Rollback();
                return false; 
            }


        }
        private static List<T> LoadDataFromJison<T>(string filepath)
        {
            if (!File.Exists(filepath))
                throw new FileNotFoundException($"The file at path {filepath} was not found.");
            string Data = File.ReadAllText(filepath);
            var options = new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            options.Converters.Add(new JsonStringEnumConverter());
            return JsonSerializer.Deserialize<List<T>>(Data, options) ?? new List<T>();

        }
    }
}
