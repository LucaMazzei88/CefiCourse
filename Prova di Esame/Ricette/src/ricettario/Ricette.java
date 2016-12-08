package ricettario;

import java.io.BufferedReader;
import java.io.FileReader;
import java.util.HashMap;

public class Ricette {
	private static boolean possibile;
	public static void stampaRicette(String ricetta){
		HashMap<String, Double> ricette=new HashMap<>();
		HashMap<String, Double> frigo=new HashMap<>();
		String temp;
		String[] arr;
		try(BufferedReader leggi=new BufferedReader(new FileReader("ricette.txt"))){
			while((temp=leggi.readLine())!=null){
				arr=temp.split(" ");
				if(arr[0].equals(ricetta)){
					ricette.put(arr[1], Double.parseDouble(arr[2]));
				}
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
		try(BufferedReader leggi=new BufferedReader(new FileReader("frigo.txt"))){
			while((temp=leggi.readLine())!=null){
				arr=temp.split(" ");
				frigo.put(arr[0], Double.parseDouble(arr[1]));
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
		possibile=true;
		ricette.forEach((i,q)->{
				if(frigo.containsKey(i)){
					if(frigo.get(i)>=q){
						System.out.println(i+": OK");
					}
					else{
						System.out.println(i+": richiesto "+q+" disponibile "+frigo.get(i));
						possibile=false;
					}
				}
				else{
					System.out.println("mancanza di: "+i);
					possibile=false;
				}
			});
		if(!possibile)
			System.out.println("Ricetta "+ricetta+" non possibile");
	}
}
