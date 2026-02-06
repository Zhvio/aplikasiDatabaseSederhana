using App1.BusinessLogic;
using App1.Models;
using FirebirdSql.Data.FirebirdClient;
using System.Data;


namespace App1
{

    public partial class Form1 : Form
    {
        private List<Panel> panelList;
        private contohBLL _BLL = new contohBLL();


        public Form1()
        {
            InitializeComponent();

            panelList = new List<Panel> { panel1, panel2, panel3 };
        }


        #region Fungsi Biasa
        private void ChangeScene(int index)
        {
            for (int i = 0; i < panelList.Count; i++)
            {
                panelList[i].Visible = (i + 1 == index);
            }
        }

        private void DeleteTableFromDatabase(string tableName)
        {
            try
            {
                DbHelper.DeleteTableFromDatabase();
                panel3_comboBox1.Items.Remove(tableName);
                panel4_dataGridView.DataSource = null;
                panel3_comboBox1.Text = "";
                MessageBox.Show($"Tabel {tableName} berhasil dihapus.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus tabel: " + ex.Message);
            }
        }

        private async Task DeleteRecord(int id)
        {
            try
            {
                await _BLL.DeleteContoh(id);
                await RefreshTampilanGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus: " + ex.Message);
            }
        }

        private void refreshUI()
        {
            panel2_ComboBox.Text = "";
            panel3_comboBox1.Text = "";
        }

        private void RefreshDatabaseDir()
        {
            panel2_ComboBox.Items.Clear();
            refreshUI();
            string[] files = System.IO.Directory.GetFiles(@"D:\Data\", "*.fdb");
            foreach (string file in files)
            {
                panel2_ComboBox.Items.Add(file);
            }
        }

        private async Task RefreshTableDir()
        {
            try
            {
                List<string> daftarTable = await DbHelper.GetAllTables();

                panel3_comboBox1.Items.Clear();
                panel3_comboBox1.Items.AddRange(daftarTable.ToArray());
                refreshUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal refresh tabel: " + ex.Message);
            }
        }

        private async Task RefreshTampilanGrid()
        {
            if (string.IsNullOrEmpty(DbHelper.SelectedTable)) return;

            try
            {
                DataTable dt = await DbHelper.GetDataTableAsync();

                panel4_dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Refresh: " + ex.Message);
            }
        }

        #endregion


        // Fungsi SYstem
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDatabaseDir();
            ChangeScene(1);
            
        }

        private void panel2_Back_Click(object sender, EventArgs e)
        {
            ChangeScene(2);
            refreshUI();
        }

        private async void panel2_Update_Click(object sender, EventArgs e)
        {
            panel4_dataGridView.EndEdit();

            if (panel4_dataGridView.CurrentRow == null) return;

            try
            {
                var row = panel4_dataGridView.CurrentRow;
                contohModel data = new contohModel
                {
                    ID = Convert.ToInt32(row.Cells["ID"].Value),
                    Nama = row.Cells["NAMA"].Value.ToString(),
                    Jumlah = Convert.ToInt32(row.Cells["JUMLAH"].Value),
                    Harga = Convert.ToInt32(row.Cells["HARGA"].Value)
                };

                await _BLL.UpdateContoh(data);
                MessageBox.Show("Berhasil Update!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void panel1_SkipButton_Click(object sender, EventArgs e)
        {
            DbHelper.Username = "USER1";
            DbHelper.Password = "123";
            ChangeScene(2);
            RefreshDatabaseDir();
        }

        private void panel2_ButtonCreateDatabase_Click(object sender, EventArgs e)
        {
            if (panel2_TextBoxCreateDatabase.Text.Trim() == "" || panel2_TextBoxCreateDatabase == null)
            {
                MessageBox.Show("Nama Database tidak boleh Kosong!!.");
            }
            else
            {
                string databaseName = @"D:\Data\" + panel2_TextBoxCreateDatabase.Text + ".FDB";
                try
                {
                    DbHelper.Username = panel1_TextBoxNama.Text;
                    DbHelper.Password = panel1_TextBoxPassword.Text;
                    DbHelper.CreateNewDatabase(databaseName);
                    panel2_TextBoxCreateDatabase.Text = "";
                    MessageBox.Show("Database berhasil dibuat di: " + databaseName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membuat database!: " + ex.Message);
                }
                RefreshDatabaseDir();
            }

        }

        private void label2_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            DbHelper.Location = panel2_ComboBox.SelectedItem.ToString();

        }

        private async void panel2_ButtonOpenDatabase_Click(object sender, EventArgs e)
        {
            string username = panel1_TextBoxNama.Text;
            string password = panel1_TextBoxPassword.Text;
            
            bool valid = await DbHelper.TryLoginAsync(username, password);

            if (valid)
            {
                MessageBox.Show("Login Sukses!");
                ChangeScene(2);
                await RefreshTableDir();
            }
            else
            {
                MessageBox.Show("Username atau password salah!");
            }
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tableName = panel3_textBoxNewTable.Text;
                DbHelper.CreateTable(tableName);

                panel3_comboBox1.Items.Add(tableName);
                panel3_textBoxNewTable.Text = "";
                MessageBox.Show("Tabel berhasil dibuat!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuat tabel! : " + ex.Message);
            }
        }

        private async void panel3_ButtonOpen_Click(object sender, EventArgs e)
        {
            if (panel3_comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Pilih tabel terlebih dahulu!");
                return;
            }

            string selectedTable = panel3_comboBox1.SelectedItem.ToString();

            try
            {
                if (await DbHelper.IsTableExists(selectedTable))
                {
                    DbHelper.SelectedTable = selectedTable;
                    ChangeScene(3);
                    await RefreshTampilanGrid();
                }
                else
                {
                    MessageBox.Show($"Tabel '{selectedTable}' tidak ada!");
                    panel3_comboBox1.Items.Remove(selectedTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void panel3_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbHelper.SelectedTable = panel3_comboBox1.SelectedItem.ToString();
        }

        private async void panel4_buttonInsert_Click(object sender, EventArgs e)
        {
            panel4_dataGridView.EndEdit();

            try
            {
                var row = panel4_dataGridView.Rows[panel4_dataGridView.RowCount-2];

                contohModel dataNew = new contohModel
                {
                    ID = Convert.ToInt32(row.Cells["ID"].Value),
                    Nama = row.Cells["NAMA"].Value?.ToString(),
                    Jumlah = Convert.ToInt32(row.Cells["JUMLAH"].Value),
                    Harga = Convert.ToInt32(row.Cells["HARGA"].Value)
                };

                await _BLL.InsertContoh(dataNew);
                await RefreshTampilanGrid();
                MessageBox.Show("Berhasil Memasukkan Data!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void panel4_ButtonRemove_Click(object sender, EventArgs e)
        {
            if (panel4_dataGridView.CurrentRow == null || panel4_dataGridView.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!");
                return;
            }

            var rawid = panel4_dataGridView.CurrentRow.Cells["ID"].Value;

            if (rawid == null || rawid == DBNull.Value) return;

            int id = Convert.ToInt32(rawid);

            DialogResult dr = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                await DeleteRecord(id);
            }
        }

        private void panel3_ButtonRemove_Click(object sender, EventArgs e)
        {
            if (panel3_comboBox1.SelectedItem == null) return;

            string tableName = panel3_comboBox1.SelectedItem.ToString();

            DialogResult dr = MessageBox.Show($"Apakah anda ingin menghapus table '{tableName}'?", "Aksi ini akan menghapus seluruh data Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                DeleteTableFromDatabase(tableName);
            }
        }

        private void panel2_ButtonRemove_Click(object sender, EventArgs e)
        {

            if (panel2_ComboBox.SelectedItem == null) return;

            string databaseName = panel2_ComboBox.SelectedItem.ToString();

            DialogResult dr = MessageBox.Show($"Apakah anda yakin ingin menghapus database '{databaseName}'?", "Semua data akan hilang!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    FbConnection.ClearAllPools();

                    if (File.Exists(DbHelper.Location))
                    {
                        File.Delete(DbHelper.Location);
                        MessageBox.Show("Database berhasil dihapus permanen!");
                        panel2_ComboBox.Text = "";
                        RefreshDatabaseDir();
                    }
                    else
                    {
                        MessageBox.Show("File database tidak ditemukan.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void panel3_ButtonBack_Click(object sender, EventArgs e)
        {
            ChangeScene(1);
            panel2_ComboBox.Text = DbHelper.Location;
        }

        private void panel2_ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDatabaseDir();
        }

        private async void panel3_ButtonRefresh_Click(object sender, EventArgs e)
        {
            await RefreshTableDir();
        }

        private async void panel4_ButtonRefresh_Click(object sender, EventArgs e)
        {
            await RefreshTampilanGrid();
        }

        private void panel1_ButtonNewWindow_Click(object sender, EventArgs e)
        {
            Form1 jendelaBaru = new Form1();
            jendelaBaru.Show();
        }

        private void panel2_ButtonBackup_Click(object sender, EventArgs e)
        {
            try
            {
                FbConnection.ClearAllPools();
                string folderBackup = @"D:\Data\Backup\";

                if (!Directory.Exists(folderBackup))
                    Directory.CreateDirectory(folderBackup);

                string destFile = Path.Combine(folderBackup, "Backup" + ".fdb");

                File.Copy(DbHelper.Location, destFile, true);

                MessageBox.Show("Backup berhasil disimpan di: " + destFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Backup: " + ex.Message);
            }
        }

        private void panel2_ButtonRestore_Click(object sender, EventArgs e)
        {
            try
            {
                FbConnection.ClearAllPools();

                OpenFileDialog selectFile = new OpenFileDialog();
                selectFile.Filter = "Firebird Database (*.fdb)|*.fdb";
                selectFile.Title = "Cari File Database";

                if (selectFile.ShowDialog() == DialogResult.OK)
                {
                    string folder = @"D:\Data\";
                    if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

                    string destFile = Path.Combine(folder, "Restore_backup" + ".fdb");

                    File.Copy(selectFile.FileName, destFile, true);

                    MessageBox.Show("Restore berhasil.");
                    RefreshDatabaseDir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Restore: " + ex.Message);
            }
        }

        private async void panel2_ButtonRepair_Click(object sender, EventArgs e)
        {
            try
            {
                await _BLL.RepairDatabase();
                MessageBox.Show("Berhasil Repair.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal! : " + ex.Message);
            }
        }
    }
}
