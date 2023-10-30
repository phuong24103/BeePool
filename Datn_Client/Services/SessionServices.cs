using Datn_Shared.ViewModels.CartDetailViewModels;
using Newtonsoft.Json;

namespace Shopping_Website.Services
{
    public class SessionServices<T>
	{
        //Lấy dữ liệu từ sesion trả về 1 list đối tượng
        public static List<T> GetObjFromSession(ISession session, string key)
		{
			//Bước 1: lấy string data từ session ở dạng json
			string jsonData = session.GetString(key);
			if (jsonData == null) return new List<T>();
			//Nếu dữ liệu null tạo mới 1 list rỗng
			//Bước 2: Convert về list
			var Objects = JsonConvert.DeserializeObject<List<T>>(jsonData);
			return Objects;
		}
		//Ghi dữ liệu từ 1 list vào session
		public static void SetObjToSession(ISession session, string key, object values)
		{
			var jsonData = JsonConvert.SerializeObject(values);
			session.SetString(key, jsonData);
        }
        public static bool CheckExistCartDetail(Guid id, List<CartDetailView> carts)
        {
            return carts.Any(x => x.ProductDetailId == id);
        }
    }
}
