Imports System.ComponentModel

Public Class VentanaBase

    Protected Overridable Function Validar() As Boolean
        Return True
    End Function

    Protected Overridable Function Cambios() As Boolean
        Return False
    End Function

    Protected Overridable Function GuardarCambios() As Boolean
        Return True
    End Function

    Protected Overridable Sub CommitChanges()

    End Sub

    Protected Overridable Sub RevertChanges()

    End Sub

    Public Sub Limpiar()
        Dim oRes As DialogResult
        If Cambios() Then
            'Preguntar
            oRes = MessageBox.Show(String.Format("Se han detectado cambios{0}{0}¿Desea guardarlos antes de limpiar la captura?", System.Environment.NewLine), "Cambios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            If oRes = DialogResult.Cancel Then
                Exit Sub
            End If
            If oRes = DialogResult.Yes Then
                If Not Validar() Then Exit Sub

                If Not GuardarCambios() Then Exit Sub
                CommitChanges()

            End If
        End If
        LimpiarDatos()
    End Sub

    Protected Overridable Sub LimpiarDatos()

    End Sub

    Public Function Guardar() As Boolean
        Dim bRes As Boolean
        If Cambios() Then
            If Validar() Then
                If GuardarCambios() Then
                    bRes = True
                    CommitChanges()
                End If
            End If
        End If
        Return bRes
    End Function

    Private Sub VentanaBase_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim oRes As DialogResult
        If Not Me.Cambios() Then Exit Sub
        'Preguntar
        oRes = MessageBox.Show(String.Format("Se han detectado cambios{0}{0}¿Desea guardarlos antes de salir?", System.Environment.NewLine), "Cambios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If oRes = DialogResult.Cancel Then
            e.Cancel = True
            Exit Sub
        End If
        If oRes = DialogResult.No Then
            Exit Sub
        End If
        If Not Validar() Then
            e.Cancel = True
        Else
            If Not GuardarCambios() Then
                e.Cancel = True
            Else
                CommitChanges()
            End If
        End If
    End Sub

    'Private Sub VentanaBase_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    '    CommitChanges()
    'End Sub

    Private Sub VentanaBase_Load(sender As Object, e As EventArgs) Handles Me.Load
        LimpiarDatos()
    End Sub
End Class