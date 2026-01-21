using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_sharp_lever_2.Properties;
using Projects_on_UserControl.Properties;

namespace Projects_on_UserControl
{
    public partial class ctlTrafficLight : UserControl
    {
        public enum enLightType { Green = 1, Orange = 2, Red = 3 };
        private enLightType _CurrentLight = enLightType.Red;

        private int _RedTime = 10;
        private int _OrangeTime = 3;
        private int _GreenTime = 10;

        private int _CurrentCountDownValue;

        public class TrafficLightEventArgs : EventArgs
        {
            public enLightType CurrentLight { get; }
            public int LightDuration { get; }

            public TrafficLightEventArgs(enLightType CurrentLight, int LightDuration)
            {
                this.CurrentLight = CurrentLight;
                this.LightDuration = LightDuration;
            }
        }
        public ctlTrafficLight()
        {
            InitializeComponent();
        }

        public enLightType CurrentLight
        {
            get
            {
                return _CurrentLight;
            }
            set
            {
                _CurrentLight = value;
                switch (_CurrentLight)
                {
                    case enLightType.Green:
                        pbTrafficLights.Image = Resources.Green;
                        lblCountDown.ForeColor = Color.Green;
                        break;
                    case enLightType.Orange:
                        pbTrafficLights.Image = Resources.Orange;
                        lblCountDown.ForeColor = Color.Orange;
                        break;
                    case enLightType.Red:
                        pbTrafficLights.Image = Resources.Red;
                        lblCountDown.ForeColor = Color.Red;
                        break;
                }

            }
        }

        public int RedTime
        {
            get { return _RedTime; }
            set
            {
                _RedTime = value;
            }
        }

        public int OrangeTime
        {
            get { return _OrangeTime; }
            set
            {
                _OrangeTime = value;
            }
        }

        public int GreemTime
        {
            get { return _GreenTime; }
            set
            {
                _GreenTime = value;
            }
        }

        public int GetCurrentTime()
        {
            switch (_CurrentLight)
            {
                case enLightType.Red:
                    return RedTime;
                case enLightType.Green:
                    return GreemTime;
                case enLightType.Orange:
                    return OrangeTime;
                default: return RedTime;
            }
        }
        public void Start()
        {
            _CurrentCountDownValue = GetCurrentTime();
            LightTimer.Start();
        }
        public void Stop()
        {
            LightTimer.Stop();
        }

        private void LightTimer_Tick(object sender, EventArgs e)
        {
            lblCountDown.Text = _CurrentCountDownValue.ToString();
            if (_CurrentCountDownValue == 0)
            {
                //MessageBox.Show("Change the colot");
                ChangeLightColor();
            }
            else
                --_CurrentCountDownValue;
        }

        private void ChangeLightColor()
        {
            switch(_CurrentLight)
            {
                case enLightType.Red:
                    CurrentLight = enLightType.Green;
                    _CurrentCountDownValue = GreemTime;
                    lblCountDown.Text = _CurrentCountDownValue.ToString();
                    OnLightChanged();
                    break;
                case enLightType.Orange:
                    CurrentLight = enLightType.Red;
                    _CurrentCountDownValue = RedTime;
                    lblCountDown.Text = _CurrentCountDownValue.ToString();
                    OnLightChanged();
                    break;
                case enLightType.Green:
                    CurrentLight = enLightType.Orange;
                    _CurrentCountDownValue = OrangeTime;
                    lblCountDown.Text = _CurrentCountDownValue.ToString();
                    OnLightChanged();
                    break;
                default:
                    pbTrafficLights.Image = Resources.Red;
                    break;
            }
        }

        public event EventHandler<TrafficLightEventArgs> RedLightOn;
        public void RedLightIsOn()
        {
            RedLightIsOn(new TrafficLightEventArgs(enLightType.Red, RedTime));
        }
        protected virtual void RedLightIsOn(TrafficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventArgs> OrangeLightOn;
        public void OrangeLightIsOn()
        {
            OrangeLightIsOn(new TrafficLightEventArgs(enLightType.Orange, OrangeTime));
        }
        protected virtual void OrangeLightIsOn(TrafficLightEventArgs e)
        {
            OrangeLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventArgs> GreenLightOn;
        public void GreenLightIsOn()
        {
            GreenLightIsOn(new TrafficLightEventArgs(enLightType.Green, GreemTime));
        }
        protected virtual void GreenLightIsOn(TrafficLightEventArgs e)
        {
            OrangeLightOn?.Invoke(this, e);
        }

        // Event that serves for all lights
        public event EventHandler<TrafficLightEventArgs> LightChanged;
        public void OnLightChanged()
        {
            OnLightChaged(new TrafficLightEventArgs(CurrentLight, _CurrentCountDownValue));
        }
        protected virtual void OnLightChaged(TrafficLightEventArgs e)
        {
            LightChanged?.Invoke(this, e);
        }
    }
}
