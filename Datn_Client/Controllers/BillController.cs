using Datn_Shared.Models;
using Datn_Shared.ViewModels.AccountViewModels;
using Datn_Shared.ViewModels.BillDetailViewModels;
using Datn_Shared.ViewModels.BillViewModels;
using Datn_Shared.ViewModels.CartDetailViewModels;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using Shopping_Website.Services;
using System.Net.Http.Json;
using System.Security.Claims;

namespace Datn_Client.Controllers
{
    public class BillController : Controller
    {
        private readonly HttpClient _httpClient;
        public BillController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Bill()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userName != null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetByCustomerId/{customer.Id}");
                return View(result);
            }
            else
            {
                var result = SessionServices<BillView>.GetObjFromSession(HttpContext.Session, "Bill");
                return View(result);
            }
        }


        
        public async Task<IActionResult> Create()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
            var result = await _httpClient.GetFromJsonAsync<List<CartDetailView>>($"https://localhost:7033/api/CartDetail/GetByCustomerId/{customer.Id}");
            List<CartDetail> cartDetails = new List<CartDetail>();
            foreach(var item in result)
            {
                CartDetail detail = new CartDetail();
                detail.Id = item.Id;
                detail.CustomerId = item.CustomerId;
                detail.ProductDetailId = item.ProductDetailId;
                detail.Quantity = item.Quantity;
                detail.Price = item.Price;
                cartDetails.Add(detail);
            }
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Bill/Create", cartDetails);
            return RedirectToAction("Bill");
        }




        [HttpPost]
        public async Task<IActionResult> CreateVoucher(string code, string address, string name, string phonenumber)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //Nếu có đăng nhập
            if(userName != null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var result = await _httpClient.GetFromJsonAsync<List<CartDetailView>>($"https://localhost:7033/api/CartDetail/GetByCustomerId/{customer.Id}");
                List<CartDetail> cartDetails = new List<CartDetail>();
                foreach (var item in result)
                {
                    CartDetail detail = new CartDetail();
                    detail.Id = item.Id;
                    detail.CustomerId = item.CustomerId;
                    detail.ProductDetailId = item.ProductDetailId;
                    detail.Quantity = item.Quantity;
                    detail.Price = item.Price;
                    cartDetails.Add(detail);
                }

                
                if (code == null)
                {   
                        await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Bill/Create", cartDetails);
                        return RedirectToAction("Bill");
                }
            
                    
                else
                {
                    string giagiam = string.Empty;
                    string message = string.Empty;
                    var allvoucher = await _httpClient.GetFromJsonAsync<List<Voucher>>($"https://localhost:7033/api/Voucher/GetAll");
                    var voucher = allvoucher.FirstOrDefault(p => p.Code == code);

                    
                    if (voucher == null)
                    {
                        message = "Voucher này không tồn tại";
                        TempData["Message"] = message;
                    }
                    else if (voucher.Status == 1)
                    {
                        message = "Voucher này đang khóa";
                        TempData["Message"] = message;

                    }
                    else if (DateTime.Now < voucher.TimeStart)
                    {
                        message = "Voucher này chưa bắt đầu";
                        TempData["Message"] = message;

                    }
                    else if (DateTime.Now > voucher.TimeEnd)
                    {
                        message = "Voucher này đã hết hạn";
                        TempData["Message"] = message;

                    }
                    else
                    {
                        giagiam = voucher.Value.ToString();
                        TempData["Giagiam"] = giagiam;
                        await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Bill/CreateBillVoucher/{code}", cartDetails);
                        return RedirectToAction("Index", "Cart");
                    }
                    return RedirectToAction("Index", "Cart");
                }


            }

            //Nếu không đăng nhập
            else
            {
                var Bills = SessionServices<BillView>.GetObjFromSession(HttpContext.Session, "Bill");
                var result = SessionServices<CartDetailView>.GetObjFromSession(HttpContext.Session, "CartDetail");
                List<CartDetail> cartDetails = new List<CartDetail>();
                foreach (var item in result)
                {
                    CartDetail detail = new CartDetail();
                    detail.Id = item.Id;
                    detail.CustomerId = item.CustomerId;
                    detail.ProductDetailId = item.ProductDetailId;
                    detail.Quantity = item.Quantity;
                    detail.Price = item.Price;
                    cartDetails.Add(detail);
                }
                double price = 0;
                foreach (var item in cartDetails)
                {
                    var productdetail = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{item.ProductDetailId}");
                    price += (productdetail.Price * item.Quantity);
                }
                //Nếu ko điền code
                if (code == null)
                {
                    if (name == null)
                    {
                        string messagename = "Vui lòng nhập tên";
                        TempData["Messagename"] = messagename;
                    }
                    else if (phonenumber == null || phonenumber.Length > 10)
                    {
                        string messagephone = "Vui lòng nhập số điện thoại và tối đa là 10";
                        TempData["Messagephone"] = messagephone;
                    }
                    else if (address == null)
                    {
                        string messageaddress = "Vui lòng nhập địa chỉ nhận";
                        TempData["Messageaddress"] = messageaddress;
                    }
                    else
                    {
                        //Kiểm tra username có tồn tại hay ko
                        var allcustomer = await _httpClient.GetFromJsonAsync<List<Customer>>($"https://localhost:7033/api/Customer/GetAll");
                        var usernamecustomer = allcustomer.FirstOrDefault(p => p.UserName == name);
                        if(usernamecustomer != null)
                        {
                            string messagename = "Username này đã tồn tại";
                            TempData["Messagename"] = messagename;
                        }
                        else
                        {
                            //Tạo mới khách hàng
                            Register Registercustomer = new Register()
                            {
                                FullName = name,
                                Username = name,
                                Password = "123456",
                                ConfirmPassword = "123456",
                                Gender = 0,
                                DateOfBirth = new DateTime(2003, 10, 20),
                                Address = address,
                                PhoneNumber = phonenumber,
                                Email = $"{name}@gmail.com",
                                Image = "anhq.png",
                            };
                            var AddCus = await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/RegisterCustomer", Registercustomer);
                            //Nếu ko tạo dc khách hàng mới
                            if (AddCus.IsSuccessStatusCode == false)
                            {
                                string messagename = "Vui lòng nhập usename không dấu và viết liền";
                                TempData["Messagename"] = messagename;
                            }
                            else
                            {
                                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{Registercustomer.Username}");
                                //Bill thêm vào session
                                BillView bill = new BillView()
                                {
                                    Id = Guid.NewGuid(),
                                    CustomerId = customer.Id,
                                    BillStatusId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                                    PaymentId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"),
                                    Price = price,
                                    CreateDate = DateTime.Now,
                                    Address = address,
                                    CustomerName = name,
                                    CustomerPhone = phonenumber,
                                };
                                //Bill thêm vào db
                                CreateBill createBill = new CreateBill()
                                {
                                    Id = bill.Id,
                                    CustomerId = customer.Id,
                                    BillStatusId = bill.BillStatusId,
                                    PaymentId = bill.PaymentId,
                                    Price = bill.Price,
                                    CreateDate = bill.CreateDate,
                                    Address = bill.Address,
                                    CustomerName = bill.CustomerName,
                                    CustomerPhone = bill.CustomerPhone,
                                };
                                await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Bill/CreateBillBT", createBill);
                                Bills.Add(bill);
                                SessionServices<BillView>.SetObjToSession(HttpContext.Session, "Bill", Bills);
                                foreach (var item in cartDetails)
                                {
                                    var productdetail = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{item.ProductDetailId}");

                                    var product = await _httpClient.GetFromJsonAsync<ProductView>($"https://localhost:7033/api/Product/GetById/{productdetail.ProductID}");
                                    UpdateProduct updateProduct = new UpdateProduct()
                                    {
                                        CategoryID = product.CategoryID,
                                        Name = product.Name,
                                        Pin = product.Pin,
                                        Wrap = product.Wrap,
                                        Rings = product.Rings,
                                        AvailableQuantity = product.AvailableQuantity - item.Quantity,
                                        Sold = product.Sold,
                                        Likes = product.Likes,
                                        CreateDate = product.CreateDate,
                                        Producer = product.Producer,
                                        Status = product.Status,
                                        Description = product.Description,
                                    };

                                    await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Product/Update/{product.Id}", updateProduct);

                                    CreateBillDetail billDetail = new CreateBillDetail()
                                    {
                                        BillId = bill.Id,
                                        ProductDetailId = productdetail.Id,
                                        Quantity = item.Quantity,
                                        Price = productdetail.Price * item.Quantity,
                                    };

                                    await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/BillDetail/Create", billDetail);
                                    result.Clear();
                                    SessionServices<CartDetailView>.SetObjToSession(HttpContext.Session, "CartDetail", result);
                                }
                                return RedirectToAction("Bill");
                            }
                        }
                        
                        
                    }

                    return RedirectToAction("Index", "Cart");
                }
                //Nếu điền code
                else
                {
                    string giagiam = string.Empty;
                    string message = string.Empty;
                    var allvoucher = await _httpClient.GetFromJsonAsync<List<Voucher>>($"https://localhost:7033/api/Voucher/GetAll");
                    var voucher = allvoucher.FirstOrDefault(p => p.Code == code);

                    if (name == null)
                    {
                        string messagename = "Vui lòng nhập tên";
                        TempData["Messagename"] = messagename;
                    }
                    else if (phonenumber == null || phonenumber.Length > 10)
                    {
                        string messagephone = "Vui lòng nhập số điện thoại và tối đa là 10";
                        TempData["Messagephone"] = messagephone;
                    }
                    else if (address == null)
                    {
                        string messageaddress = "Vui lòng nhập địa chỉ nhận";
                        TempData["Messageaddress"] = messageaddress;
                    }
                    else if (voucher == null)
                    {
                        message = "Voucher này không tồn tại";
                        TempData["Message"] = message;
                    }
                    else if (voucher.Status == 1)
                    {
                        message = "Voucher này đang khóa";
                        TempData["Message"] = message;

                    }
                    else if (DateTime.Now < voucher.TimeStart)
                    {
                        message = "Voucher này chưa bắt đầu";
                        TempData["Message"] = message;

                    }
                    else if (DateTime.Now > voucher.TimeEnd)
                    {
                        message = "Voucher này đã hết hạn";
                        TempData["Message"] = message;

                    }
                    else
                    {
                        //Kiểm tra username có tồn tại hay ko
                        var allcustomer = await _httpClient.GetFromJsonAsync<List<Customer>>($"https://localhost:7033/api/Customer/GetAll");
                        var usernamecustomer = allcustomer.FirstOrDefault(p => p.UserName == name);
                        if (usernamecustomer != null)
                        {
                            string messagename = "Username này đã tồn tại";
                            TempData["Messagename"] = messagename;
                        }
                        else
                        {
                            if (voucher != null && voucher.Status == 0 && DateTime.Now <= voucher.TimeEnd && DateTime.Now >= voucher.TimeStart)
                            {
                                price -= voucher.Value;
                            }
                            else
                            {
                                price -= 0;
                            }
                            //Tạo mới khách hàng
                            Register Registercustomer = new Register()
                            {
                                FullName = name,
                                Username = name,
                                Password = "123456",
                                ConfirmPassword = "123456",
                                Gender = 0,
                                DateOfBirth = new DateTime(2003, 10, 20),
                                Address = address,
                                PhoneNumber = phonenumber,
                                Email = $"{name}@gmail.com",
                                Image = "anhq.png",
                            };
                            var AddCus = await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/RegisterCustomer", Registercustomer);
                            if (AddCus.IsSuccessStatusCode == false)
                            {
                                string messagename = "Vui lòng nhập usename không dấu và viết liền";
                                TempData["Messagename"] = messagename;
                            }
                            else
                            {
                                giagiam = voucher.Value.ToString();
                                TempData["Giagiam"] = giagiam;
                                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{Registercustomer.Username}");
                                //Bill thêm vào session
                                BillView bill = new BillView()
                                {
                                    Id = Guid.NewGuid(),
                                    CustomerId = customer.Id,
                                    BillStatusId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                                    PaymentId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"),
                                    Price = price,
                                    CreateDate = DateTime.Now,
                                    Address = address,
                                    CustomerName = name,
                                    CustomerPhone = phonenumber,
                                };
                                //Bill thêm vào db
                                CreateBill createBill = new CreateBill()
                                {
                                    Id = bill.Id,
                                    CustomerId = customer.Id,
                                    BillStatusId = bill.BillStatusId,
                                    PaymentId = bill.PaymentId,
                                    Price = bill.Price,
                                    CreateDate = bill.CreateDate,
                                    Address = bill.Address,
                                    CustomerName = bill.CustomerName,
                                    CustomerPhone = bill.CustomerPhone,
                                };
                                await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Bill/CreateBillBT", bill);
                                Bills.Add(bill);
                                SessionServices<BillView>.SetObjToSession(HttpContext.Session, "Bill", Bills);
                                foreach (var item in cartDetails)
                                {
                                    var productdetail = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{item.ProductDetailId}");

                                    var product = await _httpClient.GetFromJsonAsync<ProductView>($"https://localhost:7033/api/Product/GetById/{productdetail.ProductID}");
                                    UpdateProduct updateProduct = new UpdateProduct()
                                    {
                                        CategoryID = product.CategoryID,
                                        Name = product.Name,
                                        Pin = product.Pin,
                                        Wrap = product.Wrap,
                                        Rings = product.Rings,
                                        AvailableQuantity = product.AvailableQuantity - item.Quantity,
                                        Sold = product.Sold,
                                        Likes = product.Likes,
                                        CreateDate = product.CreateDate,
                                        Producer = product.Producer,
                                        Status = product.Status,
                                        Description = product.Description,
                                    };

                                    await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Product/Update/{product.Id}", updateProduct);

                                    CreateBillDetail billDetail = new CreateBillDetail()
                                    {
                                        BillId = bill.Id,
                                        ProductDetailId = productdetail.Id,
                                        Quantity = item.Quantity,
                                        Price = productdetail.Price * item.Quantity,
                                    };

                                    await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/BillDetail/Create", billDetail);
                                    result.Clear();
                                    SessionServices<CartDetailView>.SetObjToSession(HttpContext.Session, "CartDetail", result);
                                }

                                return RedirectToAction("Index", "Cart");
                            }
                        }
                        
                        
                    }
                    return RedirectToAction("Index", "Cart");
                }

            }
            

            
        }

    }
}