package asd;

import java.util.ArrayList;
import java.util.HashMap;

public class Articoli {

	private ArrayList<Articolo> list=new ArrayList<>();
	private String stampa;
	public void inserisci(String codice, String descrizione, int quantita, String categoria, double prezzo){
		list.add(new Articolo(codice, descrizione, quantita, categoria, prezzo));
	}
	public String[] stampa(){
		String[] rig=new String[list.size()];
		int i=0;
		for(Articolo ele:list){
			rig[i++]=ele.toString();
		}
		return rig;
	}
	public double totale(String categoria){
		double totale=0;
		for(Articolo ele:list){
			if(ele.getCategoria().equals(categoria)){
				totale+=ele.getPrezzo()*ele.getQuantita();
			}
		}
		return totale;
	}
	public void media(){
		HashMap<String , Integer> quant=new HashMap<>();
		HashMap<String, Integer> conta=new HashMap<>();
		String key;
		stampa="";
		int somma;
		int quantita;
		for( Articolo ele:list){
			key=ele.getCategoria();
			somma=0;
			quantita=0;
			if(quant.containsKey(key)){
				somma=conta.get(key);
				quantita=quant.get(key);
			}
			quant.put(key, quantita+ele.getQuantita());
			conta.put(key, somma+1);
		}
		quant.forEach((k,v)->stampa+=k+" "+v/conta.get(k)+"\n");
		System.out.println(stampa);
 	}
}
