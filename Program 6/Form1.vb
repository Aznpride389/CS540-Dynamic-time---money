Imports System
Imports System.Globalization
Imports System.Threading
Imports System.Resources

Public Class Form1

    Inherits System.Windows.Forms.Form

    Dim currentCulture As CultureInfo
    Dim usaCulture As CultureInfo = New CultureInfo("en-US")
    Dim albaniaCulture As CultureInfo = New CultureInfo("sq-AL")
    Dim indiaCulture As CultureInfo = New CultureInfo("hi-In")
    Dim disneylandCulture As CultureInfo = New CultureInfo("")

    Dim resx_cur As ResXResourceSet
    Dim resx_money As ResXResourceSet = New ResXResourceSet("moneyResX.resx")

    Dim dateTime As DateTime = New DateTime(0)

    Dim displayMode As String

    Dim hindi_digits As Char() = {"०"c, "१"c, "२"c, "३"c, "४"c, "५"c, "६"c, "७"c, "८"c, "९"c}
    Dim latin_digits As Char() = {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c}
    Dim hindi_digits_enabled As Boolean
    Dim latin_digits_enabled As Boolean
    Dim hindi_India_currency_symbol As String
    Dim albanian_currency_symbol As String

    Dim total As Integer
    Dim cost As Decimal
    Dim conversionRatio As Decimal
    Dim tacosPerMin As Decimal
    Private Sub xlt_digits_to_H(ByRef latin As String)
        Dim i As Integer
        For i = 0 To 9
            latin = latin.Replace(latin_digits(i), hindi_digits(i))
        Next i
    End Sub

    Private Sub DefineDisneylandCulture()
        Dim disneylandCurrencyGroupSizes As Integer() = {3, 3}
        Dim disneylandNumberGroupSizes As Integer() = {4, 3}
        disneylandCulture.NumberFormat.CurrencyDecimalDigits = 2
        disneylandCulture.NumberFormat.CurrencyDecimalSeparator = "."
        disneylandCulture.NumberFormat.CurrencyGroupSizes = disneylandCurrencyGroupSizes
        disneylandCulture.NumberFormat.CurrencyGroupSeparator = ","
        disneylandCulture.NumberFormat.CurrencySymbol = "ஜ"
        disneylandCulture.NumberFormat.CurrencyPositivePattern = 1
        disneylandCulture.NumberFormat.NumberGroupSizes = disneylandNumberGroupSizes
        disneylandCulture.NumberFormat.NumberGroupSeparator = "*"
        disneylandCulture.DateTimeFormat.FullDateTimePattern = "yyyy:MM:dd HHmm"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        displayMode = "N"
        DefineDisneylandCulture()
    End Sub

    Private Sub Values()
        resx_cur = resx_money
        amountSoldLabel.Text = resx_cur.GetString("amountSoldLabel")
        total = Convert.ToInt32(resx_cur.GetString("amountSoldLabel"))
        costDisplayLabel.Text = resx_cur.GetString("costDisplayLabel")
        cost = Convert.ToDecimal(resx_cur.GetString("costDisplayLabel"))
    End Sub

    Private Sub myRefresh()
        If hindi_digits_enabled Then
            xlt_digits_to_H(costDisplayLabel.Text)
            xlt_digits_to_H(amountSoldLabel.Text)
            xlt_digits_to_H(dateTimeLabel.Text)
        End If
    End Sub

    Private Sub UsaFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usaFlagPictureBox.Click
        currentCulture = usaCulture
        Values()
        conversionRatio = Convert.ToDecimal(resx_cur.GetString("usConversion"))
        cost = cost * conversionRatio
        hindi_digits_enabled = False
        myRefresh()
        Thread.CurrentThread.CurrentUICulture = currentCulture
    End Sub

    Private Sub IndiaFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles indiaFlagPictureBox.Click
        currentCulture = indiaCulture
        Values()
        conversionRatio = Convert.ToDecimal(resx_cur.GetString("indiaConversion"))
        cost = cost * conversionRatio
        hindi_India_currency_symbol = indiaCulture.NumberFormat.CurrencySymbol
        hindi_digits_enabled = True
        latin_digits_enabled = False
        myRefresh()
        Thread.CurrentThread.CurrentUICulture = currentCulture
    End Sub
    Private Sub DisneylandFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disneylandFlagPictureBox.Click
        currentCulture = disneylandCulture
        Values()
        conversionRatio = Convert.ToDecimal(resx_cur.GetString("disneylandConversion"))
        cost = cost * conversionRatio
        hindi_digits_enabled = False
        myRefresh()
        Thread.CurrentThread.CurrentUICulture = currentCulture
    End Sub

    Private Sub AlbaniaFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles albaniaFlagPictureBox.Click
        currentCulture = albaniaCulture
        Values()
        conversionRatio = Convert.ToDecimal(resx_cur.GetString("albaniaConversion"))
        cost = cost * conversionRatio
        albanian_currency_symbol = albaniaCulture.NumberFormat.CurrencySymbol
        hindi_digits_enabled = False
        myRefresh()
        Thread.CurrentThread.CurrentUICulture = currentCulture
    End Sub

    Private Sub dateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateTimer.Tick
        dateTimeLabel.Text = DateTime.Now().ToString("F", currentCulture)
        myRefresh()
    End Sub

    Private Sub valuesTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valuesTimer.Tick
        If Thread.CurrentThread.CurrentUICulture IsNot currentCulture Then
        ElseIf Thread.CurrentThread.CurrentUICulture Is currentCulture Then
            tacosPerMin = 4.95 * 600
            total += 600
            cost += tacosPerMin * conversionRatio
            amountSoldLabel.Text = total.ToString("N", currentCulture)
            costDisplayLabel.Text = cost.ToString("C", currentCulture)
        End If
    End Sub

End Class
