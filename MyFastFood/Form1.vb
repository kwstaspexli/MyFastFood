Public Class Form1
    Private Foods(5) As String
    Private Foodsprice(5) As Integer
    Dim gyros As Image
    Dim soutzoukaki As Image
    Dim souvlaki As Image
    Dim xwriatiki As Image
    Dim prasini As Image
    Dim gemista As Image

    Private Drinks(3) As String
    Private Drinksprice(3) As Integer

    Dim fanta As Image
    Dim kokakola As Image
    Dim nero As Image
    Dim lemonada As Image

    Dim Synolo As Integer










    Private Sub O_KOSTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Foods(0) = "γυρος"
        Foods(1) = "σουτζουκακι"
        Foods(2) = "σουβλακι"
        Foods(3) = "χωριατικη"
        Foods(4) = "πρασινη"
        Foods(5) = "γεμιστα"

        Foodsprice(0) = 6
        Foodsprice(1) = 5
        Foodsprice(2) = 4
        Foodsprice(3) = 3
        Foodsprice(4) = 2
        Foodsprice(5) = 7
        FoodsListBox1.Items.AddRange(Foods)

        Drinks(0) = "πορτοκαλαδα"
        Drinks(1) = "κοκακολα"
        Drinks(2) = "νερο"
        Drinks(3) = "λεμοναδα"

        Drinksprice(0) = 2
        Drinksprice(1) = 3
        Drinksprice(2) = 1
        Drinksprice(3) = 2
        DrinksListBox1.Items.AddRange(Drinks)



    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FoodsListBox1.SelectedIndexChanged

    End Sub

    Private Sub FoodsListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles FoodsListBox1.SelectedValueChanged
        Dim idx As Integer
        idx = FoodsListBox1.SelectedIndex

        Dim foodtype As String
        foodtype = Foods(idx)


        gyros = MyFastFood.My.Resources.gyros
        soutzoukaki = MyFastFood.My.Resources.soutzoukakia
        souvlaki = MyFastFood.My.Resources.souvlaki
        xwriatiki = MyFastFood.My.Resources.xwriatiki
        prasini = MyFastFood.My.Resources.prasini
        gemista = MyFastFood.My.Resources.gemista

        Select Case foodtype

            Case "γυρος"
                foodicon1.Image = gyros
            Case "σουτζουκακι"
                foodicon1.Image = soutzoukaki
            Case "σουβλακι"
                foodicon1.Image = souvlaki
            Case "χωριατικη"
                foodicon1.Image = xwriatiki
            Case "πρασινη"
                foodicon1.Image = prasini
            Case "γεμιστα"
                foodicon1.Image = gemista
            Case Else
                Console.WriteLine("Looks like your food is not on my list")
        End Select





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idxxx As Integer
        idxxx = FoodsListBox1.SelectedIndex

        Dim foodtype As String
        foodtype = Foods(idxxx)

        Dim strposotita As String
        strposotita = Me.NumericUpDown1.Value.ToString
        Convert.ToInt32(strposotita)
        Dim strTimi As Integer
        strTimi = Foodsprice(idxxx)
        Convert.ToInt32(strTimi)

        Dim row As DataGridViewRow
        row = DataGridView1.Rows(0).Clone
        row.Cells(0).Value = foodtype
        row.Cells(1).Value = strposotita
        row.Cells(2).Value = strTimi
        DataGridView1.Rows.Add(row)


        Synolo += (strposotita * strTimi)
        stimi.Text = Str(Synolo)


















    End Sub

    Private Sub DrinkListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles DrinksListBox1.SelectedValueChanged
        Dim idx As Integer
        idx = DrinksListBox1.SelectedIndex

        Dim Drinktype As String
        Drinktype = Drinks(idx)


        fanta = MyFastFood.My.Resources.fanta
        kokakola = MyFastFood.My.Resources.kokakola
        nero = MyFastFood.My.Resources.nero
        lemonada = MyFastFood.My.Resources.lemonada

        Select Case Drinktype

            Case "πορτοκαλαδα"
                Drinkicon.Image = fanta
            Case "κοκακολα"
                Drinkicon.Image = kokakola
            Case "νερο"
                Drinkicon.Image = nero
            Case "λεμοναδα"
                Drinkicon.Image = lemonada
            Case Else
                Console.WriteLine("Looks like your food is not on my list")
        End Select

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim idxxx As Integer
        idxxx = DrinksListBox1.SelectedIndex

        Dim Drinktype As String
        Drinktype = Drinks(idxxx)

        Dim strposotita As String
        strposotita = Me.NumericUpDown1.Value.ToString
        Convert.ToInt32(strposotita)
        Dim strTimi As Integer
        strTimi = Drinksprice(idxxx)
        Convert.ToInt32(strTimi)

        Dim row As DataGridViewRow
        row = DataGridView1.Rows(0).Clone
        row.Cells(0).Value = Drinktype
        row.Cells(1).Value = strposotita
        row.Cells(2).Value = strTimi
        DataGridView1.Rows.Add(row)


        Synolo += (strposotita * strTimi)
        stimi.Text = Str(Synolo)
    End Sub
End Class
