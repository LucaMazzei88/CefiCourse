#include <iostream>
#include <string>
#define N 3
using namespace std;

struct Articoli{
    int id;
    string descrizione;
    int quantita;
    double prezzo;
};
struct Categoria{
    int codice;
    string descrizione;
    Articoli listaArticoli[N];
};
double mediaArticolo(Categoria c[]);
void stampaArticoli(Categoria c[], string descrizione);
int main()
{
    Categoria c[]{{1,"Informatica",{{1,"Pc",25,800},{2,"Mouse",32,15},{3,"Tastiera",40,20}}},
                   {2,"Elettronica",{{4,"Tv Samsung",15,1200},{5,"Tv Sony",30,1300},{6,"Stereo",33,200}}},
                   {3,"Abbigliamento",{{7,"Maglione",12,30},{8,"Jeans",45,25},{9,"Camicia",27,40}}}};
    cout<<"Media:"<<mediaArticolo(c)<<endl;
    stampaArticoli(c,"Elettronica");
    return 0;
}
double mediaArticolo(Categoria c[]){
    double somme=0;
    for(int i=0;i<N;i++){
        for(int j=0;j<N;j++){
            somme+=c[i].listaArticoli[j].prezzo;
        }
    }
    return somme/N;
}
void stampaArticoli(Categoria c[], string descrizione){
    for(int i=0;i<N;i++){
        if(c[i].descrizione.compare(descrizione)==0){
            for (int j=0;j<N;j++){
                cout<<c[i].listaArticoli[j].id<<","<<c[i].listaArticoli[j].descrizione<<","<<c[i].listaArticoli[j].quantita<<","<<c[i].listaArticoli[j].prezzo<<endl;
            }
            return;
        }
    }

}

