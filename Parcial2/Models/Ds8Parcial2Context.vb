Imports System
Imports System.Collections.Generic
Imports Microsoft.EntityFrameworkCore

Namespace Models
    Partial Public Class Ds8Parcial2Context
        Inherits DbContext

        Public Sub New()
        End Sub

        Public Sub New(options As DbContextOptions)
            MyBase.New(options)
        End Sub

        Public Overridable Property Estudiantes As DbSet(Of Estudiante)

        Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
            modelBuilder.Entity(Of Estudiante)(
                Sub(entity)
                    entity.HasKey(Function(e) e.Id).HasName("PK__Estudian__3214EC079E9152D4")

                    entity.HasIndex(Function(e) e.Cedula, "UQ__Estudian__B4ADFE382284348C").IsUnique()

                    entity.Property(Function(e) e.Apellido).
                        IsRequired().
                        HasMaxLength(250).
                        IsUnicode(False)
                    entity.Property(Function(e) e.Cedula).
                        IsRequired().
                        HasMaxLength(250).
                        IsUnicode(False)
                    entity.Property(Function(e) e.Nombre).
                        IsRequired().
                        HasMaxLength(250).
                        IsUnicode(False)
                End Sub)

            OnModelCreatingPartial(modelBuilder)
        End Sub

        Partial Private Sub OnModelCreatingPartial(modelBuilder As ModelBuilder)
        End Sub
    End Class
End Namespace
