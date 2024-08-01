using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HastaneYonetimSistemi.Utils
{
    //Extension (Uzantı): Bir nesne için yazılan özel fonksiyonlardır.
    public static class StringExtensions
    {
        //String ifadeler için özel uzantılar burada yazımıştır.

        //String bir ifadenin TC Kimlik No olup olmadığını söyler.
        public static bool IsTCKN(this string tckn)
        {
            bool isParsed = long.TryParse(tckn, out long tckn_long);
            if (isParsed && tckn_long.ToString().Length == 11)
            {
                long first9 = tckn_long / 100;
                long last2 = tckn_long % 100;
                long odds = 0, evens = 0;
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(first9);
                    long b = first9 % 10;
                    if (i % 2 == 0)
                    {
                        evens += b;
                    }
                    else
                    {
                        odds += b;
                    }
                    first9 /= 10;
                }
                long b10 = (odds * 7 - evens) % 10;
                long b11 = (odds + evens + b10) % 10;
                return last2 == b10 * 10 + b11;
            }
            return false;
        }

        //String bir ifadenin e-posta adresi olup olmadığını söyler.
        public static bool IsEmail(this string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                /*
                Character classes:
                .	any character except newline
                \w\d\s	word, digit, whitespace
                \W\D\S	not word, digit, whitespace
                [abc]	any of a, b, or c
                [^abc]	not a, b, or c
                [a-g]	character between a & g
                Anchors
                ^abc$	start / end of the string
                \b\B	word, not-word boundary

                Escaped characters:
                \.\*\\	escaped special characters
                \t\n\r	tab, linefeed, carriage return
                Groups & Lookaround
                (abc)	capture group
                \1	backreference to group #1
                (?:abc)	non-capturing group
                (?=abc)	positive lookahead
                (?!abc)	negative lookahead

                Quantifiers & Alternation:
                a*a+a?	0 or more, 1 or more, 0 or 1
                a{5}a{2,}	exactly five, two or more
                a{1,3}	between one & three
                a+?a{2,}?	match as few as possible
                ab|cd	match ab or cd
                 */
                string pattern = @"[a-z][a-z0-9._]*@[a-z][a-z0-9_]+(\.[a-z][a-z0-9_]+)+";
                Regex email_regex = new Regex(pattern, RegexOptions.IgnoreCase);
                return email_regex.IsMatch(text);
            }
            return false;
        }
    }
}
