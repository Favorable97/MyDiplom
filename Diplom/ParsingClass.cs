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

        /*
         * Разбиваем строку на массив строк, где разделитель - символ перехода на новую строчку.
         * Каждую строчку проверяем, используя регулярное выражение.
         * Если строка подходит, то записываем её во временную строку а также запоминаем строчку с началом цикла. 
         * Так до тех пор, пока не будет найдена последняя закрывающая скобка.
         * mas[0] == mas[1]
         * Дойдя до конца блока, записываем его в специальный список, но прежде форматируем
         */
        public void ParsingText() {
            ReadFile(ref textInFile);
            string[] splitText = textInFile.Split('\n');
            Regex regex = new Regex(@"\w*for\w*");
            Regex pattern = new Regex(@"\s+");

            for (int i = 0; i < splitText.Length; i++) {
                if (regex.IsMatch(splitText[i])) {
                    indexList.Add(i + 1);
                    string strWithFor = "";
                    do {
                        string str = splitText[i];
                        SearchOpenBracket(str);
                        SearchCloseBracket(str);
                        strWithFor += str;
                        i++;

                    } while (mas[0] != mas[1]);
                    i--;
                    mas[0] = 0;
                    mas[1] = 0;
                    //lstWithBlocks.Add(pattern.Replace(strWithFor.Trim('\t'), "\n"));
                    lstWithBlocks.Add(strWithFor);

                }

            }
            PrintList(lstWithBlocks);
        }

        private static void SearchOpenBracket(string str) {
            int pos = 0;
            while (str.IndexOf('{', pos) != -1) {
                mas[0]++;
                pos = str.IndexOf('{', pos) + 1;
            }
        }

        private static void SearchCloseBracket(string str) {
            int pos = 0;
            while (str.IndexOf('}', pos) != -1) {
                mas[1]++;
                pos = str.IndexOf('}', pos) + 1;
            }
        }

        public void PrintList(List<string> lst) {
            foreach (var strok in lst)
                Console.WriteLine(strok);
        }

    }
}
