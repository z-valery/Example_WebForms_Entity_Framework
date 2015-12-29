using SmartHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse.DeviceDrawe
{
    public static class TvAsp
    {
        public static Control Drawe(Tv tv)
        {
            LinkButton linkButtonTv = new LinkButton() { CssClass = "device-tv" };
            Panel panelContent = new Panel() { CssClass = "content" };
            Panel panelProperty = new Panel() { CssClass = "property" };
            Label labelChannel = new Label() { CssClass = "channel" };
            Label labelChannelName = new Label() { CssClass = "channel-name" };
            Panel panelVolume = new Panel() { CssClass = "volume" };
            Label labelVolumeText = new Label() { CssClass = "volume-text" };

            labelChannel.Text = "CHANNEL: " + Convert.ToByte(tv.Channel).ToString();
            labelChannelName.Text = tv.Channel.ToString();
            for (int i = 1; i <= tv.Volume; i++)
            {
                panelVolume.Controls.Add(new Panel() { CssClass = "level" });
            }

            panelVolume.Controls.Add(labelVolumeText);
            panelProperty.Controls.Add(panelVolume);
            panelProperty.Controls.Add(labelChannel);
            panelProperty.Controls.Add(labelChannelName);
            panelContent.Controls.Add(panelProperty);
            linkButtonTv.Controls.Add(panelContent);
            linkButtonTv.Controls.Add(DeviceBgAsp.Drawe());

            linkButtonTv.Attributes.Add("data-device", (tv as Device).TypeDevice());
            linkButtonTv.Attributes.Add("data-id", tv.Id.ToString());

            return linkButtonTv;
        }
    }
}