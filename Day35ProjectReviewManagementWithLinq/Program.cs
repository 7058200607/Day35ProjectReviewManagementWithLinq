using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35ProjectReviewManagementWithLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Project Management Problem statement");
            //UC1
            List<ProductReviews> listProductReviews = new List<ProductReviews>()
            {
                new ProductReviews(){ProductId=1,UserId=1,Rating=5,Review="Good",isLike=true},
                new ProductReviews(){ProductId=2,UserId=1,Rating=4,Review="Good",isLike=true},
                new ProductReviews(){ProductId=3,UserId=2,Rating=5,Review="Good",isLike=true},
                new ProductReviews(){ProductId=4,UserId=2,Rating=4,Review="Good",isLike=true},
                new ProductReviews(){ProductId=5,UserId=3,Rating=2,Review="nice",isLike=false},
                new ProductReviews(){ProductId=6,UserId=4,Rating=1,Review="bad ",isLike=false},
                new ProductReviews(){ProductId=1,UserId=3,Rating=1.5,Review="nice",isLike=false},
                new ProductReviews(){ProductId=11,UserId=10,Rating=4,Review="nice",isLike=true},
                new ProductReviews(){ProductId=10,UserId=10,Rating=4,Review="nice",isLike=true},
                new ProductReviews(){ProductId=12,UserId=10,Rating=4,Review="nice",isLike=true},
                new ProductReviews(){ProductId=13,UserId=10,Rating=4,Review="nice",isLike=true},
                new ProductReviews(){ProductId=14,UserId=10,Rating=4,Review="nice",isLike=true},
                new ProductReviews(){ProductId=15,UserId=10,Rating=4,Review="nice",isLike=true},
                new ProductReviews(){ProductId=16,UserId=10,Rating=4,Review="nice",isLike=true},

            };
            /*foreach (var list in listProductReviews)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " " + "UserId:-" + list.UserId + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + "isLike:-" + list.isLike);
            }
            */
            Management management = new Management();
           //UC2
           // management.TopRecords(listProductReviews);

            //UC3
           // management.SelectRecords(listProductReviews);

            //UC4
           // management.RetriveCountOfRecords(listProductReviews);
            //UC5
            //management.RetriveProductIDAndRview(listProductReviews);
            //UC6
            management.SkipTopRecords(listProductReviews);
        }
    }
}

