﻿using System;
using System.Linq;

namespace BridgeStack.ConsoleApplication
{
	public static class Program
	{
		private static readonly string _appId = "YOUR_APPLICATION_ID";
		private static readonly string _appKey = "YOUR_APPLICATION_KEY";
		private static readonly string _token = "YOUR_TEST_ACCESS_TOKEN";

		private static readonly IOAuthClient oauth = new OAuthClientFactory().Create(_appId);
		private static readonly IStackClient client = new StackClientFactory().Create(_appKey);
		private static readonly IAuthorizedStackClient authClient = new StackClientFactory().Create(_appKey, _token);

		public static void Main(string[] args)
		{
			// GetOAuthRoute();
			// OAuth();

			GetCommentsByAnswerIds();
			GetMySilverBadges();

			Console.ReadKey();
		}

		private static void GetOAuthRoute()
		{
			var state = new OAuthState();
			state.Add("example", "value");
			state.Add("another", "string");
			string value = oauth.GetExplicitOAuthApprovalUri(new OAuthScope
			{
				ReadInbox = true,
				NoExpiry = true
			}, state);
			Console.WriteLine(value);
		}

		private static void OAuth()
		{
			string secret = "YOUR_APPLICATION_SECRET";

			string code = "YOUR_CODE"; // received @ approval uri

			IOAuthResponse response = oauth.RequestAccessToken(secret, code);
			Console.WriteLine(response.AccessToken);
		}
		private static void GetInfo()
		{
			SiteQuery p = new SiteQuery { Site = NetworkSiteEnum.StackOverflow };
			IBridgeResponseItem<NetworkSiteStats> stats = client.GetInfo(p);

			Console.WriteLine(stats.Safe.TotalAnswers);
		}
		private static void GetAnswers()
		{
			PostsQuery p = new PostsQuery { Site = NetworkSiteEnum.StackOverflow };
			IBridgeResponseCollection<Answer> answers = client.GetAnswers(p);

			Console.WriteLine(answers.First().AnswerId);
		}
		private static void GetBadges()
		{
			IBridgeResponseCollection<Badge> badges = client.GetBadges();

			Console.WriteLine(badges.First().BadgeId);
		}
		private static void GetComments()
		{
			CommentsQuery p = new CommentsQuery { Site = NetworkSiteEnum.StackOverflow };
			IBridgeResponseCollection<Comment> comments = client.GetComments(p);

			Console.WriteLine(comments.First().CommentId);
		}
		private static void GetErrors()
		{
			SimpleQuery p = new SimpleQuery { Site = NetworkSiteEnum.StackOverflow };
			IBridgeResponseCollection<ApiException> errors = client.GetErrors(p);

			Console.WriteLine(errors.First().ErrorDescription);
		}
		private static void GetPosts()
		{
			PostsQuery p = new PostsQuery { Site = NetworkSiteEnum.StackOverflow };
			IBridgeResponseCollection<Post> posts = client.GetPosts(p);

			Console.WriteLine(posts.First().PostId);
		}
		private static void GetQuestions()
		{
			QuestionsQuery p = new QuestionsQuery { Site = NetworkSiteEnum.StackOverflow };
			IBridgeResponseCollection<Question> questions = client.GetQuestions(p);

			Console.WriteLine(questions.First().QuestionId);
		}
		private static void GetPrivileges()
		{
			SimpleQuery p = new SimpleQuery { Site = NetworkSiteEnum.StackOverflow };
			IBridgeResponseCollection<Privilege> privileges = client.GetPrivileges(p);

			Console.WriteLine(privileges.First().Description);
		}
		private static void GetTags()
		{
			TagsQuery p = new TagsQuery { Site = NetworkSiteEnum.StackOverflow };
			IBridgeResponseCollection<Tag> tags = client.GetTags(p);

			Console.WriteLine(tags.First().Name);
		}
		private static void GetUsers()
		{
			UsersNamedQuery p = new UsersNamedQuery { Site = NetworkSiteEnum.StackOverflow };
			IBridgeResponseCollection<User> users = client.GetUsers(p);

			Console.WriteLine(users.First().DisplayName);
		}
		private static void GetAnswersWithParams()
		{
			PostsQuery p = new PostsQuery { Site = NetworkSiteEnum.StackOverflow, Sort = QuerySortEnum.Votes, Order = QueryOrderEnum.Descending, Min = 4000 };
			IBridgeResponseCollection<Answer> answers = client.GetAnswers(p);

			Console.WriteLine(answers.First().AnswerId);
		}
		private static void GetAnswersByIds()
		{
			PostsQuery p = new PostsQuery { Site = NetworkSiteEnum.StackOverflow };
			IBridgeResponseCollection<Answer> answers = client.GetAnswers(new long[] { 7300527 }, p);

			Console.WriteLine(answers.First().AnswerId);
		}
		private static void GetCommentsByAnswerIds()
		{
			CommentsQuery p = new CommentsQuery { Site = NetworkSiteEnum.StackOverflow };
			IBridgeResponseCollection<Comment> comments = client.GetAnswersComments(new long[] { }, p);

			Console.WriteLine(comments.First().CommentId);
		}
		private static void GetMyComments()
		{
			client.Default.Site = NetworkSiteEnum.StackOverflow;
			IBridgeResponseCollection<Comment> comments = authClient.GetMyComments();

			Console.WriteLine(comments.First().CommentId);
		}
		private static void GetMySilverBadges()
		{
			client.Default.Site = NetworkSiteEnum.StackOverflow;
			BadgesOnUserQuery parameters = new BadgesOnUserQuery
			{
				Sort = QuerySortEnum.BadgeRank,
				Min = BadgeRankEnum.Silver,
				Max = BadgeRankEnum.Silver
			};
			var badges = authClient.GetMyBadges(parameters);

			foreach (var badge in badges)
			{
				Console.WriteLine(badge.Name);
			}
		}
	}
}

