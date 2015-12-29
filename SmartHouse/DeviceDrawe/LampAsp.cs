using SmartHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse.DeviceDrawe
{
    public class LampAsp
    {
        public static Control Drawe(Lamp lamp)
        {
            LinkButton linkButtonLamp = new LinkButton() { CssClass = "device-lamp" };
            Panel panelContent = new Panel() { CssClass = "content" };
            Panel panelProperty = new Panel() { CssClass = "property" };
            Panel panelLampBg = new Panel() { CssClass = "lamp-bg" };
            Label labelText = new Label() { CssClass = "text" };
            Label labelTextValue = new Label() { CssClass = "text-value" };

            panelLampBg.Attributes.CssStyle.Add("opacity", lamp.BrightPercent(lamp.Bright));
            labelText.Text = "BRIGHT:";
            labelTextValue.Text = lamp.Bright.ToString();

            panelProperty.Controls.Add(panelLampBg);
            panelProperty.Controls.Add(labelText);
            panelProperty.Controls.Add(labelTextValue);
            panelContent.Controls.Add(panelProperty);
            linkButtonLamp.Controls.Add(panelContent);
            linkButtonLamp.Controls.Add(DeviceBgAsp.Drawe());

            linkButtonLamp.Attributes.Add("data-device", (lamp as Device).TypeDevice());
            linkButtonLamp.Attributes.Add("data-id", lamp.Id.ToString());

            return linkButtonLamp;
        }
    }
}