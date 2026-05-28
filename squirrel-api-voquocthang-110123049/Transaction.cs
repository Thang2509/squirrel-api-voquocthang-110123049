namespace squirrel_api_voquocthang_110123049
{
    public class Transaction
    {
        public int Id { get; set; }
        public string SoTaiKhoan { get; set; } = string.Empty;
        public double SoTien { get; set; } // Số thực
        public string LoaiGiaoDich { get; set; } = string.Empty;
    }
}