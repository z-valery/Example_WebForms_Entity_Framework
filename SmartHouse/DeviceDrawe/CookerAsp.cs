using SmartHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse.DeviceDrawe
{
    public class CookerAsp
    {
        public static Control Drawe(Cooker cooker)
        {
            LinkButton linkButtonCooker = new LinkButton() { CssClass = "device-cooker" };
            Panel panelContent = new Panel() { CssClass = "content" };
            Panel panelProperty = new Panel() { CssClass = "property" };
            Panel panelStove1 = new Panel() { CssClass = "stove1" };
            Panel panelStove2 = new Panel() { CssClass = "stove2" };
            Panel panelStove3 = new Panel() { CssClass = "stove3" };
            Panel panelStove4 = new Panel() { CssClass = "stove4" };
            Panel panelTemp1 = new Panel() { CssClass = "temp1" };
            Panel panelTemp2 = new Panel() { CssClass = "temp2" };
            Panel panelTemp3 = new Panel() { CssClass = "temp3" };
            Panel panelTemp4 = new Panel() { CssClass = "temp4" };
            Label labelText1 = new Label() { CssClass = "text" };
            Label labelTextValue1 = new Label() { CssClass = "text-value" };
            Label labelText2 = new Label() { CssClass = "text" };
            Label labelTextValue2 = new Label() { CssClass = "text-value" };
            Label labelText3 = new Label() { CssClass = "text" };
            Label labelTextValue3 = new Label() { CssClass = "text-value" };
            Label labelText4 = new Label() { CssClass = "text" };
            Label labelTextValue4 = new Label() { CssClass = "text-value" };

            panelStove1.Attributes.CssStyle.Add("opacity", cooker.TempPercent(cooker.Temp1, cooker.MaxTemp1));
            panelStove2.Attributes.CssStyle.Add("opacity", cooker.TempPercent(cooker.Temp2, cooker.MaxTemp2));
            panelStove3.Attributes.CssStyle.Add("opacity", cooker.TempPercent(cooker.Temp3, cooker.MaxTemp3));
            panelStove4.Attributes.CssStyle.Add("opacity", cooker.TempPercent(cooker.Temp4, cooker.MaxTemp4));
            labelText1.Attributes.CssStyle.Add("display", "block");
            labelTextValue1.Attributes.CssStyle.Add("display", "block");
            labelText2.Attributes.CssStyle.Add("display", "block");
            labelTextValue2.Attributes.CssStyle.Add("display", "block");
            labelText3.Attributes.CssStyle.Add("display", "block");
            labelTextValue3.Attributes.CssStyle.Add("display", "block");
            labelText4.Attributes.CssStyle.Add("display", "block");
            labelTextValue4.Attributes.CssStyle.Add("display", "block");

            labelText1.Text = "TEMP1:";
            labelTextValue1.Text = cooker.Temp1.ToString();
            labelText2.Text = "TEMP2:";
            labelTextValue2.Text = cooker.Temp2.ToString();
            labelText3.Text = "TEMP3:";
            labelTextValue3.Text = cooker.Temp3.ToString();
            labelText4.Text = "TEMP4:";
            labelTextValue4.Text = cooker.Temp4.ToString();

            panelTemp1.Controls.Add(labelText1);
            panelTemp1.Controls.Add(labelTextValue1);
            panelTemp2.Controls.Add(labelText2);
            panelTemp2.Controls.Add(labelTextValue2);
            panelTemp3.Controls.Add(labelText3);
            panelTemp3.Controls.Add(labelTextValue3);
            panelTemp4.Controls.Add(labelText4);
            panelTemp4.Controls.Add(labelTextValue4);

            panelProperty.Controls.Add(panelStove1);
            panelProperty.Controls.Add(panelStove2);
            panelProperty.Controls.Add(panelStove3);
            panelProperty.Controls.Add(panelStove4);
            panelProperty.Controls.Add(panelTemp1);
            panelProperty.Controls.Add(panelTemp2);
            panelProperty.Controls.Add(panelTemp3);
            panelProperty.Controls.Add(panelTemp4);

            panelContent.Controls.Add(panelProperty);
            linkButtonCooker.Controls.Add(panelContent);
            linkButtonCooker.Controls.Add(DeviceBgAsp.Drawe());

            linkButtonCooker.Attributes.Add("data-device", (cooker as Device).TypeDevice());
            linkButtonCooker.Attributes.Add("data-id", cooker.Id.ToString());

            return linkButtonCooker;
        }
    }
}