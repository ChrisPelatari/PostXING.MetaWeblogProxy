// PostXING.MetaWeblogProxy.mwPost
using System;
using CookComputing.XmlRpc;

[XmlRpcMissingMapping(MappingAction.Ignore)]
public struct mwPost {
	[XmlRpcMember(Description = "Required when posting.")]
	[XmlRpcMissingMapping(MappingAction.Error)]
	public DateTime dateCreated;

	[XmlRpcMember(Description = "Required when posting.")]
	[XmlRpcMissingMapping(MappingAction.Error)]
	public string description;

	[XmlRpcMember(Description = "Required when posting.")]
	[XmlRpcMissingMapping(MappingAction.Error)]
	public string title;

	[XmlRpcMember]
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public string[] categories;

	[XmlRpcMember]
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public mwEnclosure enclosure;

	[XmlRpcMissingMapping(MappingAction.Ignore)]
	[XmlRpcMember]
	public string link;

	[XmlRpcMember]
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public string permalink;

	[XmlRpcMissingMapping(MappingAction.Ignore)]
	[XmlRpcMember(Description = "Not required when posting. Depending on server may be either string or integer. Use Convert.ToInt32(postid) to treat as integer or Convert.ToString(postid) to treat as string")]
	public string postid;

	[XmlRpcMember]
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public mwSource source;

	[XmlRpcMember]
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public string userid;

	[XmlRpcMissingMapping(MappingAction.Ignore)]
	[XmlRpcMember]
	public int mt_allow_comments;

	[XmlRpcMember]
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public int mt_allow_pings;

	[XmlRpcMember]
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public int mt_convert_breaks;

	[XmlRpcMember]
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public string mt_text_more;

	[XmlRpcMissingMapping(MappingAction.Ignore)]
	[XmlRpcMember]
	public string mt_excerpt;
}
