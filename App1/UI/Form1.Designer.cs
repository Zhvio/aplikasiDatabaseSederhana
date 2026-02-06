namespace App1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1_TextBoxNama = new TextBox();
            panel1_TextBoxPassword = new TextBox();
            LabelNama = new Label();
            LabelPassword = new Label();
            panel1_Title = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel1_ButtonNewWindow = new Button();
            panel1_SkipButton = new Button();
            panel2_ButtonRepair = new Button();
            panel2_ButtonRestore = new Button();
            panel2_ButtonBackup = new Button();
            panel2_ButtonRefresh = new Button();
            panel2_ButtonRemove = new Button();
            panel2_ButtonOpenDatabase = new Button();
            panel2_TextBoxCreateDatabase = new TextBox();
            panel2_LabelCreateDatabase = new Label();
            panel2_ButtonCreateDatabase = new Button();
            panel2_ComboBox = new ComboBox();
            panel3 = new Panel();
            panel4_ButtonRefresh = new Button();
            panel4_ButtonRemove = new Button();
            panel4_buttonInsert = new Button();
            panel3_Update = new Button();
            panel3_Back = new Button();
            panel4_dataGridView = new DataGridView();
            panel2 = new Panel();
            panel3_ButtonRefresh = new Button();
            panel3_ButtonBack = new Button();
            panel3_ButtonRemove = new Button();
            button1 = new Button();
            panel3_textBoxNewTable = new TextBox();
            label3 = new Label();
            panel3_ButtonOpen = new Button();
            label2 = new Label();
            panel3_comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panel4_dataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1_TextBoxNama
            // 
            panel1_TextBoxNama.Location = new Point(291, 129);
            panel1_TextBoxNama.Name = "panel1_TextBoxNama";
            panel1_TextBoxNama.PlaceholderText = "Masukkan Username...";
            panel1_TextBoxNama.Size = new Size(189, 23);
            panel1_TextBoxNama.TabIndex = 1;
            // 
            // panel1_TextBoxPassword
            // 
            panel1_TextBoxPassword.ImeMode = ImeMode.Off;
            panel1_TextBoxPassword.Location = new Point(291, 171);
            panel1_TextBoxPassword.Name = "panel1_TextBoxPassword";
            panel1_TextBoxPassword.PasswordChar = '*';
            panel1_TextBoxPassword.PlaceholderText = "Masukkan Password...";
            panel1_TextBoxPassword.Size = new Size(189, 23);
            panel1_TextBoxPassword.TabIndex = 2;
            // 
            // LabelNama
            // 
            LabelNama.AutoSize = true;
            LabelNama.Location = new Point(192, 129);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(93, 15);
            LabelNama.TabIndex = 4;
            LabelNama.Text = "Nama                 :";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(192, 174);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(93, 15);
            LabelPassword.TabIndex = 5;
            LabelPassword.Text = "Password           :";
            // 
            // panel1_Title
            // 
            panel1_Title.AutoSize = true;
            panel1_Title.Location = new Point(258, 36);
            panel1_Title.Name = "panel1_Title";
            panel1_Title.Size = new Size(213, 15);
            panel1_Title.TabIndex = 8;
            panel1_Title.Text = "Selamat Datang di Program Input Data.";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel1_ButtonNewWindow);
            panel1.Controls.Add(panel1_SkipButton);
            panel1.Controls.Add(panel1_Title);
            panel1.Controls.Add(LabelPassword);
            panel1.Controls.Add(LabelNama);
            panel1.Controls.Add(panel1_TextBoxPassword);
            panel1.Controls.Add(panel1_TextBoxNama);
            panel1.Controls.Add(panel2_ButtonRepair);
            panel1.Controls.Add(panel2_ButtonRestore);
            panel1.Controls.Add(panel2_ButtonBackup);
            panel1.Controls.Add(panel2_ButtonRefresh);
            panel1.Controls.Add(panel2_ButtonRemove);
            panel1.Controls.Add(panel2_ButtonOpenDatabase);
            panel1.Controls.Add(panel2_TextBoxCreateDatabase);
            panel1.Controls.Add(panel2_LabelCreateDatabase);
            panel1.Controls.Add(panel2_ButtonCreateDatabase);
            panel1.Controls.Add(panel2_ComboBox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 450);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 416);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 16;
            label1.Text = "NEW Database Name: ";
            // 
            // panel1_ButtonNewWindow
            // 
            panel1_ButtonNewWindow.Location = new Point(13, 413);
            panel1_ButtonNewWindow.Name = "panel1_ButtonNewWindow";
            panel1_ButtonNewWindow.Size = new Size(102, 23);
            panel1_ButtonNewWindow.TabIndex = 15;
            panel1_ButtonNewWindow.Text = "New Window";
            panel1_ButtonNewWindow.UseVisualStyleBackColor = true;
            panel1_ButtonNewWindow.Click += panel1_ButtonNewWindow_Click;
            // 
            // panel1_SkipButton
            // 
            panel1_SkipButton.Location = new Point(635, 408);
            panel1_SkipButton.Name = "panel1_SkipButton";
            panel1_SkipButton.Size = new Size(75, 23);
            panel1_SkipButton.TabIndex = 14;
            panel1_SkipButton.Text = "Skip";
            panel1_SkipButton.UseVisualStyleBackColor = true;
            panel1_SkipButton.Click += panel1_SkipButton_Click;
            // 
            // panel2_ButtonRepair
            // 
            panel2_ButtonRepair.Location = new Point(176, 372);
            panel2_ButtonRepair.Name = "panel2_ButtonRepair";
            panel2_ButtonRepair.Size = new Size(112, 23);
            panel2_ButtonRepair.TabIndex = 9;
            panel2_ButtonRepair.Text = "Check or Repair";
            panel2_ButtonRepair.UseVisualStyleBackColor = true;
            panel2_ButtonRepair.Click += panel2_ButtonRepair_Click;
            // 
            // panel2_ButtonRestore
            // 
            panel2_ButtonRestore.Location = new Point(13, 372);
            panel2_ButtonRestore.Name = "panel2_ButtonRestore";
            panel2_ButtonRestore.Size = new Size(75, 23);
            panel2_ButtonRestore.TabIndex = 8;
            panel2_ButtonRestore.Text = "Restore";
            panel2_ButtonRestore.UseVisualStyleBackColor = true;
            panel2_ButtonRestore.Click += panel2_ButtonRestore_Click;
            // 
            // panel2_ButtonBackup
            // 
            panel2_ButtonBackup.Location = new Point(94, 372);
            panel2_ButtonBackup.Name = "panel2_ButtonBackup";
            panel2_ButtonBackup.Size = new Size(75, 23);
            panel2_ButtonBackup.TabIndex = 7;
            panel2_ButtonBackup.Text = "Backup";
            panel2_ButtonBackup.UseVisualStyleBackColor = true;
            panel2_ButtonBackup.Click += panel2_ButtonBackup_Click;
            // 
            // panel2_ButtonRefresh
            // 
            panel2_ButtonRefresh.Location = new Point(498, 264);
            panel2_ButtonRefresh.Name = "panel2_ButtonRefresh";
            panel2_ButtonRefresh.Size = new Size(75, 23);
            panel2_ButtonRefresh.TabIndex = 6;
            panel2_ButtonRefresh.Text = "Refresh";
            panel2_ButtonRefresh.UseVisualStyleBackColor = true;
            panel2_ButtonRefresh.Click += panel2_ButtonRefresh_Click;
            // 
            // panel2_ButtonRemove
            // 
            panel2_ButtonRemove.Location = new Point(332, 264);
            panel2_ButtonRemove.Name = "panel2_ButtonRemove";
            panel2_ButtonRemove.Size = new Size(75, 23);
            panel2_ButtonRemove.TabIndex = 5;
            panel2_ButtonRemove.Text = "Delete";
            panel2_ButtonRemove.UseVisualStyleBackColor = true;
            panel2_ButtonRemove.Click += panel2_ButtonRemove_Click;
            // 
            // panel2_ButtonOpenDatabase
            // 
            panel2_ButtonOpenDatabase.Location = new Point(413, 264);
            panel2_ButtonOpenDatabase.Name = "panel2_ButtonOpenDatabase";
            panel2_ButtonOpenDatabase.Size = new Size(75, 23);
            panel2_ButtonOpenDatabase.TabIndex = 4;
            panel2_ButtonOpenDatabase.Text = "Login";
            panel2_ButtonOpenDatabase.UseVisualStyleBackColor = true;
            panel2_ButtonOpenDatabase.Click += panel2_ButtonOpenDatabase_Click;
            // 
            // panel2_TextBoxCreateDatabase
            // 
            panel2_TextBoxCreateDatabase.Location = new Point(280, 414);
            panel2_TextBoxCreateDatabase.Name = "panel2_TextBoxCreateDatabase";
            panel2_TextBoxCreateDatabase.PlaceholderText = "Create new Database...";
            panel2_TextBoxCreateDatabase.Size = new Size(137, 23);
            panel2_TextBoxCreateDatabase.TabIndex = 3;
            // 
            // panel2_LabelCreateDatabase
            // 
            panel2_LabelCreateDatabase.AutoSize = true;
            panel2_LabelCreateDatabase.Location = new Point(192, 224);
            panel2_LabelCreateDatabase.Name = "panel2_LabelCreateDatabase";
            panel2_LabelCreateDatabase.Size = new Size(96, 15);
            panel2_LabelCreateDatabase.TabIndex = 2;
            panel2_LabelCreateDatabase.Text = "Database Name: ";
            // 
            // panel2_ButtonCreateDatabase
            // 
            panel2_ButtonCreateDatabase.Location = new Point(423, 416);
            panel2_ButtonCreateDatabase.Name = "panel2_ButtonCreateDatabase";
            panel2_ButtonCreateDatabase.Size = new Size(75, 23);
            panel2_ButtonCreateDatabase.TabIndex = 1;
            panel2_ButtonCreateDatabase.Text = "Create";
            panel2_ButtonCreateDatabase.UseVisualStyleBackColor = true;
            panel2_ButtonCreateDatabase.Click += panel2_ButtonCreateDatabase_Click;
            // 
            // panel2_ComboBox
            // 
            panel2_ComboBox.FormattingEnabled = true;
            panel2_ComboBox.Location = new Point(290, 221);
            panel2_ComboBox.Name = "panel2_ComboBox";
            panel2_ComboBox.Size = new Size(190, 23);
            panel2_ComboBox.TabIndex = 0;
            panel2_ComboBox.SelectedIndexChanged += label2_ComboBox_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4_ButtonRefresh);
            panel3.Controls.Add(panel4_ButtonRemove);
            panel3.Controls.Add(panel4_buttonInsert);
            panel3.Controls.Add(panel3_Update);
            panel3.Controls.Add(panel3_Back);
            panel3.Controls.Add(panel4_dataGridView);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(720, 449);
            panel3.TabIndex = 10;
            // 
            // panel4_ButtonRefresh
            // 
            panel4_ButtonRefresh.Location = new Point(366, 417);
            panel4_ButtonRefresh.Name = "panel4_ButtonRefresh";
            panel4_ButtonRefresh.Size = new Size(75, 23);
            panel4_ButtonRefresh.TabIndex = 14;
            panel4_ButtonRefresh.Text = "Refresh";
            panel4_ButtonRefresh.UseVisualStyleBackColor = true;
            panel4_ButtonRefresh.Click += panel4_ButtonRefresh_Click;
            // 
            // panel4_ButtonRemove
            // 
            panel4_ButtonRemove.Location = new Point(456, 417);
            panel4_ButtonRemove.Name = "panel4_ButtonRemove";
            panel4_ButtonRemove.Size = new Size(75, 23);
            panel4_ButtonRemove.TabIndex = 13;
            panel4_ButtonRemove.Text = "Delete";
            panel4_ButtonRemove.UseVisualStyleBackColor = true;
            panel4_ButtonRemove.Click += panel4_ButtonRemove_Click;
            // 
            // panel4_buttonInsert
            // 
            panel4_buttonInsert.Location = new Point(635, 417);
            panel4_buttonInsert.Name = "panel4_buttonInsert";
            panel4_buttonInsert.Size = new Size(75, 23);
            panel4_buttonInsert.TabIndex = 12;
            panel4_buttonInsert.Text = "Insert";
            panel4_buttonInsert.UseVisualStyleBackColor = true;
            panel4_buttonInsert.Click += panel4_buttonInsert_Click;
            // 
            // panel3_Update
            // 
            panel3_Update.Location = new Point(554, 417);
            panel3_Update.Name = "panel3_Update";
            panel3_Update.Size = new Size(75, 23);
            panel3_Update.TabIndex = 10;
            panel3_Update.Text = "Update";
            panel3_Update.UseVisualStyleBackColor = true;
            panel3_Update.Click += panel2_Update_Click;
            // 
            // panel3_Back
            // 
            panel3_Back.Location = new Point(12, 417);
            panel3_Back.Name = "panel3_Back";
            panel3_Back.Size = new Size(75, 23);
            panel3_Back.TabIndex = 9;
            panel3_Back.Text = "Back";
            panel3_Back.UseVisualStyleBackColor = true;
            panel3_Back.Click += panel2_Back_Click;
            // 
            // panel4_dataGridView
            // 
            panel4_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panel4_dataGridView.Location = new Point(12, 12);
            panel4_dataGridView.Name = "panel4_dataGridView";
            panel4_dataGridView.Size = new Size(698, 399);
            panel4_dataGridView.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3_ButtonRefresh);
            panel2.Controls.Add(panel3_ButtonBack);
            panel2.Controls.Add(panel3_ButtonRemove);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3_textBoxNewTable);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel3_ButtonOpen);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3_comboBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(722, 454);
            panel2.TabIndex = 5;
            // 
            // panel3_ButtonRefresh
            // 
            panel3_ButtonRefresh.Location = new Point(579, 264);
            panel3_ButtonRefresh.Name = "panel3_ButtonRefresh";
            panel3_ButtonRefresh.Size = new Size(75, 23);
            panel3_ButtonRefresh.TabIndex = 8;
            panel3_ButtonRefresh.Text = "Refresh";
            panel3_ButtonRefresh.UseVisualStyleBackColor = true;
            panel3_ButtonRefresh.Click += panel3_ButtonRefresh_Click;
            // 
            // panel3_ButtonBack
            // 
            panel3_ButtonBack.Location = new Point(12, 415);
            panel3_ButtonBack.Name = "panel3_ButtonBack";
            panel3_ButtonBack.Size = new Size(75, 23);
            panel3_ButtonBack.TabIndex = 7;
            panel3_ButtonBack.Text = "Back";
            panel3_ButtonBack.UseVisualStyleBackColor = true;
            panel3_ButtonBack.Click += panel3_ButtonBack_Click;
            // 
            // panel3_ButtonRemove
            // 
            panel3_ButtonRemove.Location = new Point(481, 264);
            panel3_ButtonRemove.Name = "panel3_ButtonRemove";
            panel3_ButtonRemove.Size = new Size(75, 23);
            panel3_ButtonRemove.TabIndex = 6;
            panel3_ButtonRemove.Text = "Delete";
            panel3_ButtonRemove.UseMnemonic = false;
            panel3_ButtonRemove.UseVisualStyleBackColor = true;
            panel3_ButtonRemove.Click += panel3_ButtonRemove_Click;
            // 
            // button1
            // 
            button1.Location = new Point(481, 186);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3_textBoxNewTable
            // 
            panel3_textBoxNewTable.Location = new Point(290, 186);
            panel3_textBoxNewTable.Name = "panel3_textBoxNewTable";
            panel3_textBoxNewTable.Size = new Size(181, 23);
            panel3_textBoxNewTable.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 189);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 3;
            label3.Text = "Create new Table :";
            // 
            // panel3_ButtonOpen
            // 
            panel3_ButtonOpen.Location = new Point(396, 264);
            panel3_ButtonOpen.Name = "panel3_ButtonOpen";
            panel3_ButtonOpen.Size = new Size(75, 23);
            panel3_ButtonOpen.TabIndex = 2;
            panel3_ButtonOpen.Text = "Open";
            panel3_ButtonOpen.UseVisualStyleBackColor = true;
            panel3_ButtonOpen.Click += panel3_ButtonOpen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 229);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Table List:";
            // 
            // panel3_comboBox1
            // 
            panel3_comboBox1.FormattingEnabled = true;
            panel3_comboBox1.Location = new Point(290, 224);
            panel3_comboBox1.Name = "panel3_comboBox1";
            panel3_comboBox1.Size = new Size(181, 23);
            panel3_comboBox1.TabIndex = 0;
            panel3_comboBox1.SelectedIndexChanged += panel3_comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Aplikasi Sederhana";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panel4_dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox panel1_TextBoxNama;
        private TextBox panel1_TextBoxPassword;
        private Label LabelNama;
        private Label LabelPassword;
        private Label panel1_Title;
        private Panel panel1;
        private Panel panel3;
        private Button panel3_Back;
        private DataGridView panel4_dataGridView;
        private Button panel3_Update;
        private Button panel1_SkipButton;
        private ComboBox panel2_ComboBox;
        private TextBox panel2_TextBoxCreateDatabase;
        private Label panel2_LabelCreateDatabase;
        private Button panel2_ButtonCreateDatabase;
        private Button panel2_ButtonOpenDatabase;
        private Panel panel2;
        private Button button1;
        private TextBox panel3_textBoxNewTable;
        private Label label3;
        private Button panel3_ButtonOpen;
        private Label label2;
        private ComboBox panel3_comboBox1;
        private Button panel4_buttonInsert;
        private Button panel4_ButtonRemove;
        private Button panel3_ButtonRemove;
        private Button panel2_ButtonRemove;
        private Button panel3_ButtonBack;
        private Button panel2_ButtonRefresh;
        private Button panel3_ButtonRefresh;
        private Button panel4_ButtonRefresh;
        private Button panel1_ButtonNewWindow;
        private Button panel2_ButtonBackup;
        private Button panel2_ButtonRestore;
        private Button panel2_ButtonRepair;
        private Label label1;
    }
}
