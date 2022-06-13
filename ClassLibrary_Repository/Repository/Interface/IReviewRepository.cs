using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_RepositoryDLL.Entities;

namespace ClassLibrary_RepositoryDLL.Repository.Interface
{
    public interface IReviewRepository
    {
        List<Review> getAllReview();
        void AddReview (Review newreview);
        bool UpdateReview (Review newreview);
        bool DeleteReview(int reviewId);
        Review getReview(int reviewId);
    }
}
