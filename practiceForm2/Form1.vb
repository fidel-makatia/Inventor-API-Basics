Imports Inventor

Public Class Form1
    Dim _inventApp As Inventor.Application = Nothing

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            Try
                _inventApp = System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application")


            Catch
                System.Windows.Forms.MessageBox.Show("Opening stuff")
            End Try
            If _inventApp Is Nothing Then
                Dim invAppType As Type = System.Type.GetTypeFromProgID("Inventor.Application")
                _inventApp = System.Activator.CreateInstance(invAppType)
                _inventApp.Visible = True

            End If
        Catch

        End Try

    End Sub
End Class
