# Cấu trúc thư mục của dự án .Net MVC
###
    Cấu trúc theo thứ tự : Controllers ->Views->Models
        +Controllers: Controller là một thành phần quan trọng trong mô hình MVC (Model – View – Controller).
        Controller có nhiệm vụ:
        
        Nhận yêu cầu (request) từ người dùng thông qua URL
        
        Xử lý logic của ứng dụng
        
        Trả về View (giao diện) hoặc dữ liệu cho người dùng
        
        Controller đóng vai trò trung gian kết nối giữa Model và View.
        +view: View là thành phần trong mô hình MVC có nhiệm vụ hiển thị giao diện người dùng.
        View nhận dữ liệu từ Controller và trình bày dữ liệu đó dưới dạng HTML để trả về trình duyệt.
        
        View không chứa logic xử lý nghiệp vụ, mà chỉ tập trung vào việc hiển thị.
        +Models: Model là thành phần trong mô hình MVC (Model – View – Controller) dùng để:

        Biểu diễn dữ liệu của ứng dụng
###
        
        Chứa logic liên quan đến dữ liệu
        
        Kết nối và làm việc với cơ sở dữ liệu (nếu có)
        
        Model không xử lý giao diện và không nhận request trực tiếp từ người dùng.
                    
