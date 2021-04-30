<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
    Inherits LaVendimia.VentanaBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpVentas = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.btnNuevaVenta = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tpClientes = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.tpArticulos = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEliminarArticulo = New System.Windows.Forms.Button()
        Me.btnEditarArticulo = New System.Windows.Forms.Button()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.btnNuevoArticulo = New System.Windows.Forms.Button()
        Me.tpConfiguracion = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGuardarConfig = New System.Windows.Forms.Button()
        Me.btnCancelarConfig = New System.Windows.Forms.Button()
        Me.nudPlazoMax = New System.Windows.Forms.NumericUpDown()
        Me.nudPorcEnganche = New System.Windows.Forms.NumericUpDown()
        Me.nudTasaFin = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tpVentas.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpClientes.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpArticulos.SuspendLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpConfiguracion.SuspendLayout()
        CType(Me.nudPlazoMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPorcEnganche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTasaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TableLayoutPanel1.SetColumnSpan(Me.TabControl1, 2)
        Me.TabControl1.Controls.Add(Me.tpVentas)
        Me.TabControl1.Controls.Add(Me.tpClientes)
        Me.TabControl1.Controls.Add(Me.tpArticulos)
        Me.TabControl1.Controls.Add(Me.tpConfiguracion)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(3, 33)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(794, 414)
        Me.TabControl1.TabIndex = 0
        '
        'tpVentas
        '
        Me.tpVentas.Controls.Add(Me.Label4)
        Me.tpVentas.Controls.Add(Me.dgvVentas)
        Me.tpVentas.Controls.Add(Me.btnNuevaVenta)
        Me.tpVentas.ImageIndex = 1
        Me.tpVentas.Location = New System.Drawing.Point(31, 4)
        Me.tpVentas.Name = "tpVentas"
        Me.tpVentas.Padding = New System.Windows.Forms.Padding(3)
        Me.tpVentas.Size = New System.Drawing.Size(759, 406)
        Me.tpVentas.TabIndex = 0
        Me.tpVentas.ToolTipText = "Ventas"
        Me.tpVentas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ventas"
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen
        Me.dgvVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvVentas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(3, 41)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.RowTemplate.Height = 25
        Me.dgvVentas.Size = New System.Drawing.Size(751, 360)
        Me.dgvVentas.TabIndex = 1
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevaVenta.ImageIndex = 0
        Me.btnNuevaVenta.ImageList = Me.ImageList1
        Me.btnNuevaVenta.Location = New System.Drawing.Point(654, 3)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Size = New System.Drawing.Size(100, 32)
        Me.btnNuevaVenta.TabIndex = 0
        Me.btnNuevaVenta.Text = "Nueva"
        Me.btnNuevaVenta.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add_32px.png")
        Me.ImageList1.Images.SetKeyName(1, "buying_32px.png")
        Me.ImageList1.Images.SetKeyName(2, "customer_32px.png")
        Me.ImageList1.Images.SetKeyName(3, "price_tag_32px.png")
        Me.ImageList1.Images.SetKeyName(4, "product_32px.png")
        Me.ImageList1.Images.SetKeyName(5, "settings_32px.png")
        Me.ImageList1.Images.SetKeyName(6, "edit_32px.png")
        Me.ImageList1.Images.SetKeyName(7, "delete_32px.png")
        '
        'tpClientes
        '
        Me.tpClientes.Controls.Add(Me.Label5)
        Me.tpClientes.Controls.Add(Me.btnEliminarCliente)
        Me.tpClientes.Controls.Add(Me.btnEditarCliente)
        Me.tpClientes.Controls.Add(Me.btnNuevoCliente)
        Me.tpClientes.Controls.Add(Me.dgvClientes)
        Me.tpClientes.ImageIndex = 2
        Me.tpClientes.Location = New System.Drawing.Point(31, 4)
        Me.tpClientes.Name = "tpClientes"
        Me.tpClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpClientes.Size = New System.Drawing.Size(759, 406)
        Me.tpClientes.TabIndex = 1
        Me.tpClientes.ToolTipText = "Clientes"
        Me.tpClientes.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Clientes"
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarCliente.ImageIndex = 7
        Me.btnEliminarCliente.ImageList = Me.ImageList1
        Me.btnEliminarCliente.Location = New System.Drawing.Point(654, 99)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(100, 32)
        Me.btnEliminarCliente.TabIndex = 3
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        Me.btnEliminarCliente.Visible = False
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarCliente.ImageIndex = 6
        Me.btnEditarCliente.ImageList = Me.ImageList1
        Me.btnEditarCliente.Location = New System.Drawing.Point(654, 61)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(100, 32)
        Me.btnEditarCliente.TabIndex = 2
        Me.btnEditarCliente.Text = "Editar"
        Me.btnEditarCliente.UseVisualStyleBackColor = True
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoCliente.ImageIndex = 0
        Me.btnNuevoCliente.ImageList = Me.ImageList1
        Me.btnNuevoCliente.Location = New System.Drawing.Point(654, 23)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(100, 32)
        Me.btnNuevoCliente.TabIndex = 1
        Me.btnNuevoCliente.Text = "Nuevo"
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeRows = False
        Me.dgvClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(3, 23)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.RowTemplate.Height = 25
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(639, 372)
        Me.dgvClientes.TabIndex = 0
        '
        'tpArticulos
        '
        Me.tpArticulos.Controls.Add(Me.Label6)
        Me.tpArticulos.Controls.Add(Me.btnEliminarArticulo)
        Me.tpArticulos.Controls.Add(Me.btnEditarArticulo)
        Me.tpArticulos.Controls.Add(Me.dgvArticulos)
        Me.tpArticulos.Controls.Add(Me.btnNuevoArticulo)
        Me.tpArticulos.ImageIndex = 4
        Me.tpArticulos.Location = New System.Drawing.Point(31, 4)
        Me.tpArticulos.Name = "tpArticulos"
        Me.tpArticulos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpArticulos.Size = New System.Drawing.Size(759, 406)
        Me.tpArticulos.TabIndex = 2
        Me.tpArticulos.ToolTipText = "Artículos"
        Me.tpArticulos.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Artículos"
        '
        'btnEliminarArticulo
        '
        Me.btnEliminarArticulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarArticulo.ImageIndex = 7
        Me.btnEliminarArticulo.ImageList = Me.ImageList1
        Me.btnEliminarArticulo.Location = New System.Drawing.Point(654, 99)
        Me.btnEliminarArticulo.Name = "btnEliminarArticulo"
        Me.btnEliminarArticulo.Size = New System.Drawing.Size(100, 32)
        Me.btnEliminarArticulo.TabIndex = 5
        Me.btnEliminarArticulo.Text = "Eliminar"
        Me.btnEliminarArticulo.UseVisualStyleBackColor = True
        Me.btnEliminarArticulo.Visible = False
        '
        'btnEditarArticulo
        '
        Me.btnEditarArticulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarArticulo.ImageIndex = 6
        Me.btnEditarArticulo.ImageList = Me.ImageList1
        Me.btnEditarArticulo.Location = New System.Drawing.Point(654, 61)
        Me.btnEditarArticulo.Name = "btnEditarArticulo"
        Me.btnEditarArticulo.Size = New System.Drawing.Size(100, 32)
        Me.btnEditarArticulo.TabIndex = 4
        Me.btnEditarArticulo.Text = "Editar"
        Me.btnEditarArticulo.UseVisualStyleBackColor = True
        '
        'dgvArticulos
        '
        Me.dgvArticulos.AllowUserToAddRows = False
        Me.dgvArticulos.AllowUserToDeleteRows = False
        Me.dgvArticulos.AllowUserToResizeRows = False
        Me.dgvArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Location = New System.Drawing.Point(3, 23)
        Me.dgvArticulos.MultiSelect = False
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.ReadOnly = True
        Me.dgvArticulos.RowHeadersVisible = False
        Me.dgvArticulos.RowTemplate.Height = 25
        Me.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArticulos.Size = New System.Drawing.Size(640, 378)
        Me.dgvArticulos.TabIndex = 3
        '
        'btnNuevoArticulo
        '
        Me.btnNuevoArticulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevoArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoArticulo.ImageIndex = 0
        Me.btnNuevoArticulo.ImageList = Me.ImageList1
        Me.btnNuevoArticulo.Location = New System.Drawing.Point(654, 23)
        Me.btnNuevoArticulo.Name = "btnNuevoArticulo"
        Me.btnNuevoArticulo.Size = New System.Drawing.Size(100, 32)
        Me.btnNuevoArticulo.TabIndex = 2
        Me.btnNuevoArticulo.Text = "Nuevo"
        Me.btnNuevoArticulo.UseVisualStyleBackColor = True
        '
        'tpConfiguracion
        '
        Me.tpConfiguracion.Controls.Add(Me.Label7)
        Me.tpConfiguracion.Controls.Add(Me.btnGuardarConfig)
        Me.tpConfiguracion.Controls.Add(Me.btnCancelarConfig)
        Me.tpConfiguracion.Controls.Add(Me.nudPlazoMax)
        Me.tpConfiguracion.Controls.Add(Me.nudPorcEnganche)
        Me.tpConfiguracion.Controls.Add(Me.nudTasaFin)
        Me.tpConfiguracion.Controls.Add(Me.Label3)
        Me.tpConfiguracion.Controls.Add(Me.Label2)
        Me.tpConfiguracion.Controls.Add(Me.Label1)
        Me.tpConfiguracion.ImageIndex = 5
        Me.tpConfiguracion.Location = New System.Drawing.Point(31, 4)
        Me.tpConfiguracion.Name = "tpConfiguracion"
        Me.tpConfiguracion.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConfiguracion.Size = New System.Drawing.Size(759, 406)
        Me.tpConfiguracion.TabIndex = 3
        Me.tpConfiguracion.ToolTipText = "Configuración"
        Me.tpConfiguracion.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Configuración"
        '
        'btnGuardarConfig
        '
        Me.btnGuardarConfig.Location = New System.Drawing.Point(247, 180)
        Me.btnGuardarConfig.Name = "btnGuardarConfig"
        Me.btnGuardarConfig.Size = New System.Drawing.Size(100, 34)
        Me.btnGuardarConfig.TabIndex = 9
        Me.btnGuardarConfig.Text = "Guardar"
        Me.btnGuardarConfig.UseVisualStyleBackColor = True
        '
        'btnCancelarConfig
        '
        Me.btnCancelarConfig.Location = New System.Drawing.Point(141, 180)
        Me.btnCancelarConfig.Name = "btnCancelarConfig"
        Me.btnCancelarConfig.Size = New System.Drawing.Size(100, 34)
        Me.btnCancelarConfig.TabIndex = 8
        Me.btnCancelarConfig.Text = "Cancelar"
        Me.btnCancelarConfig.UseVisualStyleBackColor = True
        '
        'nudPlazoMax
        '
        Me.nudPlazoMax.Location = New System.Drawing.Point(142, 105)
        Me.nudPlazoMax.Name = "nudPlazoMax"
        Me.nudPlazoMax.Size = New System.Drawing.Size(80, 23)
        Me.nudPlazoMax.TabIndex = 6
        '
        'nudPorcEnganche
        '
        Me.nudPorcEnganche.DecimalPlaces = 2
        Me.nudPorcEnganche.Location = New System.Drawing.Point(142, 76)
        Me.nudPorcEnganche.Name = "nudPorcEnganche"
        Me.nudPorcEnganche.Size = New System.Drawing.Size(80, 23)
        Me.nudPorcEnganche.TabIndex = 5
        '
        'nudTasaFin
        '
        Me.nudTasaFin.DecimalPlaces = 2
        Me.nudTasaFin.Location = New System.Drawing.Point(142, 45)
        Me.nudTasaFin.Name = "nudTasaFin"
        Me.nudTasaFin.Size = New System.Drawing.Size(80, 23)
        Me.nudTasaFin.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Plazo Max."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "% Enganche}"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tasa Financiamiento"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTitulo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFecha, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitulo.ImageIndex = 3
        Me.lblTitulo.ImageList = Me.ImageList1
        Me.lblTitulo.Location = New System.Drawing.Point(3, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(394, 30)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFecha.Location = New System.Drawing.Point(403, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(394, 30)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha:"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "frmInicio"
        Me.Text = "La Vendimia"
        Me.TabControl1.ResumeLayout(False)
        Me.tpVentas.ResumeLayout(False)
        Me.tpVentas.PerformLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpClientes.ResumeLayout(False)
        Me.tpClientes.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpArticulos.ResumeLayout(False)
        Me.tpArticulos.PerformLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpConfiguracion.ResumeLayout(False)
        Me.tpConfiguracion.PerformLayout()
        CType(Me.nudPlazoMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPorcEnganche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTasaFin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpVentas As TabPage
    Friend WithEvents tpClientes As TabPage
    Friend WithEvents tpArticulos As TabPage
    Friend WithEvents tpConfiguracion As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents btnNuevaVenta As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudPlazoMax As NumericUpDown
    Friend WithEvents nudPorcEnganche As NumericUpDown
    Friend WithEvents nudTasaFin As NumericUpDown
    Friend WithEvents btnGuardarConfig As Button
    Friend WithEvents btnCancelarConfig As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents dgvArticulos As DataGridView
    Friend WithEvents btnNuevoArticulo As Button
    Friend WithEvents btnEliminarArticulo As Button
    Friend WithEvents btnEditarArticulo As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnEditarCliente As Button
    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
