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
    public partial class MainForm : System.Windows.Forms.Form
    {
        DataAccess dataAccess;
        DataTable currentTable;

        public MainForm()
        {
            InitializeComponent();

            dataAccess = new DataAccess();
            InitializeComboBox();
        }

        void InitializeComboBox()
        {
            string[] tableNames = { "Документ", "Организация", "Регистратор" };
            tableComboBox.DataSource = tableNames;
        }

        void InitializeFilterComboBox()
        {
            filterComboBox.Items.Clear();
            foreach (DataColumn col in currentTable.Columns)
            {
                filterComboBox.Items.Add(col.ColumnName);
            }
        }

        void InitializeTable(bool isTableReady = false)
        {
            if (!isTableReady)
                currentTable = dataAccess.GetAllRecords(tableComboBox.SelectedItem.ToString());
            currentTable.TableName = tableComboBox.Text;
            dataGridView.DataSource = currentTable;
            InitializeFilterComboBox();
        }

        private void tableComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            InitializeTable();
        }

        private void openFormButton_Click(object sender, EventArgs e)
        {
            switch (tableComboBox.SelectedItem.ToString())
            { 
                case "Документ":
                    new DocForm().Show();
                    break;
                case "Регистратор":
                    new RegForm().Show();
                    break;
                case "Организация":
                    new OrgForm().Show();
                    break;
                default:
                    MessageBox.Show("Ошибка открытия формы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //List<string> pars = new List<string>();
            //bool isSaved = false;
            //switch (tableComboBox.SelectedItem.ToString())
            //{
            //    case "Документ":
            //        foreach (DataRow row in currentTable.Rows)
            //        {
            //            for (int i = 0; i < currentTable.Columns.Count; i++)
            //            {
            //                pars.Add(row[i].ToString());
            //            }
            //            dataAccess.InsertDoc(pars[0], pars[1], pars[2], pars[3], pars[4], pars[5], pars[6]);
            //        }
            //        break;
            //    case "Регистратор":
                    
            //        break;
            //    case "Организация":
            //        dataAccess.DeleteAll("Организация");
            //        foreach (DataRow row in currentTable.Rows)
            //        {
            //            for (int i = 0; i < currentTable.Columns.Count; i++)
            //            {
            //                pars.Add(row[i].ToString());
            //            }
            //            isSaved = dataAccess.InsertOrg(pars[0], pars[1], pars[2], pars[3], pars[4], pars[5]);
            //            pars.Clear();
            //        }
            //        break;
            //    default:
            //        MessageBox.Show("Выбрана несуществующая таблица", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //}
            //if (isSaved)
            //    MessageBox.Show("Данные успешно обновлены", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            InitializeTable();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            currentTable = dataAccess.Select(currentTable.TableName, filterComboBox.Text, filterTextBox.Text);
            InitializeTable(true);
        }
    }
}
