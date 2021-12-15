﻿using System.Threading.Tasks;
using ManagementPages.Function;

namespace ManagementPages.Model
{
    public interface IPostModel
    {
        PostDataModel PostDataModel { get; set; }

        Task EditPost(IDbService dbService);

        Task DeletePostFromDatabase(IDbService dbService);

        Task ReloadPostDataModel(IDbService dbService);
    }
}