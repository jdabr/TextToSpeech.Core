using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// TextCleaner.cs
public class TextCleaner
{
    public string Clean(string raw)
    {
        // Remove excess whitespace, fix smart quotes, etc.
        var cleaned = Regex.Replace(raw, @"\s+", " ");
        cleaned = cleaned.Replace("\u201C", "\"").Replace("\u201D", "\"");
        return cleaned.Trim();
    }
}
