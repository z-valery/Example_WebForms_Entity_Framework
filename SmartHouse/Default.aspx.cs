using SmartHouse.DdAccess;
using SmartHouse.Models;
using SmartHouse.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse
{
    public partial class Default : System.Web.UI.Page
    {
        private static Device selectedDevice;
        private static DeviceConsole deviceConsole;

        private static DataBaseContext db = new DataBaseContext();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Session["SelectedDevice"] != null)
                {
                    selectedDevice = (Session["SelectedDevice"] as Device);
                }
                if (Session["DeviceConsole"] != null)
                {
                    deviceConsole = (Session["DeviceConsole"] as DeviceConsole);
                }
            }
            else
            {
                console.Visible = false;
            }
            InitDevicePanel();
        } 


        // Create
        public void Create(string device)
        {
            switch (device)
            {
                case "Tv":
                    Tv tv = new Tv();
                    db.Tvs.Add(tv);
                    db.SaveChanges();
                    Session["SelectedDevice"] = tv;
                    Session["DeviceConsole"] = new DeviceConsole(tv);
                    break;
                case "Fridge":
                    Fridge fridge = new Fridge();
                    db.Fridges.Add(fridge);
                    db.SaveChanges();
                    Session["SelectedDevice"] = fridge;
                    Session["DeviceConsole"] = new DeviceConsole(fridge);
                    break;
                case "Lamp":
                    Lamp lamp = new Lamp();
                    db.Lamps.Add(lamp);
                    db.SaveChanges();
                    Session["SelectedDevice"] = lamp;
                    Session["DeviceConsole"] = new DeviceConsole(lamp);
                    break;
                case "Cooker":
                    Cooker cooker = new Cooker();
                    db.Cookers.Add(cooker);
                    db.SaveChanges();
                    Session["SelectedDevice"] = cooker;
                    Session["DeviceConsole"] = new DeviceConsole(cooker);
                    break;
                case "Microwave":
                    Microwave microwave = new Microwave();
                    db.Microwaves.Add(microwave);
                    db.SaveChanges();
                    Session["SelectedDevice"] = microwave;
                    Session["DeviceConsole"] = new DeviceConsole(microwave);
                    break;
                default:
                    break;
            }
            selectedDevice = (Session["SelectedDevice"] as Device);
            deviceConsole = (Session["DeviceConsole"] as DeviceConsole);
            RefreshPage();
        }


        // Event Add Device
        protected void LinkButtonAddTv_Click(object sender, EventArgs e)
        {
            Create("Tv");
            PanelDevices.Controls.Clear();
            InitDevicePanel();
        }

        protected void LinkButtonAddFridge_Click(object sender, EventArgs e)
        {
            Create("Fridge");
            PanelDevices.Controls.Clear();
            InitDevicePanel();
        }

        protected void LinkButtonAddLamp_Click(object sender, EventArgs e)
        {
            Create("Lamp");
            PanelDevices.Controls.Clear();
            InitDevicePanel();
        }

        protected void LinkButtonAddCooker_Click(object sender, EventArgs e)
        {
            Create("Cooker");
            PanelDevices.Controls.Clear();
            InitDevicePanel();
        }

        protected void LinkButtonAddMicrowave_Click(object sender, EventArgs e)
        {
            Create("Microwave");
            PanelDevices.Controls.Clear();
            InitDevicePanel();
        }
        

        // Select Device
        public void LinkButtonSelectDevice_Click(object sender, EventArgs e)
        {
            string device = (sender as LinkButton).Attributes[("data-device")];
            int id = Convert.ToInt32((sender as LinkButton).Attributes[("data-id")]);

            switch (device)
            {
                case "Tv":
                    selectedDevice = db.Tvs.Find(id);
                    deviceConsole = new DeviceConsole(db.Tvs.Find(id));
                    break;
                case "Fridge":
                    selectedDevice = db.Fridges.Find(id);
                    deviceConsole = new DeviceConsole(db.Fridges.Find(id));
                    break;
                case "Lamp":
                    selectedDevice = db.Lamps.Find(id);
                    deviceConsole = new DeviceConsole(db.Lamps.Find(id));
                    break;
                case "Cooker":
                    selectedDevice = db.Cookers.Find(id);
                    deviceConsole = new DeviceConsole(db.Cookers.Find(id));
                    break;
                case "Microwave":
                    selectedDevice = db.Microwaves.Find(id);
                    deviceConsole = new DeviceConsole(db.Microwaves.Find(id));
                    break;
                default:
                    selectedDevice = null;
                    deviceConsole = null;
                    break;
            }
            Session["SelectedDevice"] = selectedDevice;
            Session["DeviceConsole"] = deviceConsole;
            RefreshPage();
        }


        // Console
        protected void LinkButtonOn_Click(object sender, EventArgs e)
        {
            if(selectedDevice != null)
            {
                selectedDevice.On();
            }
            RefreshPage();
        }

        protected void LinkButtonOff_Click(object sender, EventArgs e)
        {
            if (selectedDevice != null)
            {
                selectedDevice.Off();
            }
            RefreshPage();
        }


        // Delete
        protected void LinkButtonDelete_Click(object sender, EventArgs e)
        {
            if (selectedDevice != null)
            {
                string device = (selectedDevice as Device).TypeDevice();
                int id = (selectedDevice as Device).Id;

                switch (device)
                {
                    case "Tv":
                        Tv tv = db.Tvs.Find(id);
                        if (tv != null)
                        {
                            db.Tvs.Remove(tv);
                            db.SaveChanges();
                            PanelDevicesDeleteControl(tv.Id, tv.TypeDevice());
                        }
                        break;
                    case "Fridge":
                        Fridge fridge = db.Fridges.Find(id);
                        if (fridge != null)
                        {
                            db.Fridges.Remove(fridge);
                            db.SaveChanges();
                            PanelDevicesDeleteControl(fridge.Id, fridge.TypeDevice());
                        }
                        break;
                    case "Lamp":
                        Lamp lamp = db.Lamps.Find(id);
                        if (lamp != null)
                        {
                            db.Lamps.Remove(lamp);
                            db.SaveChanges();
                            PanelDevicesDeleteControl(lamp.Id, lamp.TypeDevice());
                        }
                        break;
                    case "Cooker":
                        Cooker cooker = db.Cookers.Find(id);
                        if (cooker != null)
                        {
                            db.Cookers.Remove(cooker);
                            db.SaveChanges();
                            PanelDevicesDeleteControl(cooker.Id, cooker.TypeDevice());
                        }
                        break;
                    case "Microwave":
                        Microwave microwave = db.Microwaves.Find(id);
                        if (microwave != null)
                        {
                            db.Microwaves.Remove(microwave);
                            db.SaveChanges();
                            PanelDevicesDeleteControl(microwave.Id, microwave.TypeDevice());
                        }
                        break;
                    default:
                        break;
                }
                Session["SelectedDevice"] = null;
                Session["DeviceConsole"] = null;
                selectedDevice = null;
                deviceConsole = null;
                RefreshPage();
            }
        }
        

        // Ok
        protected void LinkButtonOk_Click(object sender, EventArgs e)
        {
            if (selectedDevice != null)
            {
                db.Entry(selectedDevice).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                Session["SelectedDevice"] = null;
                Session["DeviceConsole"] = null;
                selectedDevice = null;
                deviceConsole = null;
                RefreshPage();
            }
        }


        // Event Console
        protected void LinkButtonSettingPrev_Click(object sender, EventArgs e)
        {
            if(deviceConsole != null)
            {
                deviceConsole.PrevSetting();
                RefreshPage();
            }
        }

        protected void LinkButtonSettingNext_Click(object sender, EventArgs e)
        {
            if (deviceConsole != null)
            {
                deviceConsole.NextSetting();
                RefreshPage();
            }
        }

        protected void LinkButtonValueIncr_Click(object sender, EventArgs e)
        {
            if (deviceConsole != null)
            {
                deviceConsole.IncrValue();
                RefreshPage();
            }
        }

        protected void LinkButtonValueDecr_Click(object sender, EventArgs e)
        {
            if (deviceConsole != null)
            {
                deviceConsole.DecrValue();
                RefreshPage();
            }
        }


        // Refresh Page
        private void RefreshPage()
        {
            PanelConsoleDevice.Controls.Clear();
            ListBoxDeviceProp.Items.Clear();
            LabelValue.Text = "";  

            // Selected Device
            if (selectedDevice != null)
            {
                PanelConsoleDevice.Controls.Add((selectedDevice as IDrawe).Drawe());
                console.Visible = true;
                if(selectedDevice.IsOn)
                {
                    LinkButtonOn.CssClass = "on is-active";
                    LinkButtonOff.CssClass = "off";
                }
                else
                {
                    LinkButtonOff.CssClass = "off is-active";
                    LinkButtonOn.CssClass = "on";
                }
            }
            else
            {
                console.Visible = false;
            }
            // Settings
            if (deviceConsole != null)
            {
                foreach (string property in deviceConsole.Settings)
                {
                    ListBoxDeviceProp.Items.Add(property);
                }
                ListBoxDeviceProp.SelectedIndex = deviceConsole.Settings.IndexOf(deviceConsole.SelectedSetting);
                LabelValue.Text = deviceConsole.Value;
            }
        }


        // Initialize Device Panel
        public void InitDevicePanel()
        {
            foreach (var device in db.Tvs)
            {
                Control linkButtonTv = device.Drawe();
                (linkButtonTv as LinkButton).Click += LinkButtonSelectDevice_Click;
                PanelDevices.Controls.Add(linkButtonTv);
            }

            foreach (var device in db.Fridges)
            {
                Control linkButtonFridge = device.Drawe();
                (linkButtonFridge as LinkButton).Click += LinkButtonSelectDevice_Click;
                PanelDevices.Controls.Add(linkButtonFridge);
            }
            foreach (var device in db.Lamps)
            {
                Control linkButtonLamp = device.Drawe();
                (linkButtonLamp as LinkButton).Click += LinkButtonSelectDevice_Click;
                PanelDevices.Controls.Add(linkButtonLamp);
            }
            foreach (var device in db.Cookers)
            {
                Control linkButtonCooker = device.Drawe();
                (linkButtonCooker as LinkButton).Click += LinkButtonSelectDevice_Click;
                PanelDevices.Controls.Add(linkButtonCooker);
            }
            foreach (var device in db.Microwaves)
            {
                Control linkButtonMicrowave = device.Drawe();
                (linkButtonMicrowave as LinkButton).Click += LinkButtonSelectDevice_Click;
                PanelDevices.Controls.Add(linkButtonMicrowave);
            }
        }


        // Delete Device from PanelDevices
        private void PanelDevicesDeleteControl(int id, string device)
        {
            for (int i = 0; i < PanelDevices.Controls.Count; i++)
            {
                string deviceDelete = (PanelDevices.Controls[i] as LinkButton).Attributes[("data-device")];
                int idDelete = Convert.ToInt32((PanelDevices.Controls[i] as LinkButton).Attributes[("data-id")]);
                if (deviceDelete == device && idDelete == id)
                {
                    PanelDevices.Controls.Remove(PanelDevices.Controls[i]);
                }
            }
        }


    }
}