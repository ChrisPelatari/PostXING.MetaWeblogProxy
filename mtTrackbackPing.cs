// PostXING.MetaWeblogProxy.mtTrackbackPing
using CookComputing.XmlRpc;

public struct mtTrackbackPing {
	[XmlRpcMember(Description = "The title of the entry sent in the ping.")]
	public string pingTitle;

	[XmlRpcMember(Description = "The URL of the entry.")]
	public string pingURL;

	[XmlRpcMember(Description = "The IP address of the host that sent the ping.")]
	public string pingIP;
}
