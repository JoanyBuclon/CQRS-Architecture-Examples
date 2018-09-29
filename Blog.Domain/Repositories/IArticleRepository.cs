﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories
{
    public interface IArticleRepository
    {
        void AddArticle(Article article);
        void UpdateArticle(Article article);
        void DeleteArticle(int idArticle);
        Task<Article> FindById(int idArticle);
        Task<IEnumerable<Article>> FindLatestArticles();
        Task<IEnumerable<Article>> FindByAuthor(int idAuthor);
    }
}