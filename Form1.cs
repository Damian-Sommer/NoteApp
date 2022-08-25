using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Noteapp
{
    public partial class Hauptfenster : Form
    {
        DataTable table;

        private string path = @"C:\noteapp\";

        public Hauptfenster()
        {
            InitializeComponent();

            DirectoryInfo verzeichnis = new DirectoryInfo(path);

            if (verzeichnis.Exists == false)
            {
                verzeichnis.Create();
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                titletextbox.Text = table.Rows[index].ItemArray[0].ToString();
                notetxtbox.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("Titel: ", typeof(string));

            table.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;

            dataGridView1.Columns["Titel: "].Width = 184;

        }

        private void btn_addnote_Click(object sender, EventArgs e)
        {
            titletextbox.Clear();
            notetxtbox.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            table.Rows.Add(titletextbox.Text, notetxtbox.Text);

            titletextbox.Clear();
            notetxtbox.Clear();

        }

        private void btn_deletenote_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}
