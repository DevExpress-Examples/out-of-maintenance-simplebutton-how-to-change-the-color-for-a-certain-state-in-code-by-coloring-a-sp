Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace dxSample_ButtonColoredStates
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            ColorButton()
        End Sub
        Private Sub ColorButton()
            ImageStateHelper.ColorButtonState(1, Color.Red)
            ImageStateHelper.ColorButtonState(2, Color.Green)
            ImageStateHelper.ColorButtonState(4, Color.Pink)
            ImageStateHelper.ColorButtonState(5, Color.Yellow)
        End Sub
    End Class
End Namespace
