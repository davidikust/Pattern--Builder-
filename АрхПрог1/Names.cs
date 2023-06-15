using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АрхПрог
{
    static class Names
    {
        static string[] name = { "Ben", "Don", "Bullment", "Jacob", "James", "Dar", "Makar",
            "Gulma", "Deus", "Bob", "Ben", "Bill", "Bulb", "Fred", "Fill", "Fante", "Rick", "Melmin", "Mustafa"};
        static public string GetName(int i)
        {
            return name[i % name.Length];
        }
    }
}
