using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Student_Management
{
    class CPublic
    {
        public static DataRow LoginInfo;

        public static bool isManager;

        public static void CheckUsers(string UserID, string Pwd)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.Student_ManagementConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users WHERE UserID=@UserID AND Pwd=@Pwd", cn);
            da.SelectCommand.Parameters.Add("@UserID", SqlDbType.NVarChar, 8).Value = UserID;
            da.SelectCommand.Parameters.Add("@Pwd", SqlDbType.NVarChar, 8).Value = Pwd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                LoginInfo = ds.Tables[0].Rows[0];
                isManager = true;
            }
            else
                LoginInfo = null;
        }

        public static void CheckStudent(string StuNo, string Pwd)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.Student_ManagementConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student WHERE StuNo=@StuNo AND Pwd=@Pwd", cn);
            da.SelectCommand.Parameters.Add("@StuNo", SqlDbType.Int, 8).Value = StuNo;
            da.SelectCommand.Parameters.Add("@Pwd", SqlDbType.NVarChar, 8).Value = Pwd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                LoginInfo = ds.Tables[0].Rows[0];
                isManager = false;
            }
            else
                LoginInfo = null;
        }

        public static void notSortDataGridView(System.Windows.Forms.DataGridView dgv)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
