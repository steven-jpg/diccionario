Imports System.IO
Public Class Form2
    Dim Lista As New List(Of String)
    Dim Li As New List(Of String)
    Dim imagen As String
    Dim listaSig As New List(Of String)
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox3.Visible = False
        Dim leer As New StreamReader("C:\Users\steven pozo\Desktop\steven.txt")



        Dim palabras As String
        While leer.Peek <> -1
            palabras = leer.ReadLine().ToString
            Lista.Add(palabras)
            'Label1.Text = Label1.Text & leer.ReadLine() & vbCrLf

        End While
        For Each item As String In Lista
            Me.ListBox1.Items.Add(item)
        Next item
        Dim im As New StreamReader("C:\Users\steven pozo\Desktop\steven2.txt")



        Dim i As String
        While im.Peek <> -1
            i = im.ReadLine().ToString
            Li.Add(i)
            'Label1.Text = Label1.Text & leer.ReadLine() & vbCrLf

        End While
        For Each item As String In Li
            Me.ListBox2.Items.Add(item)
        Next item

        Dim sig As New StreamReader("C:\Users\steven pozo\Desktop\steven1.txt")

        Dim j As String
        While sig.Peek <> -1
            j = sig.ReadLine().ToString
            listaSig.Add(j)
            'Label1.Text = Label1.Text & leer.ReadLine() & vbCrLf

        End While
        For Each item As String In listaSig
            Me.ListBox3.Items.Add(item)
        Next item
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        imagen = ListBox2.SelectedItem

        Dim v3 As New Form3
        MsgBox(ListBox2.SelectedIndex)


        v3.PictureBox1.Image = Image.FromFile(ListBox2.SelectedItem)
        v3.P.Text = ListBox1.Items(ListBox2.SelectedIndex)
        v3.S.Text = ListBox3.Items(ListBox2.SelectedIndex)
        Form2.ActiveForm.Hide()
        v3.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ActiveForm.Hide()
        Form4.Show()
    End Sub
End Class