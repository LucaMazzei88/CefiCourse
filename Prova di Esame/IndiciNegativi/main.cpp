#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <math.h>
#define R 3
#define C 3
using namespace std;

void stampaIndiciNegativi(int** mat, int dim1, int dim2);
int main()
{
    int dim1=R;
    int dim2=C;
    srand(time(NULL));
    int** mat=new int*[dim1];
    for(int i=0;i<dim1;i++){
        *(mat+i)=new int[dim2];
        for(int j=0;j<dim2;j++){
            *(*(mat+i)+j)=pow(-1,(rand()%10+1))*(rand()%10+1); //con pow in base a se esce un numero pari o dispari avrò un numero positivo o negativo
        }
    }
    stampaIndiciNegativi(mat,dim1,dim2);
    return 0;
}
void stampaIndiciNegativi(int** mat, int dim1, int dim2){
    cout<<"Indici con valori negativi"<<endl;
    for(int i=0;i<dim1;i++){
        for(int j=0;j<dim2;j++){
            cout<<"Valore matrice"<<*(*(mat+j)+i)<<endl;
            if(*(*(mat+j)+i)<0){
                cout<<"Riga:"<<i<<" Colonna:"<<j<<endl;
            }
        }
    }
}
