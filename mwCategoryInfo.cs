// PostXING.MetaBlogProvider.mwCategoryInfo
using CookComputing.XmlRpc;

public struct mwCategoryInfo {
	public string description;

	public string htmlUrl;

	public string rssUrl;

	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public string title;

	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public string categoryid;
}
