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
	std::list<double> numbers2(10);
	std::list<int> numbers3 = { 1, 2, 3 };
	std::list<double> numbers4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	
	for (std::list<int>::iterator it = numbers1.begin(); it != numbers1.end(); ++it) {
		*it = *it + 1;
	}
	int val = 0;
	for (std::list<double>::iterator it2 = numbers2.begin(); it2 != numbers2.end() && val <= 5; ++it2) {
		numbers2.push_back(val);
		val++;
	}

	for (std::list<int>::iterator it3 = numbers3.begin(); it3 != numbers3.end(); ++it3) {
		*it3 = *it3 + 1;
	}

	for (std::list<double>::iterator it4 = numbers4.begin(); it4 != numbers4.end(); ++it4) {
		*it4 = *it4 + 1;
	}

	std::vector<double> numbers5 = { 5, 6, 10, 12, 11, 7 };
	for (std::vector<double>::iterator it5 = numbers5.begin(); it5 != numbers5.end(); ++it5) {
		*it5 = *it5 + 1;
	}

	std::list<double> numbers6 = { 10, 17, 25, 78, 96, 11 };
	for (std::list<double>::iterator it6 = numbers6.begin(); it6 != numbers6.end(); ++it6) {
		cout << *it6;
	}

}