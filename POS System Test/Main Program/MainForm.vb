Public Class MainForm
    Public currentBtn As Object

    Public Sub switchPanel(ByVal panel As Form)
        With pnlSwitch
            .Controls.Clear()
            panel.TopLevel = False
            .Controls.Add(panel)
            panel.Show()
        End With
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.ClientSize = New Size(screenWidth, screenHeight)
        pnlSelection.Size = New Size(200, screenHeight)
        pnlRibbon.Size = New Size(screenWidth - 200, 50)
        pnlSwitch.Size = New Size(screenWidth - 200, screenHeight - 50)
    End Sub

    Public Sub DisabledButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.Gray
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles btAnalytics.Click

    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btMin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btLgtCLose_Click(sender As Object, e As EventArgs) Handles btLgtClose.Click
        Application.Exit()
    End Sub

    Private Sub btLogOut_Click(sender As Object, e As EventArgs) Handles btLogOut.Click
        LoginForm.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btSettings_Click(sender As Object, e As EventArgs) Handles btSettings.Click

    End Sub


    Private Sub btdashboard_Click(sender As Object, e As EventArgs) Handles btdashboard.Click
        Me.switchPanel(Dashboard)
    End Sub

    Private Sub btInventory_Click(sender As Object, e As EventArgs) Handles btInventory.Click
        Me.switchPanel(Inventory)
    End Sub
End Class