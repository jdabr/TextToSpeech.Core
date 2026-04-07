using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UglyToad.PdfPig;

namespace TextToSpeech.Core.Extractors
{
    internal class PdfExtractor
    {
        public class pdfExtractor : ITextExtractor
        {
            public bool CanHandle(string ext) => ext == ".pdf";

            public Task<string> ExtractAsync(Stream fileStream)
            {
                using var doc = PdfDocument.Open(fileStream);
                var text = string.Join(" ", doc.GetPages()
                    .SelectMany(p => p.GetWords())
                    .Select(w => w.Text));
                return Task.FromResult(text);
            }
        }
    }
}
