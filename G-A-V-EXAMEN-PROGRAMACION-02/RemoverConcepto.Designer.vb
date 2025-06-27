<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoverConcepto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnAceptarQuitarConcepto = New Button()
        dgvEliminarConceptos = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        CType(dgvEliminarConceptos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAceptarQuitarConcepto
        ' 
        btnAceptarQuitarConcepto.BackColor = Color.FromArgb(CByte(228), CByte(225), CByte(202))
        btnAceptarQuitarConcepto.BackgroundImageLayout = ImageLayout.Zoom
        btnAceptarQuitarConcepto.Location = New Point(12, 8)
        btnAceptarQuitarConcepto.Name = "btnAceptarQuitarConcepto"
        btnAceptarQuitarConcepto.Size = New Size(35, 35)
        btnAceptarQuitarConcepto.TabIndex = 0
        btnAceptarQuitarConcepto.Text = "Remover"
        btnAceptarQuitarConcepto.UseVisualStyleBackColor = False
        ' 
        ' dgvEliminarConceptos
        ' 
        dgvEliminarConceptos.AllowUserToAddRows = False
        dgvEliminarConceptos.AllowUserToDeleteRows = False
        dgvEliminarConceptos.AllowUserToResizeColumns = False
        dgvEliminarConceptos.AllowUserToResizeRows = False
        dgvEliminarConceptos.BackgroundColor = Color.FromArgb(CByte(144), CByte(110), CByte(108))
        dgvEliminarConceptos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEliminarConceptos.Columns.AddRange(New DataGridViewColumn() {Column1})
        dgvEliminarConceptos.Location = New Point(12, 49)
        dgvEliminarConceptos.Name = "dgvEliminarConceptos"
        dgvEliminarConceptos.RowHeadersWidth = 51
        dgvEliminarConceptos.Size = New Size(292, 389)
        dgvEliminarConceptos.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Conceptos"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' RemoverConcepto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(72), CByte(58), CByte(71))
        ClientSize = New Size(317, 450)
        Controls.Add(dgvEliminarConceptos)
        Controls.Add(btnAceptarQuitarConcepto)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "RemoverConcepto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RemoverConcepto"
        CType(dgvEliminarConceptos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAceptarQuitarConcepto As Button
    Friend WithEvents dgvEliminarConceptos As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
