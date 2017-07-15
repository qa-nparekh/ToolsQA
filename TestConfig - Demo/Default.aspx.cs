using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Configuration;
using System.Configuration;

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
        config.AppSettings.Settings["UseBrowser"].Value = "1";
        config.Save();
        ConfigurationManager.RefreshSection("appSettings");
    }


    protected void btnSave_Click(object sender, EventArgs e)
    {
        lblPath.Text = "";
        try
        {
            di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            strParentPath = di.ToString(); //di.Parent.FullName + "\\ExportoryAutomation\\bin\\debug\\";
            strFilePath = strParentPath + "testlist.txt";

            string strNameSpce = "TestCases.TestSuites.";
            if (!File.Exists(strFilePath)) File.Create(strFilePath);
            if (File.Exists(strFilePath))
            {
                File.Delete(strFilePath);
                using (StreamWriter sw = new StreamWriter(strFilePath))
                {
                    sw.AutoFlush = true;



                    ///////////////////////////////Login//////////////////////////////////////

                    if (ChkRegistrationVerification.Checked) sw.WriteLine(strNameSpce + ChkRegistrationVerification.Value);
                  
                    //sw.WriteLine(strNameSpce + "zzzGenerateSummaryReport");
                    //lblPath.Text = "Data saved successfully.";
                }
            }


           
            lblPath.Text = "Data saved successfully.";
        }
        catch (Exception ex)
        {
            lblPath.Text += ex.Message;
        }
    }
}
