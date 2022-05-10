Imports System.Xml
Imports System.Xml.Serialization

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ListBox1().Items.Clear()
        OpenFileDialog1.Title = "Please select an XML file"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "XML Files|*.xml"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim students As New StudentCollection()
            Dim serializer As New XmlSerializer(GetType(StudentCollection))
            Dim reader As New System.IO.StreamReader(OpenFileDialog1.FileName)
            students = CType(serializer.Deserialize(reader), StudentCollection)

            For Each std As Student In students.Student
                Dim Id As String = "Id : " & std.Id.ToString()
                ListBox1.Items.Add(Id)
                Id = "Name : " & std.Name.ToString()
                ListBox1.Items.Add(Id)
                Id = "Percentage : " & std.Percentage.ToString()
                ListBox1.Items.Add(Id)
            Next

        End If
    End Sub
End Class
