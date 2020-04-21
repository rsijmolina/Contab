Public Class ListaDataNavBar
    Private _BindingSourcePrincipal As BindingSource
    Property BindingSourcePrincipal() As BindingSource
        Get
            BindingSourcePrincipal = _BindingSourcePrincipal
        End Get
        Set(ByVal value As BindingSource)
            _BindingSourcePrincipal = value
        End Set
    End Property
    Private _lblBUscarDirectamente As String
    Public Property lblBuscarDirectamente() As String
        Get
            Return _lblBUscarDirectamente
        End Get
        Set(ByVal value As String)
            _lblBUscarDirectamente = value
            Me.ToolStripLabelBuscar.Text = value
        End Set
    End Property
    Private _txtBuscarDirectamente As String
    Public Property txtBuscarDirectamente() As String
        Get
            Return _txtBuscarDirectamente
        End Get
        Set(ByVal value As String)
            _txtBuscarDirectamente = value
            ToolStripTextBoxBuscar.Text = value
        End Set
    End Property
    Private _BotonEliminarVisible As Boolean
    Public Property BotonEliminarVisible() As Boolean
        Get
            Return _BotonEliminarVisible
        End Get
        Set(ByVal value As Boolean)
            _BotonEliminarVisible = value
            ToolStripButtonEliminar.Visible = value
        End Set
    End Property
    Private _BotonEditarVisible As Boolean
    Public Property BotonEditarVisible() As Boolean
        Get
            Return _BotonEditarVisible
        End Get
        Set(ByVal value As Boolean)
            _BotonEditarVisible = value
            ToolStripButtonEditar.Visible = value
        End Set
    End Property
    Private _BotonNuevoVisible As Boolean
    Public Property BotonNuevoVisible() As Boolean
        Get
            Return _BotonNuevoVisible
        End Get
        Set(ByVal value As Boolean)
            _BotonNuevoVisible = value
            ToolStripButtonNuevo.Visible = value
        End Set
    End Property
    Private _NoRegs As Int32
    Public Property NoRegs() As String
        Get
            Return _NoRegs
        End Get
        Set(ByVal value As String)
            _NoRegs = value
            ToolStripLabelNoRegistros.Text = value
        End Set
    End Property

    Public Event NuevoRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EditarRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ConsultarRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event RecargarDatosClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EliminarRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event SalirClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event BuscarDirectamenteClick(ByVal sender As Object, ByVal e As EventArgs)
    Private Sub ListaDataNavBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsNothing(BindingSourcePrincipal) Then
            If BindingSourcePrincipal.Count > 0 Then
                HabilitarTodosBotones()
            Else
                HabilitarSoloBotonNuevo()
            End If
        End If
    End Sub
    Public Sub HabilitarSoloBotonNuevo()
        ToolStripButtonNuevo.Visible = True
        ToolStripButtonNuevo.Enabled = True
        ToolStripButtonEditar.Enabled = False
        ToolStripButtonConsultar.Enabled = False
        ToolStripButtonRecargar.Enabled = False
        ToolStripButtonEliminar.Enabled = False
    End Sub
    Public Sub HabilitarTodosBotones()
        ToolStripButtonNuevo.Enabled = True
        ToolStripButtonEditar.Enabled = True
        ToolStripButtonConsultar.Enabled = True
        ToolStripButtonRecargar.Enabled = True
        ToolStripButtonEliminar.Enabled = True
    End Sub

    Private Sub ToolStripButtonNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNuevo.Click
        RaiseEvent NuevoRegistroClick(Me, e)
    End Sub

    Private Sub ToolStripButtonEditar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEditar.Click
        RaiseEvent EditarRegistroClick(Me, e)
    End Sub

    Private Sub ToolStripButtonConsultar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonConsultar.Click
        RaiseEvent ConsultarRegistroClick(Me, e)
    End Sub

    Private Sub ToolStripButtonEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEliminar.Click
        RaiseEvent EliminarRegistroClick(Me, e)
    End Sub

    Private Sub ToolStripButtonRecargar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRecargar.Click
        RaiseEvent RecargarDatosClick(Me, e)
        ToolStripLabelNoRegistros.Text = BindingSourcePrincipal.Count
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSalir.Click
        RaiseEvent SalirClick(Me, e)
    End Sub

    Private Sub ToolStripButtonBuscarDirectamente_Click(sender As Object, e As EventArgs)
        RaiseEvent BuscarDirectamenteClick(Me, e)
    End Sub

    Private Sub ToolStripTextBoxBuscar_LostFocus(sender As Object, e As EventArgs) Handles ToolStripTextBoxBuscar.LostFocus
        If ToolStripTextBoxBuscar.Text.Length > 0 Then
            txtBuscarDirectamente = ToolStripTextBoxBuscar.Text
        Else
            txtBuscarDirectamente = ""
        End If
    End Sub

End Class
