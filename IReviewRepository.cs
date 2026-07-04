using Demo_2_sun.Models;

namespace Demo_2_sun.Repositorys.Interfaces
{
    public interface IReviewRepository
    {
        Review AddReview(Review review);

        Review UpdateReview(Review review);

        void DeleteReview(Review review);

        List<Review> GetReviewsByProduct(int productId);

        Review GetReviewById(int id);

        bool CheckExistingReview(int userId, int productId);

        double CalculateAverageRating(int productId);

        void SaveChanges();
    }
}
