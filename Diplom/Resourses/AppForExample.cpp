// AppForExample.cpp: ���������� ����� ����� ��� ����������� ����������.
//

#include"stdafx.h"
#include<list>
#include<iterator>
#include<iostream>
using namespace std;
int main()
{
	std::list<int> numbers1 = { 1, 2, 3, 4, 5 };
	std::list<double> numbers2(10);
	std::list<int> numbers3 = { 1, 2, 3, 4, 5 };
	std::list<double> numbers4 = { 1, 2, 3, 4, 5 };
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
	return 0;
}
