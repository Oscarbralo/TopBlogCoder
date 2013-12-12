// TCTemplate.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <vector>
#include <sstream>
#include <iostream>

using namespace std;

int main()
{
	int cases;
	cin >> cases;
	for(int i = 0; i < cases; i++)
	{
		string chef = "";
		string assistant = "";
		bool chefTurn = true;
		int init = 1;
		int jobs0;
		int jobs1;
		cin >> jobs0 >> jobs1;
		vector<int> jobsCompleted (jobs1, 0);
		for(int a = 0; a < jobs1; a++)
			cin >> jobsCompleted[a];
		while(init <= jobs0)
		{
			if (find(jobsCompleted.begin(), jobsCompleted.end(), init) == jobsCompleted.end())
            {
				stringstream ss;
				ss << init;
                if (chefTurn)
                    chef += ss.str() + " ";
                else
                    assistant += ss.str() + " ";
                chefTurn = !chefTurn;
            }
            init++;
		}
		if(chef.length() > 0)
			chef.erase(chef.length() - 1,1);
		if(assistant.length() > 0)
			assistant.erase(assistant.length() - 1,1);
		cout << chef << endl;
		cout << assistant << endl;
	}
	return 0;
}

