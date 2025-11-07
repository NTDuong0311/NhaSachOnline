
using Microsoft.AspNetCore.Identity;
using NhaSachOnline.ChucNangPhanQuyen;

namespace NhaSachOnline.Data
{
    public class DataSeed
    {
        public static async Task KhoiTaoDuLieuMacDinh(IServiceProvider dichVu)
        {
            var quanLyNguoiDung = dichVu.GetService<UserManager<IdentityUser>>();
            var quanLyVaiTro = dichVu.GetService<RoleManager<IdentityRole>>();

            // Thêm một vai trò vào cơ sở dữ liệu
            await quanLyVaiTro.CreateAsync(new IdentityRole(PhanQuyen.Admin.ToString()));
            await quanLyVaiTro.CreateAsync(new IdentityRole(PhanQuyen.User.ToString()));

            // Tạo thông tin mặc định cho tài khoản Admin,
            // bao gồm: UserName, Email, xác thực Email
            var quanTri = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true
            };

            var nguoiDungTrongCsdl = await quanLyNguoiDung.FindByEmailAsync(quanTri.Email);
            // Nếu tài khoản Admin không tồn tại trong csdl (chưa có trong csdl)
            if (nguoiDungTrongCsdl is null)
            {
                // Tạo tài khoản Admin mới với mật khẩu là 12345
                //var ketQua = await quanLyNguoiDung.CreateAsync(quanTri, "12345");
                var ketQua = await quanLyNguoiDung.CreateAsync(quanTri, "Admin12345");
                // Nếu tạo thành công, thêm vai trò cho người dùng
                if (ketQua.Succeeded)
                {
                    await quanLyNguoiDung.AddToRoleAsync(quanTri, PhanQuyen.Admin.ToString());
                }
                else
                {
                    // Xử lý các lỗi có thể xảy ra khi tạo người dùng
                    // Ví dụ: in ra các thông báo lỗi
                    foreach (var loi in ketQua.Errors)
                    {
                        Console.WriteLine(loi.Description);
                    }
                }
            }
        }
    }
}
