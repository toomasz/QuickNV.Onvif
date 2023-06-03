using System;
using System.Net;

namespace Quick.Onvif.Discovery.Common.Discovery;

public class DiscoverySocketEventArgs : EventArgs
{
	public byte[] Message { get; set; }

	public IPEndPoint Source { get; set; }
}
