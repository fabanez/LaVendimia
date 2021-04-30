Imports System.Data.SQLite
Public Class CRUDArticulo
    Inherits VentanaBase

#Region "CodeBehind"

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblFolio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents nudPrecio As NumericUpDown
    Friend WithEvents nudExistencia As NumericUpDown
    Friend WithEvents txtModelo As TextBox

    Private Sub InitializeComponent()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblFolio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.nudPrecio = New System.Windows.Forms.NumericUpDown()
        Me.nudExistencia = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Existencia"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(87, 51)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(261, 23)
        Me.txtDescripcion.TabIndex = 0
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(87, 86)
        Me.txtModelo.MaxLength = 50
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(261, 23)
        Me.txtModelo.TabIndex = 1
        '
        'nudPrecio
        '
        Me.nudPrecio.DecimalPlaces = 2
        Me.nudPrecio.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudPrecio.Location = New System.Drawing.Point(87, 119)
        Me.nudPrecio.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudPrecio.Name = "nudPrecio"
        Me.nudPrecio.Size = New System.Drawing.Size(260, 23)
        Me.nudPrecio.TabIndex = 2
        '
        'nudExistencia
        '
        Me.nudExistencia.Location = New System.Drawing.Point(87, 154)
        Me.nudExistencia.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudExistencia.Name = "nudExistencia"
        Me.nudExistencia.Size = New System.Drawing.Size(260, 23)
        Me.nudExistencia.TabIndex = 3
        '
        'CRUDArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(360, 249)
        Me.Controls.Add(Me.nudExistencia)
        Me.Controls.Add(Me.nudPrecio)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtDescripcion)
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
        Me.Name = "CRUDArticulo"
        Me.Text = "Artículos"
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudExistencia, System.ComponentModel.ISupportInitialize).EndInit()
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
        bRes = Comparar(txtDescripcion.Text, txtDescripcion.Tag) <> 0
        bRes = bRes Or Comparar(txtModelo.Text, txtModelo.Tag) <> 0
        bRes = bRes Or Comparar(nudPrecio.Value, nudPrecio.Tag) <> 0
        bRes = bRes Or Comparar(nudExistencia.Value, nudExistencia.Tag) <> 0
        Return bRes
    End Function

    Private Function CargarDatos() As Boolean
        Dim bRes As Boolean = False
        Try
            lblFolio.Text = "Clave: 0000"
            If _id > 0 Then
                Using cCon = New SQLiteConnection("Data Source=My.db")
                    cCon.Open()
                    Dim oComm As SQLiteCommand = cCon.CreateCommand()
                    oComm.CommandText = "SELECT Descripcion, Modelo, Precio, Existencia FROM Articulos WHERE id = $id LIMIT 1"
                    oComm.Parameters.AddWithValue("$id", _id)
                    Using oRead As SQLiteDataReader = oComm.ExecuteReader()
                        While oRead.Read()
                            'SE cargan los datos
                            txtDescripcion.Text = oRead.Item("Descripcion")
                            txtModelo.Text = oRead.Item("Modelo")
                            nudPrecio.Value = oRead.Item("Precio")
                            nudExistencia.Value = oRead.Item("Existencia")
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
            If Comparar(txtDescripcion.Text, Nothing) = 0 Then
                bRes = False
                txtDescripcion.Focus()
                MessageBox.Show("El campo de descripción no puede estar vacio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            If Comparar(nudPrecio.Value, 0) = 0 Then
                bRes = False
                nudPrecio.Focus()
                MessageBox.Show("El campo de precio no puede ser cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            If Comparar(nudExistencia.Value, 0) = 0 Then
                bRes = False
                nudExistencia.Focus()
                MessageBox.Show("El campo de existencia no puede ser cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
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
            Using cCon = New SQLiteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SQLiteCommand = cCon.CreateCommand()
                oComm.CommandText = "SELECT * FROM Articulos WHERE id = $id LIMIT 1"
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
                    oComm.CommandText = "UPDATE Articulos SET Descripcion = $Des, Modelo = $Mod, Precio = $Pre, Existencia = $Exi WHERE id = $id"
                    oComm.Parameters.AddWithValue("$id", nId)
                    oComm.Parameters.AddWithValue("$Des", txtDescripcion.Text)
                    oComm.Parameters.AddWithValue("$Mod", txtModelo.Text)
                    oComm.Parameters.AddWithValue("$Pre", nudPrecio.Value)
                    oComm.Parameters.AddWithValue("$Exi", nudExistencia.Value)
                Else
                    oComm.CommandText = "INSERT INTO Articulos (Descripcion, Modelo, Precio, Existencia) VALUES ($Des, $Mod, $Pre, $Exi)"
                    oComm.Parameters.AddWithValue("$Des", txtDescripcion.Text)
                    oComm.Parameters.AddWithValue("$Mod", txtModelo.Text)
                    oComm.Parameters.AddWithValue("$Pre", nudPrecio.Value)
                    oComm.Parameters.AddWithValue("$Exi", nudExistencia.Value)
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
        txtDescripcion.Text = txtDescripcion.Tag
        txtModelo.Text = txtModelo.Tag
        nudPrecio.Value = nudPrecio.Tag
        nudPrecio.Value = nudExistencia.Tag
    End Sub

    Protected Overrides Sub CommitChanges()
        txtDescripcion.Tag = txtDescripcion.Text
        txtModelo.Tag = txtModelo.Text
        nudPrecio.Tag = nudPrecio.Value
        nudExistencia.Tag = nudExistencia.Value
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
