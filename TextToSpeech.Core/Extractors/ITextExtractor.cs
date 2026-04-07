using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeech.Core.Extractors
{
    internal class ITextExtractor
    {
        public interface Itextextractor
        {
            bool CanHandle(string fileExtension);
            Task<string> ExtractAsync(Stream fileStream);
        }
    }
}
