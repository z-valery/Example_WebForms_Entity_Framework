<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SmartHouse.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Content/Sass/css/style.css" rel="stylesheet" type="text/css" />
    <title>SmartHouse</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">

        <%--Header--%>
        <div id="header">
            <div class="logo">
                <span class="logo-head">z.valera.86@yandex.ru</span>
                <div class="mvc_webapi">
                    <asp:LinkButton ID="LinkButtonWebForms" runat="server" class="button-mvc_webapi">
                        <div class="content">
                            <div class="bg"></div>
                            <div class="fg"></div>
                        </div>
                        <span class="text">WebForms</span>
                    </asp:LinkButton>
                </div>
            </div>
        </div>

        <%--Menu--%>
        <div id="menu">
            <div class="buttons">
                <asp:LinkButton ID="LinkButtonAddTv" runat="server" CssClass="button-tv" OnClick="LinkButtonAddTv_Click">
                    <div class="content">
                        <div class="bg"></div>
                        <div class="fg"></div>
                    </div>
                    <span class="text">TV</span>
                </asp:LinkButton>
                <asp:LinkButton ID="LinkButtonAddFridge" runat="server" CssClass="button-fridge" OnClick="LinkButtonAddFridge_Click">
                    <div class="content">
                        <div class="bg"></div>
                        <div class="fg"></div>
                    </div>
                    <span class="text">FRIDGE</span>
                </asp:LinkButton>
                <asp:LinkButton ID="LinkButtonAddLamp" runat="server" CssClass="button-lamp" OnClick="LinkButtonAddLamp_Click">
                    <div class="content">
                        <div class="bg"></div>
                        <div class="fg"></div>
                    </div>
                    <span class="text">LAMP</span>
                </asp:LinkButton>
                <asp:LinkButton ID="LinkButtonAddCooker" runat="server" CssClass="button-cooker" OnClick="LinkButtonAddCooker_Click">
                    <div class="content">
                        <div class="bg"></div>
                        <div class="fg"></div>
                    </div>
                    <span class="text">COOKER</span>
                </asp:LinkButton>
                <asp:LinkButton ID="LinkButtonAddMicrowave" runat="server" CssClass="button-microwave" OnClick="LinkButtonAddMicrowave_Click">
                    <div class="content">
                        <div class="bg"></div>
                        <div class="fg"></div>
                    </div>
                    <span class="text">MICROWAVE</span>
                </asp:LinkButton>
            </div>
        </div>
 

        <%--Console--%>
        <asp:Panel ID="console" runat="server">
            <asp:Panel ID="PanelConsoleDevice" runat="server" CssClass="console-device"></asp:Panel>
            <div class="console-settings">
                <a href="#" class="settings">
                    <div class="content">
                        <div class="bg"></div>
                        <div class="fg"></div>
                    </div>
                    <span class="text">SETTINGS</span>
                </a>
                <asp:LinkButton ID="LinkButtonOn" runat="server" CssClass="on" OnClick="LinkButtonOn_Click">ON</asp:LinkButton>
                <asp:LinkButton ID="LinkButtonOff" runat="server" CssClass="off" OnClick="LinkButtonOff_Click">OFF</asp:LinkButton>
                <asp:LinkButton ID="LinkButtonDelete" runat="server" CssClass="delete" OnClick="LinkButtonDelete_Click">
                    <div class="content">
                        <div class="bg"></div>
                        <div class="fg"></div>
                    </div>
                    <span class="text">DELETE</span>
                </asp:LinkButton>
                <asp:LinkButton ID="LinkButtonOk" runat="server" CssClass="ok" OnClick="LinkButtonOk_Click">
                    <div class="content">
                        <div class="bg"></div>
                        <div class="fg"></div>
                    </div>
                    <span class="text">OK</span>
                </asp:LinkButton>

                <%--Control--%>
                <div class="control">
                    <div class="content">
                        <div class="bg"></div>
                        <div class="fg"></div>
                    </div>
                    <asp:LinkButton ID="LinkButtonSettingPrev" runat="server" CssClass="property-next" OnClick="LinkButtonSettingPrev_Click">
                        <div class="bg"></div>
                    </asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonSettingNext" runat="server" CssClass="property-prev" OnClick="LinkButtonSettingNext_Click">
                        <div class="bg"></div>
                    </asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonValueIncr" runat="server" CssClass="property-increment" OnClick="LinkButtonValueIncr_Click">
                        <div class="bg"></div>
                    </asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonValueDecr" runat="server" CssClass="property-decriment" OnClick="LinkButtonValueDecr_Click">
                        <div class="bg"></div>
                    </asp:LinkButton>
                </div>
                <div class="propertyes">
                    <div class="header">PROPERTY</div>
                    <div class="bg"></div>
                    <div class="content">
                        <asp:ListBox ID="ListBoxDeviceProp" runat="server" CssClass="device-prop" Height="111px" Width="119px"></asp:ListBox>
                    </div>
                </div>
                <div class="value">
                    <div class="header">VALUE</div>
                    <div class="bg"></div>
                    <div class="content">
                        <asp:Label ID="LabelValue" runat="server" CssClass="text">
                            <div class="border-top"></div>
                            <div class="border-bottom"></div> 
                        </asp:Label>   
                    </div>
                </div>
            </div>
        </asp:Panel>

        <%--Content--%>
        <div id="content">
            <asp:Panel ID="PanelDevices" runat="server" CssClass="devices"></asp:Panel>
        </div>

        <%--Footer--%>
        </div>
        <div id="footer">
            <div class="pre-footer-column">
                <div class="head">ABOUT ME</div>
                <div class="content">
                    Name: <span class="prop">Valery</span> <br />
                    Surname: <span class="prop">Zarviro</span> <br />
                    City: <span class="prop">Kharkov</span> <br />
                    Student: <span class="prop">False</span> <br />
                    English: <span class="prop">ReadOnly</span> <br />
                    Site: <span class="prop">©Zarviro</span> <br />
                    <div class="top-left"></div>
                    <div class="bottom-right"></div>
                </div>
            </div>
            <div class="pre-footer-column">
                <div class="head">I STUDIED</div>
                <div class="content">
                    ASP: <span class="prop">WebForms</span> <br />
                    ASP: <span class="prop">MVC</span> <br />
                    ASP: <span class="prop">WebAPI</span> <br />
                    WPF: <span class="prop">MVVM</span> <br />
                    Web: <span class="prop">SASS</span> <br />
                    Web: <span class="prop">Photoshop</span> <br />
                    <div class="top-left"></div>
                    <div class="bottom-right"></div>
                </div>
            </div>
            <div class="pre-footer-column">
                <div class="head">CONTACTS</div>
                <div class="content">
                    Skype: <br />
                    <span class="prop">z.valera86</span> <br />
                    Email: <br />
                    <span class="prop">z.valera86@yandex.ru</span> <br />
                    Telephone: <br />
                    <span class="prop">(066) 993-86-35</span> <br />
                    <div class="top-left"></div>
                    <div class="bottom-right"></div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
