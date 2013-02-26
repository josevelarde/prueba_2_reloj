using System;
namespace Practica2
{
	public class Utilerias
	{
		public Utilerias ()
		{
		}
		
		public string obtenFormatoDobleCero(int numero){
			string numeroConFormato = "";
			if(numero < 10){
				numeroConFormato = "0";
			}
			
			numeroConFormato += numero;
			return numeroConFormato;
		}
		
		public void duerme1Segundo(){
			System.Threading.Thread.Sleep(1000);
		}
		
		public void limpiaPantalla(){
			Console.Clear();
		}
		
		public void imprimeTiempoActual(int horas, int minutos, int segundos){
			Console.WriteLine(this.obtenFormatoDobleCero(horas) + ":" + 
			                  this.obtenFormatoDobleCero(minutos) + ":" + 
			                  this.obtenFormatoDobleCero(segundos));
		}
	}
}