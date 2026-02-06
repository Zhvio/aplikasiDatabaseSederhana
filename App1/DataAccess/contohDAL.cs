using App1.Models;

namespace App1.DataAccess
{
    public class contohDAL
    {
        public async Task InsertAsync(contohModel contoh)
        {
            using (var conn = DbHelper.GetConnection())
            {
                await conn.OpenAsync();
                string sql = $"INSERT INTO {DbHelper.SelectedTable} (ID, NAMA,JUMLAH, HARGA) VALUES (@id,@nama,@jumlah,@harga)";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", contoh.ID);
                    cmd.Parameters.AddWithValue("@nama", contoh.Nama);
                    cmd.Parameters.AddWithValue("@jumlah", contoh.Jumlah);
                    cmd.Parameters.AddWithValue("@harga", contoh.Harga);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(contohModel contoh)
        {
            using (var conn = DbHelper.GetConnection())
            {
                await conn.OpenAsync();
                string sql = $"UPDATE {DbHelper.SelectedTable} SET NAMA = @nama, JUMLAH = @jumlah, HARGA = @harga WHERE ID = @id";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", contoh.ID);
                    cmd.Parameters.AddWithValue("@nama", contoh.Nama);
                    cmd.Parameters.AddWithValue("@jumlah", contoh.Jumlah);
                    cmd.Parameters.AddWithValue("@harga", contoh.Harga);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var conn = DbHelper.GetConnection())
            {
                await conn.OpenAsync();
                string sql = $"DELETE FROM {DbHelper.SelectedTable} WHERE ID = @id";

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
