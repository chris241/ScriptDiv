using MongoDB.Driver;
using ScriptDiv.Helpers;
using ScriptDiv.Models;
using System;
using System.Linq;

namespace ScriptDiv.Services
{
    public class ChangeDivisionByUser : AbstractService
    {
        private readonly ApplicationIdentityContext applicationIdentity = ApplicationIdentityContext.Create();
        public override void executeTask()
        {
            var tpAccounts = applicationIdentity.TpAccounts.Find(_ => true).ToList();
            foreach (var tpAccount in tpAccounts)
            {
                //var div = applicationIdentity.Division.Find(x => x.IdLicence == tpAccount.LicenceId).ToList();
                UpdateDivions(tpAccount);
            }
        }
        private void UpdateDivions(TpAccount account)
        {
            try
            {
                var filter = Builders<Division>.Filter.Eq("IdLicence", account.LicenceId);
                var update = Builders<Division>.Update.Set("UserId", account.Id);
                applicationIdentity.Division.UpdateMany(filter, update, new UpdateOptions() { IsUpsert = false });
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}
