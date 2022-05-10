Imports System.Xml.Serialization
<Serializable()>
Public Class Student
    <XmlElement("Id")>
    Public Property Id() As Integer
    <XmlElement("Name")>
    Public Property Name() As String
    <XmlElement("Percentage")>
    Public Property Percentage() As String
End Class
<Serializable(), System.Xml.Serialization.XmlRoot("StudentCollection")>
Public Class StudentCollection
    <XmlArray("Students"), XmlArrayItem("Student", GetType(Student))>
    Public Property Student() As Student()
End Class
