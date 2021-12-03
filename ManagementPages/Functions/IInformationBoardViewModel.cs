﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementPages.Model;

namespace ManagementPages.Functions
{
    public interface IInformationBoardViewModel
    {
        public InformationBoardModel InformationBoardModel { get; set; }

        Dictionary<int, ICategoryViewModel> Categories { get; set; }

        public void GetInformationBoardData(int informationBoardId);

        public void GetCategories(int informationBoardId);

        public ICategoryViewModel SelectedCategory { get; set; }

        public Task AddNewCategory(CategoryModel newCategory, int informationBoardId, bool isPublished, IDbService dbService);

        Task EditInformationBoard(int informationBoardId, IDbService dbService);

        List<int> CategoryOrder { get; set; }
    }
}