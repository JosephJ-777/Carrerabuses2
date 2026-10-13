<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBuses
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        lblTitulo = New System.Windows.Forms.Label()
        lblBus1 = New System.Windows.Forms.Label()
        lblBus2 = New System.Windows.Forms.Label()
        lblBus3 = New System.Windows.Forms.Label()
        pbBus1 = New System.Windows.Forms.ProgressBar()
        pbBus2 = New System.Windows.Forms.ProgressBar()
        pbBus3 = New System.Windows.Forms.ProgressBar()
        lblEstado1 = New System.Windows.Forms.Label()
        lblEstado2 = New System.Windows.Forms.Label()
        lblEstado3 = New System.Windows.Forms.Label()
        lblGanador = New System.Windows.Forms.Label()
        btnIniciar = New System.Windows.Forms.Button()
        btnSalir = New System.Windows.Forms.Button()
        tmrEstados = New System.Windows.Forms.Timer(components)
        SuspendLayout()
        '
        ' lblTitulo
        '
        lblTitulo.AutoSize = True
        lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.0F, System.Drawing.FontStyle.Bold)
        lblTitulo.ForeColor = System.Drawing.Color.FromArgb(25, 61, 136)
        lblTitulo.Location = New System.Drawing.Point(20, 15)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Text = "Managua → Estelí · 150 km"
        '
        ' lblBus1..3
        '
        lblBus1.AutoSize = True
        lblBus1.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Bold)
        lblBus1.Location = New System.Drawing.Point(20, 75)
        lblBus1.Name = "lblBus1"
        lblBus1.Text = "Bus 1"
        lblBus2.AutoSize = True
        lblBus2.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Bold)
        lblBus2.Location = New System.Drawing.Point(20, 143)
        lblBus2.Name = "lblBus2"
        lblBus2.Text = "Bus 2"
        lblBus3.AutoSize = True
        lblBus3.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Bold)
        lblBus3.Location = New System.Drawing.Point(20, 211)
        lblBus3.Name = "lblBus3"
        lblBus3.Text = "Bus 3"
        '
        ' pbBus1..3
        '
        pbBus1.Location = New System.Drawing.Point(90, 70)
        pbBus1.Maximum = 150
        pbBus1.Minimum = 0
        pbBus1.Name = "pbBus1"
        pbBus1.Size = New System.Drawing.Size(400, 28)
        pbBus1.Step = 5
        pbBus1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        pbBus2.Location = New System.Drawing.Point(90, 138)
        pbBus2.Maximum = 150
        pbBus2.Minimum = 0
        pbBus2.Name = "pbBus2"
        pbBus2.Size = New System.Drawing.Size(400, 28)
        pbBus2.Step = 5
        pbBus2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        pbBus3.Location = New System.Drawing.Point(90, 206)
        pbBus3.Maximum = 150
        pbBus3.Minimum = 0
        pbBus3.Name = "pbBus3"
        pbBus3.Size = New System.Drawing.Size(400, 28)
        pbBus3.Step = 5
        pbBus3.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        ' lblEstado1..3
        '
        lblEstado1.AutoSize = False
        lblEstado1.BackColor = System.Drawing.Color.White
        lblEstado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblEstado1.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        lblEstado1.Location = New System.Drawing.Point(505, 70)
        lblEstado1.Name = "lblEstado1"
        lblEstado1.Size = New System.Drawing.Size(235, 28)
        lblEstado1.Text = "Sin iniciar"
        lblEstado1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblEstado2.AutoSize = False
        lblEstado2.BackColor = System.Drawing.Color.White
        lblEstado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblEstado2.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        lblEstado2.Location = New System.Drawing.Point(505, 138)
        lblEstado2.Name = "lblEstado2"
        lblEstado2.Size = New System.Drawing.Size(235, 28)
        lblEstado2.Text = "Sin iniciar"
        lblEstado2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblEstado3.AutoSize = False
        lblEstado3.BackColor = System.Drawing.Color.White
        lblEstado3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblEstado3.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        lblEstado3.Location = New System.Drawing.Point(505, 206)
        lblEstado3.Name = "lblEstado3"
        lblEstado3.Size = New System.Drawing.Size(235, 28)
        lblEstado3.Text = "Sin iniciar"
        lblEstado3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' lblGanador
        '
        lblGanador.AutoSize = False
        lblGanador.BackColor = System.Drawing.Color.White
        lblGanador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblGanador.Font = New System.Drawing.Font("Segoe UI", 14.0F, System.Drawing.FontStyle.Bold)
        lblGanador.ForeColor = System.Drawing.Color.DarkGreen
        lblGanador.Location = New System.Drawing.Point(20, 285)
        lblGanador.Name = "lblGanador"
        lblGanador.Size = New System.Drawing.Size(720, 40)
        lblGanador.Text = "Ganador: —"
        lblGanador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' btnIniciar / btnSalir
        '
        btnIniciar.Location = New System.Drawing.Point(460, 350)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New System.Drawing.Size(130, 36)
        btnIniciar.Text = "&Iniciar carrera"
        btnIniciar.UseVisualStyleBackColor = True
        btnSalir.Location = New System.Drawing.Point(610, 350)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New System.Drawing.Size(130, 36)
        btnSalir.Text = "&Salir"
        btnSalir.UseVisualStyleBackColor = True
        '
        ' tmrEstados
        '
        tmrEstados.Enabled = False
        tmrEstados.Interval = 100
        '
        ' FrmBuses
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 17.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        CancelButton = btnSalir
        ClientSize = New System.Drawing.Size(760, 410)
        Controls.Add(lblTitulo)
        Controls.Add(lblBus1)
        Controls.Add(lblBus2)
        Controls.Add(lblBus3)
        Controls.Add(pbBus1)
        Controls.Add(pbBus2)
        Controls.Add(pbBus3)
        Controls.Add(lblEstado1)
        Controls.Add(lblEstado2)
        Controls.Add(lblEstado3)
        Controls.Add(lblGanador)
        Controls.Add(btnIniciar)
        Controls.Add(btnSalir)
        Font = New System.Drawing.Font("Segoe UI", 10.0F)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmBuses"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Carrera de buses Managua – Estelí"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblBus1 As System.Windows.Forms.Label
    Friend WithEvents lblBus2 As System.Windows.Forms.Label
    Friend WithEvents lblBus3 As System.Windows.Forms.Label
    Friend WithEvents pbBus1 As System.Windows.Forms.ProgressBar
    Friend WithEvents pbBus2 As System.Windows.Forms.ProgressBar
    Friend WithEvents pbBus3 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblEstado1 As System.Windows.Forms.Label
    Friend WithEvents lblEstado2 As System.Windows.Forms.Label
    Friend WithEvents lblEstado3 As System.Windows.Forms.Label
    Friend WithEvents lblGanador As System.Windows.Forms.Label
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents tmrEstados As System.Windows.Forms.Timer
End Class
