Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar
Imports Mysqlx.XDevAPI.Common

Public Class AddStock
    Dim categoryFilePath As String = "Resources/Stock Category.csv"
    Dim categoryNames As New List(Of String)


    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadCategories()

    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged

    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click

    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click

    End Sub



    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged

    End Sub

    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click

    End Sub
End Class
