'This class is part of the TJC PowerPoint project.
'The TJC PowerPoint is a simple program displaying bible verses, hymns
'to a projector using Microsoft PowerPoint.
'It also has other purporses to help display usesful information to the projector
'These include:
'How to pray, service times, current time and date, holy communion slides, prayer requests
'announcements, hymnal hymns etc.
'
'Initially developed by Joshi Chan (TJC Lecieseter), from V2 onwards developed by Caleb Chan (TJC London)
'© Copyright 2023 True Jesus Church London 

Public Class LoadingScreen

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Turn on WS_EX_COMPOSITED
            Return cp
        End Get
    End Property


End Class