Public Class CTPartidasListaFrm
    Dim ListaRegistrosAbiertos As New Collection
    Dim rsiCadCls As New Rsierpgencl.Rsierpcl.Cadenas
    Dim ctCls As New CTClassLib.CTClass
    Dim mFecha As Date
    Private Sub CTPartidasListaFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CTTransaccionesEncabezadoTableAdapter.Connection.ConnectionString = strcnCAD
        Me.Top = 10
        For i As Int16 = 1 To 12
            cmbMeses.Items.Add(rsiCadCls.MesLetras(i))
        Next
        mFecha = ctCls.ObtenerFechaProceso
        c1numAño.Value = mFecha.Year
        cmbMeses.Text = rsiCadCls.MesLetras(mFecha.Month)
        ListaDataNavBarPrin.lblBuscarDirectamente = "Buscar Directamente por No. de Partida:"
        ListaDataNavBarPrin.txtBuscarDirectamente = ""
        ListaDataNavBarPrin.NoRegs = PrincipalBindingSource.Count
        If UsuarioSoloConsulta Then
            ListaDataNavBarPrin.BotonEditarVisible = False
            ListaDataNavBarPrin.BotonNuevoVisible = False
        End If

    End Sub
End Class