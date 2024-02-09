Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class Form1
    Dim filePath As String

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        'selalu di clear
        Clear()

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "All Files|*.*" ' Filter semua jenis file
        openFileDialog.Title = "Select a File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            filePath = openFileDialog.FileName
        End If

        Label1.Text = filePath
        ReadFile()
    End Sub

    Private Sub Clear()
        ' Reset Label for filepath
        Label1.Text = ""
        ' Reset DataGridView
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        ' Reset PictureBox
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Clear()
    End Sub

    Private Sub DisplayJsonInDataGridView(jsonContent As String)
        Dim jsonArray As JArray = JArray.Parse(jsonContent)
        Dim dataTable As New DataTable()

        ' Membuat kolom sesuai dengan properti JSON
        For Each jsonObject As JObject In jsonArray
            For Each prop As JProperty In jsonObject.Properties()
                dataTable.Columns.Add(prop.Name)
            Next
            ' Keluar dari loop setelah iterasi pertama
            Exit For
        Next

        ' Menambahkan baris ke DataTable
        For Each jsonObject As JObject In jsonArray
            Dim row As DataRow = dataTable.NewRow()
            For Each prop As JProperty In jsonObject.Properties()
                row(prop.Name) = prop.Value.ToString()
            Next
            dataTable.Rows.Add(row)
        Next

        ' Menetapkan DataTable sebagai DataSource untuk DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub ReadFile()
        If Not String.IsNullOrEmpty(filePath) Then
            Dim extension As String = Path.GetExtension(filePath)

            Select Case extension.ToLower()
                Case ".json"
                    ' Memeriksa jika file adalah JSON
                    Try
                        Dim jsonContent As String = File.ReadAllText(filePath)
                        DisplayJsonInDataGridView(jsonContent)
                        ' MessageBox.Show("JSON Content: " & vbCrLf & jsonContent, "JSON File Content")
                    Catch ex As Exception
                        MessageBox.Show("Error reading JSON file: " & ex.Message)
                    End Try

                Case ".jpg", ".jpeg", ".png", ".gif"
                    ' Memeriksa jika file adalah gambar
                    Try
                        ' Memuat gambar dari file ke PictureBox
                        DisplayImageWithResize(filePath)
                    Catch ex As Exception
                        MessageBox.Show("Error displaying image: " & ex.Message)
                    End Try

                Case Else
                    MessageBox.Show("Unsupported file type. Only JSON and image files are supported.")
            End Select
        Else
            MessageBox.Show("Please select a file first.")
        End If
    End Sub

    Private Sub DisplayImageWithResize(imagePath As String)
        Try
            ' Memuat gambar dari file
            Dim originalImage As Image = Image.FromFile(imagePath)

            ' Menghitung rasio aspek gambar
            Dim aspectRatio As Double = CDbl(originalImage.Width) / CDbl(originalImage.Height)

            ' Mengatur ukuran PictureBox
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            ' Mengatur gambar dengan ukuran yang sesuai dengan PictureBox
            If originalImage.Width > PictureBox1.Width Or originalImage.Height > PictureBox1.Height Then
                ' Jika gambar lebih besar dari PictureBox, maka diperkecil agar muat
                PictureBox1.Image = New Bitmap(originalImage, New Size(CInt(PictureBox1.Width), CInt(PictureBox1.Width / aspectRatio)))
            Else
                ' Jika gambar lebih kecil dari PictureBox, maka diatur sesuai ukuran aslinya
                PictureBox1.Image = originalImage
            End If
        Catch ex As Exception
            MessageBox.Show("Error displaying image: " & ex.Message)
        End Try
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        ' Panggil method Application.Exit() untuk menutup aplikasi
        Application.Exit()
    End Sub
End Class
