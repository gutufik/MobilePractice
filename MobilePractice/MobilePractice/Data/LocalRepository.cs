using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;

namespace MobilePractice.Data
{
    public class LocalRepository
    {
        SQLiteConnection dataBase;
        public LocalRepository(string databasePath)
        {
            dataBase = new SQLiteConnection(databasePath);
            dataBase.CreateTable<User>();
            dataBase.CreateTable<Product>();
        }
        public List<User> GetUsers()
        { 
            return dataBase.Table<User>().ToList();
        }

        public User GetUser(string login, string password)
        {
            return GetUsers().FirstOrDefault(x=> x.Login == login && x.Password == password);
        }
        public void RegisterUser(User user)
        { 
            dataBase.Insert(user);
        }

        public List<Product> GetProducts()
        { 
            return dataBase.Table<Product>().ToList();
        }
        public void SaveProduct(Product product)
        { 
            if (GetProducts().FirstOrDefault(x => x.Id == product.Id) == null)
                dataBase.Insert(product);
            else
                dataBase.Update(product);
        }
    }
}
