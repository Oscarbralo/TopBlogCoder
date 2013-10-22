#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    int nums = 0;
    cin >> nums;
    vector<int> v (nums, 0);
    for(int i = 0; i < nums; i++)
        cin >> v[i];
    sort(v.begin(), v.end());
    cout << v[v.size() / 2] << endl;
    return 0;
}