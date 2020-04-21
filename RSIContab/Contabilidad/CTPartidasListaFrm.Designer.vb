<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CTPartidasListaFrm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTPartidasListaFrm))
        Me.ListaDataNavBarPrin = New RSIContab.ListaDataNavBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.c1numAño = New C1.Win.C1Input.C1NumericEdit()
        Me.cmbMeses = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTPartidasListaDataSet = New RSIContab.CTPartidasListaDataSet()
        Me.CTTransaccionesEncabezadoTableAdapter = New RSIContab.CTPartidasListaDataSetTableAdapters.CTTransaccionesEncabezadoTableAdapter()
        Me.c1dbgrdPartidas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTPartidasListaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dbgrdPartidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaDataNavBarPrin
        '
        Me.ListaDataNavBarPrin.BindingSourcePrincipal = Me.PrincipalBindingSource
        Me.ListaDataNavBarPrin.BotonEditarVisible = False
        Me.ListaDataNavBarPrin.BotonEliminarVisible = False
        Me.ListaDataNavBarPrin.BotonNuevoVisible = False
        Me.ListaDataNavBarPrin.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListaDataNavBarPrin.lblBuscarDirectamente = Nothing
        Me.ListaDataNavBarPrin.Location = New System.Drawing.Point(0, 0)
        Me.ListaDataNavBarPrin.Name = "ListaDataNavBarPrin"
        Me.ListaDataNavBarPrin.NoRegs = "0"
        Me.ListaDataNavBarPrin.Size = New System.Drawing.Size(937, 69)
        Me.ListaDataNavBarPrin.TabIndex = 0
        Me.ListaDataNavBarPrin.txtBuscarDirectamente = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Controls.Add(Me.c1numAño)
        Me.GroupBox1.Controls.Add(Me.cmbMeses)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(937, 44)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.RSIContab.My.Resources.Resources._1421885829_filter
        Me.btnFiltrar.Location = New System.Drawing.Point(290, 14)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 30
        Me.btnFiltrar.Text = "FIltrar"
        Me.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'c1numAño
        '
        Me.c1numAño.DataType = GetType(Short)
        Me.c1numAño.Location = New System.Drawing.Point(46, 17)
        Me.c1numAño.Margin = New System.Windows.Forms.Padding(4)
        Me.c1numAño.Name = "c1numAño"
        Me.c1numAño.Size = New System.Drawing.Size(65, 20)
        Me.c1numAño.TabIndex = 29
        Me.c1numAño.Tag = "CM"
        Me.c1numAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numAño.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        '
        'cmbMeses
        '
        Me.cmbMeses.FormattingEnabled = True
        Me.cmbMeses.Location = New System.Drawing.Point(166, 17)
        Me.cmbMeses.Name = "cmbMeses"
        Me.cmbMeses.Size = New System.Drawing.Size(94, 21)
        Me.cmbMeses.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Año:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mes:"
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "CTTransaccionesEncabezado"
        Me.PrincipalBindingSource.DataSource = Me.CTPartidasListaDataSet
        '
        'CTPartidasListaDataSet
        '
        Me.CTPartidasListaDataSet.DataSetName = "CTPartidasListaDataSet"
        Me.CTPartidasListaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTTransaccionesEncabezadoTableAdapter
        '
        Me.CTTransaccionesEncabezadoTableAdapter.ClearBeforeFill = True
        '
        'c1dbgrdPartidas
        '
        Me.c1dbgrdPartidas.AllowUpdate = False
        Me.c1dbgrdPartidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1dbgrdPartidas.DataSource = Me.PrincipalBindingSource
        Me.c1dbgrdPartidas.FilterBar = True
        Me.c1dbgrdPartidas.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdPartidas.Images.Add(CType(resources.GetObject("c1dbgrdPartidas.Images"), System.Drawing.Image))
        Me.c1dbgrdPartidas.Location = New System.Drawing.Point(12, 119)
        Me.c1dbgrdPartidas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.c1dbgrdPartidas.Name = "c1dbgrdPartidas"
        Me.c1dbgrdPartidas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdPartidas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdPartidas.PreviewInfo.ZoomFactor = 75.0R
        Me.c1dbgrdPartidas.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdNiveles.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdPartidas.RowHeight = 18
        Me.c1dbgrdPartidas.Size = New System.Drawing.Size(913, 444)
        Me.c1dbgrdPartidas.TabIndex = 10
        Me.c1dbgrdPartidas.Text = "C1TrueDBGrid1"
        Me.c1dbgrdPartidas.PropBag = resources.GetString("c1dbgrdPartidas.PropBag")
        '
        'CTPartidasListaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 587)
        Me.Controls.Add(Me.c1dbgrdPartidas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListaDataNavBarPrin)
        Me.Name = "CTPartidasListaFrm"
        Me.Text = "Lista Partidas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTPartidasListaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dbgrdPartidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListaDataNavBarPrin As ListaDataNavBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents c1numAño As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmbMeses As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PrincipalBindingSource As BindingSource
    Friend WithEvents CTPartidasListaDataSet As CTPartidasListaDataSet
    Friend WithEvents CTTransaccionesEncabezadoTableAdapter As CTPartidasListaDataSetTableAdapters.CTTransaccionesEncabezadoTableAdapter
    Friend WithEvents c1dbgrdPartidas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
