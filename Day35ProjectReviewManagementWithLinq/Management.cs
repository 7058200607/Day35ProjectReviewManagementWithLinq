using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35ProjectReviewManagementWithLinq
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        //UC2
        public void TopRecords(List<ProductReviews> listProductReviews)
        {
            var recordedData = (from ProductReviews in listProductReviews orderby ProductReviews.Rating descending select ProductReviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " " + "UserId:-" + list.UserId + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + "isLike:-" + list.isLike);
            }
        }
        public void SelectRecords(List<ProductReviews> listProductReviews)
        {
            var recordedData = from ProductReviews in listProductReviews where (ProductReviews.ProductId == 1 || ProductReviews.ProductId == 4 || ProductReviews.ProductId == 9) && ProductReviews.Rating > 3 select ProductReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " " + "UserId:-" + list.UserId + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + "isLike:-" + list.isLike);
            }
        }
        public void RetriveCountOfRecords(List<ProductReviews> listProductReviews)
        {
            var recordedData = listProductReviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach (var list in recordedData) 
            {
                Console.WriteLine(list.ProductId + "----" + list.Count);
            }
        }
        public void RetriveProductIDAndRview(List<ProductReviews> listProductReviews) 
        {
            var recordedData = from ProductReviews in listProductReviews select new { ProductReviews.ProductId, ProductReviews.Review };
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId, "Review:-" + list.Review);
            }


            }
    }
}