package esame;

public class Persona {

	private String nomeCognome;
	private int eta;
	public String getNomeCognome() {
		return nomeCognome;
	}
	public void setNomeCognome(String nomeCognome) {
		this.nomeCognome = nomeCognome;
	}
	public int getEta() {
		return eta;
	}
	public void setEta(int eta) {
		this.eta = eta;
	}
	public Persona(String nomeCognome, int eta) {
		super();
		this.nomeCognome = nomeCognome;
		this.eta = eta;
	}
	
}
