using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODataSet {
  class Program {
    static void Main(string[] args) {
      Program p = new Program();
      QueryBooks();
      LINQInDataSet();
      EditInDataSet();
      AddRowInDataSet();
    }
    private static void LINQInDataSet() {
      using (MySqlConnection conn = GetConnection()) {
        String sql = "SELECT * FROM Books";
        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn)) {
          using (DataSet ds = new DataSet()) {
            dataAdapter.Fill(ds);
            DataRow[] rows = ds.Tables[0].Select("AuthorId=6");
            for (int i = 0; i < rows.Length; i++) {
              Console.WriteLine($"{rows[i][0]},{rows[i][1]},{rows[i][2]}");
            }
          }
        }
      }
    }

    private static void EditInDataSet() {
      using (MySqlConnection conn = GetConnection()) {
        String sql = "SELECT * FROM Books";
        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn)) {
          MySqlCommandBuilder cmdBuilder = 
            new MySqlCommandBuilder(dataAdapter);
          using (DataSet ds = new DataSet()) {
            dataAdapter.Fill(ds);
            DataRow[] rows = ds.Tables[0].Select("AuthorId=6");
            for (int i = 0; i < rows.Length; i++) {
              rows[i].BeginEdit();
              rows[i][1] = 1;
              rows[i].EndEdit();
            }
            dataAdapter.Update(ds);
          }
        }
      }
    }

    private static void AddRowInDataSet() {
      using (MySqlConnection conn = GetConnection()) {
        String sql = "SELECT * FROM Books";
        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn)) {
          MySqlCommandBuilder cmdBuilder = new MySqlCommandBuilder(dataAdapter);
          using (DataSet ds = new DataSet()) {
            dataAdapter.Fill(ds);
            DataRow newRow = ds.Tables[0].NewRow();
            newRow[1] = 6;
            newRow[2] = "New Book";
            ds.Tables[0].Rows.Add(newRow);
            dataAdapter.Update(ds);
          }
        }
      }
    }


    private static MySqlConnection GetConnection() {
      MySqlConnection connection = new MySqlConnection(
          "datasource=localhost;username=root;" +
          "password=root;database=book;charset=utf8");
      connection.Open();
      return connection;
    }

    private static void QueryBooks() {
      using (MySqlConnection conn = GetConnection()) {
        String sql = "SELECT * FROM Books";
        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn)) {
          using (DataSet ds = new DataSet()) {
            dataAdapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows) {
              foreach (object field in row.ItemArray) {
                Console.Write(field + "\t");
              }
              Console.WriteLine();
            }
          }
        }
      }
      //Console.WriteLine(ds.Tables[0].Rows[0][1]);
    }
  }
}
