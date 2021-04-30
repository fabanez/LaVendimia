Imports System.Data.SQLite
Public Class CRUDCliente
    Inherits VentanaBase

#Region "CodeBehind"

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblFolio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents txtMaterno As TextBox
    Friend WithEvents txtRFC As TextBox

    Private Sub InitializeComponent()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblFolio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(174, 205)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 32)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(272, 205)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(76, 32)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblFolio
        '
        Me.lblFolio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFolio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFolio.ForeColor = System.Drawing.Color.Green
        Me.lblFolio.Location = New System.Drawing.Point(253, 9)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(95, 22)
        Me.lblFolio.TabIndex = 2
        Me.lblFolio.Text = "Clave:"
        Me.lblFolio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Paterno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Materno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "RFC"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(74, 51)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(274, 23)
        Me.txtNombres.TabIndex = 0
        '
        'txtPaterno
        '
        Me.txtPaterno.Location = New System.Drawing.Point(74, 86)
        Me.txtPaterno.MaxLength = 50
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(274, 23)
        Me.txtPaterno.TabIndex = 1
        '
        'txtMaterno
        '
        Me.txtMaterno.Location = New System.Drawing.Point(74, 119)
        Me.txtMaterno.MaxLength = 50
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(274, 23)
        Me.txtMaterno.TabIndex = 2
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(74, 154)
        Me.txtRFC.MaxLength = 13
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(274, 23)
        Me.txtRFC.TabIndex = 3
        '
        'CRUDCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(360, 249)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.txtMaterno)
        Me.Controls.Add(Me.txtPaterno)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFolio)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CRUDCliente"
        Me.Text = "Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New(Id As Integer)

        MyBase.New()
        InitializeComponent()

        _id = Id
    End Sub

#End Region

    Private _id As Integer

    Protected Overrides Function Cambios() As Boolean
        Dim bRes As Boolean
        bRes = Comparar(txtNombres.Text, txtNombres.Tag) <> 0
        bRes = bRes OrElse Comparar(txtPaterno.Text, txtPaterno.Tag) <> 0
        bRes = bRes OrElse Comparar(txtMaterno.Text, txtMaterno.Tag) <> 0
        bRes = bRes OrElse Comparar(txtRFC.Text, txtRFC.Tag) <> 0
        Return bRes
    End Function

    Private Function CargarDatos() As Boolean
        Dim bRes As Boolean = False
        Try
            lblFolio.Text = "Clave: 0000"
            If _id > 0 Then
                Using cCon = New SqliteConnection("Data Source=My.db")
                    cCon.Open()
                    Dim oComm As SqliteCommand = cCon.CreateCommand()
                    oComm.CommandText = "SELECT Nombres, Paterno, Materno, RFC FROM Clientes WHERE id = $id LIMIT 1"
                    oComm.Parameters.AddWithValue("$id", _id)
                    Using oRead As SQLiteDataReader = oComm.ExecuteReader()
                        While oRead.Read()
                            'SE cargan los datos
                            txtNombres.Text = oRead.Item("Nombres")
                            txtPaterno.Text = oRead.Item("Paterno")
                            txtMaterno.Text = oRead.Item("Materno")
                            txtRFC.Text = oRead.Item("RFC")
                            lblFolio.Text = String.Format("Clave: {0}", _id.ToString("0000"))
                            bRes = True
                        End While
                    End Using
                End Using
            Else
                bRes = True
            End If
        Catch ex As Exception
            ShowErr(ex)
        End Try
        Return bRes
    End Function

    Protected Overrides Function Validar() As Boolean
        Dim bRes As Boolean = True
        Try
            If Comparar(txtNombres.Text, Nothing) = 0 Then
                bRes = False
                txtNombres.Focus()
                MessageBox.Show("El campo de nombres no puede estar vacio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            If Comparar(txtPaterno.Text, Nothing) = 0 And Comparar(txtMaterno.Text, Nothing) = 0 Then
                bRes = False
                txtPaterno.Focus()
                MessageBox.Show("Debe de haber al menos un apellido capturado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception

        End Try
        Return bRes
    End Function

    Protected Overrides Function GuardarCambios() As Boolean
        Dim bRes As Boolean = False
        Dim nId As Integer
        Dim bFilas As Boolean
        Try
            Using cCon = New SqliteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SqliteCommand = cCon.CreateCommand()
                oComm.CommandText = "SELECT * FROM Clientes WHERE id = $id LIMIT 1"
                oComm.Parameters.AddWithValue("$id", _id)
                Using oRead As SQLiteDataReader = oComm.ExecuteReader()
                    bFilas = oRead.HasRows
                    If oRead.Read() Then nId = oRead.Item("id")
                End Using
            End Using
            Using cCon = New SQLiteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SQLiteCommand = cCon.CreateCommand()
                If bFilas Then
                    oComm.CommandText = "UPDATE Clientes SET Nombres = $Nom, Paterno = $Pat, Materno = $Mat, RFC = $RFC WHERE id = $id"
                    oComm.Parameters.AddWithValue("$id", nId)
                    oComm.Parameters.AddWithValue("$Nom", txtNombres.Text)
                    oComm.Parameters.AddWithValue("$Pat", txtPaterno.Text)
                    oComm.Parameters.AddWithValue("$Mat", txtMaterno.Text)
                    oComm.Parameters.AddWithValue("$RFC", txtRFC.Text)
                Else
                    oComm.CommandText = "INSERT INTO Clientes (Nombres, Paterno, Materno, RFC) VALUES ($Nom, $Pat, $Mat, $RFC)"
                    oComm.Parameters.AddWithValue("$Nom", txtNombres.Text)
                    oComm.Parameters.AddWithValue("$Pat", txtPaterno.Text)
                    oComm.Parameters.AddWithValue("$Mat", txtMaterno.Text)
                    oComm.Parameters.AddWithValue("$RFC", txtRFC.Text)
                End If
                oComm.ExecuteNonQuery()
                bRes = True
            End Using
            bRes = True
            MessageBox.Show("La información se ha guardado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ShowErr(ex)
        End Try
        Return bRes
    End Function

    Protected Overrides Sub RevertChanges()
        txtNombres.Text = txtNombres.Tag
        txtPaterno.Text = txtPaterno.Tag
        txtMaterno.Text = txtMaterno.Tag
        txtRFC.Text = txtRFC.Tag

    End Sub

    Protected Overrides Sub CommitChanges()
        txtNombres.Tag = txtNombres.Text
        txtPaterno.Tag = txtPaterno.Text
        txtMaterno.Tag = txtMaterno.Text
        txtRFC.Tag = txtRFC.Text
    End Sub

    Private Sub CRUDCliente_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CargarDatos()
        CommitChanges()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CommitChanges()
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Guardar() Then
            Me.DialogResult = DialogResult.OK
        End If

    End Sub
End Class
