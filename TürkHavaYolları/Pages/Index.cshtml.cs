using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Username { get; set; }

    [BindProperty]
    public string Password { get; set; }

    public IActionResult OnPostLogin()
    {
        if (Username == "kullaniciadi" && Password == "sifre123")
        {
            // Kullanıcı doğru kimlik bilgilerini girdiyse,
            // Yolcu bilgileri sayfasına yönlendir.
            return RedirectToPage("/YolcuBilgileri");
        }
        else
        {
            // Kullanıcı yanlış kimlik bilgilerini girdiyse,
            // Hata mesajını görüntüle.
            ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre yanlış.");
            return Page();
        }
    }
}
