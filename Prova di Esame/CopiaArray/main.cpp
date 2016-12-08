#include <iostream>
#define B 3
#define A 6

using namespace std;
void inserisci(double a[], double b[], int n, int m);
void stampa(double a[], int n);
int main()
{
    double a[A+B];
    double b[]={13,1,9};
    a[0]=3;
    a[1]=2;
    a[2]=4;
    a[3]=7;
    a[4]=6;
    a[5]=5;
    int dimA=sizeof(a)/sizeof(double);
    int dimB=sizeof(b)/sizeof(double);
    inserisci(a,b,dimA, dimB);
    stampa(a,dimA);
    return 0;
}

void inserisci(double a[], double b[], int n, int m){
    int i,j;
    for(i=n-1;i>(n/2-1);i--){
        a[i]=a[i-m];
    }
    for(i=n/2-1,j=0;i<n/2-1+m;i++,j++){
        a[i]=b[j];
    }

}
void stampa(double a[], int n){
    for(int i=0;i<n;i++)
        cout<<a[i]<<endl;
}
