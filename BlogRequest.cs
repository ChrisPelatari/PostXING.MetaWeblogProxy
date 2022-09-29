// PostXING.MetaBlogProvider.BlogRequest
using CookComputing.XmlRpc;

public class BlogRequest : XmlRpcClientProtocol {
	[XmlRpcMethod("blogger.getUsersBlogs", Description = "Returns information on all the blogs a given user is a member.")]
	public bgBlogInfo[] getUsersBlogs(string appKey, string username, string password) {
		return (bgBlogInfo[])Invoke("getUsersBlogs", new object[3] { appKey, username, password });
	}
}
