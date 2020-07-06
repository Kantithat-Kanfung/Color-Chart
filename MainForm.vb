Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tColor As Type = GetType(KnownColor)
        Dim colorNames() As String = [Enum].GetNames(tColor)

        Dim pixBox As PictureBox

        For index = 1 To colorNames.Length - 1
            pixBox = New PictureBox()
            pixBox.Size = New Size(32, 32)
            pixBox.BackColor = Color.FromName(colorNames(index))
            flpColor.Controls.Add(pixBox)

            AddHandler pixBox.Click, AddressOf Click_Color
        Next

        flpColor.BackColor = Color.White
    End Sub

    Private Sub Click_Color(sender As Object, e As EventArgs)
        Dim pb As PictureBox = CType(sender, PictureBox)

        pnColor.BackColor = pb.BackColor

        Dim col As String = pb.BackColor.Name
        lbNameColor.Text = col

        Dim r, g, b As Byte
        r = pb.BackColor.R
        g = pb.BackColor.G
        b = pb.BackColor.B
        lbRGBColor.Text = $"{r}, {g}, {b}"
        lbHexColor.Text = $"#{r.ToString("x2")}{g.ToString("x2")}{b.ToString("x2")}"

        copyNameColor.Show()
        copyRGBColor.Show()
        copyHexColor.Show()

        lbCopyName.Hide()
        lbCopyRGB.Hide()
        lbCopyHex.Hide()
    End Sub

    Private Sub copyNameColor_MouseHover(sender As Object, e As EventArgs) Handles copyNameColor.MouseHover
        ToolTip1.SetToolTip(copyNameColor, "Copy Name Color")
    End Sub

    Private Sub copyRGBColor_MouseHover(sender As Object, e As EventArgs) Handles copyRGBColor.MouseHover
        ToolTip1.SetToolTip(copyRGBColor, "Copy RGB")
    End Sub

    Private Sub copyHexColor_MouseHover(sender As Object, e As EventArgs) Handles copyHexColor.MouseHover
        ToolTip1.SetToolTip(copyHexColor, "Copy Hex")
    End Sub

    Private Sub copyNameColor_Click(sender As Object, e As EventArgs) Handles copyNameColor.Click
        My.Computer.Clipboard.SetText(lbNameColor.Text)
        copyNameColor.Hide()
        lbCopyName.Text = "Copy!"
        lbCopyName.ForeColor = Color.Gray
        lbCopyName.BackColor = Color.WhiteSmoke
        lbCopyName.Show()
    End Sub

    Private Sub copyRGBColor_Click(sender As Object, e As EventArgs) Handles copyRGBColor.Click
        My.Computer.Clipboard.SetText(lbRGBColor.Text)
        copyRGBColor.Hide()
        lbCopyRGB.Text = "Copy!"
        lbCopyRGB.ForeColor = Color.Gray
        lbCopyRGB.BackColor = Color.WhiteSmoke
        lbCopyRGB.Show()
    End Sub

    Private Sub copyHexColor_Click(sender As Object, e As EventArgs) Handles copyHexColor.Click
        My.Computer.Clipboard.SetText(lbHexColor.Text)
        copyHexColor.Hide()
        lbCopyHex.Text = "Copy!"
        lbCopyHex.ForeColor = Color.Gray
        lbCopyHex.BackColor = Color.WhiteSmoke
        lbCopyHex.Show()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub
End Class
