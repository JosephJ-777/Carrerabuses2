' ============================================================
' FrmBuses.Monitor.vb  ·  ALUMNO 3 (Sincronización)
' Variable ganador, candado, SyncLock y Timer de estados.
' ============================================================
Imports System.Threading

Partial Class FrmBuses

    ' Recurso compartido: los tres hilos pueden leerlo y escribirlo.
    Private ganador As String = ""

    ' Candado: Object privado, de solo lectura y usado solo para esto.
    Private ReadOnly candado As New Object()

    ' Etiqueta de estado de cada bus, indexada por 0..2 (se llena en InicializarControles).
    Private lblEstados() As Label

    Private Sub ReiniciarGanador()
        SyncLock candado
            ganador = ""
        End SyncLock
    End Sub

    ' Sección crítica: la PREGUNTA y la ESCRITURA van juntas dentro del mismo bloque.
    ' Dentro del candado no hay Sleep ni Invoke.
    Private Function IntentarSerGanador(nombre As String) As Boolean
        Dim soyGanador As Boolean = False
        SyncLock candado
            If ganador = "" Then
                ganador = nombre
                soyGanador = True
            End If
        End SyncLock
        Return soyGanador
    End Function

    ' Tick corre en el HILO UI: aquí sí se escriben las etiquetas directamente.
    Private Sub tmrEstados_Tick(sender As Object, e As EventArgs) Handles tmrEstados.Tick
        Dim todosTerminados As Boolean = True

        For i As Integer = 0 To 2
            Dim t As Thread = buses(i)
            If t Is Nothing Then
                todosTerminados = False          ' el hilo todavía no existe
                Continue For
            End If

            Dim estado As ThreadState = t.ThreadState
            lblEstados(i).Text = estado.ToString()

            ' ThreadState es de tipo flags: no comparar con "=".
            If Not estado.HasFlag(ThreadState.Stopped) Then todosTerminados = False
        Next

        ' Las etiquetas ya se actualizaron arriba, así que se ve el estado final.
        If todosTerminados Then
            tmrEstados.Stop()
            btnIniciar.Enabled = True
        End If
    End Sub

End Class
