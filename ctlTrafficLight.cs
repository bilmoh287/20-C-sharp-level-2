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

namespace C_sharp_lever_2
{
    public partial class ctlTrafficLight : UserControl
    {
        public enum enLightType { Green = 1, Orange = 2, Red = 3};
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
                        pbTrafficLight.Image = Resources.Green;
                        lblCountDown.ForeColor = Color.Green;
                        break;
                    case enLightType.Orange:
                        pbTrafficLight.Image = Resources.Orange;
                        lblCountDown.ForeColor = Color.Orange;
                        break;
                    case enLightType.Red:
                        pbTrafficLight.Image = Resources.Red;
                        lblCountDown.ForeColor = Color.Red;
                        break;
                }

            }
        }
    }
}
