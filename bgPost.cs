// PostXING.MetaWeblogProxy.bgPost
using System;
using CookComputing.XmlRpc;

public struct bgPost {
	public DateTime dateCreated;

	[XmlRpcMember(Description = "Depending on server may be either string or integer. Use Convert.ToInt32(userid) to treat as integer or Convert.ToString(userid) to treat as string")]
	public object userid;

	public string postid;

	public string content;
}
