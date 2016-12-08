#include <iostream>
#include <stdio.h>
#include<stdlib.h>
#include <string.h>

using namespace std;
struct Persona{
    char nome[50];
    char cognome[50];
    char data[15];
    char sesso;
};
int lettura(Persona[],char[]);
void compatibili(Persona p,Persona* rubrica, int n);
bool criterio(Persona a, Persona b);
int convertiAnno(Persona a);
int main()
{
    Persona* rubrica=new Persona[100];
    int num=lettura(rubrica,"pipol.txt");
    compatibili(rubrica[0],rubrica,num);
    system("pause");
    return 0;
}


int lettura(Persona rubrica[],char nomeFile[]){
    FILE * file=fopen(nomeFile,"r");
    char* pcr;
    int num=0,i;
    if(file==NULL){
        cout<<"File non Aperto"<<endl;
    }
    char* str=new char[100];
    while((fgets(str,100,file))!=NULL){
        i=0;
        pcr=strtok(str,";");
        while(pcr!=NULL){
            switch(i){
            case 0: strcpy(rubrica[num].nome,pcr);break;
            case 1: strcpy(rubrica[num].cognome,pcr);break;
            case 2: strcpy(rubrica[num].data,pcr);break;
            case 3: rubrica[num].sesso=*pcr;break;
            default:break;
            }
            pcr=strtok(NULL,";");
            i++;
        }
        num++;
    }
    return num;
}

void compatibili(Persona p,Persona* rubrica, int n){
    for(int i=0;i<n;i++){
        if(criterio(p,rubrica[i])){
            cout<<rubrica[i].nome<<" "<<rubrica[i].cognome<<" "<<rubrica[i].sesso<<" e' compatibile con te!!!"<<endl;
        }
    }
}
bool criterio(Persona a, Persona b){
    int annoA=convertiAnno(a);
    int annoB=convertiAnno(b);
    bool provaAnno=(abs(annoA-annoB)<=5);
   // cout<<annoA<<" "<<annoB<<" "<<provaAnno<<" "<<abs(annoA-annoB)<<endl;
    if(a.sesso!=b.sesso && provaAnno){
        return true;
    }
    else{
        return false;
    }
}
int convertiAnno(Persona a){
    strtok(a.data,"/");
    strtok(NULL,"/");
    return atoi(strtok(NULL,"/"));
}
