using Microsoft.AspNetCore.Identity;

namespace MyIdentityApp.Models
{
    // IdentityUser -> ASP.NET Identity'dagi tayyor User modeli (Id, UserName, Email va boshqalar bor)
    // Biz undan meros olib, qo'shimcha ustunlar qo'shamiz
    public class ApplicationUser : IdentityUser
    {
        // FullName -> yangi ustun. Foydalanuvchining to'liq ismini saqlash uchun.
        public string FullName { get; set; }
    }
}
