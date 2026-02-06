using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Services;

namespace App1.DataAccess
{
    public class Repair
    {
        public async Task ExecuteRepair()
        {
            FbConnection.ClearAllPools();
            FbValidation validationSvc = new FbValidation();
            validationSvc.ConnectionString = $"User={DbHelper.Username};Password={DbHelper.Password};Database={DbHelper.Location};DataSource=localhost";

            // check database
            validationSvc.Options = FbValidationFlags.CheckDatabase | FbValidationFlags.Full;

            try
            {
                validationSvc.Execute();
            }
            catch
            {
                // mend (repair) jika error cek.
                validationSvc.Options = FbValidationFlags.MendDatabase | FbValidationFlags.IgnoreChecksum;
                validationSvc.Execute();
            }
        }

        public async Task BackupDatabaseAsync()
        {
            FbConnection.ClearAllPools();

            string backupPath = DbHelper.BackupFolder + DbHelper.SelectedTable + ".bak";

            FbBackup backupSvc = new FbBackup();
            backupSvc.ConnectionString = $"User={DbHelper.Username};Password={DbHelper.Password};Database={DbHelper.Location};DataSource=localhost";
            backupSvc.BackupFiles.Add(new FbBackupFile(backupPath, 2048));
            backupSvc.Verbose = true;

            // Async
            await Task.Run(() => backupSvc.Execute());
        }
    }
}
