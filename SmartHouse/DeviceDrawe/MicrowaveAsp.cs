using SmartHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse.DeviceDrawe
{
    public class MicrowaveAsp
    {
        public static Control Drawe(Microwave microwave)
        {
            LinkButton linkButtonMicrowave = new LinkButton() { CssClass = "device-microwave" };
            Panel panelContent = new Panel() { CssClass = "content" };
            Panel panelProperty = new Panel() { CssClass = "property" };
            Panel panelGrill = new Panel() { CssClass = "grill" };
            Panel panelWave = new Panel() { CssClass = "wave" };
            Label labelTextPower = new Label() { CssClass = "text" };
            Label labelTextValuePower = new Label() { CssClass = "text-value" };
            Label labelTextGrill = new Label() { CssClass = "text" };
            Label labelTextValueGrill = new Label() { CssClass = "text-value" };

            panelGrill.Attributes.CssStyle.Add("opacity", microwave.GrillPercent(microwave.Grill));
            panelWave.Attributes.CssStyle.Add("opacity", microwave.PowerPercent(microwave.Power));
            labelTextPower.Text = "POWER:";
            labelTextValuePower.Text = microwave.Power.ToString();
            labelTextGrill.Text = "GRILL:";
            labelTextValueGrill.Text = microwave.Grill.ToString();

            panelProperty.Controls.Add(panelGrill);
            panelProperty.Controls.Add(panelWave);
            panelProperty.Controls.Add(labelTextPower);
            panelProperty.Controls.Add(labelTextValuePower);
            panelProperty.Controls.Add(labelTextGrill);
            panelProperty.Controls.Add(labelTextValueGrill);

            panelContent.Controls.Add(panelProperty);
            linkButtonMicrowave.Controls.Add(panelContent);
            linkButtonMicrowave.Controls.Add(DeviceBgAsp.Drawe());

            linkButtonMicrowave.Attributes.Add("data-device", (microwave as Device).TypeDevice());
            linkButtonMicrowave.Attributes.Add("data-id", microwave.Id.ToString());

            return linkButtonMicrowave;
        }
    }
}