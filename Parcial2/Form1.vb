Imports System.ComponentModel
Imports System.Linq
Imports Parcial2.Models

Public Class Form1
    Friend Shared Ds8Parcial2Context As Models.Ds8Parcial2Context

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstudiantesListBindingSource.DataSource = Ds8Parcial2Context.Estudiantes.ToList()
    End Sub

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        Dim estudiante = Ds8Parcial2Context.Estudiantes.FirstOrDefault(Function(s As Estudiante) s.Cedula = TextBoxCedula.Text)
        Dim esNuevoEstudiante = False

        If IsNothing(estudiante) Then
            esNuevoEstudiante = True
            estudiante = New Estudiante With {
                .Cedula = TextBoxCedula.Text
            }
        End If

        estudiante.Nombre = TextBoxNombre.Text
        estudiante.Apellido = TextBoxApellido.Text
        estudiante.Parcial1 = TextBoxParcial1.Text
        estudiante.Parcial2 = TextBoxParcial2.Text
        estudiante.Parcial3 = TextBoxParcial3.Text
        estudiante.ExamenFinal = TextBoxExamenFinal.Text

        If esNuevoEstudiante Then
            Ds8Parcial2Context.Estudiantes.Add(estudiante)
        End If

        Ds8Parcial2Context.SaveChanges()

        EstudiantesListBindingSource.DataSource = Ds8Parcial2Context.Estudiantes.ToList()
    End Sub

    Private Sub ButtonNuevoEstudiante_Click(sender As Object, e As EventArgs) Handles ButtonNuevoEstudiante.Click
        TextBoxNombre.Clear()
        TextBoxApellido.Clear()
        TextBoxCedula.Clear()
        TextBoxParcial1.Clear()
        TextBoxParcial2.Clear()
        TextBoxParcial3.Clear()
        TextBoxExamenFinal.Clear()
    End Sub
End Class
