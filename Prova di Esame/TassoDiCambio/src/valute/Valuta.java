package valute;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.ArrayList;

public class Valuta {
	private File fileGiorno;
	private File fileGiornoSuccessivo;
	public Valuta(String fileGiorno, String fileGiornoSuccessivo) {
		this.fileGiorno = new File(fileGiorno);
		this.fileGiornoSuccessivo = new File(fileGiornoSuccessivo);
	}
	public void scriviCambio(ArrayList<String> giorno, ArrayList<String> giornoSuccessivo){
		try(BufferedWriter scrivi=new BufferedWriter(new FileWriter(fileGiorno))){
			giorno.forEach(d->{try{scrivi.write(d);scrivi.newLine();}catch (Exception e) {e.printStackTrace();}});
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		try(BufferedWriter scrivi=new BufferedWriter(new FileWriter(fileGiornoSuccessivo))){
			giornoSuccessivo.forEach(d->{try{scrivi.write(d);scrivi.newLine();}catch (Exception e) {e.printStackTrace();}});
		}catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
	}
	public String rialzo(String valuta){
		String temp;
		String[] arr;
		double tassoCambio1=0, tassoCambio2=0;
		try(BufferedReader leggi=new BufferedReader(new FileReader(fileGiorno))){
			while((temp=leggi.readLine())!=null){
				arr=temp.split(" ");
				if(arr[1].equals(valuta)){
					tassoCambio1=Double.parseDouble(arr[2]);
					break;
				}
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
		try(BufferedReader leggi2=new BufferedReader(new FileReader(fileGiornoSuccessivo))){
			while((temp=leggi2.readLine())!=null){
				arr=temp.split(" ");
				if(arr[1].equals(valuta)){
					tassoCambio2=Double.parseDouble(arr[2]);
					break;
				}
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
		double rialzo=100*(tassoCambio2/tassoCambio1-1);
		if(rialzo>0.01)
			return "In Rialzo";
		else if(rialzo<-0.01)
			return "In Ribasso";
		else
			return "Stabile";
	}
	public ArrayList<String> rialzo(){
		ArrayList<String> ritorna=new ArrayList<>();
		String temp;
		String[] arr;
		try(BufferedReader leggi=new BufferedReader(new FileReader(fileGiorno))){
			while((temp=leggi.readLine())!=null){
				arr=temp.split(" ");
				ritorna.add(arr[1]+" "+rialzo(arr[1]));
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
		return ritorna;
	}
}
