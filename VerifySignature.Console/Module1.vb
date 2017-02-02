Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms
Module Module1

    Sub Main()

        Dim OFD As New OpenFileDialog

        OFD.FileName = ""
        OFD.Filter = "All files|*.*"
        OFD.Title = "Select File"

        If (OFD.ShowDialog() = DialogResult.OK) Then

            Dim theCertificate As X509Certificate2
            Dim chainIsValid As Boolean = False
            Dim theCertificateChain = New X509Chain()

            Try

                Dim theSigner As X509Certificate = X509Certificate.CreateFromSignedFile(OFD.FileName)
                theCertificate = New X509Certificate2(theSigner)

            Catch ex As Exception

                System.Console.WriteLine(OFD.FileName)
                System.Console.WriteLine("Signed:Unsigned")
                System.Console.ReadLine()
                Return

            End Try

            theCertificateChain.ChainPolicy.RevocationFlag = X509RevocationFlag.ExcludeRoot
            theCertificateChain.ChainPolicy.RevocationMode = X509RevocationMode.Online
            theCertificateChain.ChainPolicy.UrlRetrievalTimeout = New TimeSpan(0, 1, 0)
            theCertificateChain.ChainPolicy.VerificationFlags = X509VerificationFlags.NoFlag
            chainIsValid = theCertificateChain.Build(theCertificate)

            If chainIsValid Then

                System.Console.WriteLine(OFD.FileName)
                System.Console.WriteLine("Signed:Signed")
                System.Console.WriteLine("CertInfo:" & theCertificate.SubjectName.Name)
                System.Console.WriteLine("CertInfo:" & theCertificate.GetEffectiveDateString())
                System.Console.WriteLine("CertInfo:" & theCertificate.GetExpirationDateString())
                System.Console.WriteLine("CertInfo:" & theCertificate.Issuer)
                System.Console.ReadLine()

            Else

                System.Console.WriteLine(OFD.FileName)
                System.Console.WriteLine("Signed:Unsigned")
                System.Console.ReadLine()

            End If

        Else

            Return

        End If
    End Sub

End Module
