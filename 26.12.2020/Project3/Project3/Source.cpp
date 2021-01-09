#include <iostream>
using namespace std;

int main() {
	cout << "vedite diagonal` Vashego TV v dujmah" << endl;
	int x, d;
	double y, sum;
	y = 2.54;
	cin >> x;
	sum = x * y;
	d = round(sum);
	cout << "diagonal` TV =" << d <<"cm"<< endl << endl;
}