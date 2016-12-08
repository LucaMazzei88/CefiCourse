package esercizio;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		ArrayList<Cliente> client=new ArrayList<>();
		client.add(new Cliente("mario", "rossi", "mario.rossi@tin.it", "066892578", 1974, 5, 9));
		client.add(new Cliente("dario","verdi","dario.verdi@tin.it","066235789",1992,11,16));
		client.add(new Cliente("filippo", "bianchi", "filippo.bianchi@tin.it","066359874" , 1981, 7, 26));
		try(BufferedWriter scrivi=new BufferedWriter(new FileWriter("output.txt"))) {
			for(Cliente ele:client){
				if(ele.getEta()>25){
					scrivi.write(ele.toString()+"\n");
				}
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.println("Finito");
	}
}
