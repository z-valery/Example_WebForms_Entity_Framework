using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse.DeviceDrawe
{
    public static class DeviceBgAsp
    {
        public static Control Drawe()
        {
            Panel panelBg = new Panel() { CssClass = "bg" };
            Panel panelBrTop = new Panel() { CssClass = "br-top" };
            Panel panelBrTopLeft = new Panel() { CssClass = "br-top-left" };
            Panel panelBottomLeft = new Panel() { CssClass = "br-bottom-left" };
            Panel panelBottomRight = new Panel() { CssClass = "br-bottom-right" };
            panelBg.Controls.Add(panelBrTop);
            panelBg.Controls.Add(panelBrTopLeft);
            panelBg.Controls.Add(panelBottomLeft);
            panelBg.Controls.Add(panelBottomRight);
            return panelBg;
        }
    }
}