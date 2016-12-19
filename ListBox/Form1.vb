Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim cnt As Byte = ListBox1.Items.Count - 1
        For i As Byte = 0 To cnt
            ListBox2.Items.Add(ListBox1.Items.Item(i))
        Next
        ListBox1.Items.Clear()
        chk_list()
       
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim cnt As Byte = ListBox2.Items.Count - 1
        For i As Byte = 0 To cnt
            ListBox1.Items.Add(ListBox2.Items.Item(i))
        Next
        ListBox2.Items.Clear()
        chk_list()
    End Sub

    Sub chk_list()
        If ListBox1.Items.Count > 0 Then
            Button1.Enabled = True
            Button2.Enabled = True
        Else
            Button1.Enabled = False
            Button2.Enabled = False
        End If

        If ListBox2.Items.Count > 0 Then
            Button3.Enabled = True
            Button4.Enabled = True
        Else
            Button3.Enabled = False
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cnt As Byte = ListBox1.Items.Count - 1
        For i As Byte = 0 To cnt
            If ListBox1.SelectedItem Then
                ListBox2.Items.Add(ListBox1.Items.Item(ListBox1.SelectedIndex))
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            End If
        Next
        chk_list()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim cnt As Byte = ListBox2.Items.Count - 1
        For i As Byte = 0 To cnt
            If ListBox2.SelectedItem Then
                ListBox1.Items.Add(ListBox2.Items.Item(ListBox2.SelectedIndex))
                ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
            End If
        Next
        chk_list()
    End Sub
End Class
