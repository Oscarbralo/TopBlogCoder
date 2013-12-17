#include <iostream>
#include <sstream>
using namespace std;

string LongestWord(string sen) 
{ 
	stringstream ss;
	ss << sen;
	string temp;
	string res = "";
	while(ss >> temp)
	{
		if(temp.length() > res.length())
			res = temp;
	}
	return res; 
}

int main() { 
  string s;
  getline(cin, s);
  // keep this function call here
  cout << LongestWord(s) << endl;
  return 0;
}           
