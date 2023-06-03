using System.Xml;

namespace Quick.Onvif.Discovery.Common.Soap;

public interface ISoapHeaderBuilder
{
	void WriteHeader(XmlWriter writer, object message);
}
