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

    5. Properties/

    +Chứa cấu hình nội bộ của project
    Ví dụ: launchSettings.json

    6. appsettings.json

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