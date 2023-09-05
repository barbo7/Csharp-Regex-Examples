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
/*
1-Bir metindeki tüm e-posta adreslerini bulmak için kullanabileceğiniz bir regex ifadesi nedir?

2-Bir metindeki tüm telefon numaralarını bulmak için kullanabileceğiniz bir regex ifadesi nedir? (Örnek format: (555) 555-5555)

3-Bir metindeki tüm URL'leri (web siteleri) bulmak için kullanabileceğiniz bir regex ifadesi nedir?

4-Bir metindeki tüm zip kodlarını (posta kodları) bulmak için kullanabileceğiniz bir regex ifadesi nedir? (Örnek format: 12345 veya 12345-6789)

5-Bir metindeki tüm tarihleri (örneğin, 01/01/2023 veya 2023-01-01) bulmak için kullanabileceğiniz bir regex ifadesi nedir?

6-Bir metindeki tüm sayıları (negatif ve ondalık sayılar dahil) bulmak için kullanabileceğiniz bir regex ifadesi nedir?

7-Bir metindeki tüm IP adreslerini (IPv4 ve IPv6) bulmak için kullanabileceğiniz bir regex ifadesi nedir?

8-Bir metindeki tüm HTML etiketlerini (örneğin, <div> veya <a href="...">) bulmak için kullanabileceğiniz bir regex ifadesi nedir?

9-Bir metindeki tüm Twitter kullanıcı adlarını (örneğin, @username) bulmak için kullanabileceğiniz bir regex ifadesi nedir?

10-Bir metindeki tüm fiyatları (örneğin, $99.99 veya 100 TL) bulmak için kullanabileceğiniz bir regex ifadesi nedir?
*/

   Regex rg1 = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
   Regex rg2 = new Regex(@"\(\d{3}\)\s\d{3}-\d{4}");
   Regex rg3 = new Regex(@"^www\.\w+\.com$");
   Regex rg4 = new Regex(@"^\w+.com$");
   Regex rg5 = new Regex(@"^\d{2}/\d{2}/\d{4}$|^\d{4}/\d{2}/\d{2}$");
   Regex rg6 = new Regex(@"^-?\d+(\.\d+)?$");
   Regex rg7 = new Regex(@"\d{3}\.\d{3}\.\d{1,3}\.\d{1,3}");
   Regex rg8 = new Regex(@"\<div\>|\<a href=\"\w+"\>");
   Regex rg9 = new Regex(@"^@\w+$");
   Regex rg10 = new Regex@"(?:\$|₺)\d+(\.\d{2})?");
   
   
