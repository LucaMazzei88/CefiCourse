package esercizio;

import java.time.LocalDate;

public class Cliente {

	private String nome;
	private String cognome;
	private String email;
	private String telefono;
	private LocalDate data;
	private int eta;
	
	public Cliente(String nome, String cognome, String email, String telefono, int anno, int mese, int giorno) {
		super();
		this.nome = nome;
		this.cognome = cognome;
		this.email = email;
		this.telefono = telefono;
		data=LocalDate.of(anno, mese, giorno);
		eta=LocalDate.now().getYear()-getData().getYear();
	}
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public String getCognome() {
		return cognome;
	}
	public void setCognome(String cognome) {
		this.cognome = cognome;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getTelefono() {
		return telefono;
	}
	public void setTelefono(String telefono) {
		this.telefono = telefono;
	}
	public LocalDate getData() {
		return data;
	}
	public void setData(LocalDate data) {
		this.data = data;
	}
	public int getEta() {
		return eta;
	}
	public void setEta(int eta) {
		this.eta = eta;
	}
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return getNome()+" "+getCognome()+"#"+getEmail()+"#"+getTelefono()+"#"+getEta();
	}
	
}
