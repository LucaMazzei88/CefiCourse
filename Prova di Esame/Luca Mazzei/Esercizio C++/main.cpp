#include <iostream>

using namespace std;
#define N 4
void cancella(int mat[][N],  int n, int indice);
void stampa(int mat[][N], int n);
int main()
{

    int mat[][N]={{1,2,3,11},{4,5,6,12},{7,8,9,13},{111,112,113,114}};
    cancella(mat,4,1);
    stampa(mat,4);
    return 0;
}

void cancella(int mat[][N],  int n, int indice){

    for(int i=indice+1;i<n;i++){
        for(int j=0;j<N;j++){
            mat[i-1][j]=mat[i][j];
        }
    }
    for(int i=0;i<N;i++){
        mat[n-1][i]=0;
    }
}
void stampa(int mat[][N], int n){
    for(int i=0;i<n;i++){
        for(int j=0;j<N;j++){
            cout<<mat[i][j]<<" ";
        }
        cout<<endl;
    }
}
