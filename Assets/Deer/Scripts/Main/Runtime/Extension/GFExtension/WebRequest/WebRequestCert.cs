using UnityEngine.Networking;
public class WebRequestCert : CertificateHandler
{
    protected override bool ValidateCertificate(byte[] certificateData)
    {
        return true;
    }
}
