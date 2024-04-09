﻿
Public Class MainForm
    Public currentBtn As Object



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.ClientSize = New Size(screenWidth, screenHeight)
        pnlSelection.Size = New Size(200, screenHeight)
        pnlRibbon.Size = New Size(screenWidth - 200, 50)
        pnlSwitch.Size = New Size(screenWidth - 200, screenHeight - 50)
    End Sub

    Private Sub btMin_Click(sender As Object, e As EventArgs) Handles btMin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btCLose_Click(sender As Object, e As EventArgs) Handles btLgtClose.Click
        LogReg("Out", lbUsername.Text)
        Application.Exit()
    End Sub

    Private Sub btLogOut_Click(sender As Object, e As EventArgs) Handles btLogOut.Click
        LoginForm.Show()
        LogReg("Out", lbUsername.Text)
        Me.Hide()
    End Sub

    Private Sub btSettings_Click(sender As Object, e As EventArgs) Handles btSettings.Click

    End Sub

    Private Sub btInventory_Click(sender As Object, e As EventArgs) Handles btInventory.Click
        switchPanel(Inventory)
    End Sub

    Private Sub btSale_Click(sender As Object, e As EventArgs) Handles btSale.Click
        switchPanel(Sales)
    End Sub

    Private Sub btHistory_Click(sender As Object, e As EventArgs) Handles btHistory.Click
        switchPanel(History)
    End Sub

    Private Sub btExpenses_Click(sender As Object, e As EventArgs) Handles btExpenses.Click
        switchPanel(Expenses)
    End Sub

    Private Sub btEmplyMngt_Click(sender As Object, e As EventArgs) Handles btEmplyMngt.Click
        switchPanel(EmployeeManagement)
    End Sub

    Private Sub btTimeLog_Click(sender As Object, e As EventArgs) Handles btTimeLog.Click
        switchPanel(TimeLog)
    End Sub

    Private Sub pnlSelection_Paint(sender As Object, e As PaintEventArgs) Handles pnlSelection.Paint

    End Sub
End Class