using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPlab8.DataController
{
    using System;
    using System.Data;
    using System.Data.Odbc;
    using System.Data.OleDb;
    using System.Windows.Forms;
    using VPlab8.Sql;

    class DataAccess : ConnectionAccess
    {
        public DataTable GetAllRecords(string tableName)
        {
            DataTable dataTable = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

            dataAdapter.SelectCommand = new OleDbCommand();
            dataAdapter.SelectCommand.Connection = new OleDbConnection(ConnectionString);
            dataAdapter.SelectCommand.CommandType = CommandType.Text;
            string selectCommand = Scripts.sqlGetAllRecords.Replace("@Table", tableName);
            dataAdapter.SelectCommand.CommandText = selectCommand;
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable Select(string tableName, string fieldName, string field)
        {
            DataTable dataTable = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

            dataAdapter.SelectCommand = new OleDbCommand();
            dataAdapter.SelectCommand.Connection = new OleDbConnection(ConnectionString);
            dataAdapter.SelectCommand.CommandType = CommandType.Text;
            string selectCommand = Scripts.sqlSelect.Replace("@Table", tableName).Replace("@FieldName", fieldName);
            dataAdapter.SelectCommand.CommandText = selectCommand;
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Field", field);
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public void SaveTable(DataTable table)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

            //dataAdapter.
            //dataAdapter.Update(table);
        }

        public bool InsertReg(string codeReg, string family, string name, string otch, string post, string date)
        {
            var insertCommand = new OleDbCommand();

            insertCommand.Connection = new OleDbConnection(ConnectionString);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.CommandText = Scripts.sqlInsertReg;
            insertCommand.Parameters.AddWithValue("@CodeReg", codeReg);
            insertCommand.Parameters.AddWithValue("@Family", family);
            insertCommand.Parameters.AddWithValue("@Name", name);
            insertCommand.Parameters.AddWithValue("@Otch", otch);
            insertCommand.Parameters.AddWithValue("@Post", post);
            insertCommand.Parameters.AddWithValue("@Date", date);
            insertCommand.Connection.Open();
            int rowsAffected = insertCommand.ExecuteNonQuery();
            insertCommand.Connection.Close();

            return rowsAffected > 0;
        }

        public bool InsertOrg(string codeOrg, string name, string fullName, string address, string phone, string fio)
        {
            var insertCommand = new OleDbCommand();

            insertCommand.Connection = new OleDbConnection(ConnectionString);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.CommandText = Scripts.sqlInsertOrg;
            insertCommand.Parameters.AddWithValue("@CodeOrg", codeOrg);
            insertCommand.Parameters.AddWithValue("@Name", name);
            insertCommand.Parameters.AddWithValue("@FullName", fullName);
            insertCommand.Parameters.AddWithValue("@Address", address);
            insertCommand.Parameters.AddWithValue("@Phone", phone);
            insertCommand.Parameters.AddWithValue("@FIO", fio);
            insertCommand.Connection.Open();
            int rowsAffected = insertCommand.ExecuteNonQuery();
            insertCommand.Connection.Close();

            return rowsAffected > 0;
        }

        public bool InsertDoc(string codeDoc, string num, string date, string content, string type, string org, string reg)
        {
            var insertCommand = new OleDbCommand();

            insertCommand.Connection = new OleDbConnection(ConnectionString);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.CommandText = Scripts.sqlInsertDoc;
            insertCommand.Parameters.AddWithValue("@DocCode", codeDoc);
            insertCommand.Parameters.AddWithValue("@Num", num);
            insertCommand.Parameters.AddWithValue("@Date", date);
            insertCommand.Parameters.AddWithValue("@Content", content);
            insertCommand.Parameters.AddWithValue("@Type", type);
            insertCommand.Parameters.AddWithValue("@Org", org);
            insertCommand.Parameters.AddWithValue("@Reg", reg);
            insertCommand.Connection.Open();
            int rowsAffected = insertCommand.ExecuteNonQuery();
            insertCommand.Connection.Close();

            return rowsAffected > 0;
        }


        public bool UpdateReg(string codeReg, string family, string name, string otch, string post, string date)
        {
            var updateCommand = new OleDbCommand();

            updateCommand.Connection = new OleDbConnection(ConnectionString);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.CommandText = Scripts.sqlUpdateReg;
            updateCommand.Parameters.AddWithValue("@Family", family);
            updateCommand.Parameters.AddWithValue("@Name", name);
            updateCommand.Parameters.AddWithValue("@Otch", otch);
            updateCommand.Parameters.AddWithValue("@Post", post);
            updateCommand.Parameters.AddWithValue("@Date", date);
            updateCommand.Parameters.AddWithValue("@CodeReg", codeReg);
            updateCommand.Connection.Open();
            int rowsAffected = updateCommand.ExecuteNonQuery();
            updateCommand.Connection.Close();

            return rowsAffected > 0;
        }

        public bool UpdateOrg(string codeOrg, string name, string fullName, string address, string phone, string fio)
        {
            var updateCommand = new OleDbCommand();

            updateCommand.Connection = new OleDbConnection(ConnectionString);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.CommandText = Scripts.sqlUpdateOrg;
            updateCommand.Parameters.AddWithValue("@Name", name);
            updateCommand.Parameters.AddWithValue("@FullName", fullName);
            updateCommand.Parameters.AddWithValue("@Address", address);
            updateCommand.Parameters.AddWithValue("@Phone", phone);
            updateCommand.Parameters.AddWithValue("@FIO", fio);
            updateCommand.Parameters.AddWithValue("@CodeOrg", codeOrg);
            updateCommand.Connection.Open();
            int rowsAffected = updateCommand.ExecuteNonQuery();
            updateCommand.Connection.Close();

            return rowsAffected > 0;
        }

        public bool UpdateDoc(string codeDoc, string num, string date, string content, string type, string org, string reg)
        {
            var updateCommand = new OleDbCommand();

            updateCommand.Connection = new OleDbConnection(ConnectionString);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.CommandText = Scripts.sqlUpdateDoc;
            updateCommand.Parameters.AddWithValue("@Num", num);
            updateCommand.Parameters.AddWithValue("@Date", date);
            updateCommand.Parameters.AddWithValue("@Content", content);
            updateCommand.Parameters.AddWithValue("@Type", type);
            updateCommand.Parameters.AddWithValue("@Org", org);
            updateCommand.Parameters.AddWithValue("@Reg", reg);
            updateCommand.Parameters.AddWithValue("@DocCode", codeDoc);
            updateCommand.Connection.Open();
            int rowsAffected = updateCommand.ExecuteNonQuery();
            updateCommand.Connection.Close();

            return rowsAffected > 0;
        }

        public bool Delete(string table, string fieldName, string field)
        {
            var deleteCommand = new OleDbCommand();

            deleteCommand.Connection = new OleDbConnection(ConnectionString);
            deleteCommand.CommandType = CommandType.Text;
            string sqlText = Scripts.sqlDelete.Replace("@Table", table).Replace("@FieldName", fieldName);
            deleteCommand.CommandText = sqlText;
            deleteCommand.Parameters.AddWithValue("@Field", field);
            deleteCommand.Connection.Open();
            int rowsAffected = deleteCommand.ExecuteNonQuery();
            deleteCommand.Connection.Close();

            return rowsAffected > 0;
        }


        public void DeleteAll(string table)
        {
            var deleteCommand = new OleDbCommand();

            deleteCommand.Connection = new OleDbConnection(ConnectionString);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.CommandText = Scripts.sqlDeleteAll.Replace("@Table", table);
            deleteCommand.Connection.Open();
            deleteCommand.ExecuteNonQuery();
            deleteCommand.Connection.Close();
        }

    }
}
