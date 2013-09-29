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

class CardCount {
public:
	vector <string> dealHands(int numPlayers, string deck) {
		vector<string> result (numPlayers, "");
		int temp = deck.length() % numPlayers;
		string tempDeck = deck.substr(0, deck.length() - temp);
		int x = 0;
		for(int a = 0; a < tempDeck.length(); a++)
		{
			stringstream s;
			s << tempDeck[a];
			result[x] += s.str();
			x++;
			if(x == result.size())
				x = 0;
		}
		return result;
	}
};

int main()
{
	CardCount x;
	vector<string> result = x.dealHands(4, "111122223333443");
	return 0;
}

