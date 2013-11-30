/*
ID: oscarbr1
PROG: ride
LANG: C++
*/

#include <sstream>
#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	int modulo = 47;
	ofstream fout ("ride.out");
	ifstream fin ("ride.in");
	string s;
	getline(fin, s);
	string ss;
	getline(fin, ss);
	string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	int res1 = 1;
	for(int i = 0; i < s.length(); i++)
		res1 *= (abc.find(s[i]) + 1);
	int res2 = 1;
	for(int i = 0; i < ss.length(); i++)
		res2 *= (abc.find(ss[i]) + 1);
	if((res1 % modulo) == (res2 % modulo))
		fout << "GO" << endl;
	else
		fout << "STAY" << endl;
	return 0;
}
