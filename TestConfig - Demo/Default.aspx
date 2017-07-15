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
    <h2>
        Automation Tests Configuration
    </h2>
    <br />
    <div style="text-align: center; font-weight: 600;">
        <asp:Label ID="lblPath" runat="server" Text=""></asp:Label></div>
    <input type="hidden" id="txtTempHdn" runat="server" value="0" />
    <div>
        <fieldset>
            <legend>Select Browser </legend>
            <table>
                <tr>
                    <td>
                        <input id="chkFirefox" runat="server" type="radio" value="1" name="browser" checked />Firefox
                    </td>
                    <td>
                        <input id="chkChrome" runat="server" type="radio" value="2" name="browser" />Chrome
                    </td>
                    <td>
                        <input id="ChkIntExp" runat="server" type="radio" value="3" name="browser" />Internet
                        Explorer
                    </td>
                    <%--  <td>
                       <input id="ChkSafari" runat="server" type="radio" value="4" name="browser" />Safari 
                    </td>--%>
                </tr>
            </table>
        </fieldset>
    </div>
    <%--<div id="dvLCPanel" class="dvHide" >--%>
    <fieldset>
        <legend>
            <input id="ChkRegister" type="checkbox" runat="server" onclick="javascript:CheckAll('tblRegister',this);"
                value="SelectAll" />Registration Module</legend>
    
        <div id="accordion">
        <h3>Dashboard Module</h3>
            <div>
            <table id="tblRegister">
            <tr>
                <td>
                    <input id="ChkRegistrationVerification" runat="server" type="checkbox" value="RegistrationVerification" />
                </td>
                <td>
                    TC_001: To verify user is able to click on 'Registration' link on Home page.<br/>TC_002: To veriy user is able to register with valid details.
                </td>
            </tr>
                <tr>
                <td>
                    <input id="Checkbox1" runat="server" type="checkbox" value="RegistrationVerification" />
                </td>
                <td>
                    TC_001: To verify user is able to click on 'Registration' link on Home page.<br/>TC_002: To veriy user is able to register with valid details.
                </td>
            </tr>
           </table>
                </div>
    </fieldset>
  

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
                        <a href="http://localhost:8080/job/LodieAutomation/" class="btn">Go to Jenkins to run
                            suite(s) </a>
                    </td>
                </tr>
            </table>
        </center>
    </div>
    <br />
    <br />
        </div>

</asp:Content>
