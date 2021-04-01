using QTElectric.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DAO
{
    class TypeDAO
    {
        private static TypeDAO instance;
        public static TypeDAO Instance
        {
            get { if (instance == null) instance = new TypeDAO(); return instance; }
            private set { instance = value; }
        }
        private TypeDAO() { }
        public int Insert_Types(Types c)
        {
            string query = "Insert_Types @type_name , @cat_id , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { c.type_name, c.cat_id, c.status, c.date_create });
            return result;
        }

        public DataTable Types()
        {
            string query = "Get_Types";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public int Update_Types(Types c)
        {
            string query = "Update_Types @id , @type_name , @cat_id , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { c.type_id, c.type_name, c.cat_id, c.status, c.date_create });
            return result;
        }
        public int Delete_Types(int id)
        {
            string query = "Delete_Types @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result;
        }
    }
}


//See the end of this message for details on invoking 
//just-in-time (JIT) debugging instead of this dialog box.

//************** Exception Text **************
//System.Data.SqlClient.SqlException (0x80131904): Incorrect syntax near ','.
//   at System.Data.SqlClient.SqlConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
//   at System.Data.SqlClient.SqlInternalConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
//   at System.Data.SqlClient.TdsParser.ThrowExceptionAndWarning(TdsParserStateObject stateObj, Boolean callerHasConnectionLock, Boolean asyncClose)
//   at System.Data.SqlClient.TdsParser.TryRun(RunBehavior runBehavior, SqlCommand cmdHandler, SqlDataReader dataStream, BulkCopySimpleResultSet bulkCopyHandler, TdsParserStateObject stateObj, Boolean& dataReady)
//   at System.Data.SqlClient.SqlCommand.FinishExecuteReader(SqlDataReader ds, RunBehavior runBehavior, String resetOptionsString, Boolean isInternal, Boolean forDescribeParameterEncryption, Boolean shouldCacheForAlwaysEncrypted)
//   at System.Data.SqlClient.SqlCommand.RunExecuteReaderTds(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, Boolean async, Int32 timeout, Task& task, Boolean asyncWrite, Boolean inRetry, SqlDataReader ds, Boolean describeParameterEncryptionRequest)
//   at System.Data.SqlClient.SqlCommand.RunExecuteReader(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, String method, TaskCompletionSource`1 completion, Int32 timeout, Task& task, Boolean& usedCache, Boolean asyncWrite, Boolean inRetry)
//   at System.Data.SqlClient.SqlCommand.InternalExecuteNonQuery(TaskCompletionSource`1 completion, String methodName, Boolean sendToPipe, Int32 timeout, Boolean& usedCache, Boolean asyncWrite, Boolean inRetry)
//   at System.Data.SqlClient.SqlCommand.ExecuteNonQuery()
//   at QTElectric.DAO.DataProvider.ExecuteNonQuery(String query, Object[] parameter) in E:\SemIII\SourceCode\Windows Forms C#\Project_QTElectric\QTElectric\DAO\DataProvider.cs:line 77
//   at QTElectric.DAO.TypeDAO.Insert_Types(Type c) in E:\SemIII\SourceCode\Windows Forms C#\Project_QTElectric\QTElectric\DAO\TypeDAO.cs:line 23
//   at QTElectric.View.frmType.AddNew() in E:\SemIII\SourceCode\Windows Forms C#\Project_QTElectric\QTElectric\View\frmType.cs:line 48
//   at QTElectric.View.frmType.btnSave_Click(Object sender, EventArgs e) in E:\SemIII\SourceCode\Windows Forms C#\Project_QTElectric\QTElectric\View\frmType.cs:line 112
//   at System.Windows.Forms.Control.OnClick(EventArgs e)
//   at System.Windows.Forms.Button.OnClick(EventArgs e)
//   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
//   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
//   at System.Windows.Forms.Control.WndProc(Message& m)
//   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
//   at System.Windows.Forms.Button.WndProc(Message& m)
//   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
//   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
//   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)
//ClientConnectionId: fb639e83 - f853 - 4793 - bf1a - f4b217f506da
//Error Number:102,State: 1,Class: 15


