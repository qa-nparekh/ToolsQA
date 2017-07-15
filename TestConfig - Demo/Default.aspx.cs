using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Web.Configuration;

public partial class _Default : System.Web.UI.Page
{
    DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
    string strParentPath;
    string strFilePath, strParamFilePath;
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void UpdateBrowserName()
    {
        string AppConfigPath = WebConfigurationManager.AppSettings["AutomationProjectPath"].ToString();
        string configFile = System.IO.Path.Combine(AppConfigPath, "App.config");
        ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
        configFileMap.ExeConfigFilename = configFile;
        System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
        config.AppSettings.Settings["UseBrowser"].Value = DropDownList1.SelectedValue.ToString();
        config.Save();
        ConfigurationManager.RefreshSection("appSettings");
    }


    protected void btnSave_Click(object sender, EventArgs e)
    {
        UpdateBrowserName();
        lblPath.Text = "";
        
        try
        {
            di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            strParentPath = di.ToString(); //di.Parent.FullName + "\\ExportoryAutomation\\bin\\debug\\";
            strFilePath = strParentPath + "testlist.txt";

            string strNameSpce = "TestSuites.";
            if (!File.Exists(strFilePath)) File.Create(strFilePath);
            if (File.Exists(strFilePath))
            {
                File.Delete(strFilePath);
                using (StreamWriter sw = new StreamWriter(strFilePath))
                {
                    sw.AutoFlush = true;

                    ///////////////////////////////Registration Module//////////////////////////////////////

                    if (ChkRegistrationVerification.Checked) sw.WriteLine(strNameSpce + ChkRegistrationVerification.Value);
                    if (ChkInvalidRegistrationVerification.Checked) sw.WriteLine(strNameSpce + ChkInvalidRegistrationVerification.Value);


                    ///////////////////////////////Configuration Module//////////////////////////////////////

                    if (Config.Checked) sw.WriteLine(strNameSpce + Config.Value);

                    ///////////////////////////////Dashboard Module//////////////////////////////////////

                    if (Bulb.Checked) sw.WriteLine(strNameSpce + Bulb.Value);
                    if (Dimmer.Checked) sw.WriteLine(strNameSpce + Dimmer.Value);
                    if (Blinds.Checked) sw.WriteLine(strNameSpce + Blinds.Value);
                    if (Socket.Checked) sw.WriteLine(strNameSpce + Socket.Value);
                }
            }
            lblPath.Text = "Data saved successfully.";
        }
        catch (Exception ex)
        {
            lblPath.Text += ex.Message;
        }

    }
    //protected void btnReport_Click(object sender, EventArgs e)
    //{
    //    DirectoryInfo dinfo = new DirectoryInfo(@"C:\Program Files (x86)\Jenkins\jobs\Demo\workspace\bin\Debug\Report");

    //    DirectoryInfo latestdir = dinfo.GetDirectories().OrderByDescending(f => f.CreationTime).FirstOrDefault();

    //    if (latestdir != null)
    //    {
    //        string strFileName = latestdir.FullName + @"\" + "Report.html";
    //        string[] filePaths = Directory.GetFiles(latestdir.FullName);
    //        System.Diagnostics.Process process = new System.Diagnostics.Process();
    //        process.StartInfo.UseShellExecute = true;
    //        process.StartInfo.FileName = strFileName;
    //        process.Start();
    //        //System.Diagnostics.Process.Start(strFileName);
    //    }
    //}
    protected void DDL1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
}
