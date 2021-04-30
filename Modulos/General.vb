Module General

    <DebuggerStepThrough>
    Public Function Comparar(v1 As Object, v2 As Object) As Integer
        Dim iRes As Integer = 0
        If Not (IsNothing(v1) And IsNothing(v2)) Then
            If IsNumeric(v1) And IsNumeric(v2) Then
                If Val(v1) > Val(v2) Then
                    iRes = 1
                ElseIf Val(v1) < Val(v2) Then
                    iRes = -1
                End If
            Else
                If IsNothing(v1) Then v1 = String.Empty
                If IsNothing(v2) Then v2 = String.Empty
                iRes = String.Compare(v1.ToString(), v2.ToString())
            End If
        End If
        Return iRes
    End Function

    <DebuggerStepThrough>
    Public Sub ShowErr(Ex As Exception)
        Dim sM As String = String.Format("Ha ocurrido un error inesperado{0}{0}{1}", System.Environment.NewLine, Ex.Message)
        MessageBox.Show(sM, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Module
