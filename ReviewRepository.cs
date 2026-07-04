using Demo_2_sun.Data;
using Demo_2_sun.Models;
using Demo_2_sun.Repositorys.Interfaces;

namespace Demo_2_sun.Repositorys.CLASSES
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDbContext _context;

        public ReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Review AddReview(Review review)
        {
            _context.reviews.Add(review);
            return review;
        }

        public Review UpdateReview(Review review)
        {
            _context.reviews.Update(review);
            return review;
        }

        public void DeleteReview(Review review)
        {
            _context.reviews.Remove(review);
        }

        public List<Review> GetReviewsByProduct(int productId)
        {
            return _context.reviews
                           .Where(r => r.ProductId == productId)
                           .ToList();
        }

        public Review GetReviewById(int id)
        {
            return _context.reviews
                           .FirstOrDefault(r => r.ReviewId == id);
        }

        public bool CheckExistingReview(int userId, int productId)
        {
            return _context.reviews
                           .Any(r => r.UserId == userId &&
                                     r.ProductId == productId);
        }

        public double CalculateAverageRating(int productId)
        {
            var reviews = _context.reviews
                                  .Where(r => r.ProductId == productId);

            if (!reviews.Any())
            {
                return 0;
            }

            return reviews.Average(r => r.Rating);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}