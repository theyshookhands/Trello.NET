namespace TrelloNet.Internal.Requests
{
	internal class BoardListsRequest : BoardRequest
	{
		public BoardListsRequest(IBoardId boardId, ListFilter filter)
			: base(boardId, "lists")
		{
			this.AddFilter(filter);
		}
	}
}