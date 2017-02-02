Imports System.Security.Cryptography.X509Certificates
Public Class FrmMain
    Sub New()
        InitializeComponent()
    End Sub
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LV.FullRowSelect = True
        LV.MultiSelect = False
        LV.View = View.Details
        LV.Columns.Add("File", 250)
        LV.Columns.Add("Signed", 100)
        LV.Columns.Add("Publisher", 0)
        LV.Columns.Add("Valid From", 0)
        LV.Columns.Add("Valid To", 0)
        LV.Columns.Add("Issued By", 0)
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OFD.Filter = "All files|*.*"
        OFD.FileName = ""
        OFD.InitialDirectory = Application.StartupPath
        If (OFD.ShowDialog() = DialogResult.OK) Then

            Dim theCertificate As X509Certificate2
            Dim chainIsValid As Boolean = False
            Dim theCertificateChain = New X509Chain()

            Try
                Dim theSigner As X509Certificate = X509Certificate.CreateFromSignedFile(OFD.FileName)
                theCertificate = New X509Certificate2(theSigner)
            Catch ex As Exception
                LV.Items.Add(OFD.FileName)
                LV.Items(LV.Items.Count - 1).SubItems.Add("Unsigned")
                LV.Items(LV.Items.Count - 1).SubItems.Add("N/A")
                LV.Items(LV.Items.Count - 1).SubItems.Add("N/A")
                LV.Items(LV.Items.Count - 1).SubItems.Add("N/A")
                LV.Items(LV.Items.Count - 1).SubItems.Add("N/A")
                LV.Items(LV.Items.Count - 1).BackColor = Color.Pink
                Return
            End Try

            theCertificateChain.ChainPolicy.RevocationFlag = X509RevocationFlag.ExcludeRoot
            theCertificateChain.ChainPolicy.RevocationMode = X509RevocationMode.Online
            theCertificateChain.ChainPolicy.UrlRetrievalTimeout = New TimeSpan(0, 1, 0)
            theCertificateChain.ChainPolicy.VerificationFlags = X509VerificationFlags.NoFlag
            chainIsValid = theCertificateChain.Build(theCertificate)

            If chainIsValid Then

                LV.Items.Add(OFD.FileName)
                LV.Items(LV.Items.Count - 1).SubItems.Add("Signed")
                LV.Items(LV.Items.Count - 1).SubItems.Add(theCertificate.SubjectName.Name)
                LV.Items(LV.Items.Count - 1).SubItems.Add(theCertificate.GetEffectiveDateString())
                LV.Items(LV.Items.Count - 1).SubItems.Add(theCertificate.GetExpirationDateString())
                LV.Items(LV.Items.Count - 1).SubItems.Add(theCertificate.Issuer)

            Else
                LV.Items.Add(OFD.FileName)
                LV.Items(LV.Items.Count - 1).SubItems.Add("Unsigned")
                LV.Items(LV.Items.Count - 1).SubItems.Add("N/A")
                LV.Items(LV.Items.Count - 1).SubItems.Add("N/A")
                LV.Items(LV.Items.Count - 1).SubItems.Add("N/A")
                LV.Items(LV.Items.Count - 1).SubItems.Add("N/A")
                LV.Items(LV.Items.Count - 1).BackColor = Color.Pink
            End If

        Else

            Return

        End If
    End Sub

    Private Sub LV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedItems.Count > 0 Then
            Dim SelectedItem As ListView.SelectedListViewItemCollection = LV.SelectedItems

            LB.Items.Clear()
            LB.Items.Add("File Path:" & SelectedItem(0).Text)
            LB.Items.Add("Signed:" & SelectedItem(0).SubItems(1).Text)
            LB.Items.Add("Publisher Information :" & SelectedItem(0).SubItems(2).Text)
            LB.Items.Add("Valid From:" & SelectedItem(0).SubItems(3).Text)
            LB.Items.Add("Valid To:" & SelectedItem(0).SubItems(4).Text)
            LB.Items.Add("Issued By:" & SelectedItem(0).SubItems(5).Text)
        End If

    End Sub
End Class
