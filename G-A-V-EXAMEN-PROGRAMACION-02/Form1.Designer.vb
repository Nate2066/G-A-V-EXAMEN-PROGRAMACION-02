<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        ckbRellenar = New CheckBox()
        dgvGastosAdmYVentas = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        txtTotal = New TextBox()
        txtTotalSGWeb = New TextBox()
        txtTotalSGContable = New TextBox()
        btnLimpiarCuadro = New Button()
        btnActualizarCuadro = New Button()
        btnAgregarConcepto = New Button()
        btnQuitarConcepto = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvGastosAdmYVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ckbRellenar)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(117, 45)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' ckbRellenar
        ' 
        ckbRellenar.AutoSize = True
        ckbRellenar.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ckbRellenar.Location = New Point(6, 15)
        ckbRellenar.Name = "ckbRellenar"
        ckbRellenar.Size = New Size(106, 24)
        ckbRellenar.TabIndex = 0
        ckbRellenar.Text = "RELLENAR"
        ckbRellenar.UseVisualStyleBackColor = True
        ' 
        ' dgvGastosAdmYVentas
        ' 
        dgvGastosAdmYVentas.AllowUserToAddRows = False
        dgvGastosAdmYVentas.AllowUserToDeleteRows = False
        dgvGastosAdmYVentas.AllowUserToResizeColumns = False
        dgvGastosAdmYVentas.AllowUserToResizeRows = False
        dgvGastosAdmYVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGastosAdmYVentas.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        dgvGastosAdmYVentas.Location = New Point(12, 63)
        dgvGastosAdmYVentas.Name = "dgvGastosAdmYVentas"
        dgvGastosAdmYVentas.RowHeadersWidth = 51
        dgvGastosAdmYVentas.Size = New Size(780, 375)
        dgvGastosAdmYVentas.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Conceptos"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "SG Contable (C$)"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "SG Web (C$)"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Totales (C$)"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(623, 452)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(169, 27)
        txtTotal.TabIndex = 2
        ' 
        ' txtTotalSGWeb
        ' 
        txtTotalSGWeb.Location = New Point(448, 452)
        txtTotalSGWeb.Name = "txtTotalSGWeb"
        txtTotalSGWeb.Size = New Size(169, 27)
        txtTotalSGWeb.TabIndex = 3
        ' 
        ' txtTotalSGContable
        ' 
        txtTotalSGContable.Location = New Point(273, 452)
        txtTotalSGContable.Name = "txtTotalSGContable"
        txtTotalSGContable.Size = New Size(169, 27)
        txtTotalSGContable.TabIndex = 4
        ' 
        ' btnLimpiarCuadro
        ' 
        btnLimpiarCuadro.BackgroundImage = CType(resources.GetObject("btnLimpiarCuadro.BackgroundImage"), Image)
        btnLimpiarCuadro.BackgroundImageLayout = ImageLayout.Zoom
        btnLimpiarCuadro.Location = New Point(12, 444)
        btnLimpiarCuadro.Name = "btnLimpiarCuadro"
        btnLimpiarCuadro.Size = New Size(35, 35)
        btnLimpiarCuadro.TabIndex = 5
        btnLimpiarCuadro.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarCuadro
        ' 
        btnActualizarCuadro.BackgroundImage = CType(resources.GetObject("btnActualizarCuadro.BackgroundImage"), Image)
        btnActualizarCuadro.BackgroundImageLayout = ImageLayout.Zoom
        btnActualizarCuadro.Location = New Point(53, 444)
        btnActualizarCuadro.Name = "btnActualizarCuadro"
        btnActualizarCuadro.Size = New Size(35, 35)
        btnActualizarCuadro.TabIndex = 6
        btnActualizarCuadro.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarConcepto
        ' 
        btnAgregarConcepto.BackgroundImage = CType(resources.GetObject("btnAgregarConcepto.BackgroundImage"), Image)
        btnAgregarConcepto.BackgroundImageLayout = ImageLayout.Zoom
        btnAgregarConcepto.Location = New Point(94, 444)
        btnAgregarConcepto.Name = "btnAgregarConcepto"
        btnAgregarConcepto.Size = New Size(35, 35)
        btnAgregarConcepto.TabIndex = 7
        btnAgregarConcepto.UseVisualStyleBackColor = True
        ' 
        ' btnQuitarConcepto
        ' 
        btnQuitarConcepto.BackgroundImage = CType(resources.GetObject("btnQuitarConcepto.BackgroundImage"), Image)
        btnQuitarConcepto.BackgroundImageLayout = ImageLayout.Zoom
        btnQuitarConcepto.Location = New Point(135, 444)
        btnQuitarConcepto.Name = "btnQuitarConcepto"
        btnQuitarConcepto.Size = New Size(35, 35)
        btnQuitarConcepto.TabIndex = 8
        btnQuitarConcepto.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 489)
        Controls.Add(btnQuitarConcepto)
        Controls.Add(btnAgregarConcepto)
        Controls.Add(btnActualizarCuadro)
        Controls.Add(btnLimpiarCuadro)
        Controls.Add(txtTotalSGContable)
        Controls.Add(txtTotalSGWeb)
        Controls.Add(txtTotal)
        Controls.Add(dgvGastosAdmYVentas)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvGastosAdmYVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ckbRellenar As CheckBox
    Friend WithEvents dgvGastosAdmYVentas As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtTotalSGWeb As TextBox
    Friend WithEvents txtTotalSGContable As TextBox
    Friend WithEvents btnLimpiarCuadro As Button
    Friend WithEvents btnActualizarCuadro As Button
    Friend WithEvents btnAgregarConcepto As Button
    Friend WithEvents btnQuitarConcepto As Button

End Class
