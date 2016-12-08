package asd;

public class Articolo {
	private String codice;
	private String descrizione;
	private int quantita;
	private String categoria;
	private double prezzo;
	public String getCodice() {
		return codice;
	}
	public void setCodice(String codice) {
		this.codice = codice;
	}
	public String getDescrizione() {
		return descrizione;
	}
	public void setDescrizione(String descrizione) {
		this.descrizione = descrizione;
	}
	public int getQuantita() {
		return quantita;
	}
	public void setQuantita(int quantita) {
		this.quantita = quantita;
	}
	public String getCategoria() {
		return categoria;
	}
	public void setCategoria(String categoria) {
		this.categoria = categoria;
	}
	public double getPrezzo() {
		return prezzo;
	}
	public void setPrezzo(double prezzo) {
		this.prezzo = prezzo;
	}
	public Articolo(String codice, String descrizione, int quantita, String categoria, double prezzo) {
		super();
		this.codice = codice;
		this.descrizione = descrizione;
		this.quantita = quantita;
		this.categoria = categoria;
		this.prezzo = prezzo;
	}
	@Override
	public String toString() {
		return "Codice=" + codice + ", descrizione=" + descrizione + ", quantita=" + quantita + ", categoria="
				+ categoria + ", prezzo=" + prezzo;
	} 
	
	
}
