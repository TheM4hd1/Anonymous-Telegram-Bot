
<DIV dir="RTL">

## بات ارسال پیام ناشناس در تلگرام 

**این بات به این صورت کار می کنه که کاربر برای فردی که درخواست سرویس دریافت پیام ناشناس رو داده یا به اصطلاح لینک دریافت پیام ناشناسش رو برای دیگران ارسال کرده پیام می فرسته**
**پیام ابتدا برای بات ارسال میشه و بعد از اون بات برای فرد دیگر پیام رو ارسال می کنه**
**کاملا شبیه به کار یک پروکسی**

###  امکانات:

 * قابلیت پاسخ به پیام ( ریپلای )
 * اطلاع به کاربر هنگام دریافت پیام جدید

###   پنل ادمین بات قابلیت های زیر رو دارا می باشد:

* مشاهده پیام های رد و بدل شده بین کاربران
* امکان فیلتر کردن پیام های خاص
* مشاهده اطلاعات کاربران
* ذخیره و مشاهده عکس پروفایل
* ارسال پیام دست جمعی به کاربران از طریق بات
* ارسال پیام به شخص خاص از طریق بات
* اضافه کردن ادمین جدید
* ارسال مشکلات فنی هندل نشده برای ادمین

### ابزار مورد نیاز:
* [SQL Server 2017 ](https://go.microsoft.com/fwlink/?linkid=853016)
* [Telegram.Bot API](https://github.com/TelegramBots/Telegram.Bot)
* [NET Framework 4.6.1.](https://www.microsoft.com/en-us/download/details.aspx?id=49981)
</DIV>

### Tables:
---
 | tbl_users | Data Type |
 | --------- |:---------:|
 | Id  | bigint |
 | FullName  | nvarchar(100) |
 | UserName  | nvarchar(100) |
 | ContactCode | nvarchar(50) |
 | ProfilePhoto | image |
 | ContactName | nvarchar(100) |
---
 | tbl_messages | Data Type |
 | ------------ |:---------:|
 | ReceiverId | bigint |
 | ReceiverName | nvarchar(100) |
  | ReceiverContactCode | nvarchar(50) |
  | ReceiverUsername | nvarchar(100) |
  | Message | nvarchar(max) |
  | SenderId | bigint |
  | SenderName | nvarchar(100) |
  | SenderUsername | nvarchar(100) |
  | Id | int |
---
| tbl_requests | Data Type |
| ------------ |:---------:|
  | Id | bigint |
  | Request | int |
  | ContactCode | nvarchar(50) |
---
###  Config:
  
  ```c#
  // BotConfigs.cs, enter your bot token here
  public const string BOT_TOKEN = "";
```
