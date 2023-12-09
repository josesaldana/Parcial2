<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        TextBoxApellido = New TextBox()
        TextBoxNombre = New TextBox()
        TextBoxCedula = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        ButtonRegistrar = New Button()
        TextBoxExamenFinal = New TextBox()
        TextBoxParcial3 = New TextBox()
        TextBoxParcial2 = New TextBox()
        TextBoxParcial1 = New TextBox()
        ButtonNuevoEstudiante = New Button()
        DataGridViewEstudiantes = New DataGridView()
        EstudiantesListBindingSource = New BindingSource(components)
        Panel1 = New Panel()
        Label8 = New Label()
        IdDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CedulaDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        NombreDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        ApellidoDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Parcial1DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Parcial2DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Parcial3DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        PromedioParcialDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        ExamenFinalDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CalificacionFinalDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridViewEstudiantes, ComponentModel.ISupportInitialize).BeginInit()
        CType(EstudiantesListBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBoxApellido)
        GroupBox1.Controls.Add(TextBoxNombre)
        GroupBox1.Controls.Add(TextBoxCedula)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(225, 127)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(228, 122)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "DATOS GENERALES"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 5
        Label3.Text = "Apellido"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 4
        Label2.Text = "Nombre"
        ' 
        ' TextBoxApellido
        ' 
        TextBoxApellido.Location = New Point(74, 85)
        TextBoxApellido.Name = "TextBoxApellido"
        TextBoxApellido.Size = New Size(142, 23)
        TextBoxApellido.TabIndex = 3
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Location = New Point(74, 56)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(142, 23)
        TextBoxNombre.TabIndex = 2
        ' 
        ' TextBoxCedula
        ' 
        TextBoxCedula.Location = New Point(74, 27)
        TextBoxCedula.Name = "TextBoxCedula"
        TextBoxCedula.Size = New Size(142, 23)
        TextBoxCedula.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 0
        Label1.Text = "Cedula"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(ButtonRegistrar)
        GroupBox2.Controls.Add(TextBoxExamenFinal)
        GroupBox2.Controls.Add(TextBoxParcial3)
        GroupBox2.Controls.Add(TextBoxParcial2)
        GroupBox2.Controls.Add(TextBoxParcial1)
        GroupBox2.Location = New Point(459, 127)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(284, 122)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "NOTAS FINALES"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(150, 25)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 15)
        Label7.TabIndex = 8
        Label7.Text = "Semestral"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(8, 83)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 7
        Label6.Text = "Parcial 3"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(8, 54)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 15)
        Label5.TabIndex = 6
        Label5.Text = "Parcial 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 5
        Label4.Text = "Parcial 1"
        ' 
        ' ButtonRegistrar
        ' 
        ButtonRegistrar.Location = New Point(150, 79)
        ButtonRegistrar.Name = "ButtonRegistrar"
        ButtonRegistrar.Size = New Size(123, 23)
        ButtonRegistrar.TabIndex = 4
        ButtonRegistrar.Text = "Registrar"
        ButtonRegistrar.UseVisualStyleBackColor = True
        ' 
        ' TextBoxExamenFinal
        ' 
        TextBoxExamenFinal.Location = New Point(214, 22)
        TextBoxExamenFinal.Name = "TextBoxExamenFinal"
        TextBoxExamenFinal.Size = New Size(59, 23)
        TextBoxExamenFinal.TabIndex = 3
        ' 
        ' TextBoxParcial3
        ' 
        TextBoxParcial3.Location = New Point(76, 80)
        TextBoxParcial3.Name = "TextBoxParcial3"
        TextBoxParcial3.Size = New Size(58, 23)
        TextBoxParcial3.TabIndex = 2
        ' 
        ' TextBoxParcial2
        ' 
        TextBoxParcial2.Location = New Point(76, 51)
        TextBoxParcial2.Name = "TextBoxParcial2"
        TextBoxParcial2.Size = New Size(58, 23)
        TextBoxParcial2.TabIndex = 1
        ' 
        ' TextBoxParcial1
        ' 
        TextBoxParcial1.Location = New Point(76, 22)
        TextBoxParcial1.Name = "TextBoxParcial1"
        TextBoxParcial1.Size = New Size(58, 23)
        TextBoxParcial1.TabIndex = 0
        ' 
        ' ButtonNuevoEstudiante
        ' 
        ButtonNuevoEstudiante.Location = New Point(749, 137)
        ButtonNuevoEstudiante.Name = "ButtonNuevoEstudiante"
        ButtonNuevoEstudiante.Size = New Size(104, 112)
        ButtonNuevoEstudiante.TabIndex = 2
        ButtonNuevoEstudiante.Text = "Nuevo Estudiante"
        ButtonNuevoEstudiante.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewEstudiantes
        ' 
        DataGridViewEstudiantes.AutoGenerateColumns = False
        DataGridViewEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewEstudiantes.Columns.AddRange(New DataGridViewColumn() {IdDataGridViewTextBoxColumn, CedulaDataGridViewTextBoxColumn, NombreDataGridViewTextBoxColumn, ApellidoDataGridViewTextBoxColumn, Parcial1DataGridViewTextBoxColumn, Parcial2DataGridViewTextBoxColumn, Parcial3DataGridViewTextBoxColumn, PromedioParcialDataGridViewTextBoxColumn, ExamenFinalDataGridViewTextBoxColumn, CalificacionFinalDataGridViewTextBoxColumn})
        DataGridViewEstudiantes.DataSource = EstudiantesListBindingSource
        DataGridViewEstudiantes.Enabled = False
        DataGridViewEstudiantes.Location = New Point(21, 276)
        DataGridViewEstudiantes.Name = "DataGridViewEstudiantes"
        DataGridViewEstudiantes.RowTemplate.Height = 25
        DataGridViewEstudiantes.Size = New Size(1013, 181)
        DataGridViewEstudiantes.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label8)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1054, 104)
        Panel1.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(12, 30)
        Label8.Name = "Label8"
        Label8.Size = New Size(197, 37)
        Label8.TabIndex = 0
        Label8.Text = "Registro: Notas"
        ' 
        ' IdDataGridViewTextBoxColumn
        ' 
        IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        IdDataGridViewTextBoxColumn.HeaderText = "Id"
        IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        IdDataGridViewTextBoxColumn.Width = 40
        ' 
        ' CedulaDataGridViewTextBoxColumn
        ' 
        CedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula"
        CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        ' 
        ' NombreDataGridViewTextBoxColumn
        ' 
        NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        ' 
        ' ApellidoDataGridViewTextBoxColumn
        ' 
        ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        ' 
        ' Parcial1DataGridViewTextBoxColumn
        ' 
        Parcial1DataGridViewTextBoxColumn.DataPropertyName = "Parcial1"
        Parcial1DataGridViewTextBoxColumn.HeaderText = "Parcial1"
        Parcial1DataGridViewTextBoxColumn.Name = "Parcial1DataGridViewTextBoxColumn"
        ' 
        ' Parcial2DataGridViewTextBoxColumn
        ' 
        Parcial2DataGridViewTextBoxColumn.DataPropertyName = "Parcial2"
        Parcial2DataGridViewTextBoxColumn.HeaderText = "Parcial2"
        Parcial2DataGridViewTextBoxColumn.Name = "Parcial2DataGridViewTextBoxColumn"
        ' 
        ' Parcial3DataGridViewTextBoxColumn
        ' 
        Parcial3DataGridViewTextBoxColumn.DataPropertyName = "Parcial3"
        Parcial3DataGridViewTextBoxColumn.HeaderText = "Parcial3"
        Parcial3DataGridViewTextBoxColumn.Name = "Parcial3DataGridViewTextBoxColumn"
        ' 
        ' PromedioParcialDataGridViewTextBoxColumn
        ' 
        PromedioParcialDataGridViewTextBoxColumn.DataPropertyName = "PromedioParcial"
        PromedioParcialDataGridViewTextBoxColumn.HeaderText = "PromedioParcial"
        PromedioParcialDataGridViewTextBoxColumn.Name = "PromedioParcialDataGridViewTextBoxColumn"
        PromedioParcialDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' ExamenFinalDataGridViewTextBoxColumn
        ' 
        ExamenFinalDataGridViewTextBoxColumn.DataPropertyName = "ExamenFinal"
        ExamenFinalDataGridViewTextBoxColumn.HeaderText = "ExamenFinal"
        ExamenFinalDataGridViewTextBoxColumn.Name = "ExamenFinalDataGridViewTextBoxColumn"
        ' 
        ' CalificacionFinalDataGridViewTextBoxColumn
        ' 
        CalificacionFinalDataGridViewTextBoxColumn.DataPropertyName = "CalificacionFinalLetra"
        CalificacionFinalDataGridViewTextBoxColumn.HeaderText = "Calificacion Final"
        CalificacionFinalDataGridViewTextBoxColumn.Name = "CalificacionFinalDataGridViewTextBoxColumn"
        CalificacionFinalDataGridViewTextBoxColumn.ReadOnly = True
        CalificacionFinalDataGridViewTextBoxColumn.Width = 130
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1054, 489)
        Controls.Add(Panel1)
        Controls.Add(DataGridViewEstudiantes)
        Controls.Add(ButtonNuevoEstudiante)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Notas"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridViewEstudiantes, ComponentModel.ISupportInitialize).EndInit()
        CType(EstudiantesListBindingSource, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxCedula As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonRegistrar As Button
    Friend WithEvents TextBoxExamenFinal As TextBox
    Friend WithEvents TextBoxParcial3 As TextBox
    Friend WithEvents TextBoxParcial2 As TextBox
    Friend WithEvents TextBoxParcial1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonNuevoEstudiante As Button
    Friend WithEvents DataGridViewEstudiantes As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents EstudiantesListBindingSource As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Parcial1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Parcial2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Parcial3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromedioParcialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExamenFinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalificacionFinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
