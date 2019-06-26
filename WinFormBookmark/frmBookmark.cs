using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBookmark
{
    public partial class frmBookmark : Form
    {
        DBBookmark db = new DBBookmark();
        public frmBookmark()
        {
            InitializeComponent();
        }

        private void btnAddBookmark_Click(object sender, EventArgs e)
        {
            if (!ValidInput())
            {
                return;
            }

            Bookmark task = new Bookmark
            {
                Name = txtBookmarkName.Text,
                Minimum = (int)numericMin.Value,
                Maximum = (int)numericMax.Value,
                Type = txtType.Text,
                Status = cboStatus.Text,
                Info = txtInfo.Text,
            };

            string query = "INSERT INTO Bookmark(Name, Type, Status, Minimum, Maximum, [Current], Info)" +
                "VALUES('" + task.Name.Replace("'", "''") + "', '" + task.Type.Replace("'", "''") + "', '" + task.Status + "', '" + task.Minimum.ToString() + "', '" + task.Maximum + "', '0', '" + task.Info.ToString() + "')";

            if (db.ExecuteQuery(query) > 0)
            {
                MessageBox.Show("Bookmark details added successfuly.");
                ClearValues();

                ShowDetails();
            }
            else
            {
                MessageBox.Show("Error while adding Bookmark.");
            }
        }

        private void ShowDetails()
        {
            DataSet data = db.GetQueryResult("SELECT Name, Type, Status, Minimum, Maximum, [Current], Info, CASE WHEN [CURRENT] = 0 THEN [CURRENT] ELSE ROUND((CONVERT(FLOAT, [CURRENT]) / Maximum) * 100, 2) END AS [% Complete] FROM Bookmark");

            gridTasks.DataSource = data.Tables[0];
            gridTasks.ClearSelection();

            //ClearValues();
        }

        private bool ValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtBookmarkName.Text))
            {
                MessageBox.Show("Please, enter Bookmark Name");
                txtBookmarkName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("Please, enter Bookmark Type");
                txtBookmarkName.Focus();
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearValues();
        }

        private void ClearValues()
        {
            txtBookmarkName.Text = "";
            numericMin.Value = 0;
            numericMax.Value = 0;
            txtType.Text = "";
            cboStatus.Text = "";
            txtInfo.Text = "";
        }

        private void frmBookmark_Load(object sender, EventArgs e)
        {
            ShowDetails();
        }

        private void gridBookmark_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableEdit(gridTasks.CurrentRow);
        }

        private void EnableEdit(DataGridViewRow row)
        {
            ViewDetails(row);

            btnAddBookmark.Visible = false;

            //btnEditTask.Location = new Point(937, 92);
            btnUpdateBookmark.Visible = true;
            txtCurrent.Enabled = true;
            btnNew.Enabled = true;
            txtBookmarkName.Enabled = false;
            grpBookmark.Text = "Bookmark Details";
        }

        private void ViewDetails(DataGridViewRow row)
        {
            txtBookmarkName.Text = row.Cells[0].Value.ToString();
            numericMin.Value = (int)row.Cells[3].Value;
            numericMax.Value = (int)row.Cells[4].Value;
            txtCurrent.Text = row.Cells[5].Value.ToString();
            txtType.Text = row.Cells[1].Value.ToString();
            cboStatus.Text = row.Cells[2].Value.ToString();
            txtInfo.Text = row.Cells[6].Value.ToString();
            txtPercentage.Text = row.Cells[7].Value.ToString();
        }

        private void gridBookmark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearValues();
            txtBookmarkName.Focus();
            btnAddBookmark.Visible = true;
            btnAddBookmark.Enabled = true;
            btnUpdateBookmark.Visible = false;
            txtBookmarkName.Enabled = true;
            grpBookmark.Text = "New - Bookmark";
        }

        private void btnUpdateBookmark_Click(object sender, EventArgs e)
        {
            if (!ValidInput())
            {
                return;
            }

            Bookmark bookmark = new Bookmark
            {
                Name = txtBookmarkName.Text,
                Minimum = (int)numericMin.Value,
                Maximum = (int)numericMax.Value,
                Current = txtCurrent.Text,
                Type = txtType.Text,
                Status = cboStatus.Text,
                Info = txtInfo.Text,
            };

            string query = "UPDATE Task SET Type = '" + bookmark.Type.Replace("'", "''") + "', Status = '" +
                bookmark.Status + "', Minimum = '" + bookmark.Minimum.ToString() + "', Maximum = '" + bookmark.Maximum.ToString() + "', [Current] = '" +
                bookmark.Current + "', Info = '" + bookmark.Info.ToString() + "' WHERE Name = '" + bookmark.Name.Replace("'", "''") + "'";

            if (db.ExecuteQuery(query) > 0)
            {
                MessageBox.Show("Bookmark details saved successfuly.");

                ShowDetails();
            }
            else
            {
                MessageBox.Show("Error while saving Bookmark details.");
            }
        }

        private void gridTasks_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            EnableEdit(gridTasks.CurrentRow);
        }
    }
}
