Imports Microsoft.EntityFrameworkCore
Imports Parcial2.Models

Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim connectionString = "Data Source=localhost;Initial Catalog=ds8-parcial2;Integrated Security=SSPI;TrustServerCertificate=True"
            Dim dbContextOptions = New DbContextOptionsBuilder().UseSqlServer(connectionString).Options
            Form1.Ds8Parcial2Context = New Ds8Parcial2Context(dbContextOptions)
        End Sub
    End Class
End Namespace
