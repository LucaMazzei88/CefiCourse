package dasd;

import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Articolo {
	private String file;
	private static String parola;
	private static ArrayList<String> paroleFile;
	public Articolo(String file, String parola) {
		super();
		this.file = file;
		Articolo.parola = parola;
		riempiArrayList();
	}
	public String getFile() {
		return file;
	}
	public void setFile(String file) {
		this.file = file;
	}
	public String getParola() {
		return parola;
	}
	public void setParola(String parola) {
		Articolo.parola = parola;
	}
	public void riempiArrayList(){
		paroleFile=new ArrayList<>();
		String riga;
		String[] temp;
		try(BufferedReader leggi=new BufferedReader(new FileReader(file))){
			while((riga=leggi.readLine())!=null){
				temp=riga.split("\\p{Space}|\\p{Punct}");
				for(String ele:temp){
					paroleFile.add(ele);
				}
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
	}
	public static int conta(int size){
		int conta=0;
		for(String ele:paroleFile){
			if(ele.length()<size&&ele.equals(parola)){
				conta++;
			}
		}
		return conta;
	}
	private static boolean isPalindroma(String parola){
		for(int i=0;i<parola.length()/2;i++){
			if(parola.charAt(i)!=parola.charAt(parola.length()-1-i))
				return false;
		}
		return true;
	}
	public static int palindrome(){
		int conta=0;
		for(String ele:paroleFile){
			if(isPalindroma(ele))
				conta++;
		}
		return conta;
	}
	public static double[] media(){
		Pattern p=Pattern.compile("\\d");
		Matcher m;
		ArrayList<Double> medie=new ArrayList<>();
		double somma;
		int conta;
		for(String ele:paroleFile){
			somma=0;
			conta=0;
			for(int i=0;i<ele.length();i++){
				m=p.matcher(""+ele.charAt(i));
				if(m.matches()){
					somma+=Double.parseDouble(""+ele.charAt(i));
					conta++;
				}
			}
			if(conta!=0){
				medie.add(somma/conta);
			}
		}
		double[] array=new double[medie.size()];
		conta=0;
		for(Double ele:medie){
			array[conta++]=ele;
		}
		return array;
	}
}
