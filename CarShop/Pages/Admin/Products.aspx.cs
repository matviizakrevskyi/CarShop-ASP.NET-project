using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarShop.Models;
using CarShop.Models.Repository;
using System.Web.ModelBinding;

namespace CarShop.Pages.Admin
{
    public partial class Products : System.Web.UI.Page
    {
        private Repository repository = new Repository();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Product> GetProducts()
        {
            return repository.Products;
        }

        public void UpdateGame(int ProductID)
        {
            Product myProduct = repository.Products
                .Where(p => p.ProductId == ProductID).FirstOrDefault();
            if (myProduct != null && TryUpdateModel(myProduct,
                new FormValueProvider(ModelBindingExecutionContext)))
            {
                repository.SaveProduct(myProduct);
            }
        }

        public void DeleteGame(int ProductID)
        {
            Product myProduct = repository.Products
                .Where(p => p.ProductId == ProductID).FirstOrDefault();
            if (myProduct != null)
            {
                repository.DeleteProduct(myProduct);
            }
        }

        public void InsertProduct()
        {
            Product myProduct = new Product();
            if (TryUpdateModel(myProduct,
                new FormValueProvider(ModelBindingExecutionContext)))
            {
                repository.SaveProduct(myProduct);
            }
        }
    }
}