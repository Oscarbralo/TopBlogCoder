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

class GuessTheNumber {
public:
	int noGuesses(int upper, int answer) {
		int result = 0;
		int lower = 1;
		int actual = -1;
		while(actual != answer)
		{
			actual = (lower + upper) / 2;
			result++;
			if(actual < answer)
				lower = actual + 1;
			else if(actual > answer)
				upper = actual - 1;
			else
				break;
		}
		return result;
	}
};

int main()
{
	GuessTheNumber g;
	int result = g.noGuesses(9, 6);
	cout << result << endl;
	return 0;
}

