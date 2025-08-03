<img width="1024" height="1536" alt="image" src="https://github.com/user-attachments/assets/c41e33a4-aaeb-46da-9ee9-7f5a06de2e64" /># Universal SQL WebAPI Gateway

Một giải pháp WebAPI duy nhất có thể xử lý toàn bộ nghiệp vụ bằng cách khai báo store procedure trong SQL Server.

## Sơ đồ tổng quát

<img width="1024" height="1536" alt="image" src="https://github.com/user-attachments/assets/d00ca2b9-a8c6-44ba-9903-89d3842bd1e7" />

## Các thành phần chính

- `tblApi`: ánh xạ mã API với store procedure
- `spSysExecuteJsonSP`: gọi động SP tương ứng, truyền JSON và nhận kết quả
- SP nghiệp vụ: nhận JSON, xử lý, trả kết quả

## Ưu điểm

- Không cần code backend nhiều
- Dễ mở rộng
- Dễ chia sẻ và áp dụng

## Ví dụ JSON request

```json
{
  "ApiCode": "customer_ins",
  "JsonParameters": "{ \"name\": \"Nguyễn Văn A\", \"phone\": \"0912345678\" }"
}
