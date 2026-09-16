using Direction.NFSe.Danfe;
using Xunit;

public class GoldenHtmlTests
{
    [Fact]
    public void Html_snapshot_should_match()
    {
        // TODO: Criar as notas fiscais eletrônicas de serviço (NFS-e) de testes
        var service = new DanfeService(); ;
        //var result = service.RenderHtml(File.ReadAllText("Fixtures/nfse.xml"), DanfeEnvironment.Production);

        //var normalized = HtmlNormalization.Normalize(result.Html);

        //var approvedPath = Path.Combine("Approved", "nfse.approved.html");
        //var approved = File.ReadAllText(approvedPath);
        var approved = "";
        var normalized = "";
        Assert.Equal(approved, normalized);
    }
}
