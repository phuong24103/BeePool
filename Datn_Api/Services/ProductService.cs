using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Datn_Api.Services
{
    public class ProductService : IProductService
    {
        private readonly MyDbContext _context;

        public ProductService(MyDbContext myDbContext)
        {
            _context = myDbContext;
        }

        public async Task<bool> CreateProduct(CreateProduct product)
        {
            Product b = new Product()
            {
                Id = Guid.NewGuid(),
                CategoryID = product.CategoryID,

                Name = product.Name,
                Pin = product.Pin,
                Wrap = product.Wrap,
                Rings = product.Rings,
                AvailableQuantity = product.AvailableQuantity,
                Sold = 0,
                Likes = 0,
                Producer = product.Producer,
                CreateDate = DateTime.Now,
                Status = product.Status,
                Description = product.Description,
            };
            try
            {
                await _context.Products.AddAsync(b);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteProduct(Guid id)
        {
            var prodt = _context.Products.Find(id);
            if (prodt == null) return false;
            try
            {
                prodt.Status = 2;
                _context.Products.Update(prodt);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<ProductView>> GetAllProduct()
        {
            var products = await _context.Products.Include(p => p.ProductDetails).ToListAsync();

            List<ProductView> proview = new List<ProductView>();

            foreach (var product in products)
            {
                Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                if (productDetailId != Guid.Empty)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;

                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : "";
                    var category = await _context.Categories.Where(p => p.Id == product.CategoryID).FirstOrDefaultAsync();

                    proview.Add(new ProductView
                    {
                        Id = product.Id,
                        CategoryID = product.CategoryID,
                        ProductDetailId = productDetailId,
                        Name = product.Name,
                        Pin = product.Pin,
                        Wrap = product.Wrap,
                        Rings = product.Rings,
                        AvailableQuantity = product.AvailableQuantity,
                        Price = price,
                        Image = image,
                        Sold = product.Sold,
                        Likes = product.Likes,
                        Producer = product.Producer,
                        CreateDate = product.CreateDate,
                        Status = product.Status,
                        Description = product.Description,
                        Category = product.Category,
                        CategoryName = category.Name

                    });
                }

            }
            return proview;
        }

        public async Task<IEnumerable<ProductView>> GetProductByCategory(string name)
        {
            var products = await _context.Products.Where(p => p.Category.Name == name).Include(p => p.ProductDetails).ToListAsync();

            List<ProductView> proview = new List<ProductView>();

            foreach (var product in products)
            {
                double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;
                var category = await _context.Categories.Where(p => p.Id == product.CategoryID).FirstOrDefaultAsync();

                proview.Add(new ProductView
                {
                    Id = product.Id,
                    CategoryID = product.CategoryID,
                    ProductDetailId = productDetailId,
                    Name = product.Name,
                    Pin = product.Pin,
                    Wrap = product.Wrap,
                    Rings = product.Rings,
                    AvailableQuantity = product.AvailableQuantity,
                    Price = price,
                    Image = image,
                    Sold = product.Sold,
                    Likes = product.Likes,
                    Producer = product.Producer,
                    CreateDate = product.CreateDate,
                    Status = product.Status,
                    Description = product.Description,
                    Category = product.Category,
                    CategoryName = category.Name

                });
            }
            return proview;
        }

        public async Task<IEnumerable<ProductView>> GetProductByCreateDateNew()
        {
            var products = await _context.Products.OrderByDescending(p => p.CreateDate).Include(p => p.ProductDetails).ToListAsync();

            List<ProductView> proview = new List<ProductView>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                    Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;
                    var category = await _context.Categories.Where(p => p.Id == product.CategoryID).FirstOrDefaultAsync();

                    proview.Add(new ProductView
                    {
                        Id = product.Id,
                        CategoryID = product.CategoryID,
                        ProductDetailId = productDetailId,
                        Name = product.Name,
                        Pin = product.Pin,
                        Wrap = product.Wrap,
                        Rings = product.Rings,
                        AvailableQuantity = product.AvailableQuantity,
                        Price = price,
                        Image = image,
                        Sold = product.Sold,
                        Likes = product.Likes,
                        Producer = product.Producer,
                        CreateDate = product.CreateDate,
                        Status = product.Status,
                        Description = product.Description,
                        Category = product.Category,
                        CategoryName = category.Name
                    });
                }
            }
            return proview;
        }

        public async Task<IEnumerable<ProductView>> GetProductByCreateDateOld()
        {
            var products = await _context.Products.OrderBy(p => p.CreateDate).Include(p => p.ProductDetails).ToListAsync();

            List<ProductView> proview = new List<ProductView>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                    Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;
                    var category = await _context.Categories.Where(p => p.Id == product.CategoryID).FirstOrDefaultAsync();

                    proview.Add(new ProductView
                    {
                        Id = product.Id,
                        CategoryID = product.CategoryID,
                        ProductDetailId = productDetailId,
                        Name = product.Name,
                        Pin = product.Pin,
                        Wrap = product.Wrap,
                        Rings = product.Rings,
                        AvailableQuantity = product.AvailableQuantity,
                        Price = price,
                        Image = image,
                        Sold = product.Sold,
                        Likes = product.Likes,
                        Producer = product.Producer,
                        CreateDate = product.CreateDate,
                        Status = product.Status,
                        Description = product.Description,
                        Category = product.Category,
                        CategoryName = category.Name
                    });
                }
            }
            return proview;
        }

        public async Task<ProductView> GetProductById(Guid id)
        {
            var product = await _context.Products.Include(p => p.ProductDetails).FirstOrDefaultAsync(p => p.Id == id);
            double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
            Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
            string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;
            ProductView proview = new ProductView();
            proview = await (
                from a in _context.Products
                join b in _context.Categories on a.CategoryID equals b.Id
                where a.Id == id
                select new ProductView()
                {
                    Id = a.Id,
                    CategoryID = a.CategoryID,
                    ProductDetailId = productDetailId,
                    Name = a.Name,
                    Pin = a.Pin,
                    Wrap = a.Wrap,
                    Rings = a.Rings,
                    AvailableQuantity = a.AvailableQuantity,
                    Price = price,
                    Image = image,
                    Sold = a.Sold,
                    Likes = a.Likes,
                    Producer = a.Producer,
                    CreateDate = a.CreateDate,
                    Status = a.Status,
                    Description = a.Description,
                    Category = b,
                    CategoryName = b.Name
                }).FirstAsync();
            return proview;
        }

        public async Task<IEnumerable<ProductView>> GetProductByName(string name)
        {
            var products = await _context.Products.Where(p => p.Name.ToLower().Contains(name.ToLower())).Include(p => p.ProductDetails).ToListAsync();

            List<ProductView> proview = new List<ProductView>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                    Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;
                    var category = await _context.Categories.Where(p => p.Id == product.CategoryID).FirstOrDefaultAsync();

                    proview.Add(new ProductView
                    {
                        Id = product.Id,
                        CategoryID = product.CategoryID,
                        ProductDetailId = productDetailId,
                        Name = product.Name,
                        Pin = product.Pin,
                        Wrap = product.Wrap,
                        Rings = product.Rings,
                        AvailableQuantity = product.AvailableQuantity,
                        Price = price,
                        Image = image,
                        Sold = product.Sold,
                        Likes = product.Likes,
                        Producer = product.Producer,
                        CreateDate = product.CreateDate,
                        Status = product.Status,
                        Description = product.Description,
                        Category = product.Category,
                        CategoryName = category.Name
                    });
                }
            }
            return proview;
        }

        public async Task<IEnumerable<ProductView>> GetProductByNameAZ()
        {
            var products = await _context.Products.OrderBy(p => p.Name).Include(p => p.ProductDetails).ToListAsync();

            List<ProductView> proview = new List<ProductView>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                    Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;
                    var category = await _context.Categories.Where(p => p.Id == product.CategoryID).FirstOrDefaultAsync();

                    proview.Add(new ProductView
                    {
                        Id = product.Id,
                        CategoryID = product.CategoryID,
                        ProductDetailId = productDetailId,
                        Name = product.Name,
                        Pin = product.Pin,
                        Wrap = product.Wrap,
                        Rings = product.Rings,
                        AvailableQuantity = product.AvailableQuantity,
                        Price = price,
                        Image = image,
                        Sold = product.Sold,
                        Likes = product.Likes,
                        Producer = product.Producer,
                        CreateDate = product.CreateDate,
                        Status = product.Status,
                        Description = product.Description,
                        Category = product.Category,
                        CategoryName = category.Name
                    });
                }
            }
            return proview;
        }

        public async Task<IEnumerable<ProductView>> GetProductByNameZA()
        {
            var products = await _context.Products.OrderByDescending(p => p.Name).Include(p => p.ProductDetails).ToListAsync();

            List<ProductView> proview = new List<ProductView>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                    Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;
                    var category = await _context.Categories.Where(p => p.Id == product.CategoryID).FirstOrDefaultAsync();

                    proview.Add(new ProductView
                    {
                        Id = product.Id,
                        CategoryID = product.CategoryID,
                        ProductDetailId = productDetailId,
                        Name = product.Name,
                        Pin = product.Pin,
                        Wrap = product.Wrap,
                        Rings = product.Rings,
                        AvailableQuantity = product.AvailableQuantity,
                        Price = price,
                        Image = image,
                        Sold = product.Sold,
                        Likes = product.Likes,
                        Producer = product.Producer,
                        CreateDate = product.CreateDate,
                        Status = product.Status,
                        Description = product.Description,
                        Category = product.Category,
                        CategoryName = category.Name
                    });
                }
            }
            return proview;
        }

        public async Task<IEnumerable<ProductView>> GetProductByPrice2()
        {
            var products = await _context.Products.Include(p => p.ProductDetails).ToListAsync();

            List<ProductView> proview = new List<ProductView>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                    Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;
                    var category = await _context.Categories.Where(p => p.Id == product.CategoryID).FirstOrDefaultAsync();

                    proview.Add(new ProductView
                    {
                        Id = product.Id,
                        CategoryID = product.CategoryID,
                        ProductDetailId = productDetailId,
                        Name = product.Name,
                        Pin = product.Pin,
                        Wrap = product.Wrap,
                        Rings = product.Rings,
                        AvailableQuantity = product.AvailableQuantity,
                        Price = price,
                        Image = image,
                        Sold = product.Sold,
                        Likes = product.Likes,
                        Producer = product.Producer,
                        CreateDate = product.CreateDate,
                        Status = product.Status,
                        Description = product.Description,
                        Category = product.Category,
                        CategoryName = category.Name
                    });
                }
                proview = proview.Where(p => p.Price >= 0 && p.Price <= 2001).ToList();
            }
            return proview;
        }

        public async Task<IEnumerable<ProductView>> GetProductByPriceMax()
        {
            var products = await _context.Products.Include(p => p.ProductDetails).ToListAsync();

            List<ProductView> proview = new List<ProductView>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                    Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;
                    var category = await _context.Categories.Where(p => p.Id == product.CategoryID).FirstOrDefaultAsync();

                    proview.Add(new ProductView
                    {
                        Id = product.Id,
                        CategoryID = product.CategoryID,
                        ProductDetailId = productDetailId,
                        Name = product.Name,
                        Pin = product.Pin,
                        Wrap = product.Wrap,
                        Rings = product.Rings,
                        AvailableQuantity = product.AvailableQuantity,
                        Price = price,
                        Image = image,
                        Sold = product.Sold,
                        Likes = product.Likes,
                        Producer = product.Producer,
                        CreateDate = product.CreateDate,
                        Status = product.Status,
                        Description = product.Description,
                        Category = product.Category,
                        CategoryName = category.Name
                    });
                }
                proview = proview.OrderByDescending(p => p.Price).ToList();
            }
            return proview;
        }

        public async Task<IEnumerable<ProductView>> GetProductByPriceMin()
        {
            var products = await _context.Products.Include(p => p.ProductDetails).ToListAsync();

            List<ProductView> proview = new List<ProductView>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                    Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;
                    var category = await _context.Categories.Where(p => p.Id == product.CategoryID).FirstOrDefaultAsync();

                    proview.Add(new ProductView
                    {
                        Id = product.Id,
                        CategoryID = product.CategoryID,
                        ProductDetailId = productDetailId,
                        Name = product.Name,
                        Pin = product.Pin,
                        Wrap = product.Wrap,
                        Rings = product.Rings,
                        AvailableQuantity = product.AvailableQuantity,
                        Price = price,
                        Image = image,
                        Sold = product.Sold,
                        Likes = product.Likes,
                        Producer = product.Producer,
                        CreateDate = product.CreateDate,
                        Status = product.Status,
                        Description = product.Description,
                        Category = product.Category,
                        CategoryName = category.Name
                    });
                }
                proview = proview.OrderBy(p => p.Price).ToList();
            }
            return proview;
        }

        public async Task<IEnumerable<ProductAdminView>> GetProductStatistics()
        {
            var products = await _context.Products.OrderByDescending(p => p.Name).Include(p => p.ProductDetails).ToListAsync();

            List<ProductAdminView> proview = new List<ProductAdminView>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;

                    Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;
                    var billDetails = _context.BillDetails.Where(p => p.ProductDetailId == productDetailId).ToListAsync().Result;
                    double revenue = 0;
                    foreach (var item in billDetails)
                    {
                        revenue += item.Price;
                    }

                    if (revenue > 0)
                    {
                        proview.Add(new ProductAdminView
                        {
                            Id = product.Id,
                            ProductDetailId = productDetailId,
                            Name = product.Name,
                            Price = price,
                            Image = image,
                            Sold = product.Sold,
                            Revenue = revenue,
                        });
                    }
                }
            }
            return proview.OrderByDescending(p => p.Revenue).Take(5).ToList();
        }

        public async Task<IEnumerable<ProductAdminView>> GetProductStatisticsFilter(string date)
        {
            var products = await _context.Products.OrderByDescending(p => p.Name).Include(p => p.ProductDetails).ToListAsync();

            List<ProductAdminView> proview = new List<ProductAdminView>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                    Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;
                    var billDetails = await _context.BillDetails.Where(p => p.ProductDetailId == productDetailId).ToListAsync();
                    double revenue = 0;
                    if (date == "today" || date == "thisYear" || date == "thisMonth")
                    {
                        foreach (var item in billDetails)
                        {
                            var bill = await _context.Bills.Where(p => p.Id == item.BillId).FirstOrDefaultAsync();
                            if (date == "today")
                            {
                                if (bill.CreateDate.DayOfYear == DateTime.Now.DayOfYear)
                                {
                                    revenue += item.Price;
                                }
                            }
                            else if (date == "thisYear")
                            {
                                if (bill.CreateDate.Year == DateTime.Now.Year)
                                {
                                    revenue += item.Price;
                                }
                            }
                            else if (date == "thisMonth")
                            {
                                if (bill.CreateDate.Year == DateTime.Now.Year && bill.CreateDate.Month == DateTime.Now.Month)
                                {
                                    revenue += item.Price;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in billDetails)
                        {
                            revenue += item.Price;
                        }
                    }
                    if (revenue > 0)
                    {
                        proview.Add(new ProductAdminView
                        {
                            Id = product.Id,
                            ProductDetailId = productDetailId,
                            Name = product.Name,
                            Price = price,
                            Image = image,
                            Sold = product.Sold,
                            Revenue = revenue,
                        });
                    }
                }
            }
            return proview.OrderByDescending(p => p.Revenue).Take(5).ToList();
        }

        public async Task<bool> UpdateProduct(Guid id, UpdateProduct product)
        {
            var n = _context.Products.Find(id);
            if (n == null) return false;
            n.Name = product.Name;
            n.Pin = product.Pin;
            n.Wrap = product.Wrap;
            n.Rings = product.Rings;
            n.AvailableQuantity = product.AvailableQuantity;
            n.Producer = product.Producer;
            n.Status = product.Status;
            n.Description = product.Description;
            try
            {
                _context.Products.Update(n);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}