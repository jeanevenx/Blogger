﻿
namespace Blogger.Domain.ArticleAggregate;
public interface IArticleRepository
{
    Task CreateAsync(Article article, CancellationToken cancellationToken);
    Task<IReadOnlyList<Article>> GetArchiveArticles(CancellationToken cancellationToken);
    Task<Article> GetArticleByCommentId(CommentId commentId, CancellationToken cancellationToken);
    Task<Article> GetArticleById(ArticleId articleId, CancellationToken cancellationToken);
    Task<Article> GetDraftById(ArticleId articleId, CancellationToken cancellationToken);
    Task<IReadOnlyList<Article>> GetLatestArticles(int pageNumber, int pageSize, CancellationToken cancellationToken);
    Task SaveChangesAsync(CancellationToken cancellationToken);
}
