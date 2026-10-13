' ============================================================
' FrmBuses.vb  ·  ALUMNO 1 (Interfaz)
' Eventos de la interfaz, preparación de pantalla y cierre seguro.
' ============================================================
Partial Class FrmBuses

    ' Bandera de cierre: los buses la leen para no tocar la UI
    ' cuando el formulario se está destruyendo.
    Private cerrando As Boolean = False

    Private Sub FrmBuses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarControles()
        PrepararPantalla()
    End Sub

    ' Arma los arreglos que permiten pasar del índice del bus (0..2)
    ' a su barra y a su etiqueta de estado.
    Private Sub InicializarControles()
        barras = {pbBus1, pbBus2, pbBus3}
        lblEstados = {lblEstado1, lblEstado2, lblEstado3}
    End Sub

    Private Sub PrepararPantalla()
        For Each pb In barras
            pb.Value = 0
        Next
        For Each lbl In lblEstados
            lbl.Text = "Sin iniciar"
        Next
        lblGanador.Text = "Ganador: —"
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        PrepararPantalla()
        ReiniciarGanador()          ' (FrmBuses.Monitor.vb) vacía la variable compartida
        cerrando = False
        btnIniciar.Enabled = False  ' evita lanzar otra carrera encima

        CrearHilos()                ' (FrmBuses.Hilos.vb) 3 Thread NUEVOS, con Name e IsBackground
        tmrEstados.Start()          ' primero el Timer...
        IniciarHilos()              ' ...y luego Start de los tres buses
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub FrmBuses_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cerrando = True
        tmrEstados.Stop()
        ' OJO: no se hace Join de los hilos aquí (interbloqueo con Invoke).
        ' Los buses son IsBackground = True, así que el proceso termina solo.
    End Sub

End Class
