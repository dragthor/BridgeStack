namespace BridgeStack
{
	/// <summary>
	/// Default values for queries coming from a particular client instance.
	/// </summary>
	internal sealed class StackClientDefaults : IStackClientDefaults
	{
		/// <summary>
		/// Default filter for all requests.
		/// </summary>
		public string Filter { get; set; }

		/// <summary>
		/// Default page size for all requests.
		/// </summary>
		public int? PageSize { get; set; }

		/// <summary>
		/// Default target network site for all requests.
		/// </summary>
		public string Site { get; set; }
	}
}