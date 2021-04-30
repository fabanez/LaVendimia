Imports System.Data.SQLite
Public Class frmInicio

    Private ConfigInit As Boolean
    Dim DTVentas As DataTable
    Dim DTClientes As DataTable
    Dim DTArticulos As DataTable

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Try
            DTVentas = New DataTable
            DTClientes = New DataTable
            DTArticulos = New DataTable

            DTClientes.Columns.Add("id", Type.GetType("System.Int32"))
            DTClientes.Columns.Add("Nombres", Type.GetType("System.String"))
            DTClientes.Columns.Add("Paterno", Type.GetType("System.String"))
            DTClientes.Columns.Add("Materno", Type.GetType("System.String"))
            DTClientes.Columns.Add("RFC", Type.GetType("System.String"))

            DTArticulos.Columns.Add("id", Type.GetType("System.Int32"))
            DTArticulos.Columns.Add("Descripcion", Type.GetType("System.String"))
            DTArticulos.Columns.Add("Modelo", Type.GetType("System.String"))
            DTArticulos.Columns.Add("Precio", Type.GetType("System.Double"))
            DTArticulos.Columns.Add("Existencia", Type.GetType("System.Double"))

            DTVentas.Columns.Add("Folio", Type.GetType("System.Int32"))
            DTVentas.Columns.Add("Clave", Type.GetType("System.Int32"))
            DTVentas.Columns.Add("Cliente", Type.GetType("System.String"))
            DTVentas.Columns.Add("Total", Type.GetType("System.Double"))
            DTVentas.Columns.Add("Fecha", Type.GetType("System.DateTime"))
        Catch ex As Exception
            ShowErr(ex)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblTitulo.Text = "      " + Me.Text
        lblFecha.Text = String.Format("Fecha: {0}", Date.Now.Date.ToString("dd/MMM/yyyy"))

        'Revisar si en la configuracion no hay registro para llmar a configuración y registrar uno
        ConfiguracionInicial()

        ListarClientes()
        ListarArticulos()
        ListarVentas()
    End Sub

#Region "General"

#End Region

#Region "Ventas"
    Private Sub ListarVentas()
        Try
            dgvVentas.DataSource = DTVentas
            dgvVentas.Columns.Item("Folio").DataPropertyName = "Folio"
            dgvVentas.Columns.Item("Clave").DataPropertyName = "Clave"
            dgvVentas.Columns.Item("Cliente").DataPropertyName = "Cliente"
            dgvVentas.Columns.Item("Total").DataPropertyName = "Total"
            dgvVentas.Columns.Item("Total").DefaultCellStyle.Format = "#,##0.00"
            dgvVentas.Columns.Item("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvVentas.Columns.Item("Fecha").DataPropertyName = "Fecha"
            dgvVentas.Columns.Item("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            'Fill table
            Using cCon = New SQLiteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SQLiteCommand = cCon.CreateCommand()
                oComm.CommandText = "SELECT VentasCab.Folio, VentasCab.Cliente AS Clave, Clientes.Nombres || ' ' || Clientes.Paterno || ' ' || Clientes.Materno AS Cliente, VentasCab.Total, VentasCab.Fecha " _
                    & "FROM VentasCab INNER JOIN Clientes ON Clientes.id = VentasCab.Cliente ORDER BY VentasCab.Folio"
                Using oRead As SQLiteDataReader = oComm.ExecuteReader()
                    DTVentas.Rows.Clear()
                    While oRead.Read()
                        Dim dr As DataRow = DTVentas.NewRow
                        'SE cargan los datos
                        dr.Item("Folio") = oRead.Item("Folio")
                        dr.Item("Clave") = oRead.Item("Clave")
                        dr.Item("Cliente") = oRead.Item("Cliente")
                        dr.Item("Total") = oRead.Item("Total")
                        dr.Item("Fecha") = oRead.Item("Fecha")
                        DTVentas.Rows.Add(dr)

                    End While
                End Using
            End Using
            dgvVentas.Refresh()
        Catch ex As Exception
            ShowErr(ex)
        End Try
    End Sub
    Private Sub btnNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        Try
            Dim oRegVenta As New RegVenta(0)
            oRegVenta.ShowDialog(Me)
            ListarVentas()
        Catch ex As Exception
            ShowErr(ex)
        End Try
    End Sub
#End Region

#Region "Clientes"
    Private Sub ListarClientes()
        Try

            dgvClientes.DataSource = DTClientes
            dgvClientes.Columns.Item("id").DataPropertyName = "id"
            dgvClientes.Columns.Item("Nombres").DataPropertyName = "Nombres"
            dgvClientes.Columns.Item("Paterno").DataPropertyName = "Paterno"
            dgvClientes.Columns.Item("Materno").DataPropertyName = "Materno"
            dgvClientes.Columns.Item("RFC").DataPropertyName = "RFC"
            dgvClientes.Columns.Item("RFC").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            'Fill table
            Using cCon = New SQLiteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SQLiteCommand = cCon.CreateCommand()
                oComm.CommandText = "SELECT id, Nombres, Paterno, Materno, RFC FROM Clientes ORDER BY id"
                Using oRead As SQLiteDataReader = oComm.ExecuteReader()
                    DTClientes.Rows.Clear()
                    While oRead.Read()
                        Dim dr As DataRow = DTClientes.NewRow
                        'SE cargan los datos
                        dr.Item("id") = oRead.Item("id")
                        dr.Item("Nombres") = oRead.Item("Nombres")
                        dr.Item("Paterno") = oRead.Item("Paterno")
                        dr.Item("Materno") = oRead.Item("Materno")
                        dr.Item("RFC") = oRead.Item("RFC")
                        DTClientes.Rows.Add(dr)

                    End While
                End Using
            End Using
            dgvClientes.Refresh()
        Catch ex As Exception
            ShowErr(ex)
        End Try
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Try
            Dim oClientes As New CRUDCliente(0)
            oClientes.ShowDialog(Me)
            ListarClientes()
        Catch ex As Exception
            ShowErr(ex)
        End Try
    End Sub

    Private Sub btnEditarCliente_Click(sender As Object, e As EventArgs) Handles btnEditarCliente.Click
        Try
            If dgvClientes.RowCount = 0 Then Exit Sub
            Dim oClientes As New CRUDCliente(dgvClientes.SelectedRows().Item(0).Cells.Item("id").Value)
            oClientes.ShowDialog(Me)
            ListarClientes()
        Catch ex As Exception
            ShowErr(ex)
        End Try
    End Sub
#End Region

#Region "Articulos"
    Private Sub ListarArticulos()
        Try

            dgvArticulos.DataSource = DTArticulos
            dgvArticulos.Columns.Item("id").DataPropertyName = "id"
            dgvArticulos.Columns.Item("Descripcion").DataPropertyName = "Descripcion"
            dgvArticulos.Columns.Item("Modelo").DataPropertyName = "Modelo"
            dgvArticulos.Columns.Item("Precio").DataPropertyName = "Precio"
            dgvArticulos.Columns.Item("Precio").DefaultCellStyle.Format = "#,##0.00"
            dgvArticulos.Columns.Item("Precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvArticulos.Columns.Item("Existencia").DataPropertyName = "Existencia"
            dgvArticulos.Columns.Item("Existencia").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            'Fill table
            Using cCon = New SQLiteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SQLiteCommand = cCon.CreateCommand()
                oComm.CommandText = "SELECT id, Descripcion, Modelo, Precio, Existencia FROM Articulos ORDER BY id"
                Using oRead As SQLiteDataReader = oComm.ExecuteReader()
                    DTArticulos.Rows.Clear()
                    While oRead.Read()
                        Dim dr As DataRow = DTArticulos.NewRow
                        'SE cargan los datos
                        dr.Item("id") = oRead.Item("id")
                        dr.Item("Descripcion") = oRead.Item("Descripcion")
                        dr.Item("Modelo") = oRead.Item("Modelo")
                        dr.Item("Precio") = oRead.Item("Precio")
                        dr.Item("Existencia") = oRead.Item("Existencia")
                        DTArticulos.Rows.Add(dr)
                    End While
                End Using
            End Using
            dgvArticulos.Refresh()
        Catch ex As Exception
            ShowErr(ex)
        End Try
    End Sub
    Private Sub btnNuevoArticulo_Click(sender As Object, e As EventArgs) Handles btnNuevoArticulo.Click
        Try
            Dim oArticulos As New CRUDArticulo(0)
            oArticulos.ShowDialog(Me)
            ListarArticulos()
        Catch ex As Exception
            ShowErr(ex)
        End Try
    End Sub

    Private Sub btnEditarArticulo_Click(sender As Object, e As EventArgs) Handles btnEditarArticulo.Click
        Try
            If dgvArticulos.RowCount = 0 Then Exit Sub
            Dim oArticulos As New CRUDArticulo(dgvArticulos.SelectedRows().Item(0).Cells.Item("id").Value)
            oArticulos.ShowDialog(Me)
            ListarArticulos()
        Catch ex As Exception
            ShowErr(ex)
        End Try
    End Sub
#End Region

#Region "Configuración"

    Protected Overrides Function Cambios() As Boolean
        Dim bRes As Boolean
        bRes = Comparar(nudTasaFin.Value, nudTasaFin.Tag) <> 0
        bRes = bRes Or Comparar(nudPorcEnganche.Value, nudPorcEnganche.Tag) <> 0
        bRes = bRes Or Comparar(nudPlazoMax.Value, nudPlazoMax.Tag) <> 0
        Return bRes
    End Function

    Private Sub ConfiguracionInicial()
        If Not CargarConfiguracion() Then
            ConfigInit = True
            'Se llama al procedimiento para requerir la configuracion inicial
            PromptForConfig()

        End If
    End Sub

    Private Function CargarConfiguracion() As Boolean
        Dim bRes As Boolean = False
        Try
            Using cCon = New SqliteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SqliteCommand = cCon.CreateCommand()
                oComm.CommandText = "SELECT TasaFin, PorcEnganche, PlazoMax FROM Configuracion LIMIT 1"
                Using oRead As SQLiteDataReader = oComm.ExecuteReader()
                    If oRead.HasRows Then
                        oRead.Read()
                        'SE cargan los datos
                        nudTasaFin.Value = oRead.Item("TasaFin")
                        nudTasaFin.Tag = nudTasaFin.Value
                        nudPorcEnganche.Value = oRead.Item("PorcEnganche")
                        nudPorcEnganche.Tag = nudPorcEnganche.Value
                        nudPlazoMax.Value = oRead.Item("PlazoMax")
                        nudPlazoMax.Tag = nudPlazoMax.Value
                        bRes = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            ShowErr(ex)
        End Try
        Return bRes
    End Function

    Private Sub PromptForConfig()
        Try
            TabControl1.SelectTab(tpConfiguracion)
            nudTasaFin.Focus()
            MessageBox.Show("No se encontró información sobre la configuración, por favor proporcione los datos y despues guarde para continuar", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ShowErr(ex)
        End Try
    End Sub

    Protected Overrides Function Validar() As Boolean
        Dim bRes As Boolean = True
        If nudTasaFin.Value = 0 And nudPorcEnganche.Value = 0 And nudPlazoMax.Value = 0 Then
            bRes = False
            MessageBox.Show("Los parámetros de configuración no puede estar vacios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return bRes
    End Function

    Protected Overrides Function GuardarCambios() As Boolean
        Dim bRes As Boolean = False
        Try
            Using cCon = New SqliteConnection("Data Source=My.db")
                cCon.Open()
                Dim oComm As SqliteCommand = cCon.CreateCommand()
                oComm.CommandText = "SELECT * FROM Configuracion LIMIT 1"
                Dim oRead As SqliteDataReader = oComm.ExecuteReader()
                If oRead.HasRows Then
                    oRead.Close()
                    oComm.CommandText = "UPDATE Configuracion SET TasaFin = $TF, PorcEnganche = $PE, PlazoMax = $PM"
                    oComm.Parameters.AddWithValue("$TF", nudTasaFin.Value)
                    oComm.Parameters.AddWithValue("$PE", nudPorcEnganche.Value)
                    oComm.Parameters.AddWithValue("$PM", nudPlazoMax.Value)
                Else
                    oRead.Close()
                    oComm.CommandText = "INSERT INTO Configuracion (TasaFin, PorcEnganche, PlazoMax) VALUES ($TF, $PE, $PM)"
                    oComm.Parameters.AddWithValue("$TF", nudTasaFin.Value)
                    oComm.Parameters.AddWithValue("$PE", nudPorcEnganche.Value)
                    oComm.Parameters.AddWithValue("$PM", nudPlazoMax.Value)
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
        nudTasaFin.Value = nudTasaFin.Tag
        nudPorcEnganche.Value = nudPorcEnganche.Tag
        nudPlazoMax.Value = nudPlazoMax.Tag

    End Sub

    Protected Overrides Sub CommitChanges()
        ConfigInit = False
        nudTasaFin.Tag = nudTasaFin.Value
        nudPorcEnganche.Tag = nudPorcEnganche.Value
        nudPlazoMax.Tag = nudPlazoMax.Value
    End Sub

    Private Sub TabControl1_Deselecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Deselecting
        If e.TabPage.Name = tpConfiguracion.Name Then
            If ConfigInit Then
                MessageBox.Show("No se ha inicializado la configuración, revise por favor", "Inicialización de Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
                Exit Sub
            End If
            'revisar si hay cambios en la configuracion
            If Me.Cambios Then
                MessageBox.Show("Se han detectado cambios en la configuración, revise antes de salir de la configuración", "Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnCancelarConfig_Click(sender As Object, e As EventArgs) Handles btnCancelarConfig.Click
        If ConfigInit Then Exit Sub
        If Not Me.Cambios Then Exit Sub
        If MessageBox.Show("¿Esta seguro de que desea cancelar la captura de las configuraciones?", "Configuración", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        RevertChanges()
        TabControl1.SelectTab(tpVentas)
    End Sub

    Private Sub btnGuardarConfig_Click(sender As Object, e As EventArgs) Handles btnGuardarConfig.Click
        Guardar()
    End Sub

#End Region
End Class