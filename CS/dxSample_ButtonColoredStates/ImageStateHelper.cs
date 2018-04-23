using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.LookAndFeel;
using DevExpress.Skins;

namespace dxSample_ButtonColoredStates {
    public static class ImageStateHelper {
        public static void ColorButtonState(int stateNumber, System.Drawing.Color stateColor) {
            SetColoredState(stateNumber, stateColor);
        }
        private static void SetColoredState(int stateNumber, Color stateColor) {
            var skin = GetCurrentSkin();
            var element = skin["Button"];
            var initialImg = element.Image;
            if (initialImg == null) {
                return;
            }
            var images = initialImg.GetImages().Images;
            if (images == null || images.Count == 0) {
                return;
            }
            var imgForState = images[stateNumber];
            var imgSize = imgForState.Size;
            var g = Graphics.FromImage(element.Image.Image);
            g.FillRectangle(new SolidBrush(stateColor), new Rectangle(new Point(0, stateNumber * imgSize.Height), imgSize));
        }
        private static Skin GetCurrentSkin() {
            return CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);
        }
    }
}
