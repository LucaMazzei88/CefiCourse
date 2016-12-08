package esame;

import javafx.scene.paint.Color;

public class Colori {
	private Persona dati;
	private String colore;
	public Persona getDati() {
		return dati;
	}
	public void setDati(Persona dati) {
		this.dati = dati;
	}
	public String getColore() {
		return colore;
	}
	public void setColore(String colore) {
		this.colore = colore;
	}
	public Colori(Persona dati, String colore) {
		super();
		this.dati = dati;
		this.colore = colore;
	}
	@Override
	public String toString() {
		return "Colore "+getColore()+";Nome Cognome "+dati.getNomeCognome()+", Età "+dati.getEta();
	}
	public static int ordineColori(String c1, String c2){
		return assegnaNum(c1)-assegnaNum(c2);
	}
	private static int assegnaNum(String col){
		Color c=Color.web(col.toLowerCase());
		return c.hashCode();
	
		/*switch(col.toLowerCase()){
		case "rosso": return 1;
		case "giallo": return 2;
		case "bianco": return 3;
		default : return Integer.MIN_VALUE;
		}*/
		
	}
}
