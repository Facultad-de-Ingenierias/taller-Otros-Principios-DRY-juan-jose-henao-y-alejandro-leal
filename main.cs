/**********************************************************************************
Tenemos un problema donde tenemos constantes que son Repetitivas como en el ejemplo 
numero 1 , para aplicar el principio DRY(Dont repeat yourself) creamos una nueva clase 
donde todos los atributos repetidos en nuestro caso el barrio y la edad queden guardados 
para no instaciarlos en todas nuestras clases(Se puede ver reflejado en nuestra clase repetidos),
igualmente se hizo para el metodo Imprimir.

**************************************************************************************/

using System;
class Problema_Clase
{
  static void Main ()
  {
    Direcciones.Direccion1 ();
    Direcciones.Direccion2 ();
    Direcciones.Direccion3 ();
  }
}

/*
EJEMPLO NUMERO 1
internal static class Direcciones {  
    public static void Direccion1() {  
        string Barrio = "Arraynes";
        string Nombre = "Juan Henao";
        string Edad="23";
        Console.WriteLine("El idividuo vive en "+Barrio+" y se llama "+Nombre+ " y Su edad es de "+Edad);  
    }
     public static void Direccion2() {  
        string Barrio = "Arraynes";
        string Nombre = "Pedro Infante";
        string Edad="23";
        Console.WriteLine("El idividuo vive en "+Barrio+" y se llama "+Nombre+ " y Su edad es de "+Edad);  
    }
        public static void Direccion3() {  
        string Barrio = "Arraynes";
        string Nombre = "Alejandro leal";
        string Edad="23";
        Console.WriteLine("El idividuo vive en "+Barrio+" y se llama "+Nombre+ " y Su edad es de "+Edad);  
    }
 
}  
*/
// Solucion al EJEMPLO 1
internal static class Direcciones
{
  private static string Barrio = Repetidos.Barrio;
  private static string Edad = Repetidos.Edad;
  public static void Direccion1 ()
  {
    ImprimirTexto ("Juan Henao");
  }
  public static void Direccion2 ()
  {
    ImprimirTexto ("Alejandro");
  }
  public static void Direccion3 ()
  {
    ImprimirTexto ("Pedro Infante");
  }
  private static void ImprimirTexto (string Nombre)
  {
    Console.WriteLine ("El idividuo vive en " + Barrio + " y se llama " +
		       Nombre + " y Su edad es de " + Edad);
  }
}

internal class Repetidos
{
  public static readonly string Barrio = "Arraynes";
  public static readonly string Edad = "23";
}
