Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label5.Text = "il ne faut pas saisir n'importe quoi !"
        Me.Label5.ForeColor = Color.Red
        Me.Label5.Visible = False
        Me.Label6.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BON As Boolean = True
        Dim cout As Double = 0
        Dim x As Integer = 0
        Dim Y As Integer = 0
        Dim Z As Double = 0

        If Me.cv.Text Is Nothing Or Not IsNumeric(Me.cv.Text) Then
            BON = False
        End If
        If Me.km.Text Is Nothing Or Not IsNumeric(Me.km.Text) Then
            BON = False
        End If
        If Me.ess.Text Is Nothing Or Not IsNumeric(Me.ess.Text) Then
            BON = False
        End If
        If Not BON Then
        Else
            x = Val(Me.cv.Text)
            Y = Val(Me.km.Text)
            Z = CDbl(Me.ess.Text)
            cout = ((Y / 100) * x) * Z
            Me.Label6.Text = "Le cout du voyage sera de " & cout & " FC"
            Me.Label6.Visible = True
        End If

    End Sub
End Class
