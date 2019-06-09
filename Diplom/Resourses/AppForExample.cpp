// AppForExample.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <list>
#include <iterator>
#include <iostream>
using namespace std;

int main()
{
	std::list<int> numbers1 = { 1, 2, 3, 4, 5 };
	for (std::list<int>::iterator it = numbers1.begin(); it != numbers1.end(); ++it) {
		*it = *it + 1;
	}
	std::list<int> numbers2 = { 1, 2, 3, 4, 5 };
	for (std::list<int>::iterator it2 = numbers2.begin(); it2 != numbers2.end(); ++it2) {
		*it2 = *it2 + 1;
	}
	std::list<int> numbers3 = { 1, 2, 3, 4, 5 };
	for (std::list<int>::iterator it3 = numbers3.begin(); it3 != numbers3.end(); ++it3) {
		*it3 = *it3 + 1;
	}
	std::list<int> numbers4 = { 1, 2, 3, 4, 5 };
	for (std::list<int>::iterator it4 = numbers4.begin(); it4 != numbers4.end(); ++it4) {
		*it4 = *it4 + 1;
	}
	std::list<int> numbers5 = { 1, 2, 3, 4, 5 };
	for (std::list<int>::iterator it5 = numbers5.begin(); it5 != numbers5.end(); ++it5) {
		*it5 = *it5 + 1;
	}
	std::list<int> numbers6 = { 1, 2, 3, 4, 5 };
	for (std::list<int>::iterator it6 = numbers6.begin(); it6 != numbers6.end(); ++it6) {
		*it6 = *it6 + 1;
	}
	std::list<int> numbers7 = { 1, 2, 3, 4, 5 };
	for (std::list<int>::iterator it7 = numbers7.begin(); it7 != numbers7.end(); ++it7) {
		*it7 = *it7 + 1;
	}
	return 0;
}