using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Diplom {
    class ParsingClass {
        private static string FilePath { get; set; }
        private static byte[] mas = new byte[2]; // 0 - открывающие скобки, 1 - закрывающие
        public List<string> lstWithBlocks = new List<string>(); // контейнер с блоками циклов
        //public List<string> lstWithList = new List<string>(); // контейнер, где хранятся имена всех контейнеров C++
        public List<int> indexList = new List<int>(); // контейнер с номерами строк циклов
        public Dictionary<string, int> informationMas = new Dictionary<string, int>();
        string textInFile = "";

        public ParsingClass(string filePath) {
            FilePath = filePath;
        }

        private static void ReadFile(ref string text) {
            using (StreamReader read = new StreamReader(FilePath, System.Text.Encoding.Default)) {
                string line = "";
                while ((line = read.ReadLine()) != null) {
                    text += line + '\n';
                }
            }
        }

        

    }
}
