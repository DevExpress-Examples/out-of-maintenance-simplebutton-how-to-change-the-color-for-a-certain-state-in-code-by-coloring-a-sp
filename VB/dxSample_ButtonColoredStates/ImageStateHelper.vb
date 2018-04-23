Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins

Namespace dxSample_ButtonColoredStates
    Public NotInheritable Class ImageStateHelper

        Private Sub New()
        End Sub

        Public Shared Sub ColorButtonState(ByVal stateNumber As Integer, ByVal stateColor As System.Drawing.Color)
            SetColoredState(stateNumber, stateColor)
        End Sub
        Private Shared Sub SetColoredState(ByVal stateNumber As Integer, ByVal stateColor As Color)
            Dim skin = GetCurrentSkin()
            Dim element = skin("Button")
            Dim initialImg = element.Image
            If initialImg Is Nothing Then
                Return
            End If
            Dim images = initialImg.GetImages().Images
            If images Is Nothing OrElse images.Count = 0 Then
                Return
            End If
            Dim imgForState = images(stateNumber)
            Dim imgSize = imgForState.Size
            Dim g = Graphics.FromImage(element.Image.Image)
            g.FillRectangle(New SolidBrush(stateColor), New Rectangle(New Point(0, stateNumber * imgSize.Height), imgSize))
        End Sub
        Private Shared Function GetCurrentSkin() As Skin
            Return CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel)
        End Function
    End Class
End Namespace
