using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.ComplexType;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using Core.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, B2CEmirContext>
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (B2CEmirContext context = new B2CEmirContext())
            {
                var result = from p in context.Product
                             join c in context.Category on p.CategoryID equals c.ID
                             select new ProductDetail
                             {
                                 ProductID = p.ID,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
