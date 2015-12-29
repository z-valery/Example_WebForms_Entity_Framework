using SmartHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse.DeviceDrawe
{
    public class FridgeAsp
    {
        public static Control Drave(Fridge fridge)
        {
            LinkButton linkButtonFridge = new LinkButton() { CssClass = "device-fridge" };
            Panel panelContent = new Panel() { CssClass = "content" };
            Panel panelProperty = new Panel() { CssClass = "property" };
            Panel panelTemp1 = new Panel() { CssClass = "temp1" };
            Panel panelTmeter1 = new Panel() { CssClass = "tmeter" };
            Panel panelScale1 = new Panel() { CssClass = "scale" };
            Panel panelCircle1 = new Panel() { CssClass = "circle" };
            Label labelText1 = new Label() { CssClass = "text" };
            Label labelTextValue1 = new Label() { CssClass = "text-value" };
            Panel panelTemp2 = new Panel() { CssClass = "temp2" };
            Panel panelTmeter2 = new Panel() { CssClass = "tmeter" };
            Panel panelScale2 = new Panel() { CssClass = "scale" };
            Panel panelCircle2 = new Panel() { CssClass = "circle" };
            Label labelText2 = new Label() { CssClass = "text" };
            Label labelTextValue2 = new Label() { CssClass = "text-value" };

            panelScale1.Height = fridge.TempScaleInt(fridge.Temp1, 2);
            labelText1.Text = "TEMP 1:";
            labelText1.Width = 60;
            labelTextValue1.Text = fridge.Temp1.ToString();

            panelScale2.Height = fridge.TempScaleInt(fridge.Temp2, 5);
            labelText2.Text = "TEMP 2:";
            labelText2.Width = 60;
            labelTextValue2.Text = fridge.Temp2.ToString();

            panelTmeter2.Controls.Add(panelScale2);
            panelTmeter2.Controls.Add(panelCircle2);
            panelTemp2.Controls.Add(panelTmeter2);
            panelTemp2.Controls.Add(labelText2);
            panelTemp2.Controls.Add(labelTextValue2);

            panelTmeter1.Controls.Add(panelScale1);
            panelTmeter1.Controls.Add(panelCircle1);
            panelTemp1.Controls.Add(panelTmeter1);
            panelTemp1.Controls.Add(labelText1);
            panelTemp1.Controls.Add(labelTextValue1);

            panelProperty.Controls.Add(panelTemp1);
            panelProperty.Controls.Add(panelTemp2);
            panelContent.Controls.Add(panelProperty);
            linkButtonFridge.Controls.Add(panelContent);
            linkButtonFridge.Controls.Add(DeviceBgAsp.Drawe());

            linkButtonFridge.Attributes.Add("data-device", (fridge as Device).TypeDevice());
            linkButtonFridge.Attributes.Add("data-id", fridge.Id.ToString());

            return linkButtonFridge;
        }
    }
}