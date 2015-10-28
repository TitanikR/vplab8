using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VPlab8.DataController;

namespace VPlab8
{
    public partial class RegForm : System.Windows.Forms.Form
    {
        DataAccess dataAccess;
        DataTable table;
        int _recordNum;

        public RegForm()
        {
            InitializeComponent();

            dataAccess = new DataAccess();
            InitializeTable();
            _recordNum = 0;
        }

        void InitializeTable()
        {
            table = dataAccess.GetAllRecords("Регистратор");
            table.TableName = "Регистратор";
            UpdateFields();
        }

        void UpdateFields()
        {
            recordNum.Text = (_recordNum + 1).ToString();
            if (_recordNum < table.Rows.Count)
            {
                RegCodeTextBox.Enabled = false;
                RegCodeTextBox.Text = table.Rows[_recordNum].Field<string>(0);
                familyTextBox.Text = table.Rows[_recordNum].Field<string>(1);
                nameTextBox.Text = table.Rows[_recordNum].Field<string>(2);
                otchTextBox.Text = table.Rows[_recordNum].Field<string>(3);
                postTextBox.Text = table.Rows[_recordNum].Field<string>(4);
                bringDateTimePicker.Value = table.Rows[_recordNum].Field<DateTime>(5);
            }
            else
            {
                RegCodeTextBox.Enabled = true;
                RegCodeTextBox.Text = "";
                familyTextBox.Text = "";
                nameTextBox.Text = "";
                otchTextBox.Text = "";
                postTextBox.Text = "";
                bringDateTimePicker.Value = DateTime.Now;
            }
        }

        private void prevRecord_Click(object sender, EventArgs e)
        {
            _recordNum--;
            if (_recordNum < 0)
                _recordNum = table.Rows.Count - 1;
            UpdateFields();
        }

        private void nextRecord_Click(object sender, EventArgs e)
        {
            _recordNum++;
            if (_recordNum >= table.Rows.Count)
                _recordNum = 0;
            UpdateFields();
        }

        private void newRegButton_Click(object sender, EventArgs e)
        {
            _recordNum = table.Rows.Count;
            UpdateFields();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool success;
            if (_recordNum == table.Rows.Count)
            {
                success = dataAccess.InsertReg(RegCodeTextBox.Text, familyTextBox.Text, nameTextBox.Text, otchTextBox.Text, postTextBox.Text, bringDateTimePicker.Value.ToShortDateString());
                if (success)
                    MessageBox.Show("Регистратор успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                success = dataAccess.UpdateReg(RegCodeTextBox.Text, familyTextBox.Text, nameTextBox.Text, otchTextBox.Text, postTextBox.Text, bringDateTimePicker.Value.ToShortDateString());
                if (success)
                    MessageBox.Show("Запись успешно обновлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            table = dataAccess.GetAllRecords("Регистратор");
        }

        private void recordNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TextBox textBox = (TextBox)sender;
                int recordNum;
                if (int.TryParse(textBox.Text, out recordNum) && recordNum < table.Rows.Count && recordNum > 0)
                {
                    _recordNum = recordNum - 1;
                }
                else
                {
                    textBox.Text = table.Rows.Count.ToString();
                    _recordNum = table.Rows.Count - 1;
                }
                UpdateFields();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool success = dataAccess.Delete(table.TableName, table.Columns[0].ColumnName, RegCodeTextBox.Text);
            if (success)
            {
                MessageBox.Show("Запись успешно удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_recordNum != 0)
                    _recordNum -= 1;
                else
                    _recordNum = 0;
                InitializeTable();
                UpdateFields();
            }
        }
    }
}
