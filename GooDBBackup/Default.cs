using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GooDBBackup
{
    public partial class Default : Form
    {
        #region GlobalVariable
        string cs = System.Configuration.ConfigurationManager.AppSettings["cs"];
        string exportPath = System.Configuration.ConfigurationManager.AppSettings["exportPath"];
        bool autoStart = (System.Configuration.ConfigurationManager.AppSettings["autoStart"].Trim().ToLower() == "true" ? true : false);
        bool autoClose = (System.Configuration.ConfigurationManager.AppSettings["autoClose"].Trim().ToLower() == "true" ? true : false);
        bool replaceFile = (System.Configuration.ConfigurationManager.AppSettings["replaceFile"].Trim().ToLower() == "true" ? true : false);
        #endregion
        public Default()
        {
            InitializeComponent();
        }
        private void Default_Load(object sender, EventArgs e)
        {
            setDefault();
            if (autoStart)
            {
                MySQLBackup();
            }
            if (autoClose)
            {
                Application.Exit();
            }
        }
        private void setDefault()
        {
            #region Procedure
            this.Text = clsGlobalNative.ApplicationName + " v." + clsGlobalNative.ApplicationVersion();
            lblConnection.Text = cs;
            lblExportPath.Text = exportPath;
            #endregion
        }
        private void btBackup_Click(object sender, EventArgs e)
        {
            MySQLBackup();
        }
        private void MySQLBackup()
        {
            #region Variable
            var directoryInfo = new DirectoryInfo(exportPath);
            var dt = new DataTable();
            #endregion
            #region Procedure
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            try
            {
                #region DatabaseList
                MySqlConnection myConn = new MySqlConnection(cs);
                MySqlDataAdapter myDa = new MySqlDataAdapter("SHOW DATABASES;", myConn);

                myDa.Fill(dt);
                myConn.Dispose();
                myDa.Dispose();
                #endregion
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string constring = cs + "database=" + dt.Rows[i]["Database"].ToString() + ";";
                        var fullName = "";
                        if (!replaceFile)
                        {
                            var directoryInfoDay = new DirectoryInfo(exportPath + @"\" + DateTime.Now.ToString("yyyyMMdd"));
                            if (!directoryInfoDay.Exists)
                            {
                                directoryInfoDay.Create();
                            }
                            fullName = string.Format("{0}{1}.sql", 
                                        directoryInfoDay.FullName+@"\",
                                        dt.Rows[i]["Database"].ToString());
                        }
                        else
                        {
                            fullName = string.Format("{0}{1}.sql",
                                        exportPath,
                                        dt.Rows[i]["Database"].ToString());
                        }
                        
                        var fileInfo = new FileInfo(fullName);
                        if (!fileInfo.Exists) fileInfo.Delete();
                        using (MySqlConnection conn = new MySqlConnection(constring))
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    cmd.Connection = conn;
                                    conn.Open();
                                    mb.ExportToFile(fileInfo.FullName);
                                    conn.Close();
                                }
                            }
                        }
                    }
                }
                lblResult.Text = "Success";
                lblResult.ForeColor = ColorTranslator.FromHtml("#22B14C");
            }
            catch(Exception ex)
            {
                lblResult.Text += "Fail : " + ex.Message;
                lblResult.ForeColor = ColorTranslator.FromHtml("#D5343A");
            }
            #endregion
        }
    }
}
