# I. Cấu trúc thư mục dự án ASP.NET MVC Controllers/
###
    1.Controllers/

    + Chứa các Controller
    + Nhận request từ người dùng, xử lý logic và trả về View
    Ví dụ: HomeController.cs, DemoController.cs

    2.Models/

    + Chứa các Model (lớp dữ liệu)
    + Đại diện cho dữ liệu + nghiệp vụ
    Ví dụ: Student.cs, Product.cs

    3.Views/

    + Chứa các View (.cshtml) để hiển thị giao diện
    + Cấu trúc bên trong:
    + Views/Home/Index.cshtml
    + Views/Demo/Index.cshtml
    + Views/Shared/ → layout chung, _Layout.cshtml, Error.cshtml

    4.wwwroot/

    + Chứa file tĩnh
    + Gồm:
    - css/
    - js/
    - images/

    + Không xử lý logic, chỉ để hiển thị

    5.Properties/

    +Chứa cấu hình nội bộ của project
    Ví dụ: launchSettings.json

    6.appsettings.json

    + File cấu hình ứng dụng
    + Chuỗi kết nối DB, cấu hình môi trường

    7.Program.cs

    + Điểm khởi động ứng dụng
    + Cấu hình:
    -MVC
    - Route
    - Middleware

    8.csproj

    + File cấu hình project
    + Quản lý package, framework, build

    9.bin/ & obj/

    + Thư mục sinh ra khi build/run
    + Không chỉnh sửa thủ công
###
# II. Định tuyến (Route) trong .Net MVC 
### 
    1.Định tuyến (Routing) trong .NET MVC

    + Routing là cơ chế ánh xạ URL đến Controller và Action.
    + Giúp hệ thống biết khi người dùng truy cập một đường dẫn thì hàm nào sẽ được thực thi.

    2.Cấu hình Route mặc định

    + Định tuyến được cấu hình trong file Program.cs:

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    - controller=Home: Controller mặc định
    - action=Index: Action mặc định
    - id?: tham số tuỳ chọn

    3.Cách hoạt động

    URL → Routing → Controller → Action → View → User
    + Các kiểu Routing:

    - Convention-based Routing
    Dựa trên quy ước URL
    Dạng: /Controller/Action
    Ví dụ: /Demo/Index
    
    - Attribute Routing
    Khai báo route trực tiếp trên Controller hoặc Action

    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }

    - Routing với tham số

    Ví dụ URL: /Student/Detail/5

    Action tương ứng: public IActionResult Detail(int id)

    4.Kết luận

    + Routing là thành phần quan trọng trong .NET MVC
    + Giúp điều hướng request từ URL đến đúng Controller và Action
    + Có 2 loại chính: Convention-based Routing và Attribute Routing
###
# III. Controller, View trong .Net MVC
###
    1.Controller
    + Controller là thành phần nhận request từ người dùng.
    + Xử lý logic, gọi Model (nếu cần) và trả kết quả về View.
    + Nằm trong thư mục Controllers/.
    
    Ví dụ:
        using Microsoft.AspNetCore.Mvc;

    namespace NetCoreAPI.Controllers
    {
        public class DemoController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
        }
    }

    2.View

    + View dùng để hiển thị giao diện cho người dùng.
    + Viết bằng Razor (.cshtml).
    + Nhận dữ liệu từ Controller để hiển thị.
    + Nằm trong thư mục Views/.

    3.Kết luận

    + Controller: xử lý request và điều khiển luồng.
    + View: hiển thị giao diện cho người dùng.
    + Controller và View phối hợp với Routing để tạo nên ứng dụng .NET MVC hoàn chỉnh.
###