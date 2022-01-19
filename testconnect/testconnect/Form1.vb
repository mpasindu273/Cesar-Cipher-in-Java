Imports System.Data.SqlClient
Public Class Form1
    Dim constr As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user1\Desktop\testconnect\testconnect\Database1.mdf;Integrated Security=True"
    Dim da As New SqlDataAdapter


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.LibraryDataSet.book)
        'TODO: This line of code loads data into the 'Database1DataSet.a' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'AddressBookDataSet.tblContacts' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BookBindingSource.MovePrevious()
        If BookBindingSource.IsBindingSuspended Then
            MsgBox("No more records")
        End If
    End Sub
End Class
