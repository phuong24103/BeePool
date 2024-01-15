using Datn_Client.Models.Payment;
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
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetByCustomerId/{customer.Id}");
                return View(result);
            }
            else
            {
                var bill = SessionServices<BillView>.GetObjFromSession(HttpContext.Session, "Bill");
                if(bill.Count == 0)
                {
                    return RedirectToAction("Register", "Register");
                }
                else
                {
                    return View(bill);
                }
                
            }
        }

        public async Task<IActionResult> BillStatus1()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var idbillstatus1 = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15");
                var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetBillByCustomerIdAndBillStatusId/{customer.Id}/{idbillstatus1}");
                return View(result);
            }
            else
            {
                var bill = SessionServices<BillView>.GetObjFromSession(HttpContext.Session, "Bill");
                if (bill.Count == 0)
                {
                    return RedirectToAction("Register", "Register");
                }
                else
                {
                    return View(bill);
                }
            }
        }
        public async Task<IActionResult> BillStatus2()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var idbillstatus1 = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5");
                var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetBillByCustomerIdAndBillStatusId/{customer.Id}/{idbillstatus1}");
                return View(result);
            }
            else
            {
                var bill = SessionServices<BillView>.GetObjFromSession(HttpContext.Session, "Bill");
                if (bill.Count == 0)
                {
                    return RedirectToAction("Register", "Register");
                }
                else
                {
                    return View(bill);
                }
            }
        }
        public async Task<IActionResult> BillStatus3()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var idbillstatus1 = Guid.Parse("b392b872-712a-41a7-8542-83fb58249c23");
                var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetBillByCustomerIdAndBillStatusId/{customer.Id}/{idbillstatus1}");
                return View(result);
            }
            else
            {
                var bill = SessionServices<BillView>.GetObjFromSession(HttpContext.Session, "Bill");
                if (bill.Count == 0)
                {
                    return RedirectToAction("Register", "Register");
                }
                else
                {
                    return View(bill);
                }
            }
        }
        public async Task<IActionResult> BillStatus4()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var idbillstatus1 = Guid.Parse("00357f21-9356-468b-8c0c-b590e3d1bc0a");
                var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetBillByCustomerIdAndBillStatusId/{customer.Id}/{idbillstatus1}");
                return View(result);
            }
            else
            {
                var bill = SessionServices<BillView>.GetObjFromSession(HttpContext.Session, "Bill");
                if (bill.Count == 0)
                {
                    return RedirectToAction("Register", "Register");
                }
                else
                {
                    return View(bill);
                }
            }
        }
        public async Task<IActionResult> BillStatus5()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var idbillstatus1 = Guid.Parse("33c0bdd2-85ca-4f05-9360-22be333895fe");
                var result = await _httpClient.GetFromJsonAsync<List<BillView>>($"https://localhost:7033/api/Bill/GetBillByCustomerIdAndBillStatusId/{customer.Id}/{idbillstatus1}");
                return View(result);
            }
            else
            {
                var bill = SessionServices<BillView>.GetObjFromSession(HttpContext.Session, "Bill");
                if (bill.Count == 0)
                {
                    return RedirectToAction("Register", "Register");
                }
                else
                {
                    return View(bill);
                }
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
        public async Task<IActionResult> CreateVoucher(string code, string address, string name, string phonenumber, string payment)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            //Nếu có đăng nhập
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var result = await _httpClient.GetFromJsonAsync<List<CartDetailView>>($"https://localhost:7033/api/CartDetail/GetByCustomerId/{customer.Id}");
                //Kiểm tra giỏ hàng rỗng
                if(result.Count == 0)
                {
                    string messagecart = "Giỏ hàng rỗng";
                    TempData["Messagecart"] = messagecart;
                    return RedirectToAction("Index", "Cart");
                }
                else
                {
                
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


                if (code == null)
                {
                    if (name == null)
                    {
                        string messagename = "Vui lòng nhập tên";
                        TempData["Messagename"] = messagename;
                        return RedirectToAction("Index", "Cart");
                    }
                    else if (phonenumber == null || phonenumber.Length > 10)
                    {
                        string messagephone = "Vui lòng nhập số điện thoại và tối đa là 10";
                        TempData["Messagephone"] = messagephone;
                        return RedirectToAction("Index", "Cart");
                    }
                    else if (address == null)
                    {
                        string messageaddress = "Vui lòng nhập địa chỉ nhận";
                        TempData["Messageaddress"] = messageaddress;
                        return RedirectToAction("Index", "Cart");
                    }
                    else if(payment == null)
                    {
                        string messagepayment = "Vui lòng chọn phương thức thanh toán";
                        TempData["Messagepayment"] = messagepayment;
                        return RedirectToAction("Index", "Cart");
                    }
                    else
                    {
                        string giagiam = "0";
                        TempData["Giagiam"] = giagiam;
                        string thanhcong = "Đặt hàng thành công";
                        TempData["Thanhcong"] = thanhcong;
                        //await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Bill/Create/{payment}", cartDetails);
                        //return RedirectToAction("Index", "Cart");
                        CreateBill bill = new CreateBill()
                        {
                            Id = Guid.NewGuid(),
                            CustomerId = customer.Id,
                            BillStatusId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                            PaymentId = Guid.Parse(payment),
                            Price = price,
                            CreateDate = DateTime.Now,
                            Address = address,
                            CustomerName = name,
                            CustomerPhone = phonenumber,
                        };
                        await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Bill/CreateBillBT", bill);
                        foreach (var item in cartDetails)
                        {
                            var productdetail = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{item.ProductDetailId}");

                            //var product = await _httpClient.GetFromJsonAsync<ProductView>($"https://localhost:7033/api/Product/GetById/{productdetail.ProductID}");
                            //UpdateProduct updateProduct = new UpdateProduct()
                            //{
                            //    CategoryID = product.CategoryID,
                            //    Name = product.Name,
                            //    Pin = product.Pin,
                            //    Wrap = product.Wrap,
                            //    Rings = product.Rings,
                            //    AvailableQuantity = product.AvailableQuantity - item.Quantity,
                            //    Sold = product.Sold,
                            //    Likes = product.Likes,
                            //    CreateDate = product.CreateDate,
                            //    Status = product.Status,
                            //    Description = product.Description,
                            //};

                            //await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Product/Update/{product.Id}", updateProduct);

                            CreateBillDetail billDetail = new CreateBillDetail()
                            {
                                BillId = bill.Id,
                                ProductDetailId = productdetail.Id,
                                Quantity = item.Quantity,
                                Price = productdetail.Price * item.Quantity,
                            };

                            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/BillDetail/Create", billDetail);
                            await _httpClient.DeleteAsync($"https://localhost:7033/api/CartDetail/Delete/{item.Id}");
                        }
                        //Cộng điểm cho khách hàng
                        if (price > 100000)
                        {
                            customer.Point += (int)price / 10000;
                            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Customer/UpdatePoint/{customer.Id}", customer);
                        }
                        if (payment == "a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16")
                        {
                            return Redirect(UrlPayment(bill.Id));
                        }
                        else
                        {
                            return RedirectToAction("Index", "Cart");
                        }

                    }                       
                        
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
                    else if (customer.Point < voucher.PointCustomer)
                    {
                        message = "Khách hàng không đủ điểm để sử dụng voucher này";
                        TempData["Message"] = message;
                    }
                    else if (name == null)
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
                    else if(payment == null)
                    {
                        string messagepayment = "Vui lòng chọn phương thức thanh toán";
                        TempData["Messagepayment"] = messagepayment;
                    }
                    else
                    {
                        giagiam = voucher.Value.ToString();
                        TempData["Giagiam"] = giagiam;
                        string thanhcong = "Đặt hàng thành công";
                        TempData["Thanhcong"] = thanhcong;
                        //await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Bill/CreateBillVoucher/{code}/{payment}", cartDetails);
                        //return RedirectToAction("Index", "Cart");
                        if (voucher != null && voucher.Status == 0 && DateTime.Now <= voucher.TimeEnd && DateTime.Now >= voucher.TimeStart)
                        {
                            price -= voucher.Value;
                        }
                        else
                        {
                            price -= 0;
                        }
                        CreateBill bill = new CreateBill()
                        {
                            Id = Guid.NewGuid(),
                            CustomerId = customer.Id,
                            BillStatusId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                            PaymentId = Guid.Parse(payment),
                            Price = price,
                            CreateDate = DateTime.Now,
                            Address = address,
                            CustomerName = name,
                            CustomerPhone = phonenumber,
                        };
                        await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Bill/CreateBillBT", bill);
                        foreach (var item in cartDetails)
                        {
                            var productdetail = await _httpClient.GetFromJsonAsync<ViewProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{item.ProductDetailId}");

                            //var product = await _httpClient.GetFromJsonAsync<ProductView>($"https://localhost:7033/api/Product/GetById/{productdetail.ProductID}");
                            //UpdateProduct updateProduct = new UpdateProduct()
                            //{
                            //    CategoryID = product.CategoryID,
                            //    Name = product.Name,
                            //    Pin = product.Pin,
                            //    Wrap = product.Wrap,
                            //    Rings = product.Rings,
                            //    AvailableQuantity = product.AvailableQuantity - item.Quantity,
                            //    Sold = product.Sold,
                            //    Likes = product.Likes,
                            //    CreateDate = product.CreateDate,
                            //    Status = product.Status,
                            //    Description = product.Description,
                            //};

                            //await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Product/Update/{product.Id}", updateProduct);

                            CreateBillDetail billDetail = new CreateBillDetail()
                            {
                                BillId = bill.Id,
                                ProductDetailId = productdetail.Id,
                                Quantity = item.Quantity,
                                Price = productdetail.Price * item.Quantity,
                            };

                            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/BillDetail/Create", billDetail);
                            await _httpClient.DeleteAsync($"https://localhost:7033/api/CartDetail/Delete/{item.Id}");
                        }
                        //Cộng điểm cho khách hàng
                        if (price > 100000)
                        {
                            customer.Point += (int)price / 10000;
                            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Customer/UpdatePoint/{customer.Id}", customer);
                        }
                        if (payment == "a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16")
                        {
                            return Redirect(UrlPayment(bill.Id));
                        }
                        else
                        {
                            return RedirectToAction("Index", "Cart");
                        }

                    }
                    return RedirectToAction("Index", "Cart");
                }

                }
            }

            //Nếu không đăng nhập
            else
            {
                var Bills = SessionServices<BillView>.GetObjFromSession(HttpContext.Session, "Bill");
                var result = SessionServices<CartDetailView>.GetObjFromSession(HttpContext.Session, "CartDetail");
                //Kiểm tra giỏ hàng rỗng
                if(result.Count == 0)
                {
                    string messagecart = "Giỏ hàng rỗng";
                    TempData["Messagecart"] = messagecart;
                    return RedirectToAction("Index", "Cart");
                }
                else
                {
                
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
                    else if (payment == null)
                    {
                        string messagepayment = "Vui lòng chọn phương thức thanh toán";
                        TempData["Messagepayment"] = messagepayment;
                    }
                    else
                    {
                        //Kiểm tra username có tồn tại hay ko
                        //var allcustomer = await _httpClient.GetFromJsonAsync<List<Customer>>($"https://localhost:7033/api/Customer/GetAll");
                        //var usernamecustomer = allcustomer.FirstOrDefault(p => p.UserName == name);
                        //if(usernamecustomer != null)
                        //{
                        //    string messagename = "Username này đã tồn tại";
                        //    TempData["Messagename"] = messagename;
                        //}
                        //else
                        //{
                            //Tạo mới khách hàng
                            Register Registercustomer = new Register()
                            {
                                FullName = name,
                                Username = "khach",
                                Password = "123456",
                                ConfirmPassword = "123456",
                                Gender = 0,
                                DateOfBirth = new DateTime(2003, 10, 20),
                                Address = address,
                                PhoneNumber = phonenumber,
                                Email = "khach@gmail.com",
                            };
                            var AddCus = await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/RegisterCustomer", Registercustomer);
                            //Nếu ko tạo dc khách hàng mới
                            //if (AddCus.IsSuccessStatusCode == false)
                            //{
                            //    string messagename = "Vui lòng nhập usename không dấu và viết liền";
                            //    TempData["Messagename"] = messagename;
                            //}
                            //else
                            //{
                                string giagiam = "0";
                                TempData["Giagiam"] = giagiam;
                                string thanhcong = "Đặt hàng thành công";
                                TempData["Thanhcong"] = thanhcong;
                                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{Registercustomer.Username}");
                                //Bill thêm vào session
                                BillView bill = new BillView()
                                {
                                    Id = Guid.NewGuid(),
                                    CustomerId = customer.Id,
                                    BillStatusId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                                    PaymentId = Guid.Parse(payment),
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

                                    //var product = await _httpClient.GetFromJsonAsync<ProductView>($"https://localhost:7033/api/Product/GetById/{productdetail.ProductID}");
                                    //UpdateProduct updateProduct = new UpdateProduct()
                                    //{
                                    //    CategoryID = product.CategoryID,
                                    //    Name = product.Name,
                                    //    Pin = product.Pin,
                                    //    Wrap = product.Wrap,
                                    //    Rings = product.Rings,
                                    //    AvailableQuantity = product.AvailableQuantity - item.Quantity,
                                    //    Sold = product.Sold,
                                    //    Likes = product.Likes,
                                    //    CreateDate = product.CreateDate,
                                    //    Status = product.Status,
                                    //    Description = product.Description,
                                    //};

                                    //await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Product/Update/{product.Id}", updateProduct);

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
                                //Cộng điểm cho khách hàng
                                if (price > 100000)
                                {
                                    customer.Point += (int)price / 10000;
                                    await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Customer/UpdatePoint/{customer.Id}", customer);
                                }
                                if (payment == "a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16")
                                {
                                    return Redirect(UrlPayment(bill.Id));
                                }
                                else
                                {
                                    return RedirectToAction("Index", "Cart");
                                }
                                
                            //}
                        //}
                        
                        
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
                    else if (payment == null)
                    {
                        string messagepayment = "Vui lòng chọn phương thức thanh toán";
                        TempData["Messagepayment"] = messagepayment;
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
                    else if (voucher.PointCustomer > 0)
                    {
                        message = "Khách hàng không đủ điểm để sử dụng voucher này(Vì chưa đăng nhập nên điểm là 0)";
                        TempData["Message"] = message;
                    }
                    else
                    {
                        //Kiểm tra username có tồn tại hay ko
                        //var allcustomer = await _httpClient.GetFromJsonAsync<List<Customer>>($"https://localhost:7033/api/Customer/GetAll");
                        //var usernamecustomer = allcustomer.FirstOrDefault(p => p.UserName == name);
                        //if (usernamecustomer != null)
                        //{
                        //    string messagename = "Username này đã tồn tại";
                        //    TempData["Messagename"] = messagename;
                        //}
                        //else
                        //{
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
                                Username = "khach",
                                Password = "123456",
                                ConfirmPassword = "123456",
                                Gender = 0,
                                DateOfBirth = new DateTime(2003, 10, 20),
                                Address = address,
                                PhoneNumber = phonenumber,
                                Email = "khach@gmail.com",
                            };
                            var AddCus = await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/RegisterCustomer", Registercustomer);
                            //if (AddCus.IsSuccessStatusCode == false)
                            //{
                            //    string messagename = "Vui lòng nhập usename không dấu và viết liền";
                            //    TempData["Messagename"] = messagename;
                            //}
                            //else
                            //{
                                giagiam = voucher.Value.ToString();
                                TempData["Giagiam"] = giagiam;
                                string thanhcong = "Đặt hàng thành công";
                                TempData["Thanhcong"] = thanhcong;
                                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{Registercustomer.Username}");
                                //Bill thêm vào session
                                BillView bill = new BillView()
                                {
                                    Id = Guid.NewGuid(),
                                    CustomerId = customer.Id,
                                    BillStatusId = Guid.Parse("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                                    PaymentId = Guid.Parse(payment),
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

                                    //var product = await _httpClient.GetFromJsonAsync<ProductView>($"https://localhost:7033/api/Product/GetById/{productdetail.ProductID}");
                                    //UpdateProduct updateProduct = new UpdateProduct()
                                    //{
                                    //    CategoryID = product.CategoryID,
                                    //    Name = product.Name,
                                    //    Pin = product.Pin,
                                    //    Wrap = product.Wrap,
                                    //    Rings = product.Rings,
                                    //    AvailableQuantity = product.AvailableQuantity - item.Quantity,
                                    //    Sold = product.Sold,
                                    //    Likes = product.Likes,
                                    //    CreateDate = product.CreateDate,
                                    //    Status = product.Status,
                                    //    Description = product.Description,
                                    //};

                                    //await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Product/Update/{product.Id}", updateProduct);

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
                                //Cộng điểm cho khách hàng
                                if (price > 100000)
                                {
                                    customer.Point += (int)price / 10000;
                                    await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Customer/UpdatePoint/{customer.Id}", customer);
                                }
                                if (payment == "a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16")
                                {
                                    return Redirect(UrlPayment(bill.Id));
                                }
                                else
                                {
                                    return RedirectToAction("Index", "Cart");
                                }
                            //}
                        //}
                        
                        
                    }
                    return RedirectToAction("Index", "Cart");
                }

            }
            

            }
        }

        public string UrlPayment(Guid id)
        {
            var urlPayment = "";
            var bill = _httpClient.GetFromJsonAsync<BillView>($"https://localhost:7033/api/Bill/GetById/{id}").Result;


            string vnp_Returnurl = "https://localhost:7162/BillDetails/VnpayReturn"; //URL nhan ket qua tra ve
            string vnp_Url = "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html"; //URL thanh toan cua VNPAY 
            string vnp_TmnCode = "M5D7W272"; //Ma định danh merchant kết nối (Terminal Id)
            string vnp_HashSecret = "DGGZJILFSRTUPWIOIBRQXDXJXQPLAOZY"; //Secret Key

            VnPayLibrary vnpay = new VnPayLibrary();

            var price = (long)bill.Price * 100;
            vnpay.AddRequestData("vnp_Version", VnPayLibrary.VERSION);
            vnpay.AddRequestData("vnp_Command", "pay");
            vnpay.AddRequestData("vnp_TmnCode", vnp_TmnCode);
            vnpay.AddRequestData("vnp_Amount", price.ToString());


            vnpay.AddRequestData("vnp_CreateDate", bill.CreateDate.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", "VND");
            vnpay.AddRequestData("vnp_IpAddr", "13.160.92.202");
            vnpay.AddRequestData("vnp_Locale", "vn");
            vnpay.AddRequestData("vnp_OrderInfo", "Thanh toan don hang:" + bill.Id);
            vnpay.AddRequestData("vnp_OrderType", "other"); //default value: other

            vnpay.AddRequestData("vnp_ReturnUrl", vnp_Returnurl);
            vnpay.AddRequestData("vnp_TxnRef", bill.Id.ToString());

            //Add Params of 2.1.0 Version
            //Billing
            urlPayment = vnpay.CreateRequestUrl(vnp_Url, vnp_HashSecret);
            return urlPayment;
        }


    }
}