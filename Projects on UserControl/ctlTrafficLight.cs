using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projects_on_UserControl.Properties;

namespace Projects_on_UserControl
{
    public partial class ctlTrafficLight : UserControl
    {
        public enum enLightType { Green = 1, Orange = 2, Red = 3 };
        private enLightType _lightType;

        public ctlTrafficLight()
        {
            InitializeComponent();
        }

        public ctlTrafficLight.enLightType LightType
        {
            get
            {
                return _lightType;
            }
            set
            {
                _lightType = value;
                switch (_lightType)
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
    }
}
