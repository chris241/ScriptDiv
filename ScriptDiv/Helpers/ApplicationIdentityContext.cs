using MongoDB.Driver;
using ScriptDiv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDiv.Helpers
{
	public class ApplicationIdentityContext : IDisposable
	{
		private static readonly object lockObject = new object();
		private static ApplicationIdentityContext instance;
		public static ApplicationIdentityContext Create()
		{
			if (instance == null)
			{
				lock (lockObject)
				{
					if (instance == null)
					{
						var client = new MongoClient("mongodb://localhost:27017/CustomerApplication");
						var database = client.GetDatabase("CustomerApplication");
						var division = database.GetCollection<Division>("division");
						var tpAccounts = database.GetCollection<TpAccount>("tpAccount");
						var users = database.GetCollection<Users>("users");
						var userRoles = database.GetCollection<UserRole>("userRole");
						instance = new ApplicationIdentityContext
						{
							Users = users,
							UserRole = userRoles,
							TpAccounts = tpAccounts,
							Division = division
						};
					}
				}
			}
			return instance;
		}
		public IMongoCollection<Division> Division { get; set; }
		public IMongoCollection<TpAccount> TpAccounts { get; set; }
		public IMongoCollection<Users> Users { get; set; }
		public IMongoCollection<UserRole> UserRole { get; set; }

		public void Dispose()
		{
		}
	}
}
