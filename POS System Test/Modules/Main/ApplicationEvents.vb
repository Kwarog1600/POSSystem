Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

    ' Example:
    ' Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
    '
    '   ' Setting the application-wide default Font:
    '   e.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
    '
    '   ' Setting the HighDpiMode for the Application:
    '   e.HighDpiMode = HighDpiMode.PerMonitorV2
    '
    '   ' If a splash dialog is used, this sets the minimum display time:
    '   e.MinimumSplashScreenDisplayTime = 4000
    ' End Sub

    Partial Friend Class MyApplication

        Public screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Public screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

        Private Sub AppLoad(sender As Object, e As EventArgs) Handles Me.Startup
            CreateStarting()
            With LoginForm
                .Size = New Size(screenWidth, screenHeight)
                .pnlMain.Size = New Size(screenWidth, screenHeight)
                .Logo.Location = New Point((screenWidth - (.Logo.Size.Width + .pnlContainer.Size.Width)) / 3, (screenHeight - .Logo.Size.Height) / 2)
                .pnlContainer.Location = New Point((screenWidth - .pnlContainer.Size.Width) * (2 / 3), (screenHeight - .pnlContainer.Size.Height) / 2)
                .btClose.Location = New Point(screenWidth - 50, 0)
            End With
        End Sub
    End Class
End Namespace
