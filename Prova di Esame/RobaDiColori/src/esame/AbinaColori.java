package esame;

import java.util.ArrayList;
import java.util.Comparator;

public class AbinaColori {
	public AbinaColori(ArrayList<Colori> listaColori) {
		this.listaColori = listaColori;
	}
	private ArrayList<Colori> listaColori=new ArrayList<>();
	private ArrayList< Colori> rosso=new ArrayList<>();
	private ArrayList<Colori> giallo=new ArrayList<>();
	private ArrayList<Colori> bianco=new ArrayList<>();
	public void ordinaColori(){
		/*for(Colori ele:listaColori){
			switch(ele.getColore().toLowerCase()){
				case "rosso": rosso.add(ele); break;
				case "giallo": giallo.add(ele); break;
				case "bianco": bianco.add(ele);break;
				default: break;
			}
		}
		listaColori.clear();
		listaColori.addAll(rosso);
		listaColori.addAll(giallo);
		listaColori.addAll(bianco);*/
		listaColori.sort((c1,c2)-> Colori.ordineColori(c1.getColore(), c2.getColore()));
	}
	
	
	public ArrayList<String> raggruppaColori(){
		ArrayList<String> rag=new ArrayList<>();
		rag.add(costruisciStringa("Rosso", rosso));
		rag.add(costruisciStringa("Giallo", giallo));
		rag.add(costruisciStringa("Bianco", bianco));
		return rag;
	}
	private String costruisciStringa(String colore, ArrayList<Colori> col){
		String temp="[\""+colore+"\":{";
		for(Colori ele:col){
			temp+=ele.getDati().getNomeCognome()+",";
		}
		temp+="}";
		return temp;
	}
	public double mediaColori(){
		double somme=0;
		for(Colori ele:listaColori){
			somme+=ele.getDati().getEta();
		}
		return somme/3;
	}
}
