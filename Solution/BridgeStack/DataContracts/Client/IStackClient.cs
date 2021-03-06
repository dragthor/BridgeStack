using System;

namespace BridgeStack
{
	/// <summary>
	/// Exposes methods to access the StackExchange API. Excludes methods that require authentication.
	/// <para>Documentation can be found following the link below:</para>
	/// <para>https://api.stackexchange.com/docs</para>
	/// </summary>
	public interface IStackClient
	{
		/// <summary>
		/// The application's key. Grants a higher request quota.
		/// </summary>
		string AppKey { get; }
		/// <summary>
		/// The default values for this client.
		/// </summary>
		IDefaults Default { get; }
		/// <summary>
		/// Event log message dispatcher.
		/// </summary>
		IEventLog EventLog { get; }
		/// <summary>
		/// Internal response cache store for the API.
		/// </summary>
		IResponseCache Cache { get; }
		/// <summary>
		/// Request throttler implementation instance.
		/// </summary>
		IRequestThrottler Throttler { get; }

		#region API

		#region Answer

		/// <summary>
		/// Makes a request to API method /answers
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/answers</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all the undeleted answers in the system.</returns>
		IBridgeResponseCollection<Answer> GetAnswers(PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /answers/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/answers-by-ids</para>
		/// </summary>
		/// <param name="ids">The answer {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the set of answers identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<Answer> GetAnswers(long[] ids, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /answers/{ids}/comments
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments-on-answers</para>
		/// </summary>
		/// <param name="ids">The answer {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comments on a set of answers identified by <paramref name="ids"/>..</returns>
		IBridgeResponseCollection<Comment> GetAnswersComments(long[] ids, CommentsQuery parameters = null);

		/// <summary>
		/// Makes a request to API method /answers/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/answers-by-ids</para>
		/// </summary>
		/// <param name="id">The single answer in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the answer identified by <paramref name="id"/>.</returns>
		IBridgeResponseItem<Answer> GetAnswer(long id, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /answers/{ids}/comments
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments-on-answers</para>
		/// </summary>
		/// <param name="id">The single answer in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comments on an answers identified by <paramref name="id"/>..</returns>
		IBridgeResponseCollection<Comment> GetAnswerComments(long id, CommentsQuery parameters = null);

		#endregion

		#region Badges

		/// <summary>
		/// Makes a request to API method /badges
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/badges</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all the badges in the system.</returns>
		IBridgeResponseCollection<Badge> GetBadges(BadgesNamedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /badges/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/badges-by-ids</para>
		/// </summary>
		/// <param name="ids">The badge {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the set of badges identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<Badge> GetBadges(long[] ids, BadgesQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /badges/recipients
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/badge-recipients</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns recently awarded badges in the system.</returns>
		IBridgeResponseCollection<Badge> GetBadgesRecipients(RangedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /badges/{ids}/recipients
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/badge-recipients-by-ids</para>
		/// </summary>
		/// <param name="ids">The badge {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns recently awarded badges in the system, constrained to a certain set of badges identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<Badge> GetBadgesRecipients(long[] ids, RangedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /badges/name
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/badges-by-name</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all explicitly named badges in the system.</returns>
		IBridgeResponseCollection<Badge> GetBadgesExplicitlyNamed(BadgesNamedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /badges/tags
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/badges-by-tag</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the badges that are awarded for participation in specific tags.</returns>
		IBridgeResponseCollection<Badge> GetBadgesOnTags(BadgesNamedQuery parameters = null);

		/// <summary>
		/// Makes a request to API method /badges/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/badges-by-ids</para>
		/// </summary>
		/// <param name="id">The single badge in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the badge identified by <paramref name="id"/>.</returns>
		IBridgeResponseItem<Badge> GetBadge(long id, BadgesQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /badges/{ids}/recipients
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/badge-recipients-by-ids</para>
		/// </summary>
		/// <param name="id">The single badge in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns recently awarded badges in the system, constrained to a badge identified by <paramref name="id"/>.</returns>
		IBridgeResponseCollection<Badge> GetBadgeRecipients(long id, RangedQuery parameters = null);
		#endregion

		#region Comments

		/// <summary>
		/// Makes a request to API method /comments
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all the comments on the site.</returns>
		IBridgeResponseCollection<Comment> GetComments(CommentsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /comments/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments-by-ids</para>
		/// </summary>
		/// <param name="ids">The comment {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the set of comments identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<Comment> GetComments(long[] ids, CommentsQuery parameters = null);

		/// <summary>
		/// Makes a request to API method /comments/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments-by-ids</para>
		/// </summary>
		/// <param name="id">The single comment in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comment identified by <paramref name="id"/>.</returns>
		IBridgeResponseItem<Comment> GetComment(long id, CommentsQuery parameters = null);

		#endregion

		#region Errors

		/// <summary>
		/// Makes a request to API method /errors
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/errors</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the various error codes that can be produced by the API.</returns>
		IBridgeResponseCollection<ApiException> GetErrors(SimpleQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /errors/{id}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/simulate-error</para>
		/// </summary>
		/// <param name="id">The id of the error to simulate</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>This method allows you to generate an error.</returns>
		IBridgeResponseItem<ApiException> SimulateError(int id, SiteQuery parameters = null);

		#endregion

		#region Posts

		/// <summary>
		/// Makes a request to API method /posts
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/posts</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all the posts (questions and answers) in the system.</returns>
		IBridgeResponseCollection<Post> GetPosts(PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /posts/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/posts-by-ids</para>
		/// </summary>
		/// <param name="ids">The posts {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the set of posts (questions and answers) identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<Post> GetPosts(long[] ids, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /posts/{ids}/comments
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments-on-posts</para>
		/// </summary>
		/// <param name="ids">The posts {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comments on the posts identified by <paramref name="ids"/>, regardless of the type of the posts.</returns>
		IBridgeResponseCollection<Comment> GetPostsComments(long[] ids, CommentsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /posts/{ids}/revisions
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/revisions-by-ids</para>
		/// </summary>
		/// <param name="ids">The posts {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the edit revisions on the posts identified by <paramref name="ids"/>, regardless of the type of the posts.</returns>
		IBridgeResponseCollection<Revision> GetPostsRevisions(long[] ids, RangedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /posts/{ids}/suggested-edits
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/posts-on-suggested-edits</para>
		/// </summary>
		/// <param name="ids">The posts {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the suggested edits on the posts identified by <paramref name="ids"/>, regardless of the type of the posts.</returns>
		IBridgeResponseCollection<SuggestedEdit> GetPostsSuggestedEdits(long[] ids, SuggestedEditsQuery parameters = null);

		/// <summary>
		/// Makes a request to API method /posts/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/posts-by-ids</para>
		/// </summary>
		/// <param name="id">The single post in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the post identified by <paramref name="id"/>.</returns>
		IBridgeResponseItem<Post> GetPost(long id, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /posts/{ids}/comments
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments-on-posts</para>
		/// </summary>
		/// <param name="id">The single post in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comments on the post identified by <paramref name="id"/>.</returns>
		IBridgeResponseCollection<Comment> GetPostComments(long id, CommentsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /posts/{ids}/revisions
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/revisions-by-ids</para>
		/// </summary>
		/// <param name="id">The single post in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the edit revisions on the post identified by <paramref name="id"/>.</returns>
		IBridgeResponseCollection<Revision> GetPostRevisions(long id, RangedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /posts/{ids}/suggested-edits
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/posts-on-suggested-edits</para>
		/// </summary>
		/// <param name="id">The single post in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the suggested edits on the post identified by <paramref name="id"/>.</returns>
		IBridgeResponseCollection<SuggestedEdit> GetPostSuggestedEdits(long id, SuggestedEditsQuery parameters = null);

		#endregion

		#region Privileges

		/// <summary>
		/// Makes a request to API method /privileges
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/privileges</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the privileges that can be earned on a site.</returns>
		IBridgeResponseCollection<Privilege> GetPrivileges(SimpleQuery parameters = null);

		#endregion

		#region Questions

		/// <summary>
		/// Makes a request to API method /questions
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/questions</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all the questions in the system.</returns>
		IBridgeResponseCollection<Question> GetQuestions(QuestionsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/questions-by-ids</para>
		/// </summary>
		/// <param name="ids">The question {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the set of questions identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<Question> GetQuestions(long[] ids, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/{ids}/answers
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/answers-on-questions</para>
		/// </summary>
		/// <param name="ids">The question {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the answers on the questions identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<Answer> GetQuestionsAnswers(long[] ids, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/{ids}/comments
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments-on-questions</para>
		/// </summary>
		/// <param name="ids">The question {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comments on the questions identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<Comment> GetQuestionsComments(long[] ids, CommentsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/{ids}/linked
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/linked-questions</para>
		/// </summary>
		/// <param name="ids">The question {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the questions which link to those identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<Question> GetQuestionsLinked(long[] ids, QuestionsRelatedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/{ids}/related
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/related-questions</para>
		/// </summary>
		/// <param name="ids">The question {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns questions that the site considers related to those identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<Question> GetQuestionsRelated(long[] ids, QuestionsRelatedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/{ids}/timeline
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/questions-timeline</para>
		/// </summary>
		/// <param name="ids">The question {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the timeline for questions identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<QuestionTimeline> GetQuestionsTimeline(long[] ids, RangedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/unanswered
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/unanswered-questions</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns questions the site considers to be unanswered.</returns>
		IBridgeResponseCollection<Question> GetQuestionsConsideredUnanswered(PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/no-answers
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/no-answer-questions</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns questions which have received no answers.</returns>
		IBridgeResponseCollection<Question> GetQuestionsWithNoAnswers(PostsQuery parameters = null);

		/// <summary>
		/// Makes a request to API method /questions/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/questions-by-ids</para>
		/// </summary>
		/// <param name="id">The single question in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the set of question identified by <paramref name="id"/>.</returns>
		IBridgeResponseItem<Question> GetQuestion(long id, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/{ids}/answers
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/answers-on-questions</para>
		/// </summary>
		/// <param name="id">The single question in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the answers on the question identified by <paramref name="id"/>.</returns>
		IBridgeResponseCollection<Answer> GetQuestionAnswers(long id, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/{ids}/comments
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments-on-questions</para>
		/// </summary>
		/// <param name="id">The single question in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comments on the question identified by <paramref name="id"/>.</returns>
		IBridgeResponseCollection<Comment> GetQuestionComments(long id, CommentsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/{ids}/linked
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/linked-questions</para>
		/// </summary>
		/// <param name="id">The single question in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the questions which link to that identified by <paramref name="id"/>.</returns>
		IBridgeResponseCollection<Question> GetQuestionLinked(long id, QuestionsRelatedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/{ids}/related
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/related-questions</para>
		/// </summary>
		/// <param name="id">The single question in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns questions that the site considers related to that identified by <paramref name="id"/>.</returns>
		IBridgeResponseCollection<Question> GetQuestionRelated(long id, QuestionsRelatedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /questions/{ids}/timeline
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/questions-timeline</para>
		/// </summary>
		/// <param name="id">The single question in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the timeline for the question identified by <paramref name="id"/>.</returns>
		IBridgeResponseCollection<QuestionTimeline> GetQuestionTimeline(long id, RangedQuery parameters = null);

		#endregion

		#region Revisions

		/// <summary>
		/// Makes a request to API method /revisions/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/revisions-by-guids</para>
		/// </summary>
		/// <param name="guids">The revision {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns edit revisions identified by <paramref name="guids"/>.</returns>
		IBridgeResponseCollection<Revision> GetRevisions(Guid[] guids, RangedQuery parameters = null);

		/// <summary>
		/// Makes a request to API method /revisions/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/revisions-by-guids</para>
		/// </summary>
		/// <param name="guid">The single revision in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the edit revision identified by <paramref name="guid"/>.</returns>
		IBridgeResponseItem<Revision> GetRevision(Guid guid, RangedQuery parameters = null);

		#endregion

		#region Search

		/// <summary>
		/// Makes a request to API method /search
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/search</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns any questions which satisfy a search criteria.</returns>
		IBridgeResponseCollection<Question> Search(SearchQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /similar
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/similar</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns questions which are similar to a hypothetical one based on a title and tag combination.</returns>
		IBridgeResponseCollection<Question> Similar(SearchSimilarQuery parameters = null);

		#endregion

		#region Suggested Edits

		/// <summary>
		/// Makes a request to API method /suggested-edits
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/suggested-edits</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all the suggested edits in the system.</returns>
		IBridgeResponseCollection<SuggestedEdit> GetSuggestedEdits(SuggestedEditsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /suggested-edits/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/suggested-edits-by-ids</para>
		/// </summary>
		/// <param name="ids">The suggested edit {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the set of suggested edits identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<SuggestedEdit> GetSuggestedEdits(long[] ids, SuggestedEditsQuery parameters = null);

		/// <summary>
		/// Makes a request to API method /suggested-edits/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/suggested-edits-by-ids</para>
		/// </summary>
		/// <param name="id">The single suggested edit in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the suggested edis identified by <paramref name="id"/>.</returns>
		IBridgeResponseItem<SuggestedEdit> GetSuggestedEdit(long id, SuggestedEditsQuery parameters = null);

		#endregion

		#region Info

		/// <summary>
		/// Makes a request to API method /info
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/info</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns a collection of statistics about the site.</returns>
		IBridgeResponseItem<NetworkSiteStats> GetInfo(SiteQuery parameters = null);

		#endregion

		#region Tags

		/// <summary>
		/// Makes a request to API method /tags
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/tags</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all the tags found on a site.</returns>
		IBridgeResponseCollection<Tag> GetTags(TagsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /tags/synonyms
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/tag-synonyms</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all tag synonyms found a site.</returns>
		IBridgeResponseCollection<TagSynonym> GetTagSynonyms(TagSynonymsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /tags/{tags}/faq
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/faqs-by-tags</para>
		/// </summary>
		/// <param name="tags">The {tags} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the frequently asked questions for the given set of tags in <paramref name="tags"/>.</returns>
		IBridgeResponseCollection<Question> GetTagsFrequentlyAskedQuestions(string[] tags, SimpleQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /tags/{tags}/related
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/related-tags</para>
		/// </summary>
		/// <param name="tags">The {tags} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the tags that are most related to those in <paramref name="tags"/>.</returns>
		IBridgeResponseCollection<Tag> GetTagsRelated(string[] tags, SimpleQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /tags/{tags}/synonyms
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/synonyms-by-tags</para>
		/// </summary>
		/// <param name="tags">The {tags} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the tags synonyms for the given set of tags in <paramref name="tags"/>.</returns>
		IBridgeResponseCollection<TagSynonym> GetTagsSynonyms(string[] tags, TagSynonymsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /tags/{tag}/top-answerers/{period}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/top-answerers-on-tags</para>
		/// </summary>
		/// <param name="tag">A single {tag}.</param>
		/// <param name="period">The selected {period}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the top 30 answerers active in a single tag, of either all-time or the last 30 days.</returns>
		IBridgeResponseCollection<TagScore> GetTagTopAnswerers(string tag, QueryPeriodEnum period, TagScoresQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /tags/{tag}/top-askers/{period}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/top-askers-on-tags</para>
		/// </summary>
		/// <param name="tag">A single {tag}.</param>
		/// <param name="period">The selected {period}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the top 30 askers active in a single tag, of either all-time or the last 30 days.</returns>
		IBridgeResponseCollection<TagScore> GetTagTopAskers(string tag, QueryPeriodEnum period, TagScoresQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /tags/{tags}/wikis
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/wikis-by-tags</para>
		/// </summary>
		/// <param name="tags">The {tags} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the wikis that go with the given set of tags in {tags}.</returns>
		IBridgeResponseCollection<TagWiki> GetTagsWikis(string[] tags, SimpleQuery parameters = null);

		/// <summary>
		/// Makes a request to API method /tags/{tags}/faq
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/faqs-by-tags</para>
		/// </summary>
		/// <param name="tag">The single tag in {tags}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the frequently asked questions for the tag identified by <paramref name="tag"/>.</returns>
		IBridgeResponseCollection<Question> GetTagFrequentlyAskedQuestions(string tag, SimpleQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /tags/{tags}/related
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/related-tags</para>
		/// </summary>
		/// <param name="tag">The single tag in {tags}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the tags that are most related to that identified by <paramref name="tag"/>.</returns>
		IBridgeResponseCollection<Tag> GetTagRelated(string tag, TagsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /tags/{tags}/synonyms
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/synonyms-by-tags</para>
		/// </summary>
		/// <param name="tag">The single tag in {tags}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the tags synonyms for the tag identified by <paramref name="tag"/>.</returns>
		IBridgeResponseCollection<TagSynonym> GetTagSynonyms(string tag, TagSynonymsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /tags/{tags}/wikis
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/wikis-by-tags</para>
		/// </summary>
		/// <param name="tag">The single tag in {tags}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the tags wiki for the tag identified by <paramref name="tag"/>.</returns>
		IBridgeResponseItem<TagWiki> GetTagWiki(string tag, SimpleQuery parameters = null);
		#endregion

		#region Users

		#region Vectorized

		/// <summary>
		/// Makes a request to API method /users
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/users</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all the users in the system.</returns>
		IBridgeResponseCollection<User> GetUsers(UsersNamedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/users-by-ids</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the set of users identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<User> GetUsers(long[] ids, UsersQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/answers
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/answers-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the answers the users identified by <paramref name="ids"/> posted.</returns>
		IBridgeResponseCollection<Answer> GetUsersAnswers(long[] ids, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/badges
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/badges-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the badges the users identified by <paramref name="ids"/> earned.</returns>
		IBridgeResponseCollection<Badge> GetUsersBadges(long[] ids, BadgesOnUserQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/comments
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comments the users identified by <paramref name="ids"/> posted.</returns>
		IBridgeResponseCollection<Comment> GetUsersComments(long[] ids, CommentsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/comments/{toid}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments-by-users-to-user</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="toId">The user who's mentioned (being replied to). {toid} parameter.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comments the users identified by <paramref name="ids"/> posted in reply to  the single user identified by <paramref name="toId"/>.</returns>
		IBridgeResponseCollection<Comment> GetUsersCommentsInReplyTo(long[] ids, long toId, CommentsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/favorites
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/favorites-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the questions the users identified by <paramref name="ids"/> favorited.</returns>
		IBridgeResponseCollection<Question> GetUsersQuestionFavorites(long[] ids, QuestionFavoritesQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/mentioned
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/mentions-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comments the users identified by <paramref name="ids"/> were mentioned in.</returns>
		IBridgeResponseCollection<Comment> GetUsersMentions(long[] ids, CommentsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{id}/privileges
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/privileges-on-users</para>
		/// </summary>
		/// <param name="id">The single user {id}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the privileges the user identified by <paramref name="id"/> has.</returns>
		IBridgeResponseCollection<Privilege> GetUserPrivileges(long id, SimpleQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/questions
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/questions-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the questions the users identified by <paramref name="ids"/> asked.</returns>
		IBridgeResponseCollection<Question> GetUsersQuestions(long[] ids, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/questions/no-answers
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/no-answer-questions-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the questions the users identified by <paramref name="ids"/> asked, which have no answers.</returns>
		IBridgeResponseCollection<Question> GetUsersQuestionsWithNoAnswers(long[] ids, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/questions/unaccepted
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/unaccepted-questions-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the questions the users identified by <paramref name="ids"/> asked, which have at least one answer, but no accepted answer.</returns>
		IBridgeResponseCollection<Question> GetUsersQuestionsWithNoAcceptedAnswer(long[] ids, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/questions/unanswered
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/unanswered-questions-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the questions the users identified by <paramref name="ids"/> asked, which the site consideres unanswered, while still having at least one answer posted.</returns>
		IBridgeResponseCollection<Question> GetUsersQuestionsConsideredUnanswered(long[] ids, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/reputation
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/reputation-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the reputation changes for the users identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<Reputation> GetUsersReputationChanges(long[] ids, RangedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/suggested-edits
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/suggested-edits-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the suggested edits the users identified by <paramref name="ids"/> submitted.</returns>
		IBridgeResponseCollection<SuggestedEdit> GetUsersSuggestedEdits(long[] ids, SuggestedEditsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/tags
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/tags-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the tags the users identified by <paramref name="ids"/> have been active in.</returns>
		IBridgeResponseCollection<Tag> GetUsersActiveTags(long[] ids, TagsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/tags/{tags}/top-answers
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/top-user-answers-in-tags</para>
		/// </summary>
		/// /// <param name="id">The single user {id}.</param>
		/// <param name="tags">The {tags} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the top answers the users identified by <paramref name="id"/> has posted in response to questions with the given <paramref name="tags"/>.</returns>
		IBridgeResponseCollection<Answer> GetUserTopAnswers(long id, string[] tags, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/tags/{tags}/top-questions
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/top-user-questions-in-tags</para>
		/// </summary>
		/// /// <param name="id">The single user {id}.</param>
		/// <param name="tags">The {tags} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the top questions the users identified by <paramref name="id"/> has asked with the given <paramref name="tags"/>.</returns>
		IBridgeResponseCollection<Question> GetUserTopQuestions(long id, string[] tags, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/timeline
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/timeline-on-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns a subset of actions the users identified by <paramref name="ids"/> have taken on the system.</returns>
		IBridgeResponseCollection<UserTimeline> GetUsersTimeline(long[] ids, RangedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/top-answer-tags
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/top-answer-tags-on-users</para>
		/// </summary>
		/// <param name="id">The single user {id}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns a single user's top 30 tags by answer score.</returns>
		IBridgeResponseCollection<TagTop> GetUserTopAnswerTags(long id, SimpleQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/top-question-tags
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/top-question-tags-on-users</para>
		/// </summary>
		/// <param name="id">The single user {id}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns a single user's top 30 tags by question score.</returns>
		IBridgeResponseCollection<TagTop> GetUserTopQuestionTags(long id, SimpleQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/moderators
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/moderators</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Gets those users on a system who can exercise moderation powers.</returns>
		IBridgeResponseCollection<User> GetModerators(UsersQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/moderators/elected
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/elected-moderators</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns those users on a site who both have moderator powers, and were actually elected.</returns>
		IBridgeResponseCollection<User> GetModeratorsElected(UsersQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/associated
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/associated-users</para>
		/// </summary>
		/// <param name="ids">The user {ids} vector.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all of a user's associated accounts for a set of users identified by <paramref name="ids"/>.</returns>
		IBridgeResponseCollection<NetworkUser> GetUsersAssociatedAccounts(long[] ids, SimpleQuery parameters = null);

		#endregion

		#region Singular

		/// <summary>
		/// Makes a request to API method /users/{ids}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/users-by-ids</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the user identified by <paramref name="id"/>.</returns>
		IBridgeResponseItem<User> GetUser(long id, UsersQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/answers
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/answers-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the answers the user identified by <paramref name="id"/> posted.</returns>
		IBridgeResponseCollection<Answer> GetUserAnswers(long id, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/badges
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/badges-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the badges the user identified by <paramref name="id"/> earned.</returns>
		IBridgeResponseCollection<Badge> GetUserBadges(long id, BadgesOnUserQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/comments
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comments the user identified by <paramref name="id"/> posted.</returns>
		IBridgeResponseCollection<Comment> GetUserComments(long id, CommentsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/comments/{toid}
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/comments-by-users-to-user</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="toId">The user who's mentioned (being replied to). {toid} parameter.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comments the user identified by <paramref name="id"/> posted in reply to  the single user identified by <paramref name="toId"/>.</returns>
		IBridgeResponseCollection<Comment> GetUserCommentsInReplyTo(long id, long toId, CommentsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/favorites
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/favorites-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the questions the user identified by <paramref name="id"/> favorited.</returns>
		IBridgeResponseCollection<Question> GetUserQuestionFavorites(long id, QuestionFavoritesQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/mentioned
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/mentions-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the comments the user identified by <paramref name="id"/> were mentioned in.</returns>
		IBridgeResponseCollection<Comment> GetUserMentions(long id, CommentsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/questions
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/questions-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the questions the user identified by <paramref name="id"/> asked.</returns>
		IBridgeResponseCollection<Question> GetUserQuestions(long id, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/questions/no-answers
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/no-answer-questions-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the questions the user identified by <paramref name="id"/> asked, which have no answers.</returns>
		IBridgeResponseCollection<Question> GetUserQuestionsWithNoAnswers(long id, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/questions/unaccepted
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/unaccepted-questions-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the questions the user identified by <paramref name="id"/> asked, which have at least one answer, but no accepted answer.</returns>
		IBridgeResponseCollection<Question> GetUserQuestionsWithNoAcceptedAnswer(long id, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/questions/unanswered
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/unanswered-questions-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the questions the user identified by <paramref name="id"/> asked, which the site consideres unanswered, while still having at least one answer posted.</returns>
		IBridgeResponseCollection<Question> GetUserQuestionsConsideredUnanswered(long id, PostsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/reputation
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/reputation-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the reputation changes for the user identified by <paramref name="id"/>.</returns>
		IBridgeResponseCollection<Reputation> GetUserReputationChanges(long id, RangedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/suggested-edits
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/suggested-edits-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the suggested edits the user identified by <paramref name="id"/> submitted.</returns>
		IBridgeResponseCollection<SuggestedEdit> GetUserSuggestedEdits(long id, SuggestedEditsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/tags
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/tags-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns the tags the user identified by <paramref name="id"/> have been active in.</returns>
		IBridgeResponseCollection<Tag> GetUserActiveTags(long id, TagsQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/timeline
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/timeline-on-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns a subset of actions the user identified by <paramref name="id"/> have taken on the system.</returns>
		IBridgeResponseCollection<UserTimeline> GetUserTimeline(long id, RangedQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /users/{ids}/associated
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/associated-users</para>
		/// </summary>
		/// <param name="id">The single user in {ids}.</param>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all of a user's associated accounts for a set of user identified by <paramref name="id"/>.</returns>
		IBridgeResponseCollection<NetworkUser> GetUserAssociatedAccounts(long id, SimpleQuery parameters = null);

		#endregion

		#endregion

		#region Network Methods

		/// <summary>
		/// Makes a request to API method /access-tokens/{accessTokens}/invalidate
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/invalidate-access-tokens</para>
		/// </summary>
		/// <param name="tokens">The access token {accessTokens} vector.</param>
		/// <returns>Immediately expires the access tokens passed. This method is meant to allow an application to discard any active access tokens it no longer needs.</returns>
		IBridgeResponseCollection<AccessToken> AccessTokensInvalidate(string[] tokens);
		/// <summary>
		/// Makes a request to API method /access-tokens/{accessTokens}/read
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/read-access-tokens</para>
		/// </summary>
		/// <param name="tokens">The access token {accessTokens} vector.</param>
		/// <returns>Returns the properties for a set of access tokens.</returns>
		IBridgeResponseCollection<AccessToken> AccessTokensRead(string[] tokens);
		/// <summary>
		/// Makes a request to API method /apps/{accessTokens}/de-authenticate
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/application-de-authenticate</para>
		/// </summary>
		/// <param name="tokens">The access token {accessTokens} vector.</param>
		/// <returns>This method is meant for uninstalling applications, recovering from access_token leaks, or simply as a stronger form of <see cref="AccessTokenInvalidate"/>.</returns>
		IBridgeResponseCollection<AccessToken> AccessTokensDeauthenticate(string[] tokens);

		/// <summary>
		/// Makes a request to API method /access-tokens/{accessTokens}/invalidate
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/invalidate-access-tokens</para>
		/// </summary>
		/// <param name="token">The single access token in {accessTokens}.</param>
		/// <returns>Immediately expires the access tokens passed. This method is meant to allow an application to discard any active access tokens it no longer needs.</returns>
		IBridgeResponseCollection<AccessToken> AccessTokenInvalidate(string token);
		/// <summary>
		/// Makes a request to API method /access-tokens/{accessTokens}/read
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/read-access-tokens</para>
		/// </summary>
		/// <param name="token">The single access token in {accessTokens}.</param>
		/// <returns>Returns the properties for a set of access tokens.</returns>
		IBridgeResponseCollection<AccessToken> AccessTokenRead(string token);
		/// <summary>
		/// Makes a request to API method /apps/{accessTokens}/de-authenticate
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/application-de-authenticate</para>
		/// </summary>
		/// <param name="token">The single access token in {accessTokens}.</param>
		/// <returns>This method is meant for uninstalling applications, recovering from access_token leaks, or simply as a stronger form of <see cref="AccessTokenInvalidate"/>.</returns>
		IBridgeResponseCollection<AccessToken> AccessTokenDeauthenticate(string token);

		/// <summary>
		/// Makes a request to API method /filter/create
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/create-filter</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Creates a new filter given a list of includes, excludes, a base filter, and whether or not this filter should be "unsafe".</returns>
		IBridgeResponseItem<Filter> CreateNetworkFilter(CreateFilterQuery parameters = null);
		/// <summary>
		/// Makes a request to API method /filter/{filters}/read
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/read-filter</para>
		/// </summary>
		/// <param name="ids">The filter {ids} vector.</param>
		/// <returns>Returns the fields included by the filters identified by <paramref name="ids"/>, and the "safeness" of those filters.</returns>
		IBridgeResponseCollection<Filter> GetNetworkFilters(string[] ids);

		/// <summary>
		/// Makes a request to API method /filter/{filters}/read
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/read-filter</para>
		/// </summary>
		/// <param name="id">The single filter in {ids}.</param>
		/// <returns>Returns the filter identified by <paramref name="id"/>.</returns>
		IBridgeResponseItem<Filter> GetNetworkFilter(string id);

		/// <summary>
		/// Makes a request to API method /sites
		/// <para>Documentation can be found following the link below:</para>
		/// <para>https://api.stackexchange.com/docs/sites</para>
		/// </summary>
		/// <param name="parameters">The request parameters.</param>
		/// <returns>Returns all sites in the network.</returns>
		IBridgeResponseCollection<NetworkSite> GetNetworkSites(SimpleQuery parameters = null);

		#endregion

		#endregion
	}
}