using FluentValidation.Resources;
using System.Globalization;

public class UzbekLanguageManager : LanguageManager
{
    public UzbekLanguageManager()
    {
        Culture = new CultureInfo("uz");

        AddTranslation("uz", "NotEmptyValidator", "'{PropertyName}' maydoni majburiy");
        AddTranslation("uz", "LengthValidator", "'{PropertyName}' uzunligi {MinLength} dan {MaxLength} gacha bo‘lishi kerak");
        AddTranslation("uz", "EmailValidator", "'{PropertyName}' formati noto‘g‘ri");
        AddTranslation("uz", "EqualValidator", "'{PropertyName}' mos kelmadi");
        AddTranslation("uz", "MinimumLengthValidator", "'{PropertyName}' kamida {MinLength} belgidan iborat bo‘lishi kerak");
        AddTranslation("uz", "MatchesValidator", "'{PropertyName}' formati noto‘g‘ri");
    }
}
