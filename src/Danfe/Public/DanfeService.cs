using System;
using System.IO;
using System.Xml.Serialization;

namespace Direction.NFSe.Danfe;

public sealed class DanfeService
{
    private readonly DanfeHtmlRenderer _renderer;

    public DanfeService(DanfeOptions? options = null)
    {
        options ??= new DanfeOptions();
        _renderer = new DanfeHtmlRenderer(options);
    }

    public DanfeResult RenderHtml(NFSeSchema nfse, DanfeEnvironment environment, DanfeStatus status = DanfeStatus.Autorizada)
    {
        var (html, warnings) = _renderer.RenderInternal(nfse, environment, status);

        return new DanfeResult
        {
            Environment = environment,
            Html = html,
            Warnings = warnings
        };
    }

    public DanfeResult RenderHtml(string xml, DanfeEnvironment environment, DanfeStatus status = DanfeStatus.Autorizada)
    {
        using var sr = new StringReader(xml);
        return RenderHtml(Deserialize(sr), environment, status);
    }

    public DanfeResult RenderHtml(Stream xmlStream, DanfeEnvironment environment, DanfeStatus status = DanfeStatus.Autorizada)
    {
        using var sr = new StreamReader(xmlStream);
        return RenderHtml(Deserialize(sr), environment, status);
    }
    private static NFSeSchema Deserialize(TextReader reader)
    {
        var serializer = new XmlSerializer(typeof(NFSeSchema));
        var obj = serializer.Deserialize(reader);
        if (obj is not NFSeSchema nfse)
            throw new InvalidOperationException("Falha ao desserializar NFSeSchema.");

        return nfse;
    }
}
