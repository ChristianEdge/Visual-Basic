
'Author: Christian Edge
'Course: CIS 212 Visual Basic
'Date: 28 Apr 2019
'Project: Flags of the World

Public Class FlagsOfTheWorld

    Const OneInch As Integer = 96
    Const HalfInch As Integer = 48
    Const ThirdInch As Integer = 32
    Const QuarterInch As Integer = 24
    Const EigthInch As Integer = 12
    Const TwelfthInch As Integer = 8
    Const SixteenthInch As Integer = 6

    Const flag_FullWidth As Integer = (4 * OneInch) + HalfInch
    Const flag_FullHeight As Integer = 3 * OneInch
    Const flag_HalfWidth As Integer = (2 * OneInch) + QuarterInch
    Const flag_HalfHeight As Integer = OneInch + HalfInch

    Dim graphics As Graphics

    Private Sub FlagsOfTheWorld_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        graphics = picboxFlag.CreateGraphics
    End Sub


    Private Sub btnBangladesh_Click(sender As Object, e As EventArgs) Handles btnBangladesh.Click
        picboxFlag.Refresh()

        graphics.FillRectangle(Brushes.ForestGreen, 0, 0, flag_FullWidth, flag_FullHeight)
        graphics.FillEllipse(Brushes.Red, OneInch, HalfInch,
                             OneInch * 2, OneInch * 2)
    End Sub

    Private Sub btnBahamas_Click(sender As Object, e As EventArgs) Handles btnBahamas.Click
        picboxFlag.Refresh()

        graphics.FillRectangle(Brushes.SteelBlue, 0, 0, flag_FullWidth, flag_FullHeight)
        graphics.FillRectangle(Brushes.Yellow, 0, OneInch, flag_FullWidth, OneInch)

        Dim A As New Point(0, 0)
        Dim B As New Point(0, flag_FullHeight)
        Dim C As New Point(OneInch * 2, flag_HalfHeight)
        Dim triangle As Point() = {A, B, C}
        graphics.FillPolygon(Brushes.Black, triangle)
    End Sub

    Private Sub btnIceland_Click(sender As Object, e As EventArgs) Handles btnIceland.Click
        picboxFlag.Refresh()

        graphics.FillRectangle(Brushes.Blue, 0, 0, flag_FullWidth, flag_FullHeight)
        graphics.FillRectangle(Brushes.White, 0, OneInch + EigthInch,
                               flag_FullWidth, HalfInch + QuarterInch)
        graphics.FillRectangle(Brushes.White, OneInch, 0, HalfInch + QuarterInch, flag_FullHeight)
        graphics.FillRectangle(Brushes.Red, 0, OneInch + QuarterInch + EigthInch,
                               flag_FullWidth, QuarterInch)
        graphics.FillRectangle(Brushes.Red, OneInch + QuarterInch, 0,
                               QuarterInch, flag_FullHeight)
    End Sub

    Private Sub btnEstonia_Click(sender As Object, e As EventArgs) Handles btnEstonia.Click
        picboxFlag.Refresh()
        graphics.FillRectangle(Brushes.SteelBlue, 0, 0, flag_FullWidth, OneInch)
        graphics.FillRectangle(Brushes.Black, 0, OneInch, flag_FullWidth, OneInch)
        graphics.FillRectangle(Brushes.White, 0, OneInch * 2, flag_FullWidth, OneInch)
    End Sub

    Private Sub btnIsrael_Click(sender As Object, e As EventArgs) Handles btnIsrael.Click
        picboxFlag.Refresh()
        graphics.FillRectangle(Brushes.White, 0, 0, flag_FullWidth, flag_FullHeight)
        graphics.FillRectangle(Brushes.Blue, 0, ThirdInch, flag_FullWidth, QuarterInch + EigthInch)
        graphics.FillRectangle(Brushes.Blue, 0, flag_FullHeight - (ThirdInch + QuarterInch + EigthInch),
                               flag_FullWidth, QuarterInch + EigthInch)

        Dim BluePen = New Pen(Drawing.Color.Blue, 5)
        Dim A As New Point(flag_HalfWidth, OneInch) 'Top Middle
        Dim B As New Point(flag_HalfWidth - HalfInch, OneInch + HalfInch + QuarterInch) 'Bottom left
        Dim C As New Point(flag_HalfWidth + HalfInch, OneInch + HalfInch + QuarterInch) 'Bottom right
        Dim triangle As Point() = {A, B, C}
        graphics.DrawPolygon(BluePen, triangle)
        Dim D As New Point(flag_HalfWidth, flag_FullHeight - OneInch) 'Bottom mid
        Dim F As New Point(flag_HalfWidth - HalfInch, flag_FullHeight - (OneInch + HalfInch + QuarterInch)) 'Top left
        Dim G As New Point(flag_HalfWidth + HalfInch, flag_FullHeight - (OneInch + HalfInch + QuarterInch)) 'Top right
        Dim triangle2 As Point() = {D, F, G}
        graphics.DrawPolygon(BluePen, triangle2)
    End Sub

    Private Sub btnBenin_Click(sender As Object, e As EventArgs) Handles btnBenin.Click
        picboxFlag.Refresh()

        graphics.FillRectangle(Brushes.Green, 0, 0, (2 * OneInch), flag_FullHeight)
        graphics.FillRectangle(Brushes.Yellow, (2 * OneInch), 0, (2 * OneInch) + HalfInch, OneInch + HalfInch)
        graphics.FillRectangle(Brushes.Red, (2 * OneInch), OneInch + HalfInch,
                               (2 * OneInch) + HalfInch, OneInch + HalfInch)
    End Sub

    Private Sub btnGuyana_Click(sender As Object, e As EventArgs) Handles btnGuyana.Click
        picboxFlag.Refresh()

        graphics.FillRectangle(Brushes.Green, 0, 0, flag_FullWidth, flag_FullHeight)

        Dim A As New Point(0, 0)
        Dim B As New Point(0, 3 * OneInch)
        Dim C As New Point((4 * OneInch) + HalfInch, OneInch + HalfInch)
        Dim bigTrangle As Point() = {A, B, C}
        Dim Pen1 = New Pen(Drawing.Color.White, 8)
        graphics.FillPolygon(Brushes.Yellow, bigTrangle)
        graphics.DrawPolygon(Pen1, bigTrangle)

        Dim D As New Point((2 * OneInch), OneInch + HalfInch)
        Dim smallTriangle As Point() = {A, B, D}
        Dim Pen2 = New Pen(Drawing.Color.Black, 8)
        graphics.FillPolygon(Brushes.Red, smallTriangle)
        graphics.DrawPolygon(Pen2, smallTriangle)
    End Sub

    Private Sub btnTunisia_Click() Handles btnTunisia.Click
        picboxFlag.Refresh()

        graphics.FillRectangle(Brushes.Red, 0, 0, flag_FullWidth, flag_FullHeight)
        graphics.FillEllipse(Brushes.White, flag_HalfWidth - (QuarterInch * 3), flag_HalfHeight - (QuarterInch * 3),
                            (QuarterInch * 3) * 2, (QuarterInch * 3) * 2)
        graphics.FillEllipse(Brushes.Red, flag_HalfWidth - HalfInch, flag_HalfHeight - HalfInch,
                            OneInch, OneInch)
        graphics.FillEllipse(Brushes.White, flag_HalfWidth - HalfInch + QuarterInch, flag_HalfHeight - HalfInch + SixteenthInch,
                            OneInch - EigthInch, OneInch - EigthInch)

        'The code below is for the star in the flag
        'I wanted to draw a polygon with points but ran out of time trying to implement it
        Dim OffsetX As Integer = 15
        Dim OffsetY As Integer = -25

        Dim v1 As New Point(flag_HalfWidth + OffsetX, flag_HalfHeight + OffsetY) 'Center top
        Dim v2 As New Point(flag_HalfWidth + OffsetX + 30, flag_HalfHeight + OffsetY + 50) 'Bottom right
        Dim v3 As New Point(flag_HalfWidth + OffsetX - 30, flag_HalfHeight + OffsetY + 50) 'Bottom left
        Dim v4 As New Point(flag_HalfWidth + OffsetX, flag_HalfHeight + OffsetY + 40) 'Bottom center
        Dim v5 As New Point(flag_HalfWidth + OffsetX - 30, flag_HalfHeight + OffsetY + 15)
        Dim v6 As New Point(flag_HalfWidth + OffsetX + 30, flag_HalfHeight + OffsetY + 15)
        Dim v7 As New Point(flag_HalfWidth + OffsetX, flag_HalfHeight + 15)
        Dim points As Point() = {v1, v2, v4, v3}
        Dim points2 As Point() = {v5, v6, v7}
        graphics.FillPolygon(Brushes.Red, points)
        graphics.FillPolygon(Brushes.Red, points2)

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
