// TopCoderCppTemplate.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <vector>
#include <list>
#include <map>
#include <set>
#include <queue>
#include <deque>
#include <stack>
#include <bitset>
#include <algorithm>
#include <functional>
#include <numeric>
#include <utility>
#include <sstream>
#include <iostream>
#include <iomanip>
#include <cstdio>
#include <cmath>
#include <cstdlib>
#include <ctime>

using namespace std;

class CCipher {
public:
	string decode(string cipherText, int shift) {
		string temp = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
		string res;
		for(int a = 0; a < cipherText.length(); a++)
		{
			int index = temp.find(cipherText[a]);
			int newIndex = index - shift;
			if(newIndex < 0)
				newIndex += temp.length();
			res.push_back(temp[newIndex]);
		}
		return res;
	}
};

int _tmain(int argc, _TCHAR* argv[])
{
	CCipher x;
	std::string result = x.decode("AAQREQFGT", 2);
	std::cout << result << std::endl;
	return 0;
}

