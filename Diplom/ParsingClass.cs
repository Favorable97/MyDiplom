﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Diplom {
    class ParsingClass {
        private static byte[] mas = new byte[2]; // 0 - открывающие скобки, 1 - закрывающие
        private List<string> lstWithBlocks = new List<string>(); // контейнер с блоками циклов
        public List<string> lstWithTypeIter = new List<string>(); // контейнер, где хранятся типы итераторов/контейнеров C++
        private List<int> indexList = new List<int>(); // контейнер с номерами строк циклов
        public Dictionary<string, int> informationMas = new Dictionary<string, int>();
        private string TextInFile { get; }

        public ParsingClass(string textInFile) {
            TextInFile = textInFile;
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
            string[] splitText = TextInFile.Split('\n');
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
            SearchIterators();
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

        /*
         * Определяем нужные для нас итераторы
         * Работает не правильно, если элементы и добавляются, и идёт обращение 
         */
        private void SearchIterators() {
            for (int i = 0; i < lstWithBlocks.Count; i++) {
                Regex regex = new Regex(@"\w*::iterator");
                string strWithArg = lstWithBlocks[i].Substring(lstWithBlocks[i].IndexOf('(') + 1, lstWithBlocks[i].IndexOf(';') - lstWithBlocks[i].IndexOf('(') - 1);
                if (regex.IsMatch(strWithArg)){ 
                    if (IsList(strWithArg)) {
                        string nameIterator = strWithArg.Substring(strWithArg.IndexOf(' ') + 1, strWithArg.IndexOf('=') - strWithArg.IndexOf(' ') - 1).Trim(' ');
                        string[] masString = lstWithBlocks[i].Split('\t');
                        for (int j = 2; j < masString.Length; j++) {
                            if (masString[j].Contains(nameIterator)) {
                                informationMas.Add(nameIterator, indexList[i]);
                                lstWithTypeIter.Add(TypeDefinitionIter(i));
                                break;
                            }
                        }
                    }
                }
            }
        }

        /*
         * Определение типа контейнера 
         * Находим символ ":" от него + 2 - это начальная позиция и находим символ < - это конечная позиция
         * Создан, что предотвратить оптимизацию только контейнера list
         */

        private bool IsList(string str) {
            bool isList = str.Substring(str.IndexOf(':') + 2, str.IndexOf('<') - (str.IndexOf(':') + 2)) == "list" ? true : false;
            return isList; 
        }

        /*
         * Определение типа итераторов
         * Разбиваем строку с циклом, чтобы осталось только например(std::list<int>::iterator it = numbers1.begin())
         * Далее определяем то, что находится между символами '<' и '>'
         */
        private string TypeDefinitionIter(int index) {
            string strWithArg = lstWithBlocks[index].Substring(lstWithBlocks[index].IndexOf('(') + 1, lstWithBlocks[index].IndexOf(';') - lstWithBlocks[index].IndexOf('(') - 1);
            int pos1 = strWithArg.IndexOf('<');
            int pos2 = strWithArg.IndexOf('>');
            string typeIterator = strWithArg.Substring(pos1 + 1, pos2 - pos1 - 1);
            return typeIterator;
        }
        
    }
}
