' ============================================================
' FrmBuses.Hilos.vb  ·  ALUMNO 2 (Hilos)
' Creación de los hilos y el método Viajar().
' ============================================================
Imports System.Threading

Partial Class FrmBuses

    Private Const DistanciaKm As Integer = 150
    Private Const PasoKm As Integer = 5

    ' Los tres hilos (uno por bus). El Timer también los recorre.
    Private buses(2) As Thread

    ' Barra de cada bus, indexada por 0..2 (se llena en InicializarControles).
    Private barras() As ProgressBar

    ' Crea tres objetos Thread NUEVOS (un Thread Stopped no se puede reiniciar).
    ' Name e IsBackground se fijan ANTES de Start.
    Private Sub CrearHilos()
        For i As Integer = 0 To 2
            Dim t As New Thread(AddressOf Viajar)
            t.Name = "Bus " & (i + 1)
            t.IsBackground = True
            buses(i) = t
        Next
    End Sub

    Private Sub IniciarHilos()
        For Each t As Thread In buses
            t.Start()
        Next
    End Sub

    ' Se ejecuta en el HILO DE CADA BUS, nunca en el hilo UI.
    Private Sub Viajar()
        Dim nombre As String = Thread.CurrentThread.Name           ' "Bus 1", "Bus 2" o "Bus 3"
        Dim indice As Integer = Integer.Parse(nombre.Substring(nombre.Length - 1)) - 1
        Dim rnd As New Random()                                    ' variable local: un Random por hilo

        For km As Integer = PasoKm To DistanciaKm Step PasoKm
            If cerrando Then Return                                ' salir sin tocar la interfaz

            Dim kmActual As Integer = km                           ' copia local para la lambda
            Dim ok As Boolean = EjecutarEnUI(Sub() barras(indice).Value = kmActual)
            If Not ok Then Return

            Thread.Sleep(rnd.Next(50, 201))                        ' 50..200 ms (201 es exclusivo)
        Next

        ' Llegó a Estelí: sección crítica (en FrmBuses.Monitor.vb)
        If IntentarSerGanador(nombre) Then
            EjecutarEnUI(Sub() lblGanador.Text = "Ganador: " & nombre)
        End If
        ' Al terminar el método, el hilo pasa solo a Stopped.
    End Sub

    ' Pide al hilo UI que ejecute 'accion'. Devuelve False si el formulario
    ' ya no está disponible (cierre a mitad de la carrera).
    Private Function EjecutarEnUI(accion As Action) As Boolean
        If cerrando OrElse IsDisposed Then Return False
        Try
            Me.Invoke(New MethodInvoker(Sub() accion()))
            Return True
        Catch ex As ObjectDisposedException
            Return False
        Catch ex As InvalidOperationException When cerrando OrElse IsDisposed
            Return False
        End Try
    End Function

End Class
