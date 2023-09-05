/*Codeland Username Validation
HIDE QUESTION
Have the function CodelandUsernameValidation(str) take the str parameter being passed and determine if the string is a valid username according to the following rules:
1. The username is between 4 and 25 characters.(4 ile 25 karakter arasında olmalı)
2. It must start with a letter.(harfle başlamalı)
3. It can only contain letters, numbers, and the underscore character.(alfanümerik karakterler içermeli)
4. It cannot end with an underscore character.(alt çizgi (_) ile bitmemeli)*/ 
--
   public static string GelenKullaniciAdi(string str) {

    Regex rg = new Regex(@"^[a-zA-Z]\w{3,24}(?<!_)$");
    Match match = rg.Match(str);
      
    return match.Success.ToString();
  }
