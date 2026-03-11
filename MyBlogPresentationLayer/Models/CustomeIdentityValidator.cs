using Microsoft.AspNetCore.Identity;

namespace MyBlogPresentationLayer.Models;

public class CustomeIdentityValidator:IdentityErrorDescriber
{
    public override IdentityError PasswordRequiresLower()
    {
        return new IdentityError()
        {
            Code = "PasswordRequiresLower",
            Description = "Lütfen En az 1 tane küçük veri girişi yapınız('a'-'z')."
        };
        
    }

    public override IdentityError PasswordTooShort(int length)
    {
        return new IdentityError()
        {
            Code = "PasswordTooShort",
            Description = "Lütgen en az 6 karakter veri girişi yapınız."
        };
    }
}