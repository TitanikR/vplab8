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

    public partial class DocForm : System.Windows.Forms.Form
    {
        DataAccess dataAccess;
        DataTable table;
        int _recordNum;
        SortedList<string, string> orgCode, regCode;

        string[] docTypes = { "АР5", "АР6", "КА2", "РТ4"};

        public DocForm()
        {
            InitializeComponent();

            dataAccess = new DataAccess();
            InitializeComboBoxes();
            InitializeForm();
            
        }

        void InitializeForm()
        {
            InitializeTable();
            _recordNum = 0;
            UpdateFields();
        }

        void InitializeTable()
        {
            table = dataAccess.GetAllRecords("Документ");
            table.TableName = "Документ";
        }

        void InitializeComboBoxes()
        {
            typeComboBox.DataSource = docTypes;
            DataTable table = dataAccess.GetAllRecords("Организация");
            orgCode = new SortedList<string, string>();
            foreach (DataRow row in table.Rows)
            {
                orgCode.Add(row[0].ToString(), row[1].ToString());
                orgComboBox.Items.Add(row[1].ToString());
            }
            table = dataAccess.GetAllRecords("Регистратор");
            regCode = new SortedList<string, string>();
            foreach (DataRow row in table.Rows)
            {
                regCode.Add(row[0].ToString(), row[1].ToString());
                regComboBox.Items.Add(row[1].ToString());
            }
        }

        void UpdateFields()
        {
            recordNum.Text = (_recordNum + 1).ToString();
            if (_recordNum < table.Rows.Count)
            {
                DocCodeTextBox.Enabled = false;
                DocCodeTextBox.Text = table.Rows[_recordNum].Field<string>(0);
                docNumTextBox.Text = table.Rows[_recordNum].Field<string>(1);
                regDateTimePicker.Value = table.Rows[_recordNum].Field<DateTime>(2);
                contentTextBox.Text = table.Rows[_recordNum].Field<string>(3);
                typeComboBox.Text = table.Rows[_recordNum].Field<string>(4);
                orgComboBox.Text = orgCode[table.Rows[_recordNum].Field<string>(5)];
                regComboBox.Text = regCode[table.Rows[_recordNum].Field<string>(6)];
            }
            else
            {
                DocCodeTextBox.Enabled = true;
                DocCodeTextBox.Text = "";
                docNumTextBox.Text = "";
                regDateTimePicker.Value = DateTime.Now;
                contentTextBox.Text = "";
                typeComboBox.Text = "";
                orgComboBox.Text = "";
                regComboBox.Text = "";
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
                success = dataAccess.InsertDoc(DocCodeTextBox.Text, docNumTextBox.Text, regDateTimePicker.Value.ToShortDateString(), contentTextBox.Text, typeComboBox.Text, orgCode.Keys[orgCode.IndexOfValue(orgComboBox.Text)],  regCode.Keys[regCode.IndexOfValue(regComboBox.Text)]);
                if (success)
                    MessageBox.Show("Документ успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                success = dataAccess.UpdateDoc(DocCodeTextBox.Text, docNumTextBox.Text, regDateTimePicker.Value.ToShortDateString(), contentTextBox.Text, typeComboBox.Text, orgCode.Keys[orgCode.IndexOfValue(orgComboBox.Text)], regCode.Keys[regCode.IndexOfValue(regComboBox.Text)]);
                if (success)
                    MessageBox.Show("Запись успешно обновлена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            InitializeTable();
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
            bool success = dataAccess.Delete(table.TableName, table.Columns[0].ColumnName, DocCodeTextBox.Text);
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
