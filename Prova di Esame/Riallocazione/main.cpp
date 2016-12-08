#include <iostream>
#include <stdlib.h>
using namespace std;
void aggiungiElemento(int* arrayOrdinato, int dimA, int num);
int compar(const void* a,const void* b);
void stampaArray(int* a, int dimA);
int main()
{
    int* arrayOrdinato=new int[4];
    *(arrayOrdinato)=4;
    *(arrayOrdinato+1)=32;
    *(arrayOrdinato+2)=98;
    *(arrayOrdinato+3)=57;
    aggiungiElemento(arrayOrdinato,4,50);
    stampaArray(arrayOrdinato,5);
    return 0;
}
int compar(const void* a,const void* b){
    return (*(int*)a-*(int*)b);
}
void aggiungiElemento(int* arrayOrdinato, int dimA, int num){
    arrayOrdinato=(int*)realloc(arrayOrdinato,sizeof(int)*(dimA+1));
    arrayOrdinato[dimA]=num;
    qsort(arrayOrdinato, dimA+1,sizeof(int), compar );
}
void stampaArray(int* a, int dimA){
    for(int i=0;i<dimA;i++){
        cout<<*(a+i)<<" ";
    }
    cout<<endl;
}

