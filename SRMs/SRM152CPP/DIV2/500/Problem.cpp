// TCTemplate.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <vector>

using namespace std;

class LeaguePicks {
public:
	vector <int> returnPicks(int position, int friends, int picks) {
		vector<int> result;
		bool left = true;
		int r = ((friends - position) * 2) + 1;
		int j = 0;
		int temp = 0;
		while(temp <= picks)
		{
			if(left)
			{
				if(j == 0)
				{
					temp += position;
					if(temp <= picks)
						result.push_back(temp);
				}
				else
				{
					temp += ((position - 1) * 2) + 1;
					if(temp <= picks)
						result.push_back(temp);
				}
				j++;
				left = false;
			}
			else
			{
				temp += r;
				if(temp <= picks)
					result.push_back(temp);
				left = true;
			}
		}
		return result;
	}
};

int main()
{
	LeaguePicks l;
	vector<int> t = l.returnPicks(3, 6, 15);
	return 0;
}

