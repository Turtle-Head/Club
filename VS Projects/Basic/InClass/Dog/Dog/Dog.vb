Public Class Dog
    Private name As String
    Private age As Integer
    Private breed As String
    Private color As String

    Public Sub New()
        name = ""
        age = 0
        breed = ""
        color = ""
    End Sub
    Public Sub New(name As String, age As Integer, breed As String, color As String)
        Me.name = name
        Me.age = age
        Me.breed = breed
        Me.color = color
    End Sub
    Public Function Print() As String
        Return $"Hi, my name is {name} who is {breed} and is {age} years old and has a {color} coat"
    End Function
End Class