Imports System.Data.SQLite

Public Class RegVenta
    Inherits VentanaBase

#Region "CodeBehind"

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblBonificacion As Label
    Friend WithEvents lblEnganche As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cbArticulos As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblRFC As Label
    Friend WithEvents cbClientes As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvArticulos As DataGridView
    Friend WithEvents rb3meses As RadioButton
    Friend WithEvents rb6meses As RadioButton
    Friend WithEvents rb12meses As RadioButton
    Friend WithEvents rb9meses As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblFolio As Label

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblFolio = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblBonificacion = New System.Windows.Forms.Label()
        Me.lblEnganche = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cbArticulos = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.cbClientes = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.rb3meses = New System.Windows.Forms.RadioButton()
        Me.rb6meses = New System.Windows.Forms.RadioButton()
        Me.rb12meses = New System.Windows.Forms.RadioButton()
        Me.rb9meses = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(587, 490)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 32)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(685, 490)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(76, 32)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblFolio
        '
        Me.lblFolio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFolio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFolio.ForeColor = System.Drawing.Color.Green
        Me.lblFolio.Location = New System.Drawing.Point(666, 9)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(95, 22)
        Me.lblFolio.TabIndex = 2
        Me.lblFolio.Text = "Folio:"
        Me.lblFolio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotal.Location = New System.Drawing.Point(657, 326)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(85, 19)
        Me.lblTotal.TabIndex = 29
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBonificacion
        '
        Me.lblBonificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBonificacion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblBonificacion.Location = New System.Drawing.Point(657, 300)
        Me.lblBonificacion.Name = "lblBonificacion"
        Me.lblBonificacion.Size = New System.Drawing.Size(85, 19)
        Me.lblBonificacion.TabIndex = 28
        Me.lblBonificacion.Text = "0.00"
        Me.lblBonificacion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEnganche
        '
        Me.lblEnganche.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEnganche.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblEnganche.Location = New System.Drawing.Point(657, 274)
        Me.lblEnganche.Name = "lblEnganche"
        Me.lblEnganche.Size = New System.Drawing.Size(85, 19)
        Me.lblEnganche.TabIndex = 27
        Me.lblEnganche.Text = "0.00"
        Me.lblEnganche.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Location = New System.Drawing.Point(520, 326)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 19)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Total"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Location = New System.Drawing.Point(520, 300)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 19)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Bonificación enganche"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Location = New System.Drawing.Point(520, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 19)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Enganche"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnAgregar.Location = New System.Drawing.Point(372, 60)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(40, 34)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "+"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'cbArticulos
        '
        Me.cbArticulos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbArticulos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbArticulos.FormattingEnabled = True
        Me.cbArticulos.Location = New System.Drawing.Point(62, 60)
        Me.cbArticulos.Name = "cbArticulos"
        Me.cbArticulos.Size = New System.Drawing.Size(300, 23)
        Me.cbArticulos.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Artículo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 8)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Location = New System.Drawing.Point(368, 12)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(31, 15)
        Me.lblRFC.TabIndex = 19
        Me.lblRFC.Text = "RFC:"
        '
        'cbClientes
        '
        Me.cbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbClientes.FormattingEnabled = True
        Me.cbClientes.Location = New System.Drawing.Point(62, 9)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(300, 23)
        Me.cbClientes.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Cliente"
        '
        'dgvArticulos
        '
        Me.dgvArticulos.AllowUserToAddRows = False
        Me.dgvArticulos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        Me.dgvArticulos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Location = New System.Drawing.Point(2, 100)
        Me.dgvArticulos.MultiSelect = False
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.RowHeadersVisible = False
        Me.dgvArticulos.RowTemplate.Height = 25
        Me.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvArticulos.Size = New System.Drawing.Size(759, 163)
        Me.dgvArticulos.TabIndex = 3
        '
        'rb3meses
        '
        Me.rb3meses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rb3meses.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb3meses.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rb3meses.Location = New System.Drawing.Point(2, 376)
        Me.rb3meses.Name = "rb3meses"
        Me.rb3meses.Size = New System.Drawing.Size(740, 19)
        Me.rb3meses.TabIndex = 4
        Me.rb3meses.TabStop = True
        Me.rb3meses.Text = "3 meses"
        Me.rb3meses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb3meses.UseVisualStyleBackColor = True
        '
        'rb6meses
        '
        Me.rb6meses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rb6meses.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb6meses.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rb6meses.Location = New System.Drawing.Point(3, 400)
        Me.rb6meses.Name = "rb6meses"
        Me.rb6meses.Size = New System.Drawing.Size(739, 19)
        Me.rb6meses.TabIndex = 5
        Me.rb6meses.TabStop = True
        Me.rb6meses.Text = "6 meses"
        Me.rb6meses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb6meses.UseVisualStyleBackColor = True
        '
        'rb12meses
        '
        Me.rb12meses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rb12meses.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb12meses.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rb12meses.Location = New System.Drawing.Point(4, 448)
        Me.rb12meses.Name = "rb12meses"
        Me.rb12meses.Size = New System.Drawing.Size(738, 19)
        Me.rb12meses.TabIndex = 7
        Me.rb12meses.TabStop = True
        Me.rb12meses.Text = "12 meses"
        Me.rb12meses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb12meses.UseVisualStyleBackColor = True
        '
        'rb9meses
        '
        Me.rb9meses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rb9meses.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb9meses.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rb9meses.Location = New System.Drawing.Point(3, 424)
        Me.rb9meses.Name = "rb9meses"
        Me.rb9meses.Size = New System.Drawing.Size(739, 19)
        Me.rb9meses.TabIndex = 6
        Me.rb9meses.TabStop = True
        Me.rb9meses.Text = "9 meses"
        Me.rb9meses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb9meses.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(2, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(759, 19)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "ABONOS MENSUALES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'RegVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(773, 534)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rb12meses)
        Me.Controls.Add(Me.rb9meses)
        Me.Controls.Add(Me.rb6meses)
        Me.Controls.Add(Me.rb3meses)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblBonificacion)
        Me.Controls.Add(Me.lblEnganche)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cbArticulos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblRFC)
        Me.Controls.Add(Me.cbClientes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvArticulos)
        Me.Controls.Add(Me.lblFolio)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegVenta"
        Me.Text = "Venta"
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private DTClientes As DataTable
    Private DTArticulos As DataTable
    Private DTVentaDet As DataTable

    Private Guardada As Boolean
    Private TasaFin As Double
    Private PlazoMax As Integer
    Private PorcEnganche As Double
    Private Subtotal As Decimal, Enganche As Decimal, Bonificacion As Decimal, Total As Decimal

    Private Function CargarConfiguracion() As Boolean
        Dim bRes As Boolean = False
        Try
            Using cCon = New SQLiteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SQLiteCommand = cCon.CreateCommand()
                oComm.CommandText = "SELECT TasaFin, PorcEnganche, PlazoMax FROM Configuracion LIMIT 1"
                Using oRead As SQLiteDataReader = oComm.ExecuteReader()
                    If oRead.HasRows Then
                        oRead.Read()
                        'SE cargan los datos
                        TasaFin = oRead.Item("TasaFin")
                        PorcEnganche = oRead.Item("PorcEnganche")
                        PlazoMax = oRead.Item("PlazoMax")
                        bRes = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            ShowErr(ex)
        End Try
        Return bRes
    End Function

    Protected Overrides Function Cambios() As Boolean
        Dim bRes As Boolean

        bRes = dgvArticulos.RowCount > 0
        'Si ha y total se toma como que hay cambios
        bRes = bRes OrElse CDec(lblTotal.Text) > 0
        bRes = bRes And Not Guardada
        'bRes = Comparar(txtDescripcion.Text, txtDescripcion.Tag) <> 0
        'bRes = bRes Or Comparar(txtModelo.Text, txtModelo.Tag) <> 0
        'bRes = bRes Or Comparar(nudPrecio.Value, nudPrecio.Tag) <> 0
        'bRes = bRes Or Comparar(nudExistencia.Value, nudExistencia.Tag) <> 0
        Return bRes
    End Function

    Private Function CargarDatos() As Boolean
        Dim bRes As Boolean = False

        Try
            Dim ListaClientes As New AutoCompleteStringCollection()
            Dim ListaArticulos As New AutoCompleteStringCollection()
            Guardada = False
            'Se obtiene el folio a mostrar de la nueva venta
            lblFolio.Text = "Folio: 00000"
            Using cCon = New SQLiteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SQLiteCommand = cCon.CreateCommand()
                oComm.CommandText = "SELECT Folio + 1 AS Folio FROM VentasCab ORDER BY Folio DESC LIMIT 1"
                Using oRead As SQLiteDataReader = oComm.ExecuteReader()
                    If oRead.HasRows Then
                        While oRead.Read()
                            'SE cargan los datos
                            lblFolio.Text = $"Folio: {oRead.Item("Folio"):D5}"
                            bRes = True
                        End While
                    Else
                        lblFolio.Text = "Folio: 00001"
                    End If
                End Using
            End Using

            'Se cargan los datos de los clientes en el combo
            DTClientes = New DataTable
            DTClientes.Columns.Add("id", Type.GetType("System.Int32"))
            DTClientes.Columns.Add("Nombre", Type.GetType("System.String"))
            DTClientes.Columns.Add("RFC", Type.GetType("System.String"))
            cbClientes.DataSource = DTClientes
            cbClientes.DisplayMember = "Nombre"
            cbClientes.ValueMember = "id"
            'Fill table
            Using cCon = New SQLiteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SQLiteCommand = cCon.CreateCommand()
                oComm.CommandText = "SELECT id, Nombres || ' ' || Paterno || ' ' || Materno AS Nombre, RFC FROM Clientes ORDER BY Nombre"
                Using oRead As SQLiteDataReader = oComm.ExecuteReader()
                    DTClientes.Rows.Clear()
                    While oRead.Read()
                        Dim dr As DataRow = DTClientes.NewRow
                        'SE cargan los datos
                        dr.Item("id") = oRead.Item("id")
                        dr.Item("Nombre") = oRead.Item("Nombre")
                        ListaClientes.Add(oRead.Item("Nombre"))
                        dr.Item("RFC") = oRead.Item("RFC")
                        DTClientes.Rows.Add(dr)
                    End While
                End Using
            End Using

            cbClientes.AutoCompleteCustomSource = ListaClientes
            cbClientes.Refresh()

            'Se cargan los registros de los articulos en el combo
            DTArticulos = New DataTable
            DTArticulos.Columns.Add("id", Type.GetType("System.Int32"))
            DTArticulos.Columns.Add("Descripcion", Type.GetType("System.String"))
            DTArticulos.Columns.Add("Modelo", Type.GetType("System.String"))
            DTArticulos.Columns.Add("Precio", Type.GetType("System.Double"))
            DTArticulos.Columns.Add("Existencia", Type.GetType("System.Double"))
            cbArticulos.DataSource = DTArticulos
            cbArticulos.DisplayMember = "Descripcion"
            cbArticulos.ValueMember = "id"
            'Fill table
            Using cCon = New SQLiteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SQLiteCommand = cCon.CreateCommand()
                oComm.CommandText = "SELECT id, Descripcion, Modelo, Precio, Existencia FROM Articulos ORDER BY Descripcion"
                Using oRead As SQLiteDataReader = oComm.ExecuteReader()
                    DTArticulos.Rows.Clear()
                    While oRead.Read()
                        Dim dr As DataRow = DTArticulos.NewRow
                        'SE cargan los datos
                        dr.Item("id") = oRead.Item("id")
                        dr.Item("Descripcion") = oRead.Item("Descripcion")
                        ListaArticulos.Add(oRead.Item("Descripcion"))
                        dr.Item("Modelo") = oRead.Item("Modelo")
                        dr.Item("Precio") = oRead.Item("Precio")
                        dr.Item("Existencia") = oRead.Item("Existencia")
                        DTArticulos.Rows.Add(dr)
                    End While
                End Using
            End Using
            cbArticulos.AutoCompleteCustomSource = ListaArticulos
            cbArticulos.Refresh()

            'Detalle de la venta
            DTVentaDet = New DataTable
            DTVentaDet.Columns.Add("id", Type.GetType("System.Int32"))
            DTVentaDet.Columns.Add("Descripcion", Type.GetType("System.String"))
            DTVentaDet.Columns.Add("Modelo", Type.GetType("System.String"))
            DTVentaDet.Columns.Add("Cantidad", Type.GetType("System.Int32"))
            DTVentaDet.Columns.Add("Precio", Type.GetType("System.Double"))
            DTVentaDet.Columns.Add("Importe", Type.GetType("System.Double")).Expression = "Cantidad * Precio"
            DTVentaDet.Columns.Add("Existencia", Type.GetType("System.Double"))

            dgvArticulos.DataSource = DTVentaDet

            Dim ColImg As New DataGridViewImageColumn()

            ColImg.Image = My.Resources.delete_16px
            dgvArticulos.Columns.Add(ColImg)

            For Each col As DataGridViewColumn In dgvArticulos.Columns
                If col.Name = "Cantidad" Then
                    col.ReadOnly = False
                Else
                    col.ReadOnly = True
                End If
                If col.Name = "Precio" Then
                    col.DefaultCellStyle.Format = "#,##0.00"
                End If
                If col.Name = "Existencia" Then
                    col.Visible = False
                End If
                If col.Name = "Importe" Then
                    col.DefaultCellStyle.Format = "#,##0.00"
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                Else
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
            Next

            cbClientes.Text = String.Empty
            cbArticulos.Text = String.Empty

            'If _id > 0 Then
            '    Using cCon = New SQLiteConnection("Data Source=My.db")
            '        cCon.Open()
            '        Dim oComm As SQLiteCommand = cCon.CreateCommand()
            '        oComm.CommandText = "SELECT Descripcion, Modelo, Precio, Existencia FROM Articulos WHERE id = $id LIMIT 1"
            '        oComm.Parameters.AddWithValue("$id", _id)
            '        Using oRead As SQLiteDataReader = oComm.ExecuteReader()
            '            While oRead.Read()
            '                'SE cargan los datos
            '                txtDescripcion.Text = oRead.Item("Descripcion")
            '                txtModelo.Text = oRead.Item("Modelo")
            '                nudPrecio.Value = oRead.Item("Precio")
            '                nudExistencia.Value = oRead.Item("Existencia")
            '                lblFolio.Text = String.Format("Folio: {0}", _id.ToString("0000"))
            '                bRes = True
            '            End While
            '        End Using
            '    End Using
            'Else
            '    bRes = True
            'End If
        Catch ex As Exception
            ShowErr(ex)
        End Try
        Return bRes
    End Function

    Protected Overrides Function Validar() As Boolean
        Dim bRes As Boolean = True
        Try
            dgvArticulos.EndEdit()

            If cbClientes.SelectedIndex < 0 Then
                bRes = False
                cbClientes.Focus()
                MessageBox.Show("Seleccione un cliente por favor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If

            If dgvArticulos.RowCount = 0 Then
                bRes = False
                dgvArticulos.Focus()
                MessageBox.Show("No hay artículos capturados", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If

            For Each drA As DataRow In DTVentaDet.Rows
                If IsDBNull(drA.Item("Cantidad")) OrElse drA.Item("Cantidad") = 0 Then
                    bRes = False
                    dgvArticulos.Focus()
                    MessageBox.Show("Hay artículos capturados con cantidad cero o vacia, revise por favor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Try
                End If
            Next

            If Not (rb3meses.Checked Or rb6meses.Checked Or rb9meses.Checked Or rb12meses.Checked) Then
                bRes = False
                MessageBox.Show("Debe de seleccionar una opción de mensualidades", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If

            'If Comparar(nudExistencia.Value, 0) = 0 Then
            '    bRes = False
            '    nudExistencia.Focus()
            '    MessageBox.Show("El campo de existencia no puede ser cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Exit Try
            'End If
        Catch ex As Exception
            ShowErr(ex)
        End Try
        Return bRes
    End Function

    Protected Overrides Function GuardarCambios() As Boolean
        Dim bRes As Boolean = False
        'Dim nId As Integer
        Dim nTotal As Decimal
        Dim nCliente As Integer
        Try
            Using cCon = New SQLiteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SQLiteCommand = cCon.CreateCommand()
                'oComm.CommandText = "SELECT Folio FROM VentasCab WHERE Folio = $id LIMIT 1"
                'oComm.Parameters.AddWithValue("$id", _id)
                'Using oRead As SQLiteDataReader = oComm.ExecuteReader()
                '    bFilas = oRead.HasRows
                '    If oRead.Read() Then nId = oRead.Item("id")
                'End Using

                'oComm.Parameters.Clear()
                'If bFilas Then
                '    oComm.CommandText = "UPDATE VentasCab SET Total = $Tot WHERE Folio = $id"
                '    oComm.Parameters.AddWithValue("$id", nId)
                '    oComm.Parameters.AddWithValue("$Tot", CDec(lblTotal.Text))
                'Else
                nCliente = cbClientes.SelectedValue

                If rb3meses.Checked Then nTotal = rb3meses.Tag
                If rb6meses.Checked Then nTotal = rb6meses.Tag
                If rb9meses.Checked Then nTotal = rb9meses.Tag
                If rb12meses.Checked Then nTotal = rb12meses.Tag

                oComm.CommandText = "INSERT INTO VentasCab (Cliente, TasaFin, PorcEnganche, Plazo, Subtotal, Bonificacion, Total, Fecha) VALUES ($Cli, $Tas, $Por, $Pla, $Sub, $Bon, $Tot, $Fec)"
                oComm.Parameters.AddWithValue("$Cli", nCliente)
                oComm.Parameters.AddWithValue("$Tas", TasaFin)
                oComm.Parameters.AddWithValue("$Por", Enganche)
                oComm.Parameters.AddWithValue("$Pla", PlazoMax)
                oComm.Parameters.AddWithValue("$Sub", Subtotal)
                oComm.Parameters.AddWithValue("$Bon", Bonificacion)
                oComm.Parameters.AddWithValue("$Tot", nTotal)
                oComm.Parameters.AddWithValue("$Fec", Date.Now)
                'End If
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

    'Protected Overrides Sub RevertChanges()
    '    txtDescripcion.Text = txtDescripcion.Tag
    '    txtModelo.Text = txtModelo.Tag
    '    nudPrecio.Value = nudPrecio.Tag
    '    nudPrecio.Value = nudExistencia.Tag
    'End Sub

    'Protected Overrides Sub CommitChanges()
    '    txtDescripcion.Tag = txtDescripcion.Text
    '    txtModelo.Tag = txtModelo.Text
    '    nudPrecio.Tag = nudPrecio.Value
    '    nudExistencia.Tag = nudExistencia.Value
    'End Sub

    Private Sub RegVenta_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not CargarConfiguracion() Then
            MessageBox.Show("No se pudo cargar los datos de configuración, la ventana se cerrará", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End If
        CargarDatos()
        CalcularMensualidades()
        CommitChanges()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CommitChanges()
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Guardar() Then
            Guardada = True
            Me.DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub cbClientes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbClientes.SelectedValueChanged
        'Se asigna el rfc a la etiqueta
        If Not cbClientes.SelectedValue Is Nothing Then
            lblRFC.Text = String.Format("RFC: {0}", DTClientes.Select(String.Format("id = {0}", cbClientes.SelectedValue))(0).Item("RFC"))
        Else
            lblRFC.Text = "RFC:"
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim dr As DataRow
        'Validar que se haya seleccionado un articulo
        If cbArticulos.SelectedValue Is Nothing Then
            cbArticulos.Focus()
            MessageBox.Show("Debe seleccionar un articulo para agregar a la venta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'Buscar los datos del articulo para agregarlo al grid
        dr = DTArticulos.Select(String.Format("id = {0}", cbArticulos.SelectedValue))(0)

        'Verifica existencia disponible
        If dr.Item("Existencia") <= 0 Then
            cbArticulos.Focus()
            MessageBox.Show("El articulo seleccionado no cuenta con existencia, verifique por favor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Verificar si ya existe el articulo para ignorarlo
        If DTVentaDet.Select(String.Format("id = {0}", dr.Item("id"))).Count > 0 Then
            Exit Sub
        End If

        Dim drN As DataRow = DTVentaDet.NewRow()
        drN.Item("id") = dr.Item("id")
        drN.Item("Descripcion") = dr.Item("Descripcion")
        drN.Item("Modelo") = dr.Item("Modelo")
        drN.Item("Cantidad") = 1
        drN.Item("Precio") = dr.Item("Precio") * (1 + (TasaFin * PlazoMax / 100))
        drN.Item("Existencia") = dr.Item("Existencia")

        DTVentaDet.Rows.Add(drN)
        dgvArticulos.Refresh()
        CalcularTotales()
        CalcularMensualidades()

        cbArticulos.Text = String.Empty
        cbArticulos.Focus()
    End Sub

    Private Sub CalcularTotales()
        Try
            Subtotal = 0
            For Each R As DataRow In DTVentaDet.Rows
                Subtotal += R.Item("Importe")
            Next
            Enganche = Subtotal * (PorcEnganche / 100)
            Bonificacion = Enganche * (TasaFin * PlazoMax / 100)
            Total = Subtotal - Enganche - Bonificacion

            lblEnganche.Text = Enganche.ToString("#,##0.00")
            lblBonificacion.Text = Bonificacion.ToString("#,##0.00")
            lblTotal.Text = Total.ToString("#,##0.00")
        Catch ex As Exception
            ShowErr(ex)
        End Try
    End Sub

    Private Sub CalcularMensualidades()
        Dim Contado As Decimal
        Dim TotalParcial As Decimal, Abono As Decimal, Ahorro As Decimal
        Dim TextoAbono, TextoTotal, TextoAhorro As String
        Try
            Contado = Total / (1 + (TasaFin * PlazoMax / 100))

            'Calculo de 3 meses
            TotalParcial = Contado * (1 + (TasaFin * 3 / 100))
            Abono = TotalParcial / 3
            Ahorro = Total - TotalParcial
            TextoAbono = $"3 ABONOS DE {Abono:$#,##0.00}".PadRight(40)
            TextoTotal = $"TOTAL A PAGAR {TotalParcial:$#,##0.00}".PadRight(40)
            TextoAhorro = $"SE AHORRA {Ahorro:$#,##0.00}".PadRight(25)
            rb3meses.Text = TextoAbono + TextoTotal + TextoAhorro
            rb3meses.Tag = TotalParcial

            'Calculo de 6 meses
            TotalParcial = Contado * (1 + (TasaFin * 6 / 100))
            Abono = TotalParcial / 6
            Ahorro = Total - TotalParcial
            TextoAbono = $"6 ABONOS DE {Abono:$#,##0.00}".PadRight(40)
            TextoTotal = $"TOTAL A PAGAR {TotalParcial:$#,##0.00}".PadRight(40)
            TextoAhorro = $"SE AHORRA {Ahorro:$#,##0.00}".PadRight(25)
            rb6meses.Text = TextoAbono + TextoTotal + TextoAhorro
            rb6meses.Tag = TotalParcial

            'Calculo de 9 meses
            TotalParcial = Contado * (1 + (TasaFin * 9 / 100))
            Abono = TotalParcial / 9
            Ahorro = Total - TotalParcial
            TextoAbono = $"9 ABONOS DE {Abono:$#,##0.00}".PadRight(40)
            TextoTotal = $"TOTAL A PAGAR {TotalParcial:$#,##0.00}".PadRight(40)
            TextoAhorro = $"SE AHORRA {Ahorro:$#,##0.00}".PadRight(25)
            rb9meses.Text = TextoAbono + TextoTotal + TextoAhorro
            rb9meses.Tag = TotalParcial

            'Calculo de 12 meses
            TotalParcial = Contado * (1 + (TasaFin * 12 / 100))
            Abono = TotalParcial / 12
            Ahorro = Total - TotalParcial
            TextoAbono = $"12 ABONOS DE {Abono:$#,##0.00}".PadRight(40)
            TextoTotal = $"TOTAL A PAGAR {TotalParcial:$#,##0.00}".PadRight(40)
            TextoAhorro = $"SE AHORRA {Ahorro:$#,##0.00}".PadRight(25)
            rb12meses.Text = TextoAbono + TextoTotal + TextoAhorro
            rb12meses.Tag = TotalParcial

        Catch ex As Exception
            ShowErr(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CalcularTotales()
        CalcularMensualidades()
        Timer1.Enabled = False
    End Sub

    Private Sub dgvArticulos_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvArticulos.CellValidating
        If dgvArticulos.Columns.Item(e.ColumnIndex).Name <> "Cantidad" Then Exit Sub
        If Not IsNumeric(dgvArticulos.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue) Then
            MessageBox.Show("El valor debe de ser un número", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
            Exit Sub
        End If
        CalcularTotales()
        CalcularMensualidades()
    End Sub

    Private Sub dgvArticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellClick
        If e.ColumnIndex = dgvArticulos.Columns.Count - 1 Then
            dgvArticulos.Rows.Remove(dgvArticulos.Rows.Item(e.RowIndex))

        End If
    End Sub

    Private Sub dgvArticulos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvArticulos.RowsRemoved
        Timer1.Enabled = True
    End Sub
End Class
