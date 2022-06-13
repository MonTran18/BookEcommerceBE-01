using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_RepositoryDLL.Entities;

namespace ClassLibrary_RepositoryDLL.Repository.Interface
{
    public interface ICategoryRepository
    {
        List<Category> getAllCategory();
        void AddCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(int categoryId);
        Category getCategory(int categoryId);

        //Create Search by Name follow the name in the website
        //Category getCategoryByName(string productName);
    }
}
