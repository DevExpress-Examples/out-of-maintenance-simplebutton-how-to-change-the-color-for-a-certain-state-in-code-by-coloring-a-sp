using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace dxSample_ButtonColoredStates {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            ColorButton();
        }
        private void ColorButton() {
            ImageStateHelper.ColorButtonState(1, Color.Red);
            ImageStateHelper.ColorButtonState(2, Color.Green);
            ImageStateHelper.ColorButtonState(4, Color.Pink);
            ImageStateHelper.ColorButtonState(5, Color.Yellow);
        }
    }
}
