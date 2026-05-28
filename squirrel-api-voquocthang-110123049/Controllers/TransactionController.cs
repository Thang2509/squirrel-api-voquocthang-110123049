using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using squirrel_api_voquocthang_110123049;
namespace squirrel_api_voquocthang_110123049.Controllers
{
    [ApiController]
    [Route("api/giaodich")] // Đường dẫn API theo đúng yêu cầu đề bài
    public class TransactionController : ControllerBase
    {
        // Khởi tạo cứng (Hardcode) danh sách dữ liệu gồm 5 dòng giao dịch theo bảng đề bài cho
        private static readonly List<Transaction> MockTransactions = new List<Transaction>
        {
            new Transaction { Id = 1, SoTaiKhoan = "1023456789", SoTien = 500000, LoaiGiaoDich = "Nap tien" },
            new Transaction { Id = 2, SoTaiKhoan = "1023456789", SoTien = 200000, LoaiGiaoDich = "Rut tien" },
            new Transaction { Id = 3, SoTaiKhoan = "1098765432", SoTien = 1000000, LoaiGiaoDich = "Nap tien" },
            new Transaction { Id = 4, SoTaiKhoan = "1098765432", SoTien = 150000, LoaiGiaoDich = "Rut tien" },
            new Transaction { Id = 5, SoTaiKhoan = "1055566677", SoTien = 300000, LoaiGiaoDich = "Nap tien" }
        };

        // API GET: Lọc và xuất ra các giao dịch có loại là "Nap tien"
        [HttpGet]
        public IActionResult GetDepositTransactions()
        {
            var result = MockTransactions
                .Where(t => t.LoaiGiaoDich == "Nap tien")
                .ToList();

            return Ok(result); // Trả về mã HTTP 200 kèm chuỗi JSON kết quả
        }
        // API GET: Xuất ra TOÀN BỘ 5 dòng dữ liệu trong CSDL vùng nhớ
[HttpGet("tatca")]
public IActionResult GetAllTransactions()
{
    return Ok(MockTransactions); // Trả về toàn bộ danh sách không lọc
}
    }
}