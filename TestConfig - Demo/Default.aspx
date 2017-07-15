<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script type="text/javascript" language="javascript">
        function CheckAll(objPnl, objEle) {
            var tab = document.getElementById(objPnl); // table with id tbl1
            var elems = tab.getElementsByTagName("input");
            var len = elems.length;

            for (var i = 0; i < len; i++) {
                if (elems[i].type == "checkbox") {
                    elems[i].checked = objEle.checked;
                }
            }
        }
        function showLCPanel(selRdo) {
            document.getElementById('dvLCPanel').className = "dvShow";
            document.getElementById('<%= txtTempHdn.ClientID %>').value = selRdo;
        }
        function hideLCPanel(selRdo) {
            document.getElementById('dvLCPanel').className = "dvHide";
            document.getElementById('<%= txtTempHdn.ClientID %>').value = selRdo;
        }
        function ChkCustomer_Insert_onclick() {

        }

    </script>
    <head>
        <meta charset="utf-8" />
        <title>jQuery UI Accordion - Default functionality</title>
        <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
        <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
        <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
        <script>
            $(function () {
                $("#accordion").accordion();
            });
        </script>
    </head>
    <style type="text/css">
        .dvShow
        {
            display: block;
            visibility: visible;
        }

        .dvHide
        {
            display: none;
            visibility: hidden;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h1 align="center"><b>Automation Test Configuration</b>
    </h1>
    <br />
    <div style="text-align: center; font-weight: 600;">
        <asp:Label ID="lblPath" runat="server" Text=""></asp:Label>
    </div>
    <input type="hidden" id="txtTempHdn" runat="server" value="0" />
    <div>
        <fieldset>
            <legend>Select Browser </legend>
            
            <table>
                <tr>
                    <td>
                 
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack=true 
                     onselectedindexchanged ="DDL1_SelectedIndexChanged">
                    <asp:ListItem Value="1">Chrome</asp:ListItem>
                    <asp:ListItem Value="2">Firefox</asp:ListItem>
                    <asp:ListItem Value="3">IE</asp:ListItem>
                    </asp:DropDownList>

                    </td>
                </tr>
            </table>
        </fieldset>
    </div>
    <%--<div id="dvLCPanel" class="dvHide" >--%>

    <%--<legend>
            <input id="ChkRegister" type="checkbox" runat="server" onclick="javascript: CheckAll('tblRegister', this);"
                value="SelectAll" />Public Training Module</legend>--%>
    <div id="accordion">
      
        <h3>Registration Module</h3>
        <div>

             <table id="tblRegister">
                <tr>
                    <td>
                        <input id="Checkbox2" type="checkbox" runat="server" onclick="javascript: CheckAll('tblRegister', this);"
                            value="SelectAll" />
                    </td>
                    <td><b>Select All</b><br />
                    </td>
                </tr>
                <tr>
                <td>
                    <input id="ChkRegistrationVerification" runat="server" type="checkbox" value="TC1_RegistrationWithValidData" />
                </td>
                <td>
                    TC_001: To veriy user is able to register with valid details.
                </td>
            </tr>
                   <tr>
                <td>
                    <input id="ChkInvalidRegistrationVerification" runat="server" type="checkbox" value="TC2_RegistrationWithInvallidData" />
                </td>
                <td>
                    TC_002: To veriy user is not able to register with invalid details.
                </td>
            </tr>
          </table>
        </div>
        
        <h3>Dashboard Module</h3>
        <div>
           <table id="tblDashboard">
                <tr>
                    <td>
                        <input id="Checkbox1" type="checkbox" runat="server" onclick="javascript: CheckAll('tblDashboard', this);"
                            value="SelectAll" />
                    </td>
                    <td><b>Select All</b><br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="Bulb" runat="server" type="checkbox" value="bulbTest case 1" />
                    </td>
                    <td>Bulb TestCase 1<br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="Dimmer" runat="server" type="checkbox" value="dimmerTest case 2" />
                    </td>
                    <td>Dimmer TestCase 2
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="Blinds" runat="server" type="checkbox" value="blindsTest case 3" />
                    </td>
                    <td>Blinds TestCase 3
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="Socket" runat="server" type="checkbox" value="socketTest case 4" />
                    </td>
                    <td>Socket TestCase 4
                    </td>
                </tr>
            </table>
        </div>
         
        <h3>Configuration Module</h3>
        <div>
            <table id="tblConfiguration">
                <tr>
                    <td>
                        <input id="ChkRegister" type="checkbox" runat="server" onclick="javascript: CheckAll('tblConfiguration', this);"
                            value="SelectAll" />
                    </td>
                    <td><b>Select All</b><br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="Config" runat="server" type="checkbox" value="Test case 1" />
                    </td>
                    <td>Configuratoin TestCase 1<br />
                    </td>
                </tr>
         
            </table>
        </div>

    </div>
    <br />
    <%--</div>--%>
    <div style="text-align: center; white-space: nowrap;">
        <center>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text=" Save " OnClick="btnSave_Click"  />
                    </td>
                    <td>
                        |
                    </td>
                    <td>
                        <a href="http://localhost:85/project.html?projectId=ToolsQA&tab=projectOverview" class="btn">Go to TeamCity to run
                            suite(s) </a>
                    </td>
                      <td>
                        
                    </td>
                      
                </tr>
            </table>
        </center>
    </div>
    <br />
    <br />
</asp:Content>
