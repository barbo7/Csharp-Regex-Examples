using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
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

/*Longest Word
HIDE QUESTION
Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the string.
If there are two or more words that are the same length, return the first word from the string with that length. 
Ignore punctuation and assume sen will not be empty. Words may also contain numbers, for example "Hello world123 567"*/
public static string LongestWord(string sen) {
     sen = Regex.Replace(sen, @"[^\w\s]", "");
    string[] kelimeler = sen.Split(' ');
    int uzun = 0;
    List<string> uzunOlanlar = new List<string>();
    string son = "";
    foreach(string i in kelimeler)
    {
      if(i.Length > uzun)
      {
        uzun = i.Length;
        uzunOlanlar.Clear();
        uzunOlanlar.Add(i);
      }
      else if(i.Length==uzun)
        uzunOlanlar.Add(i);
    }
