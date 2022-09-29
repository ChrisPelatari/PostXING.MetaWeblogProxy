// PostXING.MetaBlogProvider.mtPostTitle
using System;
using CookComputing.XmlRpc;

public struct mtPostTitle {
	[XmlRpcMember(Description = "This is in the timezone of the weblog blogid.")]
	public DateTime created;

	public string postid;

	public string userid;

	public string title;
}
