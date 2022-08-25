namespace Noteapp
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_addnote = new System.Windows.Forms.Button();
            this.btn_deletenote = new System.Windows.Forms.Button();
            this.notetxtbox = new System.Windows.Forms.RichTextBox();
            this.lbl_shownotes = new System.Windows.Forms.Label();
            this.titletextbox = new System.Windows.Forms.RichTextBox();
            this.lbl_notetitle = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_storage = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe Print", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(215, 76);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Noteapp";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_save.Location = new System.Drawing.Point(303, 44);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(202, 55);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_read.FlatAppearance.BorderSize = 0;
            this.btn_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_read.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_read.Location = new System.Drawing.Point(531, 44);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(202, 55);
            this.btn_read.TabIndex = 3;
            this.btn_read.Text = "Lesen";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_addnote
            // 
            this.btn_addnote.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_addnote.FlatAppearance.BorderSize = 0;
            this.btn_addnote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addnote.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addnote.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_addnote.Location = new System.Drawing.Point(901, 12);
            this.btn_addnote.Name = "btn_addnote";
            this.btn_addnote.Size = new System.Drawing.Size(357, 55);
            this.btn_addnote.TabIndex = 4;
            this.btn_addnote.Text = "Neue Notiz hinzufügen";
            this.btn_addnote.UseVisualStyleBackColor = false;
            this.btn_addnote.Click += new System.EventHandler(this.btn_addnote_Click);
            // 
            // btn_deletenote
            // 
            this.btn_deletenote.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_deletenote.FlatAppearance.BorderSize = 0;
            this.btn_deletenote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletenote.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletenote.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_deletenote.Location = new System.Drawing.Point(901, 73);
            this.btn_deletenote.Name = "btn_deletenote";
            this.btn_deletenote.Size = new System.Drawing.Size(357, 55);
            this.btn_deletenote.TabIndex = 5;
            this.btn_deletenote.Text = "Notiz löschen";
            this.btn_deletenote.UseVisualStyleBackColor = false;
            this.btn_deletenote.Click += new System.EventHandler(this.btn_deletenote_Click);
            // 
            // notetxtbox
            // 
            this.notetxtbox.Location = new System.Drawing.Point(303, 260);
            this.notetxtbox.Name = "notetxtbox";
            this.notetxtbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.notetxtbox.Size = new System.Drawing.Size(870, 564);
            this.notetxtbox.TabIndex = 6;
            this.notetxtbox.Text = "";
            // 
            // lbl_shownotes
            // 
            this.lbl_shownotes.AutoSize = true;
            this.lbl_shownotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.lbl_shownotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shownotes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_shownotes.Location = new System.Drawing.Point(12, 188);
            this.lbl_shownotes.Name = "lbl_shownotes";
            this.lbl_shownotes.Size = new System.Drawing.Size(72, 20);
            this.lbl_shownotes.TabIndex = 7;
            this.lbl_shownotes.Text = "Notizen: ";
            // 
            // titletextbox
            // 
            this.titletextbox.Location = new System.Drawing.Point(303, 211);
            this.titletextbox.Name = "titletextbox";
            this.titletextbox.Size = new System.Drawing.Size(870, 19);
            this.titletextbox.TabIndex = 9;
            this.titletextbox.Text = "";
            // 
            // lbl_notetitle
            // 
            this.lbl_notetitle.AutoSize = true;
            this.lbl_notetitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notetitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_notetitle.Location = new System.Drawing.Point(303, 190);
            this.lbl_notetitle.Name = "lbl_notetitle";
            this.lbl_notetitle.Size = new System.Drawing.Size(164, 20);
            this.lbl_notetitle.TabIndex = 10;
            this.lbl_notetitle.Text = "Titel von deiner Notiz:";
            // 
            // lbl_storage
            // 
            this.lbl_storage.AutoSize = true;
            this.lbl_storage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_storage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_storage.Location = new System.Drawing.Point(303, 237);
            this.lbl_storage.Name = "lbl_storage";
            this.lbl_storage.Size = new System.Drawing.Size(58, 20);
            this.lbl_storage.TabIndex = 11;
            this.lbl_storage.Text = "Inhalt: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Wheat;
            this.dataGridView1.Location = new System.Drawing.Point(1, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(251, 613);
            this.dataGridView1.TabIndex = 12;
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1270, 823);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_storage);
            this.Controls.Add(this.lbl_notetitle);
            this.Controls.Add(this.titletextbox);
            this.Controls.Add(this.lbl_shownotes);
            this.Controls.Add(this.notetxtbox);
            this.Controls.Add(this.btn_deletenote);
            this.Controls.Add(this.btn_addnote);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_title);
            this.Name = "Hauptfenster";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noteapp";
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_addnote;
        private System.Windows.Forms.Button btn_deletenote;
        private System.Windows.Forms.RichTextBox notetxtbox;
        private System.Windows.Forms.Label lbl_shownotes;
        private System.Windows.Forms.RichTextBox titletextbox;
        private System.Windows.Forms.Label lbl_notetitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_storage;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

