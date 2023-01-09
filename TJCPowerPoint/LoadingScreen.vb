Public Class LoadingScreen
    'CREATING DROPDOWN SHADOW AND ROUDED CORNERS

    'https://stackoverflow.com/questions/16493698/drop-shadow-on-a-borderless-winform#:~:text=1)%20Create%20an%20image%20having,4)%20You%20are%20done!
    Dim aeroEnabled = False
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            CheckAeroEnabled()
            Dim cp As CreateParams = MyBase.CreateParams
            If Not aeroEnabled Then
                cp.ClassStyle = NativeConstants.CS_DROPSHADOW
                Return cp
            Else
                Return cp
            End If
        End Get
    End Property
    Protected Overrides Sub WndProc(ByRef m As Message)
        Select Case m.Msg
            Case NativeConstants.WM_NCPAINT
                Dim val = 2
                If aeroEnabled Then
                    NativeMethods.DwmSetWindowAttribute(Handle, 2, val, 4)
                    Dim bla As New NativeStructs.MARGINS()
                    With bla
                        .bottomHeight = 1
                        .leftWidth = 1
                        .rightWidth = 1
                        .topHeight = 1
                    End With
                    NativeMethods.DwmExtendFrameIntoClientArea(Handle, bla)
                End If
                Exit Select
        End Select
        MyBase.WndProc(m)
    End Sub
    Private Sub CheckAeroEnabled()
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            Dim response As Integer = NativeMethods.DwmIsCompositionEnabled(enabled)
            aeroEnabled = (enabled = 1)
        Else
            aeroEnabled = False
        End If
    End Sub
End Class