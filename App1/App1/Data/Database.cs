using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using App1.Models;
using System.Threading.Tasks;

namespace App1.Data
{
    class Database
    {
        readonly SQLiteAsyncConnection db;
        public Database(string StringConnection) 
        {
            db = new SQLiteAsyncConnection(StringConnection);
            db.CreateTableAsync<Users>().Wait();
        }
        public Task<Users> FindByIDAsync(int id)
        {
            return db.Table<Users>().Where(x => x.ID == id).FirstOrDefaultAsync();
        }
        public Task<Users> FindByLoginAsync(string login)
        {
            return db.Table<Users>().Where(x => x.Login == login).FirstOrDefaultAsync();
        }
        public Task<int> SaveUseAsync(Users user)
        {
            if (user.ID!=0)
            {
                return db.UpdateAsync(user);
            }
            else
            {
                return db.InsertAsync(user);
            }
        }
        public Task<int> DeleteUser(Users user)
        {
            return db.DeleteAsync(user);
        }
    }
}
