#include <iostream>
using namespace std;

int main() {
	cout << "Skolko ect Vash Homjak?" << endl;
	int k, time;
	double weight, weight2;
	cin >> k;
	time = 30;
	weight = k * time;
	weight2 = weight / 1000;
	cout << weight << "gr nujno homjaku na mesjac ili " << weight2<<"kg"<<endl << endl;
}