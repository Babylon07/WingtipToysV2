using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToysV2.Models;
using System.Web.ModelBinding;

namespace WingtipToysV2
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Fetch products to populate ListView in 'ProductList.aspx'
        // 'Id' is passed from ListView in 'Site.Master' page.
        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            var _db = new ProductContext();
            IQueryable<Product> query = _db.Products;
           
            // If 'ProductList.aspx' navigated to using Category links,
            // then show only products with CategoryID matching chosen link ("id")
            if(categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            
            return query;
           
        }
    }
}