using App1.DataAccess;
using App1.Models;

namespace App1.BusinessLogic
{
    public class contohBLL
    {
        private contohDAL _dal = new contohDAL();
        private Repair _repDAL = new Repair();
        // 1. INSERT
        public async Task InsertContoh(contohModel data)
        {
            if (data.ID < 0) throw new Exception("Id gaboleh ksoong");
            if (string.IsNullOrWhiteSpace(data.Nama)) throw new Exception("Nama gk boleh kosong");
            await _dal.InsertAsync(data);
        }

        // 2. UPDATE
        public async Task UpdateContoh(contohModel data)
        {
            if (data.ID < 0) throw new Exception("Id tidak valid");
            if (data.Harga < 0) throw new Exception("Harga tidak valid");

            await _dal.UpdateAsync(data);
        }

        // 3. DELETE
        public async Task DeleteContoh(int id)
        {
            await _dal.DeleteAsync(id);
        }

        // Repair
        public async Task RepairDatabase()
        {
            // cek database
            if (string.IsNullOrEmpty(DbHelper.Location)) throw new Exception("Lokasi database belum dipilih!");

            try
            {
                // backup file
                await _repDAL.BackupDatabaseAsync();

                // jalankan repair
                await _repDAL.ExecuteRepair();
            }
            catch (Exception ex)
            {
                throw new Exception("Proses Maintenance Gagal: " + ex.Message);
            }
        }
    }
}